using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entEmpleado
    {
        public int idEmpleado { get; set; }
        public string nombre { get; set; }
        public string sexo { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public bool estEmpleado { get; set; }
        public int idCargo { get; set; }
        public string nombreCargo { get; set; }

    }
}
