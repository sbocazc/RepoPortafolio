using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_tareas
{
    public class GtSeccion
    {
        public int ID_SECCION { get; set; }
        public string NOMBRE_SECCION { get; set; }
        public int DEPARTAMENTO_ID_DEPARTAMENTO { get; set; }
        public int SUBDEPARTAMENTO_ID_SUBDEPTO { get; set; }

        public GtSeccion()
        {

        }
    }
}
