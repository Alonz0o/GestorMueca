using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetadoBultos.Models
{
    public class NtIp
    {
        public int id { get; set; }
        public int idNt { get; set; }
        public string cliente { get; set; }
        public string op { get; set; }
        public int pallets { get; set; }
        public string bobinas { get; set; }
        public DateTime fecha { get; set; }
        public string ancho { get; set; }
        public string espesor { get; set; }
        public string largo { get; set; }
        public string maquina { get; set; }
        public string operario { get; set; }
        public int cantidad { get; set; }
        public string observacion { get; set; }
        public string fechaCreado { get; set; }
        public int cantBobinas { get; set; }
        public string sector { get; set; }
        public int totalBolsas { get; set; }
        public double pesoTarimaVacia { get; set; }
        public DateTime fechaEntrega { get; set; }
        public int codigo { get; set; }
        public double teoricoMinimo { get; set; }
        public double teoricoMaximo { get; set; }
        public double teoricoNominal { get; set; }
        public int version { get; set; }
        public int revision { get; set; }
        public int idEmbalaje { get; set; }
        public string embalajeFecha { get; set; }
        public double neto { get; set; }
        public int idDeposito { get; set; }
        public double metros { get; set; }
        public string embalaje_pDescripcion { get; set; }
        public string embalaje_pDisposicion { get; set; }
        public string embalaje_pFungible { get; set; }
        public bool parteFinal { get; set; }
    }
}
