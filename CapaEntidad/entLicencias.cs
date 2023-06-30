using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entLicencias
    {
        public int idLicencia { get; set; }
        public DateTime fecInicioLicencia { get; set; }
        public DateTime fecFinalLicencia { get; set; }
        public string horaReg { get; set; }
        public bool estLicencia { get; set; }
        public int idEmpleado { get; set; }
        public int idTipoLicencia { get; set; }
        public string nombreTipoLicencia { get; set; }
        public string nombreEmpleado { get; set; }
    }

}
