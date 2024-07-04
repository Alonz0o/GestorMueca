using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetadoBultos.Models
{
    public class Bulto
    {
        public int idBulto { get; set; }
        public int numBulto { get; set; }
        public string legajo { get; set; }
        public int cantBolsas { get; set; }
        public int idOrigen1 { get; set; }
        public int idOrigen2 { get; set; }
        public int idOrigen3 { get; set; }
        public int sectorOrigen { get; set; }
        public int idOrden { get; set; }
        public string observacion { get; set; }
        public DateTime fechaCreado { get; set; }
        public int idnt { get; set; }

    }
}
