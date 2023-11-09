using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_De_Datos
{
    public class DA_Categoria:DA_BASE
    {
        public static bool InsertarCategoria(Categoria objCategoria) 
        {
            String strSQL = "INSERT INTO categoria(nombre,descripcion)VALUES( ";
            strSQL +="'"+ objCategoria.Nombre + "',";
            strSQL +="'"+ objCategoria.Descripcion + "');";
            return RealizarTransaccion(strSQL);
        }
        public static bool ActualizarCategoria(Categoria objCategoria)
        {

            string strSQL = "Update proveedor set nombre='" +
                objCategoria.Nombre + "',descrpcion='" +
                objCategoria.Descripcion + "';";



            return RealizarTransaccion(strSQL);

        }
        public static DataTable ConsultarCategoria() 
        {
            DataTable dt = new DataTable();
            String strSQL = "SELECT * FROM categoria;";
            return ConsultarDatos(strSQL);
        }

    }
}
