using DevExpress.XtraEditors.Controls;
using EtiquetadoBultos.Models;
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
    public partial class formMuestras : MaterialForm
    {
        ConexionMySql mySqlConexion = new ConexionMySql();

        public formMuestras(int creadas, int requeridas)
        {
            InitializeComponent();
            lblAlerta.Text = "No es posible generar un IP sin las muestras requeridas." + "\n" + "Creadas: " + creadas + "\n" + "Requeridas: " + requeridas;

            string[] codigoOrden = formPrincipal.instancia.lblInstanciaOP.Text.Split('/');
            var bobinasOp = mySqlConexion.buscarBobinasMuestreo(codigoOrden[0].Trim(), codigoOrden[1].Trim(), formPrincipal.instancia.bobinaSector);
            
            cbBobina.Properties.Items.AddRange(bobinasOp.ToList());
        }
        private void formMuestras_Load(object sender, EventArgs e)
        {
            tbAnchoTotal.Select();

        }
        private void tbAnchoTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbLargoTotal.Focus();
            }
        }

        private void tbLargoTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                cbBobina.Focus();
                //cbBobina.DroppedDown = true;                
            }
        }
        private void cbBobina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                rbPrepicadoBien.Focus();
            }
        }

        private void cbPallets_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                rbPrepicadoBien.Focus();
            }
        }
        private void rbPrepicadoBien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                rbBloqueoBien.Focus();
            }
        }
        private void rbBloqueoBien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                rbSoldaduraBien.Focus();
            }
        }

        private void rbSoldaduraBien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnAgregarMuestra.Focus();
                btnAgregarMuestra.PerformClick();
            }
        }

        private void btnAgregarMuestra_Click(object sender, EventArgs e)
        {
            RadioButton rbPrepicado = tlpPrepicado.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked);
            RadioButton rbBloqueo = tlpBloqueo.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked);
            RadioButton rbSoldadura = tlpSoldadura.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked);

            // Si se encuentra un RadioButton seleccionado, desmárcalo
            if (rbPrepicado != null) rbPrepicado.Checked = false;
            if (rbBloqueo != null) rbBloqueo.Checked = false;
            if (rbSoldadura != null) rbSoldadura.Checked = false;
            Bobina bobinaSeleccionado = null;
            if (cbBobina.SelectedIndex != -1)
            {
                bobinaSeleccionado = (Bobina)cbBobina.SelectedItem;
            }
            if (bobinaSeleccionado == null) return;
            if (tbAnchoTotal.Text == "") return;
            if (tbLargoTotal.Text == "") return;

            var requeridas = mySqlConexion.AgregarMuestra(bobinaSeleccionado.indice,tbAnchoTotal.Text,tbLargoTotal.Text,DateTime.Now, rbPrepicado.Tag,rbBloqueo.Tag,rbSoldadura.Tag, formPrincipal.instancia.datosOp[11]);
            if (requeridas != -1) {
                MessageBox.Show("Muestra agregada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbAnchoTotal.Focus();
                tbAnchoTotal.Text = "";
                tbLargoTotal.Text = "";
                cbBobina.SelectedIndex = -1;

                var muestrasTotales = mySqlConexion.VerificarMuestreo(formPrincipal.instancia.datosOp[11], formPrincipal.instancia.datosOp[7]);
                lblAlerta.Text = "No es posible generar un IP sin las muestras requeridas." + "\n" + "Creadas: " + muestrasTotales[0] + "\n" + "Requeridas: " + muestrasTotales[1];
                if (Convert.ToInt32(muestrasTotales[0]) == Convert.ToInt32(muestrasTotales[1])) Close();

            }
            else MessageBox.Show("Error al agregar muestra.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

     
    }
}
