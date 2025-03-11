using EtiquetadoBultos.Models;
using ScrapKP.AAFControles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtiquetadoBultos
{
    public partial class formEnsayoProduccion : Form
    {
        public int orden = 0, codigo = 0, idop = 0, aConfeccionar = 0, idBobinaMadre = 0, legajo = 0;
        double pesoBolsaMedio=0.0, pesoBolsaMaximo=5;
        string maquina = "";

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbPallet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                tbAncho.Focus();
            }
        }

        private void tbAncho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                tbLargo.Focus();
            }
        }

        private void tbLargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                tbPesoBolsa.Focus();
            }
        }

        private void tbPesoBolsa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnAgregarEnsayo.Focus();
            }
        }

        Especificacion espAncho = new Especificacion();
        Especificacion espLargo = new Especificacion();
        private void formEnsayoProduccion_Load(object sender, EventArgs e)
        {
            orden = Convert.ToInt32(formPrincipal.instancia.datosOp[8]);
            codigo = Convert.ToInt32(formPrincipal.instancia.datosOp[9]);
            idop = Convert.ToInt32(formPrincipal.instancia.datosOp[11]);
            aConfeccionar = Convert.ToInt32(formPrincipal.instancia.datosOp[7]);
            idBobinaMadre = formPrincipal.instancia.bobinaMadre;
            maquina = formPrincipal.instancia.maquinaAsignada;
            legajo = Convert.ToInt32(formPrincipal.instancia.operarioAsignado);

            var muestreo = formPrincipal.instancia.mySqlConexion.VerificarMuestreo(idop, aConfeccionar);

            lblRealizadas.Text = "Realizadas: " + muestreo.Realizadas;
            lblRequeridas.Text = "Requeridas: " + muestreo.Requeridas;

            lblTitulo.Text = "Ensayo para: " + orden + "/" + codigo;
            espAncho = formPrincipal.instancia.mySqlConexion.GetFichaTecnicaConfeccionAncho(codigo);
            btnEspAncho.Text = espAncho.Medio + "±" + espAncho.Maximo;
            espLargo = formPrincipal.instancia.mySqlConexion.GetFichaTecnicaConfeccionLargo(codigo);
            btnEspLargo.Text = espLargo.Medio + "±" + espLargo.Maximo;

            pesoBolsaMedio = Math.Round(Convert.ToDouble(formPrincipal.instancia.datosOp[13]) * 1000, 2);
            btnEspPesoBolsa.Text = pesoBolsaMedio + "±" + pesoBolsaMaximo;
            lblNumPaquete.Text = "Paquete N°: " + formPrincipal.instancia.ultimoBulto;
            lblNumBobina.Text = "Bobina N°: " + idBobinaMadre;
            tbPallet.Focus();
        }


        public formEnsayoProduccion()
        {
            InitializeComponent();

        }
        private string GetTurno()
        {
            var turnoNombre = "";
            TimeSpan horaAhora = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            if (horaAhora >= new TimeSpan(7, 00, 00) && horaAhora < new TimeSpan(14, 59, 59))
            {
                turnoNombre = "TM";
            }
            if (horaAhora >= new TimeSpan(15, 00, 00) && horaAhora < new TimeSpan(23, 59, 59))
            {
                turnoNombre = "TT";
            }
            if (horaAhora >= new TimeSpan(00, 00, 00) && horaAhora < new TimeSpan(6, 59, 59))
            {
                turnoNombre = "TN";
            }
            return turnoNombre;
        }
        private bool ValidarFormularioItems(string valorEnsayo, bool constante)
        {
            if (valorEnsayo.Contains(".")) valorEnsayo = valorEnsayo.Replace('.', ','); ;
            if (!constante)
            {
                if (!Utils.IsSoloNumODecimal(valorEnsayo))
                {
                    MessageBox.Show("Solo numeros decimales");
                    return false;
                }
            }
            else
            {
                if (!Utils.IsSoloSignoA(valorEnsayo))
                {
                    MessageBox.Show("Solo valores numericos, ok, no ok, guion(-)");
                    return false;
                }
            }

            return true;
        }
        private bool ValidarTolerancia(AAFTextBox tb, double toleranciaMed, double toleranciaMax)
        {
            var valortb = tb.Texts.Replace(".", ",");
            var valorIngresado = toleranciaMed;
            var valorReferencia = Convert.ToDouble(valortb);

            double limiteInferior = valorIngresado - toleranciaMax * 20;
            double limiteSuperior = valorIngresado + toleranciaMax * 20;
            if (valorReferencia >= limiteInferior && valorReferencia <= limiteSuperior)
            {
                tb.BackColor = Color.White;
                return true;
            }
            else
            {
                tb.BackColor = Color.LightCoral;
                return false;
            }
        }

        private void btnAgregarEnsayo_Click(object sender, EventArgs e)
        {
            var ensayo = new ProtocoloItem();
            ensayo.Turno = GetTurno();
            ensayo.OP = idop.ToString();
            ensayo.Legajo = legajo;

            if (!ValidarFormularioItems(tbAncho.Texts, false)) return;
            if (!ValidarFormularioItems(tbLargo.Texts, false)) return;
            if (!ValidarFormularioItems(tbPesoBolsa.Texts, false)) return;

            //calcular los limites tolerancia
            if (!ValidarTolerancia(tbAncho, espAncho.Medio, espAncho.Maximo))
            {
                tbAncho.BackColor = Color.LightCoral;
                return;
            }
            else
            {
                tbAncho.BackColor = Color.White;
            }

            if (!ValidarTolerancia(tbAncho, espAncho.Medio, espAncho.Maximo)) return;
            if (!ValidarTolerancia(tbLargo, espLargo.Medio, espLargo.Maximo)) return;
            if (!ValidarTolerancia(tbPesoBolsa, pesoBolsaMedio, pesoBolsaMaximo)) return;
            

            List<ItemValor> valores = new List<ItemValor> {
                new ItemValor{ Valor=Convert.ToDouble(tbAncho.Texts), ValorConstante="0",IdItem=9,IdBobinaMadre=idBobinaMadre },
                new ItemValor{ Valor=Convert.ToDouble(tbLargo.Texts), ValorConstante="0",IdItem=7,IdBobinaMadre=idBobinaMadre },
                new ItemValor{ Valor=Convert.ToDouble(tbPesoBolsa.Texts), ValorConstante="0",IdItem=14,IdBobinaMadre=idBobinaMadre },

            };

            if (formPrincipal.instancia.mySqlConexion.InsertEnsayoLote(valores, ensayo))
            {
                tbAncho.Texts = "";
                tbLargo.Texts = "";
                tbPesoBolsa.Texts = "";
                MessageBox.Show("Ensayo agregado correctamente");
                Close();
            }

        }
    }
}
