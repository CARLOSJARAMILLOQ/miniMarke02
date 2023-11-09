using Capa_De_Datos;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public  class CN_Proveedor

    {
        public static bool InsetarProveedor(Proveedor objProveedor)
        {
            return DA_Proveedor.InsetarProveedor(objProveedor);
        }

        public static bool ActualizarProveedor(Proveedor objProveedor)
        {
            return DA_Proveedor.ActualizarProveedor(objProveedor);
        }
        public static DataTable ConsutarProveedor()
        {
            return DA_Proveedor.ConsutarProveedor();
        }
      
       
    }
}
