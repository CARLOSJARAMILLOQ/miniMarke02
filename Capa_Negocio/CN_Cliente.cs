using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_De_Datos;
using Capa_Entidades;

namespace Capa_Negocio
{
    public class CN_Cliente
    {
        public static bool ActualizarCliente(Cliente objCliente) 
        {
            return DA_Cliente.ActualizarCliente(objCliente);
        }
        public static DataTable ConsultarCliente() 
        {
            return DA_Cliente.ConsultarCliente();
        }
        public static bool InsertarCliente(Cliente objCliente) { 
            return DA_Cliente.InsertarCliente(objCliente);
        }
    }
}
