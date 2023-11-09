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
    public class CN_Categoria
    {
        public static bool InsertarCategoria(Categoria objCategoria) { 
            return DA_Categoria.InsertarCategoria (objCategoria);
        }
        public static bool ActualizarCategoria(Categoria objCategoria) 
        {
            return DA_Categoria.ActualizarCategoria(objCategoria);
        }
        public static DataTable ConsultarCategoria() 
        {
            return DA_Categoria.ConsultarCategoria();
        }
    }
}
