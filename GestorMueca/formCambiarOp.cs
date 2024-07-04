using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace EtiquetadoBultos
{
    public partial class formCambiarOp : MaterialForm
    {
        ConexionMySql mySqlConexion = new ConexionMySql();
        public formCambiarOp()
        {
            InitializeComponent();
        }

        private void btnCambiarOp_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tbOrden.Text))
            {
                MessageBox.Show("Introducir Orden.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(tbCodigo.Text))
            {
                MessageBox.Show("Introducir Código.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var datosOpe = mySqlConexion.buscarOp(tbOrden.Text, tbCodigo.Text);
            if (datosOpe.Count <= 0)
            
            {           
                MessageBox.Show("O/P no valida o inexistente.", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                //var datosW = mySqlConexion.buscarOpTW(tbOrden.Text, tbCodigo.Text);
            }

            formPrincipal.instancia.bobinaSector = mySqlConexion.comprobarSector(tbCodigo.Text);
            formPrincipal.instancia.datosOp = datosOpe;
            formPrincipal.instancia.bobinasOp = mySqlConexion.buscarBobinas(tbOrden.Text, tbCodigo.Text, formPrincipal.instancia.bobinaSector);
            formPrincipal.instancia.cambiarDatos();
            
            Close();
        }

        private void ibtnSalirOp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalirOp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ibtnOrdenLimpiar_Click(object sender, EventArgs e)
        {
            tbOrden.Clear();
        }

        private void ibtnCodigoLimpiar_Click(object sender, EventArgs e)
        {
            
            tbCodigo.Clear();
        }

        private void formCambiarOp_Activated(object sender, EventArgs e)
        {
            tbOrden.Focus();
        }

        private void tbOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter | e.KeyChar == '/' | e.KeyChar == '-')
            {           
                tbCodigo.Focus();
            }
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbOrden.Text))
                {
                    MessageBox.Show("Introducir Orden.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbOrden.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(tbCodigo.Text))
                {
                    MessageBox.Show("Introducir Código.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbCodigo.Focus();
                    return;
                }

                var datosOpe = mySqlConexion.buscarOp(tbOrden.Text, tbCodigo.Text);
                if (datosOpe.Count <= 0)
                {
                    MessageBox.Show("O/P no valida o inexistente.", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                formPrincipal.instancia.bobinaSector = mySqlConexion.comprobarSector(tbCodigo.Text);
                formPrincipal.instancia.datosOp = datosOpe;
                formPrincipal.instancia.bobinasOp = mySqlConexion.buscarBobinas(tbOrden.Text, tbCodigo.Text, formPrincipal.instancia.bobinaSector);
                formPrincipal.instancia.cambiarDatos();
                Close();
            }
        }

        private void tbOrden_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbOrden.Text)) {
                if (tbOrden.Text.Contains("/")) {
                    tbOrden.Text = tbOrden.Text.Replace("/", string.Empty);
                    return;
                }
                if (tbOrden.Text.Contains("-"))
                {
                    tbOrden.Text = tbOrden.Text.Replace("-", string.Empty);
                    return;
                }

            }
            
        }
    }
}
