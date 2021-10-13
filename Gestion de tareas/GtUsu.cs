using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_tareas
{
   public class GtUsu
    {
        public int ID_USUARIO { get; set; }
        public string NOMBRE_USUARIO { get; set; }
        public string CONTRASENA { get; set; }
        public int EMPRESA_ID_EMPRESA { get; set; }
        public string TIPO_USUARIO { get; set; }

        public GtUsu()
        {

        }
    }
}
