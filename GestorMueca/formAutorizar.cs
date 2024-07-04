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
    public partial class formAutorizar : Form
    {
        ConexionMySql mySqlConexion = new ConexionMySql();
        int contadorErrores = 1;
        public bool autenticacion = false;
        public string autoriza = "";
        public formAutorizar()
        {
            InitializeComponent();
            var encargadosNomApe = mySqlConexion.buscarEncargadosNomApe();
            cbEncargado.DataSource = new BindingSource(encargadosNomApe, null);
            if (formReEtiquetar.instancia != null) {
                if (!string.IsNullOrEmpty(formReEtiquetar.instancia.mensajeAlerta))
                {
                    lblAlerta.Text = formReEtiquetar.instancia.mensajeAlerta;
                }
            }
            
        }

        private void ibtnVerContrasena_Click(object sender, EventArgs e)
        {
            if (ibtnVerContrasena.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                tbContraseña.UseSystemPasswordChar = false;
                ibtnVerContrasena.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                tbContraseña.UseSystemPasswordChar = true;
                ibtnVerContrasena.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }

        }

        private void ibtnContraseñaLimpiar_Click(object sender, EventArgs e)
        {
            tbContraseña.Clear();
        }

        private void btnVerificarUsuario_Click(object sender, EventArgs e)
        {        
            if (!string.IsNullOrEmpty(tbContraseña.Text))
            {            
                if (mySqlConexion.verificarContraseña(cbEncargado.SelectedItem.ToString(), tbContraseña.Text))
                {
                    MessageBox.Show("Verificación aceptada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    autenticacion = true;
                    autoriza = cbEncargado.SelectedItem.ToString();
                    Close();
                }
                else
                {
                    if (contadorErrores == 3) Application.Exit();
                    DialogResult verificarUsuario = MessageBox.Show("La contraseña ingresada no es correcta.", "ERROR, INTENTO N° " + contadorErrores, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (verificarUsuario == DialogResult.Retry)
                    {

                    }
                    else if (verificarUsuario == DialogResult.Cancel)
                    {
                        Close();
                    }
                    contadorErrores++;
                }

            }
            else MessageBox.Show("Debe ingresar una contraseña.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ibtnSalirVerificacion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(tbContraseña.Text))
                {
                    if (mySqlConexion.verificarContraseña(cbEncargado.SelectedItem.ToString(), tbContraseña.Text))
                    {
                        MessageBox.Show("Verificación aceptada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        autoriza = cbEncargado.SelectedItem.ToString();
                        autenticacion = true;
                        Close();
                    }
                    else
                    {
                        tbContraseña.Clear();
                        if (contadorErrores == 3) Application.Exit();
                        DialogResult verificarUsuario = MessageBox.Show("La contraseña ingresada no es correcta.", "ERROR, INTENTO N° " + contadorErrores, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (verificarUsuario == DialogResult.Retry)
                        {

                        }
                        else if (verificarUsuario == DialogResult.Cancel)
                        {
                            Close();
                        }
                        contadorErrores++;
                    }

                }
                else MessageBox.Show("Debe ingresar una contraseña.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void formAutorizar_Activated(object sender, EventArgs e)
        {
            tbContraseña.Focus();
        }
    }
}
