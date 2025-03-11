using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetadoBultos.Models
{
    class Parada
    {
        public int Id { get; set; }
        public string Maquina { get; set; }
        public string TotalHora { get; set; }
        public DateTime FechaComienzo { get; set; }
        public DateTime FechaFin { get; set; }
        public string OperarioNombre { get; set; }
        public string Auxiliar01 { get; set; }
        public string Auxiliar02 { get; set; }
        public string Auxiliar03 { get; set; }
        public string OperadorMantenimiento { get; set; }
        public string TurnoEncargado { get; set; }
        public string Motivo { get; set; }
        public string Rubro { get; set; }
        public string Observacion { get; set; }
        public int LiberacionSanitaria { get; set; }
        public DateTime FechaReal { get; set; }
        public int Orden { get; set; }
        public int Codigo { get; set; }
    }
}
