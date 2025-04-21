using DevExpress.XtraGrid.Columns;
using EtiquetadoBultos.Models;
using ScrapKP.AAFControles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        string maquina = "";
        private List<ProtocoloItem> items = new List<ProtocoloItem>();
        public Especificacion espAncho = new Especificacion();
        public Especificacion espLargo = new Especificacion();
        public static formEnsayoProduccion instancia;

        private void formEnsayoProduccion_Load(object sender, EventArgs e)
        {
            orden = Convert.ToInt32(formPrincipal.instancia.datosOp[8]);
            codigo = Convert.ToInt32(formPrincipal.instancia.datosOp[9]);
            idop = Convert.ToInt32(formPrincipal.instancia.datosOp[11]);
            aConfeccionar = Convert.ToInt32(formPrincipal.instancia.datosOp[7]);
            idBobinaMadre = formPrincipal.instancia.bobinaMadre;
            maquina = formPrincipal.instancia.maquinaSeleccionada;
            legajo = Convert.ToInt32(formPrincipal.instancia.operarioAsignado);

            var muestreo = formPrincipal.instancia.mySqlConexion.VerificarMuestreo(idop, aConfeccionar);

            lblRealizadas.Text = "Realizadas: " + muestreo.Realizadas;
            lblRequeridas.Text = "Requeridas: " + muestreo.Requeridas;

            lblTitulo.Text = "Ensayo para: " + orden + "/" + codigo;
            espAncho = formPrincipal.instancia.mySqlConexion.GetFichaTecnicaConfeccionAncho(codigo);
            espLargo = formPrincipal.instancia.mySqlConexion.GetFichaTecnicaConfeccionLargo(codigo);


            lblNumPaquete.Text = "Paquete N°: " + formPrincipal.instancia.ultimoBulto;
            lblNumBobina.Text = "Bobina N°: " + idBobinaMadre;
            tbPallet.Focus();
            if (gvItemsValor.Columns.Count() == 0)
            {
                GenerarTablaItemsValor();
            }
            else {
                gvItemsValor.Columns.Clear();
                GenerarTablaItemsValor();             
            }
            GetItems(maquina);

            if (gvItemsValor.RowCount > 0)
            {
                gvItemsValor.FocusedRowHandle = 0;
                gvItemsValor.FocusedColumn = gvItemsValor.Columns["Valor"];
                gvItemsValor.ShowEditor();
            }

        }

        private void GenerarTablaItemsValor()
        {
            GridColumn cId = new GridColumn();
            cId.FieldName = "Id";
            cId.Caption = "";
            cId.UnboundDataType = typeof(int);
            cId.OptionsColumn.AllowEdit = false;

            GridColumn cNombre = new GridColumn();
            cNombre.FieldName = "Nombre";
            cNombre.Caption = "Nombre";
            cNombre.UnboundDataType = typeof(string);
            cNombre.Visible = true;
            cNombre.OptionsColumn.AllowEdit = false;

            GridColumn cMedida = new GridColumn();
            cMedida.FieldName = "Medida";
            cMedida.Caption = "Medida";
            cMedida.UnboundDataType = typeof(string);
            cMedida.Visible = true;
            cMedida.OptionsColumn.AllowEdit = false;

            GridColumn cValor = new GridColumn();
            cValor.FieldName = "Valor";
            cValor.Caption = "Valor";
            cValor.Visible = true;
            cValor.UnboundDataType = typeof(string);

            GridColumn cEspecificacion = new GridColumn();
            cEspecificacion.FieldName = "EspecificacionDato";
            cEspecificacion.Caption = "Especificación";
            cEspecificacion.Visible = true;
            cEspecificacion.UnboundDataType = typeof(string);
            cEspecificacion.OptionsColumn.AllowEdit = false;

            gvItemsValor.Columns.AddRange(new GridColumn[] { cId, cNombre, cMedida, cValor, cEspecificacion });
        }

        public formEnsayoProduccion()
        {
            InitializeComponent();
            instancia = this;

        }

        private void GetItems(string maquina)
        {
            items = formPrincipal.instancia.mySqlConexion.GetItemsPorMaquina(maquina, "produccion").OrderBy(e => e.Posicion).ToList();
            gcItemsValor.DataSource = items;
            gvItemsValor.BestFitColumns();
        }

        private void gvItemsValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (gvItemsValor.FocusedRowHandle == gvItemsValor.RowCount - 1) {
                    e.Handled = true;
                    btnAgregarEnsayo.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void tbPallet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                gcItemsValor.Focus();
                btnAgregarEnsayo.Focus();

            }
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

        private bool ValidarTolerancia(double valor, double toleranciaMed, double toleranciaMax)
        {
            var valortb = valor;
            var valorIngresado = toleranciaMed;
            var valorReferencia = valortb;

            double limiteInferior = valorIngresado - toleranciaMax * 20;
            double limiteSuperior = valorIngresado + toleranciaMax * 20;
            if (valorReferencia >= limiteInferior && valorReferencia <= limiteSuperior)
            {
                //tb.BackColor = Color.White;
                return true;
            }
            else
            {
                //tb.BackColor = Color.LightCoral;
                return false;
            }
        }

        private void gvItemsValor_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            var focus = (ProtocoloItem)gvItemsValor.GetFocusedRow();
            if (view.FocusedColumn.FieldName == "Valor")
            {
                string valor = e.Value?.ToString();
                if (valor.Contains("."))
                {
                    valor = valor.Replace('.', ',');
                    e.Value = valor.Replace('.', ',');
                }

                if (!focus.EsConstante)
                {
                    if (focus.Medida == "Milimetro" || focus.Medida == "Entero")
                    {
                        if (!Utils.IsSoloNumerico(valor))
                        {
                            e.Valid = false;
                            e.ErrorText = "Solo numeros enteros.";
                        }
                    }
                    else if (focus.Medida == "Gramos")
                    {
                        if (!Utils.IsSoloNumODecimal(valor))
                        {
                            e.Valid = false;
                            e.ErrorText = "Solo numeros enteros o decimales.";
                        }
                    }
                    else if (focus.Medida == "Fuelle")
                    {
                        if (!Utils.IsSoloNumOP(valor))
                        {
                            e.Valid = false;
                            e.ErrorText = "Este valor es de fuelle, acepta 2 valores en formato a/b.";
                        }
                    }
                }
                else
                {
                    if (focus.Medida == "Caracter")
                    {
                        if (!Utils.IsSoloSignoA(valor))
                        {
                            e.Valid = false;
                            e.ErrorText = "Este valor es constante y solo permite (ok), (no ok) y (-).";
                        }
                    }

                }
            }
        }

        private void btnAgregarEnsayo_Click(object sender, EventArgs e)
        {
            var ensayo = new ProtocoloItem();
            ensayo.Turno = GetTurno();
            ensayo.OP = idop.ToString();
            ensayo.Legajo = legajo;
            if (!Utils.IsSoloNumerico(tbNumPaquete.Texts))
            {
                MessageBox.Show("Debe ingresar numero de paquete.");
                return;
            }

            ensayo.PaqueteNum = Convert.ToInt32(tbNumPaquete.Texts);
            List<ItemValor> valores = new List<ItemValor>();
            for (int i = 0; i < gvItemsValor.RowCount; i++)
            {
                var idSeleccionado = (int)gvItemsValor.GetRowCellValue(i, "Id");
                var item = items.FirstOrDefault(d => d.Id == idSeleccionado);
                if (item.Valor != null)
                {
                    if (item.Valor == "0") continue;
                    item.Valor = item.Valor.Replace(',', '.');
                    if (item.Id == 9) if (!ValidarTolerancia(Convert.ToDouble(item.Valor), espAncho.Medio, espAncho.Maximo)) return;
                    if (item.Id == 7) if (!ValidarTolerancia(Convert.ToDouble(item.Valor), espLargo.Medio, espLargo.Maximo)) return;
                    if (item.Id == 14) if (!ValidarTolerancia(Convert.ToDouble(item.Valor, CultureInfo.InvariantCulture), Math.Round(Convert.ToDouble(formPrincipal.instancia.datosOp[13]) * 1000, 2), 5)) return;

                    if (item.EsConstante || item.Medida == "Fuelle")
                    {
                        item.ValorConstante = item.Valor.ToString();
                        item.Valor = "0";

                    }
                    else item.ValorConstante = "0";
                    valores.Add(new ItemValor { Valor = item.Valor, ValorConstante = item.ValorConstante, IdItem = item.Id, IdBobinaMadre = idBobinaMadre });
                }
                
            }

            if (valores.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un valor de ensayo.");
                return;
            }

            if (formPrincipal.instancia.mySqlConexion.InsertEnsayoLote(valores, ensayo))
            {
                Close();
            }


        }
    }
}
