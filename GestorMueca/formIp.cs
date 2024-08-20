using EtiquetadoBultos.Models;
using FontAwesome.Sharp;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtiquetadoBultos
{
    public partial class formIp : MaterialForm
    {
        ConexionMySql mySqlConexion = new ConexionMySql();
        //Lapiz
        Pen lapizNegro3Px = new Pen(Color.Black, 3);
        Pen lapizNegro1Px = new Pen(Color.Black, 1);
        //Fontos
        Font robotoMini = new Font("Roboto Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Font robotoLightMedium = new Font("Roboto Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Font robotoLight = new Font("Roboto Light", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Font robotoMedium = new Font("Roboto Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Font robotoMediumMini = new Font("Roboto Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Font barcode = new Font("MRV Code39extMA", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
        IList<int> palletsCreados;
        IList<Usuario> personal = new List<Usuario>();
        double pesoMillar = double.Parse(formPrincipal.instancia.datosOp[13]);
        string operarios, operariosSeleccionar, op;
        int palletNumero, totalBultos, totalBolsas, desde, hasta, minimo, maximo;
        double pesoNetoTeorico = 0.0;
        DataTable dt = new DataTable("bultos");
        DataView dv = null;
        public static formIp instancia;
        public IList<string> columnaSelecionadaEditar = new List<string>();
        NtIp ntIp = new NtIp();
        public int cantEditada = 0;
        public bool palletModificado = false;
        public string motivoBaja;
        public string total = "";

        public formIp()
        {
            InitializeComponent();
            instancia = this;
            formPrincipal.instancia.limpiarEM();
            op = formPrincipal.instancia.datosOp[8] + "/" + formPrincipal.instancia.datosOp[9];
            var largoMostrar = double.Parse(formPrincipal.instancia.datosOp[2]) * 100;
            lblClienteOP.Text = formPrincipal.instancia.datosOp[0] + " | " + op;
            lblLargo.Text = lblLargo.Text + largoMostrar + "cm";
            lblAncho.Text = lblAncho.Text + formPrincipal.instancia.datosOp[1] + "cm";
            lblEspesor.Text = lblEspesor.Text + formPrincipal.instancia.datosOp[3] + "µm";
            lblMaquina.Text = lblMaquina.Text + formPrincipal.instancia.datosOp[6];
            lblFecha.Text = lblFecha.Text + DateTime.Now;
            palletsCreados = mySqlConexion.buscarPallets(op);
            palletNumero = palletsCreados.Count() + 1;
            lblPallet.Text = "Pallet N°: " + palletNumero;

            cargarDatosEnTextBox();
            verOperariosCargadosEnFormPrincipal();

            dt.Columns.Add(new DataColumn("Numero de bultos", typeof(int)));
            dt.Columns.Add(new DataColumn("Creación", typeof(string)));
            dt.Columns.Add(new DataColumn("Cantidad de bolsas", typeof(int)));
            dt.Columns.Add(new DataColumn("idbulto", typeof(int)));
            dt.Columns.Add(new DataColumn("seleccionarBulto", typeof(bool)));
            dt.Columns.Add(new DataColumn("idorigen", typeof(int)));

            //Agregar imgBoton columna            
            DataGridViewImageColumn btnEditar = new DataGridViewImageColumn();
            btnEditar.HeaderText = "";
            btnEditar.Name = "editarBulto";
            btnEditar.Image = Properties.Resources.editar16px;

            var bultosRegistrados = mySqlConexion.buscarBultos(formPrincipal.instancia.datosOp[11]);
            foreach (Bulto bulto in bultosRegistrados)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["Numero de bultos"] = bulto.numBulto;
                dataRow["Creación"] = bulto.fechaCreado.ToString("dd/MM/yyyy HH:mm:ss");
                dataRow["Cantidad de bolsas"] = bulto.cantBolsas;
                dataRow["idbulto"] = bulto.idBulto;
                dataRow["idorigen"] = bulto.idOrigen1;
                dt.Rows.Add(dataRow);
            }

            dgvBultosRegistrados.DataSource = dt;
            dgvBultosRegistrados.Columns.Add(btnEditar);
            ajustarTamDgv();
        }

        private void ajustarTamDgv()
        {
            dgvBultosRegistrados.Columns["seleccionarBulto"].HeaderText = "";            
            dgvBultosRegistrados.Columns["idbulto"].Visible = false;
            dgvBultosRegistrados.Columns["idorigen"].Visible = false;
            dgvBultosRegistrados.Columns["editarBulto"].Width = 16;
            dgvBultosRegistrados.Columns["seleccionarBulto"].Width = 16;
            dgvBultosRegistrados.Columns["editarBulto"].Width = 21;
        }

        private void verOperariosCargadosEnFormPrincipal()
        {
            if (formPrincipal.instancia.operadores[1] != "0")
            {
                operarios = formPrincipal.instancia.operadores[1];
                if (formPrincipal.instancia.operadores[2] != "0" & formPrincipal.instancia.operadores[3] != "0")
                {
                    operarios = operarios + "-" + formPrincipal.instancia.operadores[2] + "-" + formPrincipal.instancia.operadores[3];
                    lblOperarios.Text = lblOperarios.Text + operarios;
                    buscarNombreOpeXLegajo(formPrincipal.instancia.operadores[1]);
                    buscarNombreAux01XLegajo(formPrincipal.instancia.operadores[2]);
                    buscarNombreAux02XLegajo(formPrincipal.instancia.operadores[3]);
                    return;

                }
                else if (formPrincipal.instancia.operadores[2] == "0" & formPrincipal.instancia.operadores[3] == "0")
                {
                    lblOperarios.Text = "Unico operario: " + operarios;
                    buscarNombreOpeXLegajo(operarios);
                    return;
                }
                if (formPrincipal.instancia.operadores[2] != "0")
                {
                    operarios = operarios + "-" + formPrincipal.instancia.operadores[2];
                    buscarNombreOpeXLegajo(formPrincipal.instancia.operadores[1]);
                    buscarNombreAux01XLegajo(formPrincipal.instancia.operadores[2]);
                }
                else if (formPrincipal.instancia.operadores[3] != "0")
                {
                    operarios = operarios + "-" + formPrincipal.instancia.operadores[3];
                    buscarNombreOpeXLegajo(formPrincipal.instancia.operadores[1]);
                    buscarNombreAux02XLegajo(formPrincipal.instancia.operadores[3]);
                }
                lblOperarios.Text = lblOperarios.Text + operarios;
            }
        }

        private void buscarNombreOpeXLegajo(string legajo)
        {
            var operario = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(legajo));
            if (operario != null)
            {
                lblOperario.Text = operario.Nombre + " " + operario.Apellido;
            }
            else
            {
                MessageBox.Show("No existe el legajo " + tbOperario.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblOperario.Text = "";
                tbOperario.Text = "";
                tbOperario.Focus();
            }

        }

        private void buscarNombreAux01XLegajo(string legajo)
        {

            var auxiliar = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(legajo));
            if (auxiliar != null)
            {
                lblAuxiliar01.Text = auxiliar.Nombre + " " + auxiliar.Apellido;
            }
            else
            {
                MessageBox.Show("No existe el legajo " + tbAuxiliar01.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblAuxiliar01.Text = "";
                tbAuxiliar01.Text = "";
                tbAuxiliar01.Focus();
            }
        }

        private void buscarNombreAux02XLegajo(string legajo)
        {

            var auxiliar = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(legajo));
            if (auxiliar != null)
            {
                lblAuxiliar02.Text = auxiliar.Nombre + " " + auxiliar.Apellido;
            }
            else
            {
                MessageBox.Show("No existe el legajo " + tbAuxiliar02.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblAuxiliar02.Text = "";
                tbAuxiliar02.Text = "";
                tbAuxiliar02.Focus();
            }
        }

        private void cargarDatosEnTextBox()
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            personal = mySqlConexion.buscarPersonal();

            foreach (Usuario u in personal)
            {
                autoCompleteCollection.Add(u.Legajo.ToString());
            }
            tbOperario.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbOperario.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbOperario.AutoCompleteCustomSource = autoCompleteCollection;

            tbAuxiliar01.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbAuxiliar01.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbAuxiliar01.AutoCompleteCustomSource = autoCompleteCollection;

            tbAuxiliar02.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbAuxiliar02.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbAuxiliar02.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //TODO VERVER
            //var requeridas = mySqlConexion.VerificarMuestreo(formPrincipal.instancia.datosOp[11], formPrincipal.instancia.datosOp[7]);
            //if (!formPrincipal.instancia.datosOp[0].Contains("RHEEM"))
            //{
            //    if (!(bool)requeridas[2])
            //    {
            //        try
            //        {
            //            formMuestras formMuestras = new formMuestras(Convert.ToInt32(requeridas[0]), Convert.ToInt32(requeridas[1]));
            //            formMuestras.ShowDialog();
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Error" + ex);
            //        }
            //        return;
            //    }
            //}

            if (dgvBultosRegistrados.Rows.Count == 0) return;
            var resp = false;
            foreach (DataGridViewRow row in dgvBultosRegistrados.Rows)
            {
                if ((bool)row.Cells["seleccionarBulto"].FormattedValue == true) {
                    resp = true; 
                    break; 
                }
            }

            if (!resp)
            {
                MessageBox.Show("Debe seleccionar al menos un bulto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (lblOperarios.Text == "Operarios: " & string.IsNullOrEmpty(tbOperario.Text))
            {
                if (tbOperario.Visible) tbOperario.Focus();
                MessageBox.Show("Debe ingresar al menos un operario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(tbPesoTarima.Text))
            {
                MessageBox.Show("Debe ingresar peso de tarima.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPesoTarima.Focus();
                return;
            }
            if (!tbPesoTarima.Text.All(char.IsDigit))
            {
                MessageBox.Show("Ingresar peso de tarima expresado en números.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPesoTarima.Focus();
                return;
            }

            if (int.Parse(tbPesoTarima.Text) < 5 | int.Parse(tbPesoTarima.Text) > 60)
            {
                tbPesoTarima.Clear();
                tbPesoTarima.Focus();
                MessageBox.Show("Ingresar peso de tarima entre 5 a 60Kgm.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            do
            {
                if (tbOperario.Visible)
                {
                    if (tbOperario.Text != "0")
                    {
                        operariosSeleccionar = tbOperario.Text;
                        if (tbAuxiliar01.Text != "" & tbAuxiliar02.Text != "")
                        {
                            operariosSeleccionar = operariosSeleccionar + "-" + tbAuxiliar01.Text + "-" + tbAuxiliar02.Text;
                            break;
                        }
                        else if (tbAuxiliar01.Text == "" & tbAuxiliar02.Text == "")
                        {
                            operariosSeleccionar = tbOperario.Text;
                            break;
                        }
                        if (tbAuxiliar01.Text != "")
                        {
                            operariosSeleccionar = operariosSeleccionar + "-" + tbAuxiliar01.Text;
                            break;
                        }
                        else if (tbAuxiliar02.Text != "")
                        {
                            operariosSeleccionar = operariosSeleccionar + "-" + tbAuxiliar02.Text;
                            break;
                        }
                    }
                }
                break;
            } while (true);

            ntIp.idNt = mySqlConexion.buscarUltimoNtIntermedio();
            ntIp.cliente = formPrincipal.instancia.datosOp[0];
            ntIp.op = formPrincipal.instancia.datosOp[8] + "/" + formPrincipal.instancia.datosOp[9];
            ntIp.pallets = palletNumero;
            ntIp.bobinas = total;
            ntIp.fechaEntrega = DateTime.Parse(formPrincipal.instancia.datosOp[10]);
            ntIp.ancho = formPrincipal.instancia.datosOp[1];
            ntIp.espesor = formPrincipal.instancia.datosOp[3];
            ntIp.maquina = formPrincipal.instancia.datosOp[6];
            ntIp.largo = double.Parse(formPrincipal.instancia.datosOp[2]) * 100 + "";
            ntIp.operario = operariosSeleccionar != null ? operariosSeleccionar : operarios;
            ntIp.cantidad = 1;
            ntIp.fechaCreado = DateTime.Now.Date.ToString("dd/MM/yyyy HH:mm:ss");
            ntIp.cantBobinas = totalBultos;
            ntIp.totalBolsas = totalBolsas;
            ntIp.pesoTarimaVacia = int.Parse(tbPesoTarima.Text);
            ntIp.codigo = int.Parse(formPrincipal.instancia.datosOp[9]);

            var datosExtrusion = mySqlConexion.buscarExtrusion(formPrincipal.instancia.datosOp[9]);
            if (datosExtrusion.Count != 0)
            {
                ntIp.version = int.Parse(datosExtrusion[1]);
                ntIp.revision = int.Parse(datosExtrusion[2]);
                ntIp.teoricoNominal = totalBolsas * (double.Parse(formPrincipal.instancia.datosOp[2]) * double.Parse(datosExtrusion[5])) / 1000;
                ntIp.teoricoMinimo = totalBolsas * ((double.Parse(formPrincipal.instancia.datosOp[2]) * double.Parse(datosExtrusion[5]) - double.Parse(datosExtrusion[6])) / 1000);
                ntIp.teoricoMaximo = totalBolsas * ((double.Parse(formPrincipal.instancia.datosOp[2]) * double.Parse(datosExtrusion[5]) + double.Parse(datosExtrusion[7])) / 1000);
            }

            var datosEmbalaje = mySqlConexion.buscarEmbalaje(formPrincipal.instancia.datosOp[9]);
            if (datosEmbalaje.Count != 0)
            {
                ntIp.idEmbalaje = int.Parse(datosEmbalaje[0]);
                ntIp.embalajeFecha = datosEmbalaje[1];
            }

            ntIp.neto = pesoNetoTeorico;
            ntIp.idDeposito = 0;
            ntIp.metros = totalBolsas * double.Parse(formPrincipal.instancia.datosOp[2]);
            ntIp.sector = "C";
            ntIp.idDeposito = 0;

            var datosEmbalajeFicha = mySqlConexion.buscarEmbalajeFichaTecnica(ntIp.idEmbalaje.ToString());
            if (datosEmbalajeFicha.Count != 0)
            {
                ntIp.embalaje_pDescripcion = datosEmbalajeFicha[0];
                ntIp.embalaje_pDisposicion = datosEmbalajeFicha[1];
                ntIp.embalaje_pFungible = datosEmbalajeFicha[6];
            }

            seleccionImp.AllowSomePages = true;
            seleccionImp.ShowHelp = true;
            seleccionImp.Document = docImprimir;
            DialogResult respuesta = seleccionImp.ShowDialog();

            //Si el resultado de la impresion es Ok, creo nuevo nt y tambien
            //actulizo bultos
            if (respuesta == DialogResult.OK)
            {              
                var str = Math.Round(ntIp.metros);
                string sql = "insert into nt (nt, cliente, o_p, pallets, bobinas, ancho, espesor, maquina, operario, cantidad, creado, cant_bobinas, sector, largo, total_bolsas, peso_tarima_vacia, codigo, teorico_minimo, teorico_nominal, teorico_maximo, version, revision, id_embalaje, embalaje_fecha, neto, iddeposito, metros) " +
                $"values('{ntIp.idNt}', '{ntIp.cliente}', '{ntIp.op}', '{ntIp.pallets}', '{ntIp.bobinas}', '{ntIp.ancho}', '{ntIp.espesor}', '{ntIp.maquina}', '{ntIp.operario}', '{ntIp.cantidad}',  STR_TO_DATE('{ntIp.fechaCreado}', '%d/%m/%Y %H:%i:%s'), '{ntIp.cantBobinas}', '{ntIp.sector}', '{ntIp.largo}', '{ntIp.totalBolsas}', '{ntIp.pesoTarimaVacia}', '{ntIp.codigo}', '{ntIp.teoricoMinimo.ToString().Replace(",", ".")}', '{ntIp.teoricoNominal.ToString().Replace(",", ".")}', '{ntIp.teoricoMaximo.ToString().Replace(",", ".")}', '{ntIp.version}', '{ntIp.revision}', '{ntIp.idEmbalaje}', STR_TO_DATE('{ntIp.embalajeFecha}', '%d/%m/%Y %H:%i:%s'), '{ntIp.neto.ToString().Replace(",", ".")}', '{ntIp.idDeposito}', '{Math.Round(ntIp.metros)}');";
                var sqlActualizarBultosIdNtP1 = "update bultos set idnt = (case";
                var sqlActualizarBultosIdNtP2 = "where id in (";
                foreach (DataGridViewRow row in dgvBultosRegistrados.Rows)
                {
                    if (!string.IsNullOrEmpty(row.Cells["seleccionarBulto"].Value.ToString()))
                    {
                        if ((bool)row.Cells["seleccionarBulto"].Value == true)
                        {
                            sqlActualizarBultosIdNtP1 = sqlActualizarBultosIdNtP1 + " when id = " + row.Cells["idbulto"].Value.ToString() + " then " + ntIp.idNt + " ";
                            sqlActualizarBultosIdNtP2 = sqlActualizarBultosIdNtP2 + row.Cells["idbulto"].Value.ToString() + ",";
                        }
                    }
                }
                sqlActualizarBultosIdNtP1 = sqlActualizarBultosIdNtP1 + "end) ";
                sqlActualizarBultosIdNtP2 = sqlActualizarBultosIdNtP2.TrimEnd(',') + ");";
                sqlActualizarBultosIdNtP1 = sqlActualizarBultosIdNtP1 + sqlActualizarBultosIdNtP2;
                //Update bultos involucrados en dgvBultosRegistrados
                if (mySqlConexion.sqlSimpleQuery(sqlActualizarBultosIdNtP1, sql))
                {
                    docImprimir.Print();
                    docImprimir.Dispose();
                    Close();
                }
                else MessageBox.Show("Error, no es posible imprimir esta IP en este momento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ibtnSalirOp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbPesoTarima_TextChanged(object sender, EventArgs e)
        {
            if (!tbPesoTarima.Text.All(char.IsDigit))
            {
                MessageBox.Show("Ingresar solo números.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPesoTarima.Clear();
                return;
            }
        }

        private void ibtnOperarios_Click(object sender, EventArgs e)
        {
            if (ibtnOperarios.IconChar == IconChar.ToggleOff)
            {
                ibtnOperarios.IconChar = IconChar.ToggleOn;
                tbOperario.Visible = true;
                tbAuxiliar01.Visible = true;
                tbAuxiliar02.Visible = true;
                lblOperarios.Text = "Operarios: ";
                lblOperario.Text = "";
                lblAuxiliar01.Text = "";
                lblAuxiliar02.Text = "";
            }
            else
            {
                ibtnOperarios.IconChar = IconChar.ToggleOff;
                tbOperario.Visible = false;
                tbAuxiliar01.Visible = false;
                tbAuxiliar02.Visible = false;
                lblOperario.Text = "";
                lblAuxiliar01.Text = "";
                lblAuxiliar02.Text = "";
                tbOperario.Clear();
                tbAuxiliar01.Clear();
                tbAuxiliar02.Clear();
                verOperariosCargadosEnFormPrincipal();
            }
        }

        private void tbOperario_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbOperario.Text)) lblOperario.Text = "";

            if (!tbOperario.Text.All(char.IsDigit))
            {
                MessageBox.Show("Expresar legajo solo números.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbOperario.Clear();
                return;
            }
        }

        private void tbAuxiliar01_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAuxiliar01.Text)) lblAuxiliar01.Text = "";
            if (!tbAuxiliar01.Text.All(char.IsDigit))
            {
                MessageBox.Show("Expresar legajo solo números.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbAuxiliar01.Clear();
                return;
            }
        }

        private void tbAuxiliar02_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAuxiliar02.Text)) lblAuxiliar02.Text = "";
            if (!tbAuxiliar02.Text.All(char.IsDigit))
            {
                MessageBox.Show("Expresar legajo solo números.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbAuxiliar02.Clear();
                return;
            }
        }

        private void tbOperario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter & tbOperario.Text.All(char.IsDigit)& !string.IsNullOrEmpty(tbOperario.Text))
            {
                var operario = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbOperario.Text));
                if (operario != null)
                {
                    lblOperario.Text = operario.Nombre + " " + operario.Apellido;
                }
                else
                {
                    MessageBox.Show("No existe el legajo " + tbOperario.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblOperario.Text = "";
                    tbOperario.Text = "";
                    tbOperario.Focus();
                }
            }
        }

        private void tbAuxiliar01_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && tbAuxiliar01.Text.All(char.IsDigit) & !string.IsNullOrEmpty(tbAuxiliar01.Text))
            {
                var auxiliar = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbAuxiliar01.Text));
                if (auxiliar != null)
                {
                    lblAuxiliar01.Text = auxiliar.Nombre + " " + auxiliar.Apellido;
                }
                else
                {
                    MessageBox.Show("No existe el legajo " + tbAuxiliar01.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblAuxiliar01.Text = "";
                    tbAuxiliar01.Text = "";
                    tbAuxiliar01.Focus();
                }
            }
        }

        private void tbAuxiliar02_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && tbAuxiliar02.Text.All(char.IsDigit) & !string.IsNullOrEmpty(tbAuxiliar02.Text))
            {
                var auxiliar = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbAuxiliar02.Text));
                if (auxiliar != null)
                {
                    lblAuxiliar02.Text = auxiliar.Nombre + " " + auxiliar.Apellido;
                }
                else
                {
                    MessageBox.Show("No existe el legajo " + tbAuxiliar02.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblAuxiliar02.Text = "";
                    tbAuxiliar02.Text = "";
                    tbAuxiliar02.Focus();
                }
            }
        }

        private void pnlBultosTotales_MouseLeave(object sender, EventArgs e)
        {
            pnlBultosTotales.BackColor = Color.White;
        }

        private void pnlBultosTotales_MouseEnter(object sender, EventArgs e)
        {
            pnlBultosTotales.BackColor = Color.FromArgb(50, 0, 120, 215);
        }

        private void pnlTotalBolsas_MouseEnter(object sender, EventArgs e)
        {
            pnlTotalBolsas.BackColor = Color.FromArgb(50, 0, 120, 215);

        }

        private void pnlTotalBolsas_MouseLeave(object sender, EventArgs e)
        {
            pnlTotalBolsas.BackColor = Color.White;
        }


        private void filtrarPorNumBulto() {         
            if (!string.IsNullOrEmpty(tbFiltroDesde.Text) & !string.IsNullOrEmpty(tbFiltroHasta.Text))
            {
                EnumerableRowCollection<DataRow> query = from bultos in dt.AsEnumerable()
                                                         where bultos.Field<int>("Numero de bultos") >= int.Parse(tbFiltroDesde.Text) & bultos.Field<int>("Numero de bultos") <= int.Parse(tbFiltroHasta.Text)
                                                         select bultos;

                dv = query.AsDataView();
                dgvBultosRegistrados.DataSource = dv;
                lblBultosTotales.Text = "Total bultos: ";
                lblTotalBolsas.Text = "Total de bolsas: ";
                lblPesoTeorico.Text = "Peso teórico(neto): ";
                return;
            }

            if (!string.IsNullOrEmpty(tbFiltroDesde.Text))
            {
                EnumerableRowCollection<DataRow> query = from bultos in dt.AsEnumerable()
                                                         where bultos.Field<int>("Numero de bultos") >= int.Parse(tbFiltroDesde.Text)
                                                         select bultos;


                dv = query.AsDataView();
                dgvBultosRegistrados.DataSource = dv;
                lblBultosTotales.Text = "Total bultos: ";
                lblTotalBolsas.Text = "Total de bolsas: ";
                lblPesoTeorico.Text = "Peso teórico(neto): ";
            }
            if (!string.IsNullOrEmpty(tbFiltroHasta.Text))
            {
                EnumerableRowCollection<DataRow> query = from bultos in dt.AsEnumerable()
                                                         where bultos.Field<int>("Numero de bultos") <= int.Parse(tbFiltroHasta.Text)
                                                         select bultos;

                dv = query.AsDataView();
                dgvBultosRegistrados.DataSource = dv;
                lblBultosTotales.Text = "Total bultos: ";
                lblTotalBolsas.Text = "Total de bolsas: ";
                lblPesoTeorico.Text = "Peso teórico(neto): ";
            }

        }

        private void filtrarPorFecha()
        {
            if (dtpDesde.Value != null & dtpHasta.Value != null)
            {
                EnumerableRowCollection<DataRow> query = from bultos in dt.AsEnumerable()
                                                         where bultos.Field<DateTime>("Creación") >= dtpDesde.Value & bultos.Field<DateTime>("Creación") <= dtpHasta.Value
                                                         select bultos;

                dv = query.AsDataView();
                dgvBultosRegistrados.DataSource = dv;
                return;
            }
        }


        private void tbFiltroDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void tDosCifras_Tick(object sender, EventArgs e)
        {
            tbFiltroHasta.Text = desde + 1 + "";
        }

       

        private void dgvBultosRegistrados_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgvBultosRegistrados.SelectedCells.Count == 1 || dgvBultosRegistrados.SelectedCells.Count == 0) return;
            if (dgvBultosRegistrados.SelectedRows.Count == 1) return;
            
            foreach (DataGridViewCell cell in dgvBultosRegistrados.SelectedCells)
            {
                if (cell.ColumnIndex == 5) {
                    if ((bool)cell.FormattedValue == false) cell.Value = true;
                }
            }

        }
        List<MinMax> minMax = new List<MinMax>();
        private void dgvBultosRegistrados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 & e.RowIndex != -1)
            {
                if ((bool)dgvBultosRegistrados["seleccionarBulto", e.RowIndex].FormattedValue == true)
                {
                    MinMax numBulto = new MinMax();
                    numBulto.numero = int.Parse(dgvBultosRegistrados["Numero de bultos", e.RowIndex].Value.ToString());
                    numBulto.indice = int.Parse(dgvBultosRegistrados["idbulto", e.RowIndex].Value.ToString());
                    numBulto.cantPorPaquete = int.Parse(dgvBultosRegistrados["Cantidad de bolsas", e.RowIndex].Value.ToString());
                    totalBolsas = totalBolsas + int.Parse(dgvBultosRegistrados["Cantidad de bolsas", e.RowIndex].Value.ToString());
                    minMax.Add(numBulto);
                }
                else
                {
                    totalBolsas = totalBolsas - int.Parse(dgvBultosRegistrados["Cantidad de bolsas", e.RowIndex].Value.ToString());
                    var bultoRemover = minMax.SingleOrDefault(s => s.indice == int.Parse(dgvBultosRegistrados["idbulto", e.RowIndex].Value.ToString()));
                    if (bultoRemover != null)
                    {
                        if (bultoRemover.indice != 0)
                        {
                            minMax.Remove(bultoRemover);
                        }
                    }
                }

                if (minMax.Count != 0)
                {
                    total = "";
                    var distintosPaquetes = minMax.GroupBy(a => a.cantPorPaquete).Select(p => new { paquete = p.Key, cantidad = p.ToList().Count }).ToList();
                    foreach (var i in distintosPaquetes) {
                        total = total + "[" + i.cantidad.ToString() + "x" + i.paquete.ToString() + "]";
                    }
                    
                    minimo = minMax.Select(m => m.numero).Min();
                    maximo = minMax.Select(m => m.numero).Max();
                    totalBultos = minMax.Select(m => m.numero).Count();
                    pesoNetoTeorico = totalBolsas * pesoMillar;
                    lblBultosTotales.Text = "Total bultos: " + totalBultos;
                    lblTotalBolsas.Text = "Total de bolsas: " + totalBolsas + total;
                    lblPesoTeorico.Text = "Peso teórico(neto): " + string.Format("{0:0.00}", pesoNetoTeorico);
                }
                else
                {
                    lblBultosTotales.Text = "Total bultos: ";
                    lblTotalBolsas.Text = "Total de bolsas: ";
                    lblPesoTeorico.Text = "Peso teórico(neto): ";
                }
            }
        }

        private void docImprimir_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Primera columna cabecera
            e.Graphics.DrawString(formPrincipal.instancia.datosOp[0], robotoMedium, Brushes.Black, new RectangleF(20, 20, 600, 25));
            e.Graphics.DrawString("IP: " + ntIp.idNt, robotoLight, Brushes.Black, new RectangleF(20, 65, 300, 25));
            e.Graphics.DrawString("O/P: " + op, robotoLight, Brushes.Black, new RectangleF(580, 65, 200, 25));

            //Segunda columna cabecera
            //Empresa SANLUFILM S.A.
            e.Graphics.DrawString("SANLUFILM S.A.", robotoMediumMini, Brushes.Black, new RectangleF(580, 20, 180, 15));
            //Fecha realizado
            e.Graphics.DrawString("Impresión realizada el: " + DateTime.Now, robotoMini, Brushes.Black, new RectangleF(580, 30, 250, 15));

            //Largo/Espesor/Ancho
            e.Graphics.DrawString(lblLargo.Text, robotoLight, Brushes.Black, new RectangleF(20, 100, 180, 25));
            e.Graphics.DrawString(lblEspesor.Text, robotoLight, Brushes.Black, new RectangleF(310, 100, 180, 25));
            e.Graphics.DrawString(lblAncho.Text, robotoLight, Brushes.Black, new RectangleF(580, 100, 180, 25));

            //Primera Linea
            e.Graphics.DrawLine(lapizNegro3Px, 20, 125, 830, 125);

            //Primera columna
            //Numero pallet
            e.Graphics.DrawString("N° de pallet: " + palletNumero.ToString(), robotoLight, Brushes.Black, new RectangleF(20, 130, 180, 25));
            //Bultos
            e.Graphics.DrawString("Bultos: " + totalBultos, robotoLight, Brushes.Black, new RectangleF(20, 160, 180, 20));
            //Maquina
            e.Graphics.DrawString(lblMaquina.Text, robotoLight, Brushes.Black, new RectangleF(20, 190, 300, 25));
            //Fecha
            e.Graphics.DrawString("Creado el: "+ntIp.fechaCreado, robotoLight, Brushes.Black, new RectangleF(20, 220, 300, 25));

            //Segunda columna
            //Peso tarima
            e.Graphics.DrawString("Peso tarima: " + tbPesoTarima.Text + "Kgs", robotoLight, Brushes.Black, new RectangleF(310, 130, 300, 25));
            //Total bolsas
            e.Graphics.DrawString(lblTotalBolsas.Text, robotoLight, Brushes.Black, new RectangleF(310, 160, 500, 25));
            //Peso teorico
            e.Graphics.DrawString(lblPesoTeorico.Text + "Kgs", robotoLight, Brushes.Black, new RectangleF(310, 190, 300, 25));
            //Operarios
            e.Graphics.DrawString(tbOperario.Visible ? "Operario/s: "+operariosSeleccionar : lblOperarios.Text, robotoLight, Brushes.Black, new RectangleF(310, 220, 300, 25));
            //Segunda Linea
            e.Graphics.DrawLine(lapizNegro3Px, 20, 250, 830, 250);

            //Ficha embalaje
            e.Graphics.DrawString("Ficha de embalaje: " + ntIp.embalaje_pDescripcion + " EE:" + ntIp.idEmbalaje, robotoMedium, Brushes.Black, new RectangleF(20, 260, 800, 30));
            e.Graphics.DrawString("Disposicion: " + ntIp.embalaje_pDisposicion, robotoLightMedium, Brushes.Black, new RectangleF(25, 290, 800, 500));

            //Segunda columna embalaje
            e.Graphics.DrawString("Fungible: " + ntIp.embalaje_pFungible + "Kgs", robotoLight, Brushes.Black, new RectangleF(25, 780, 300, 25));

            //Tercera Linea
            e.Graphics.DrawLine(lapizNegro3Px, 25, 810, 800, 810);

            //Linea Recta Primera
            e.Graphics.DrawLine(lapizNegro3Px, 25, 810, 25, 880);
            //Linea Recta Media
            e.Graphics.DrawLine(lapizNegro3Px, 400, 810, 400, 880);
            //Linea Recta Ultima
            e.Graphics.DrawLine(lapizNegro3Px, 800, 810, 800, 880);

            var YCuadro = 820;
            var contador = 0;
            var insumos = mySqlConexion.buscarEmbalajeInsumos(ntIp.idEmbalaje.ToString());
            foreach (Insumo insumo in insumos)
            {
                if (contador > 1)
                {
                    if (contador == 2) YCuadro = 820;
                    //Cuadritos
                    e.Graphics.DrawRectangle(lapizNegro1Px, 410, YCuadro, 20, 20);

                    //Cuadritos items
                    e.Graphics.DrawString(insumo.nombre, robotoLightMedium, Brushes.Black, new RectangleF(435, YCuadro, 300, 25));

                    //Cuadritos items cantidad
                    e.Graphics.DrawString(insumo.unidad, robotoLightMedium, Brushes.Black, new RectangleF(710, YCuadro, 300, 25));
                }
                else
                {
                    //Cuadritos
                    e.Graphics.DrawRectangle(lapizNegro1Px, 35, YCuadro, 20, 20);

                    //Cuadritos items
                    e.Graphics.DrawString(insumo.nombre, robotoLightMedium, Brushes.Black, new RectangleF(65, YCuadro, 300, 25));

                    //Cuadritos items cantidad
                    e.Graphics.DrawString(insumo.unidad, robotoLightMedium, Brushes.Black, new RectangleF(310, YCuadro, 300, 25));
                }

                YCuadro = YCuadro + 30;
                contador++;
            }

            //Cuarta Linea
            e.Graphics.DrawLine(lapizNegro3Px, 25, 880, 800, 880);

            //Pie
            e.Graphics.DrawString("Mantener esta hoja, hasta el sector de recepcion", robotoLight, Brushes.Black, new RectangleF(35, 890, 600, 25));
            e.Graphics.DrawString("Sector de recepcion, archivar esta hoja", robotoLight, Brushes.Black, new RectangleF(35, 920, 600, 25));

            //Cuadro de firma
            e.Graphics.DrawRectangle(lapizNegro1Px, 600, 950, 200, 100);
            e.Graphics.DrawString("Firma", robotoLight, Brushes.Black, new RectangleF(670, 1030, 60, 25));

            //Codigo de barra 
            e.Graphics.DrawString("IP" + ntIp.idNt, barcode, Brushes.Black, new RectangleF(12, 950, 300, 200));

        }

        private void dgvBultosRegistrados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {           
                if (e.Button != MouseButtons.Right) return;
                dgvBultosRegistrados.ClearSelection();
                dgvBultosRegistrados.Rows[e.RowIndex].Selected = true;
                cmsDgvBultos.Show(MousePosition);
            }

        }

        private void cbSeleccionarTodo_CheckedChanged(object sender, EventArgs e)
        {
            dgvBultosRegistrados.ClearSelection();
            if (cbSeleccionarTodo.Checked)
            {

                for (int i = 0; i < dgvBultosRegistrados.RowCount; i++)
                    dgvBultosRegistrados["seleccionarBulto", i].Selected = true;
            }
            else
            {
                dgvBultosRegistrados.ClearSelection();
                for (int i = 0; i < dgvBultosRegistrados.RowCount; i++)
                    dgvBultosRegistrados["seleccionarBulto", i].Value = false;
            }
        }

        private void itemEditar_Click(object sender, EventArgs e)
        {
            cantEditada = 0;
            if (dgvBultosRegistrados.SelectedRows.Count == 1)
            {
                columnaSelecionadaEditar.Clear();
                try
                {
                    if ((bool)dgvBultosRegistrados.SelectedCells[5].FormattedValue)
                    {
                        dgvBultosRegistrados.SelectedCells[5].Value = false;
                    }

                    columnaSelecionadaEditar.Add(dgvBultosRegistrados.SelectedCells[1].Value.ToString());
                    columnaSelecionadaEditar.Add(dgvBultosRegistrados.SelectedCells[2].Value.ToString());
                    columnaSelecionadaEditar.Add(dgvBultosRegistrados.SelectedCells[3].Value.ToString());
                    columnaSelecionadaEditar.Add(dgvBultosRegistrados.SelectedCells[4].Value.ToString());
                    columnaSelecionadaEditar.Add(dgvBultosRegistrados.SelectedCells[6].Value.ToString());
                    formEditarBulto editarBulto = new formEditarBulto();
                    editarBulto.ShowDialog();
                    if (cantEditada != 0)
                    {
                        dgvBultosRegistrados.SelectedCells[3].Value = cantEditada;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }

        }

        private void itemEliminar_Click(object sender, EventArgs e)
        {
            motivoBaja = "";
            if (dgvBultosRegistrados.SelectedRows.Count == 1)
            {
                try
                {
                    formMotivoBaja motivo = new formMotivoBaja();
                    motivo.ShowDialog();

                    formAutorizar formAutorizar = new formAutorizar();
                    formAutorizar.ShowDialog();
                    if (formAutorizar.autenticacion)
                    {
                        string sql01 = "";
                        var idBulto = dgvBultosRegistrados.SelectedCells[4].Value.ToString();
                        if (motivoBaja != "")
                        {
                            sql01 = $"update bultos b set b.estado = 0, b.observacion = '{motivoBaja + " Eliminado por: " + formAutorizar.autoriza}' where id = '{dgvBultosRegistrados.SelectedCells[4].Value}';";
                        }
                        else {
                            sql01 = $"update bultos b set b.estado = 0, b.observacion = 'Eliminado por :{formAutorizar.autoriza}' where id = '{dgvBultosRegistrados.SelectedCells[4].Value}';";
                        }

                        var cantBolsasOriginal = dgvBultosRegistrados.SelectedCells[3].Value.ToString();
                        var idBobina = dgvBultosRegistrados.SelectedCells[6].Value.ToString();
                        var deBolsasAMts = int.Parse(cantBolsasOriginal) * double.Parse(formPrincipal.instancia.datosOp[2]);
                        string sql02 = "";
     
                        var sector = formPrincipal.instancia.bobinaSector;
                        if (sector == "i" | sector == "I")
                        {
                            sql02 = $"update impresionesproductoterminado ipt set ipt.metrosremanentes = ipt.metrosremanentes + '{(int)deBolsasAMts}', ipt.observaciones ='{operarios}'" +
                                    $" where e.indice = '{idBobina}';";
                        } 
                        if (sector == "e" | sector == "E")
                        {
                            sql02 = $"update extrusiones e set e.metrosremanentes = e.metrosremanentes + '{(int)deBolsasAMts}', e.observaciones ='{operarios}'" +
                                    $" where e.indice = '{idBobina}';";
                        }

                            if (mySqlConexion.sqlSimpleQuery(sql01, sql02))
                        {
                            if ((bool)dgvBultosRegistrados.SelectedCells[5].FormattedValue)
                            {
                                dgvBultosRegistrados.SelectedCells[5].Value = false;
                            }
                            
                            dgvBultosRegistrados.Rows.RemoveAt(dgvBultosRegistrados.SelectedRows[0].Index);
                            formPrincipal.instancia.bobinasOp.FirstOrDefault(bob => bob.indice == int.Parse(idBobina)).mtsRemanentesRollo+=(int)deBolsasAMts;
                            (formPrincipal.instancia.Controls.Find("tbBolsasSolicitadas", true).FirstOrDefault() as TextBox).Text = formPrincipal.instancia.datosOp[7] + "|" + mySqlConexion.totalBolsasCreadas(formPrincipal.instancia.datosOp[11]); ;
                            //si es diferente a 0 es que se seleccionaron paquetes
                          

                            lblBultosTotales.Text = "Total bultos: ";
                            lblTotalBolsas.Text = "Total de bolsas: ";
                            lblPesoTeorico.Text = "Peso teórico(neto): ";

                        }
                        else MessageBox.Show("Error, comunique este problema a sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
        }

        private void dgvBultosRegistrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cantEditada = 0;
            if (e.ColumnIndex == 2 && e.RowIndex == -1) return;
            columnaSelecionadaEditar.Clear();
            if (e.ColumnIndex == 0 && e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                if ((bool)dgvBultosRegistrados["seleccionarBulto", e.RowIndex].FormattedValue == false)
                {
                    celdaClickEditar(e.RowIndex);
                }
                else {
                    dgvBultosRegistrados["seleccionarBulto", e.RowIndex].Value = false;
                    celdaClickEditar(e.RowIndex);
                }
                
            }

            if (e.ColumnIndex == 5 && e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                if (dgvBultosRegistrados.SelectedCells.Count == 1 && (bool)dgvBultosRegistrados["seleccionarBulto", e.RowIndex].FormattedValue == true)
                {
                    dgvBultosRegistrados["seleccionarBulto", e.RowIndex].Value = false;
                    return;
                }
                else dgvBultosRegistrados["seleccionarBulto", e.RowIndex].Value = true;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            formMostrarPallets mostrarPallets = new formMostrarPallets();
            mostrarPallets.ShowDialog();
            if (palletModificado == true)
            {
                Close();
            }
        }

        private void celdaClickEditar(int index)
        {          
            try
            {
                columnaSelecionadaEditar.Add(dgvBultosRegistrados["Numero de bultos", index].Value.ToString());
                columnaSelecionadaEditar.Add(dgvBultosRegistrados["Creación", index].Value.ToString());
                columnaSelecionadaEditar.Add(dgvBultosRegistrados["Cantidad de bolsas", index].Value.ToString());
                columnaSelecionadaEditar.Add(dgvBultosRegistrados["idBulto", index].Value.ToString());
                columnaSelecionadaEditar.Add(dgvBultosRegistrados["idorigen", index].Value.ToString());
                formEditarBulto editarBulto = new formEditarBulto();
                editarBulto.ShowDialog();
                if (cantEditada != 0)
                {
                    dgvBultosRegistrados["Cantidad de bolsas", index].Value = cantEditada;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbFiltroHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void tbPesoTarima_TextChanged_1(object sender, EventArgs e)
        {
            if (!tbPesoTarima.Text.All(char.IsDigit))
            {
                tbPesoTarima.Text = "";
                return;
            }
        }

        private void tbPesoTarima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void formIp_Activated(object sender, EventArgs e)
        {

        }

        private void tbFiltroDesde_TextChanged(object sender, EventArgs e)
        {
            if (cbSeleccionarTodo.Checked) cbSeleccionarTodo.Checked = false;
            foreach (DataGridViewRow row in dgvBultosRegistrados.Rows)
            {
                if (row.Cells[5].FormattedValue.Equals(true))
                {
                    row.Cells[5].Value = false;
                }
            }
            if (!tbFiltroDesde.Text.All(char.IsDigit))
            {
                tbFiltroDesde.Text = "";
                return;
            }
            if (dv != null) dv.RowFilter = "";
            if (tbFiltroDesde.Text == "0") tbFiltroDesde.Text = "";

            desde = !string.IsNullOrEmpty(tbFiltroDesde.Text) ? int.Parse(tbFiltroDesde.Text) : 0;
            if (!string.IsNullOrEmpty(tbFiltroDesde.Text) & !string.IsNullOrEmpty(tbFiltroHasta.Text)) if (desde >= hasta) tbFiltroDesde.Text = desde - 1 + "";
            filtrarPorNumBulto();
        }

        private void tbFiltroHasta_TextChanged(object sender, EventArgs e)
        {
            if (cbSeleccionarTodo.Checked) cbSeleccionarTodo.Checked = false;
            foreach (DataGridViewRow row in dgvBultosRegistrados.Rows)
            {
                if (row.Cells[5].FormattedValue.Equals(true))
                {
                    row.Cells[5].Value = false;
                }
            }

            if (!tbFiltroHasta.Text.All(char.IsDigit)) {
                tbFiltroHasta.Text = "";
                return;
            }

            if (dv != null) dv.RowFilter = "";
            if (tbFiltroHasta.Text == "0") tbFiltroHasta.Text = "";
            hasta = !string.IsNullOrEmpty(tbFiltroHasta.Text) ? int.Parse(tbFiltroHasta.Text) : 0;
            if (tDosCifras.Enabled == true) tDosCifras.Stop();
            if (desde > 0 & hasta > 0) if (hasta <= desde)
                {
                    tDosCifras.Start();
                    return;
                }
            filtrarPorNumBulto();
        }


        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Esta función todavía no está habilitada");
            //if (dtpHasta.Value <= dtpDesde.Value) dtpHasta.Value = dtpDesde.Value;
            //filtrarPorFecha();
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Esta función todavía no está habilitada");
            //if (dtpDesde.Value >= dtpHasta.Value) dtpDesde.Value = dtpHasta.Value;
            //filtrarPorFecha();
        }

        private void tsmPorNumero_Click(object sender, EventArgs e)
        {
            tssbFiltros.Image = Properties.Resources.numerado16px;
            dtpDesde.Visible = false;
            dtpHasta.Visible = false;
        }

        private void dgvBultosRegistrados_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && (e.ColumnIndex == 0 || e.ColumnIndex == 5)) dgvBultosRegistrados.Cursor = Cursors.Hand;
        }

        private void dgvBultosRegistrados_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && (e.ColumnIndex == 0 || e.ColumnIndex == 5) ) dgvBultosRegistrados.Cursor = Cursors.Default;
        }

        private void tsmPorFecha_Click(object sender, EventArgs e)
        {
            tssbFiltros.Image = Properties.Resources.calendario16px;
            dtpDesde.Visible = true;
            dtpHasta.Visible = true;
            tbFiltroDesde.Text = "";
            tbFiltroHasta.Text = "";
            if (dv != null) dv.RowFilter = "";
        }
    }
}
