using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public String TipoDeDocumento { get; set; }
        public string Identificacion { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String Correo { get; set;}
        public String Telefono { get; set; }

    }
}
