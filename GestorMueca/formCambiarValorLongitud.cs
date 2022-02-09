using EtiquetadoBultos.Models;
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
    public partial class formCambiarValorLongitud : Form
    {
        ConexionMySql mySqlConexion = new ConexionMySql();
        IList<Usuario> personal = new List<Usuario>();
        public int mtsNuevoValor = 0;
        public string legajoVerificar;
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
            tbEncargado.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbEncargado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbEncargado.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void tbEncargado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && tbEncargado.Text.All(char.IsDigit))
            {              
                if (string.IsNullOrEmpty(tbEncargado.Text))
                {
                    MessageBox.Show("Debe ingresar legajo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbEncargado.Focus();
                    return;
                }

                if (!tbEncargado.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Use solamente numeros.", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbEncargado.Focus();
                    return;
                }

                var encargado = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbEncargado.Text));
                if (encargado != null) lblEncargado.Text = encargado.Nombre + " " + encargado.Apellido;
                else
                {
                    MessageBox.Show("No existe el legajo " + tbEncargado.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblEncargado.Text = "Operario *";
                    tbEncargado.Text = "";
                    tbEncargado.Focus();
                }
                        
            }
        }

        private void btnSalirOp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCambiarLongitud_Click(object sender, EventArgs e)
        {
            legajoVerificar = "";
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

            if (string.IsNullOrEmpty(tbEncargado.Text))
            {
                MessageBox.Show("Debe ingresar legajo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbEncargado.Focus();
                return;
            }

            if (!tbEncargado.Text.All(char.IsDigit))
            {
                MessageBox.Show("Use solamente numeros.", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEncargado.Focus();
                return;
            }
            legajoVerificar = tbEncargado.Text;
            formAutorizar autorizarForm = new formAutorizar();
            autorizarForm.ShowDialog();
            if (autorizarForm.autenticacion)
            {
                mtsNuevoValor = int.Parse(tbMetros.Text);
                Close();
            }else MessageBox.Show("No se pudo realizar esta acción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      
        }
        private void ibtnMetrosLimpiar_Click(object sender, EventArgs e)
        {
            tbMetros.Clear();
        }

        private void ibtnEncargadoLimpiar_Click(object sender, EventArgs e)
        {
            tbEncargado.Clear();
            lblEncargado.Text = "Autoriza";
        }

        private void tbMetros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbMetros.Text))
                {
                    MessageBox.Show("Debe ingresar metros.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (tbMetros.Text.All(char.IsDigit))
                {
                    tbEncargado.Focus();
                }
                else MessageBox.Show("Use solamente numeros.", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }
        private void tbEncargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
