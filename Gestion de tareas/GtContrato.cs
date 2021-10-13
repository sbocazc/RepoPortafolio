using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_tareas
{
    public class GtContrato
    {
        public int ID_CONTRATO { get; set; }
        public System.DateTime FEHCA_CREACION { get; set; }
        public string DESCRIPCION_CONTRATO { get; set; }
        public System.DateTime FEHCA_INICIO { get; set; }
        public System.DateTime FEHCA_TERMINO { get; set; }
        public int EMPRESA_ID_EMPRESA { get; set; }

        public GtContrato()
        {

        }
    }
}
