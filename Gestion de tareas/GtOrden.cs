using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_tareas
{
    public class GtOrden
    {
        public string ID_ORDEN { get; set; }
        public string TAREA { get; set; }
        public string NOTA { get; set; }
        public string MailContacto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int IdActividadEmpresa { get; set; }
        public int IdTipoEmpresa { get; set; }

        public GtOrden()
        {

        }
    }
}
