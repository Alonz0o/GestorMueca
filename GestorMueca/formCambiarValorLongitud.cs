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
    public partial class formCambiarValorLongitud : MaterialForm
    {
        ConexionMySql mySqlConexion = new ConexionMySql();
        IList<Usuario> personal = new List<Usuario>();
        public int mtsNuevoValor = 0;
        public string nomApeVerificarCambiarValor;
        public static formCambiarValorLongitud instancia;
        public formCambiarValorLongitud()
        {
            InitializeComponent();
            instancia = this;
            cargarDatosEnTextBox();

        }
        private void formCambiarValorLongitud_Activated(object sender, EventArgs e)
        {
            tbMetros.Focus();
        }
        private void ibtnSalirOp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargarDatosEnTextBox()
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            personal = mySqlConexion.buscarEncargados();
            foreach (Usuario u in personal) autoCompleteCollection.Add(u.Legajo.ToString());
        }

        private void btnSalirOp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCambiarLongitud_Click(object sender, EventArgs e)
        {
            if (formReEtiquetar.instancia != null) {
                formReEtiquetar.instancia.nomApeVerificarReEtiquetar = "";
            }

            if (string.IsNullOrEmpty(tbMetros.Text))
            {
                MessageBox.Show("Debe ingresar metros.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMetros.Focus();
                return;
            }

            if (!tbMetros.Text.All(char.IsDigit))
            {
                MessageBox.Show("Use solamente numeros.", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMetros.Focus();
                return;
            }

            formAutorizar autorizarForm = new formAutorizar();
            autorizarForm.ShowDialog();
            if (autorizarForm.autenticacion)
            {
                mtsNuevoValor = int.Parse(tbMetros.Text);
                Close();
            }
        }
        private void ibtnMetrosLimpiar_Click(object sender, EventArgs e)
        {
            tbMetros.Clear();
        }

        private void tbMetros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar)) e.Handled = true;

            if (formReEtiquetar.instancia != null)
            {
                formReEtiquetar.instancia.nomApeVerificarReEtiquetar = "";
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbMetros.Text))
                {
                    MessageBox.Show("Debe ingresar metros.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                formAutorizar autorizarForm = new formAutorizar();
                autorizarForm.ShowDialog();
                if (autorizarForm.autenticacion)
                {
                    nomApeVerificarCambiarValor = autorizarForm.autoriza;
                    mtsNuevoValor = int.Parse(tbMetros.Text);
                    Close();
                }
                else MessageBox.Show("No se pudo realizar esta acción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tbMetros_TextChanged(object sender, EventArgs e)
        {
            if (!tbMetros.Text.All(char.IsDigit))
            {
                tbMetros.Text = "";
                return;
            }
        }
    }
}
