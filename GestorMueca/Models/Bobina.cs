using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetadoBultos.Models
{
    public class Bobina
    {
        public int indice { get; set; }
        public int numRollo { get; set; }
        public int longitudRollo { get; set; }
        public double neto { get; set; }
        public double pesoRollo { get; set; }
        public double kilosRollo { get; set; }       
        public int mtsRemanentesRollo { get; set; }
        public int idNTIntermedio { get; set; }
    }
}
