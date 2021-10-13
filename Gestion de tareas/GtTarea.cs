using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_tareas
{
    public class GtTarea
    {
        public int ID_TAREA { get; set; }
        public string PRIORIDAD { get; set; }
        public string NOMBRE_TAREA { get; set; }
        public string DESCRIPCION_TAREA { get; set; }
        public System.DateTime FEHCA_INI { get; set; }
        public System.DateTime FEHCA_TER { get; set; }

        public string NOMBRE_RESPONSABLE { get; set; }

        public GtTarea()
        {

        }
    }
}
