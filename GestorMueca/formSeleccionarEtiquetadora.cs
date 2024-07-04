using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtiquetadoBultos
{
    public partial class formSeleccionarEtiquetadora : MaterialForm
    {
        public formSeleccionarEtiquetadora()
        {
            InitializeComponent();           
        }

        private void ibtnSalirOp_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnEtiquetar1_Click(object sender, EventArgs e)
        {
            formPrincipal.instancia.etiquetadoraSeleccionada = "0";
            Close();
        }
        private void btnEtiquetar2_Click(object sender, EventArgs e)
        {
            formPrincipal.instancia.etiquetadoraSeleccionada = "1";
            Close();
        }

        private void btnEtiquetar3_Click(object sender, EventArgs e)
        {
            formPrincipal.instancia.etiquetadoraSeleccionada = "2";
            Close();
        }

        private void btnEtiquetar4_Click(object sender, EventArgs e)
        {
            formPrincipal.instancia.etiquetadoraSeleccionada = "3";
            Close();
        }

        private void btnEtiquetar5_Click(object sender, EventArgs e)
        {
            formPrincipal.instancia.etiquetadoraSeleccionada = "4";
            Close();
        }
    }
}
