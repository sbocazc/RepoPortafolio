using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_tareas
{
    public class GtEmpresa
    {
        public int ID_EMPRESA { get; set; }
        public string NOMBRE_EMPRESA { get; set; }
        public string RAZON_SOCIAL { get; set; }
        public int RUN_CLIENTE { get; set; }
        public int DV_CLIENTE { get; set; }
        public string PRIMER_NOMBRE { get; set; }
        public string SEGUNDO_NOMBRE { get; set; }
        public string APELLIDO_PATERNO { get; set; }
        public string APELLIDO_MATERNO { get; set; }
        public string EMAIL { get; set; }
        public int NUMERO_CELULAR { get; set; }

        public GtEmpresa()
        {
                
        }
    }
}
