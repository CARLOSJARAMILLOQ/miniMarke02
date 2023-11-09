using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;

namespace Capa_De_Datos
{
    public  class DA_Proveedor: DA_BASE
    {
        public static bool InsetarProveedor(Proveedor objProveedor)
        {
            string strSQL = "INSERT INTO proveedor (nit, razonSocial, telefono, nomenclatura, ciudad, departamento," +
                " correo) values(";
            strSQL += "'" + objProveedor.Nit + "',";
            strSQL += "'" + objProveedor.RazonSocial + "',";
            strSQL += "'" + objProveedor.Telefono + "',";
            strSQL += "'" + objProveedor.Nomenclatura + "',";
            strSQL += "'" + objProveedor.Ciudad + "',";
            strSQL += "'" + objProveedor.Departamento + "',";
            strSQL += "'" + objProveedor.Correo + "');";
            
            return RealizarTransaccion(strSQL);

        }
        public static bool ActualizarProveedor(Proveedor objProveedor)
        {

            string strSQL = "Update proveedor set ,telefono='" +
                objProveedor.Telefono + "',nomenclatura='" +
                objProveedor.Nomenclatura + "',ciudad='" +
                objProveedor.Ciudad + "',departamento='" +
                objProveedor.Departamento + "',correo='" +
                objProveedor.Correo + "';";



            return RealizarTransaccion(strSQL);

        }
        public static DataTable ConsutarProveedor()
        {

            DataTable td = new DataTable();
            string strSQL = "SELECT * FROM proveedor;";
            return ConsultarDatos(strSQL);
        }


    }
}
