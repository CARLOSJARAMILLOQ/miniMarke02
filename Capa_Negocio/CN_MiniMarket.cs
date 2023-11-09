using Capa_De_Datos;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Capa_Negocio
{
    public class CN_MiniMarket
    {
        public static bool ActualizarMiniMarket(MiniMarket objMiniMarket)
        {
            return DA_MiniMarket.ActualizarMiniMarket(objMiniMarket);
        }
        public static DataTable ConsutarMiniMarket() 
        {
            return DA_MiniMarket.ConsutarMiniMarket();
        }
    }
}
