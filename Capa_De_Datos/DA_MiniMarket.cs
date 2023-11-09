using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;


namespace Capa_De_Datos
{
    public  class DA_MiniMarket : DA_BASE
    {
        public static bool InsetarMiniMarket(MiniMarket objMiniMarket)
        {
            string strSQL = "Insert intO minimarket(nit,razonSocial,telefono,nomenclatura,ciudad,departamento," +
                "correo,sitioWeb,facebook,whastapp)values(";
            strSQL += "'" + objMiniMarket.Nit+ "',";
            strSQL += "'" + objMiniMarket.RazonSocial + "',";
            strSQL += "'" + objMiniMarket.Telefono + "',";
            strSQL += "'" + objMiniMarket.Nomenclatura + "',";
            strSQL += "'" + objMiniMarket.Ciudad + "',";
            strSQL += "'" + objMiniMarket.Departamento + "',";
            strSQL += "'" + objMiniMarket.Correo + "',";
            strSQL += "'" + objMiniMarket.SitioWeb + "',";
            strSQL += "'" + objMiniMarket.Facebook + "',";
            strSQL += "'" + objMiniMarket.Whastapp + "');";
            return RealizarTransaccion(strSQL);

        }
        public static bool ActualizarMiniMarket(MiniMarket objMiniMarket)
        {
            string strSQL = "Update  minimarket set" +
                "" +
                " razonSocial='" + objMiniMarket.RazonSocial + 
                "',telefono='" + objMiniMarket.Telefono +
                "',nomenclatura='" + objMiniMarket.Nomenclatura +
                "',ciudad='" + objMiniMarket.Ciudad + 
                "',departamento='" + objMiniMarket.Departamento + 
                "',correo='" + objMiniMarket.Correo +
                "',sitioWeb='" + objMiniMarket.SitioWeb +
                "',facebook='" + objMiniMarket.Facebook + 
                "',whastapp='" + objMiniMarket.Whastapp + "';";



            return RealizarTransaccion(strSQL);

        }
        public static DataTable ConsutarMiniMarket() { 
         
            DataTable td=new DataTable();
            String strSQL = "SELECT nit,razonSocial,telefono,nomenclatura,ciudad, departamento,ciudad,correo,sitioWeb,facebook,whastapp from minimarket where idMinimarket=1;";
            return ConsultarDatos(strSQL);
        }

    }
}
