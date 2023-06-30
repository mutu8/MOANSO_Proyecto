using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entContratos
    {
        public int idContrato { get; set; }
        public DateTime fecInicioContrato { get; set; }
        public DateTime fecFinalContrato { get; set; }
        public string horaReg { get; set; }
        public bool estContrato { get; set; }
        public string nombreTipoContrato { get; set; }
        public string nombreEmpleado { get; set; }
        public int idEmpleado { get; set; }
        public int idTipoContrato { get; set; }
    }
}
