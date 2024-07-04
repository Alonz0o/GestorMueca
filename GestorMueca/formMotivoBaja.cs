using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtiquetadoBultos
{
    public partial class formMotivoBaja : MaterialForm
    {
        public formMotivoBaja()
        {
            InitializeComponent();
            tbMotivo.Select();
        }

        private void ibtnLimpiarMotivo_Click(object sender, EventArgs e)
        {
            tbMotivo.Clear();
        }

        private void ibtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            formIp.instancia.motivoBaja = tbMotivo.Text;
            Close();
        }
    }
}
