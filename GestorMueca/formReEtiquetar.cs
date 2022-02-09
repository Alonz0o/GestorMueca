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
    public partial class formReEtiquetar : Form
    {
        ConexionMySql mySqlConexion = new ConexionMySql();
        int desde = 0;
        int hasta = 0;
        public formReEtiquetar()
        {
            InitializeComponent();
            var rangoDeBultos = mySqlConexion.buscarBustos(formPrincipal.instancia.datosOp[11]);
            cbDesdeBobina.DataSource = new BindingSource(rangoDeBultos, null);
            cbHastaBobina.DataSource = new BindingSource(rangoDeBultos, null);
        }

        private void ibtnSalirReEtiquetado_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalirReEtiquetado_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReEtiquetar_Click(object sender, EventArgs e)
        {

        }

        private void cbDesdeBobina_SelectedIndexChanged(object sender, EventArgs e)
        {
            desde = int.Parse(cbDesdeBobina.SelectedIndex.ToString());
            hasta = int.Parse(cbHastaBobina.SelectedIndex.ToString());
            if (desde == -1 | hasta == -1) return;

            if (desde > hasta)
            {
                cbHastaBobina.SelectedIndex = desde;
                return;
            }
        }

        private void cbHastaBobina_SelectedIndexChanged(object sender, EventArgs e)
        {
            desde = int.Parse(cbDesdeBobina.SelectedIndex.ToString());
            hasta = int.Parse(cbHastaBobina.SelectedIndex.ToString());
            if (desde == -1 | hasta == -1) return;


            if (desde > hasta)
            {
                cbHastaBobina.SelectedIndex = desde;
                return;
            }



            var current = cbDesdeBobina.SelectedValue;
        }

        
    }
}
