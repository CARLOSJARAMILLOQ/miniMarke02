using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;

namespace Capa_De_Datos
{
    public class DA_Cliente:DA_BASE
    {
        public static bool InsertarCliente(Cliente objCliente) 
        {
            String strSQL = "INSERT INTO cliente(tipoDeDocumento,identificacion,nombres,apellidos,correo,telefono)" +
                "VALUES(";
            strSQL +="'"+ objCliente.TipoDeDocumento + "',";
            strSQL += "'" + objCliente.Identificacion + "',";
            strSQL +="'" + objCliente.Nombres + "',";
            strSQL += "'" + objCliente.Apellidos + "',";
            strSQL += "'" + objCliente.Correo + "',";
            strSQL += "'" + objCliente.Telefono + "');";
            return RealizarTransaccion(strSQL);

        }
        public static bool ActualizarCliente(Cliente objCliente)
        {

            string strSQL = "Update cliente set nombres='" +
                objCliente.Nombres + "',apellidos='" +
                objCliente.Apellidos + "',correo='" +
                objCliente.Correo + "',telefono='" +
                objCliente.Telefono  + "';";



            return RealizarTransaccion(strSQL);

        }
        public static DataTable ConsultarCliente() 
        {
            DataTable dt = new DataTable();
            String strSQL = "SELECT * FROM cliente;";
            return ConsultarDatos(strSQL);
                
        }

    }
}
