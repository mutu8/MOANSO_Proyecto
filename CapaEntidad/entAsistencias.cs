using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entAsistencias
    {
        
        public DateTime fecRegAsistencia { get; set; }
        public string horaRegAsistencia { get; set; }
        public bool estAsistencia { get; set; }
        public string tipoAsistencia { get; set; }
        public int idAsistencia { get; set; }
        public int idEmpleado { get; set; }
        public string nombreEmpleado { get; set; }
    }

}
