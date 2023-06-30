using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCargos
    {
        public int idCargo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public DateTime fecRegCargo { get; set; }
        public bool estCargo { get; set; }
        public int idArea { get; set; }
        public string nombreArea { get; set; }
    }
   
}

