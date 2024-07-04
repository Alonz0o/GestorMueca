using FontAwesome.Sharp;
using EtiquetadoBultos.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using MaterialSkin.Controls;

namespace EtiquetadoBultos
{

    public partial class formPrincipal : MaterialForm
    {

        //Constantes
        const int identificador = 0;
        const int mtsDisponibles = 4;
        const int mtsOriginales = 2;
        const int orden = 8;
        const int codigo = 9;
        const int cantidadDeBolsas = 12;
        //Variables
        public static formPrincipal instancia;
        ConexionMySql mySqlConexion = new ConexionMySql();
        private double sumatoriaMtsBobinas;
        IList<Usuario> personal = new List<Usuario>();
        public IList<string> datosOp = new List<string>();
        public IList<Bobina> bobinasOp = new List<Bobina>();
        Calculo calc = new Calculo();
        formCambiarValorLongitud formCambiarValor = new formCambiarValorLongitud();
        public string[] operadores = new string[4] { "0", "0", "0", "0" };
        public string[] operadoresNomApe = new string[4] { "0", "0", "0", "0" };
        public List<Bobina> bobinasXPallet = new List<Bobina>();
        public List<Bobina> bobinasRemanentes = new List<Bobina>();
        int bolsasConfeccionadas = 0;
        public string etiquetadoraSeleccionada = "0";
        public string encargadoNomApe = "";
        public string bobinaSector = "";
        public string fasonCantidad = "";
        public string maquinaSeleccionada = "";
        public Label lblInstanciaOP;

        public formPrincipal()
        {
            InitializeComponent();
            cargarDatosEnTextBox();
            if (Program.argumentos.Count != 0)
            {


                bobinaSector = mySqlConexion.comprobarSector(Program.argumentos[1]);
                datosOp = mySqlConexion.buscarOp(Program.argumentos[0], Program.argumentos[1]);
                if (datosOp.Count == 0) return;
                bobinasOp = mySqlConexion.buscarBobinas(Program.argumentos[0], Program.argumentos[1], bobinaSector);
                
                if (Program.argumentos[2] != "0")
                {
                    cargarEncargado(Program.argumentos[2]);
                }
                if (Program.argumentos[3] != "0")
                {
                    tbOperario.Text = Program.argumentos[3];
                    if (!string.IsNullOrEmpty(tbOperario.Text)) cargarPersonal("00");
                }
                if (Program.argumentos[4] != "0")
                {
                    maquinaSeleccionada = mySqlConexion.buscarMaquinaPorId(Program.argumentos[4]);                 
                }
                if (maquinaSeleccionada=="FASON") {
                    btnEtiquetar.Visible = false;
                    btnGenerarFason.Visible = true;
                }
                cambiarDatos();
            }
            
            instancia = this;
            dgvBobinasRegistradas.AllowUserToAddRows = false;
            dgvBobinasRegistradas.Columns.Add("cIdentificador", "Identificador");
            dgvBobinasRegistradas.Columns.Add("cNumRollo", "Num Bobina");
            dgvBobinasRegistradas.Columns.Add("cLongRollo", "Mts Originales");
            dgvBobinasRegistradas.Columns.Add("cPesoRollo", "Neto");
            dgvBobinasRegistradas.Columns.Add("cMtsRemanentes", "Mts Disponibles");

            if (!Directory.Exists(@"D:\ZplEtiquetado"))
            {
                Directory.CreateDirectory(@"D:\ZplEtiquetado");
                if (!File.Exists(@"D:\\ZplEtiquetado\ZplEjecutableSECTORCONFECCION.bat")) {
                    FileStream fs = new FileStream(@"D:\\ZplEtiquetado\ZplEjecutableSECTORCONFECCION.bat", FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(fs);
                    writer.WriteLine(@"copy D:\ZplEtiquetado\ZPLArchivo.ejf \\SECTORCONFECCION\zpl02");
                    writer.Close();
                }
                if (!File.Exists(@"D:\\ZplEtiquetado\ZplEjecutableMaquina10.bat"))
                {
                    FileStream fs = new FileStream(@"D:\\ZplEtiquetado\ZplEjecutableMaquina10.bat", FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(fs);
                    writer.WriteLine(@"copy D:\ZplEtiquetado\ZPLArchivo.ejf \\MAQUINA10\zt230");
                    writer.Close();
                }
                if (!File.Exists(@"D:\\ZplEtiquetado\ZplEjecutableMaquina11.bat"))
                {
                    FileStream fs = new FileStream(@"D:\\ZplEtiquetado\ZplEjecutableMaquina11.bat", FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(fs);
                    writer.WriteLine(@"copy D:\ZplEtiquetado\ZPLArchivo.ejf \\MAQUINA11\zt230_1");
                    writer.Close();
                }
                if (!File.Exists(@"D:\\ZplEtiquetado\ZplEjecutableMaquina12.bat"))
                {
                    FileStream fs = new FileStream(@"D:\\ZplEtiquetado\ZplEjecutableMaquina12.bat", FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(fs);
                    writer.WriteLine(@"copy D:\ZplEtiquetado\ZPLArchivo.ejf \\MAQUINA12-PC\zm400");
                    writer.Close();
                }
                if (!File.Exists(@"D:\\ZplEtiquetado\ZplEjecutableMaquina49.bat"))
                {
                    FileStream fs = new FileStream(@"D:\\ZplEtiquetado\ZplEjecutableMaquina49.bat", FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(fs);
                    writer.WriteLine(@"copy D:\ZplEtiquetado\ZPLArchivo.ejf \\MAQUINA49\Zebra492");
                    writer.Close();
                }

            }

            lblInstanciaOP = lblOp;

        }

        public void cambiarDatos()
        {
            limpiarForm();
            var largoMostrar = double.Parse(datosOp[2]) * 100;
            lblOp.Text = datosOp[orden] + " / " + datosOp[codigo];
            tbCliente.Text = datosOp[0];
            lblMaquina.Text = maquinaSeleccionada != "" ? maquinaSeleccionada : datosOp[6];
            lblSoldadura.Text = datosOp[5];   
            
            tbAnchoBolsa.Text = datosOp[1] + "cm";
            tbLargoBolsa.Text = largoMostrar.ToString() + "cm";
            tbEspesorBolsa.Text = datosOp[3] + "µm";
            var totalBolsasCreadas = mySqlConexion.totalBolsasCreadas(datosOp[11]);
      
            var excedenteMin = int.Parse(datosOp[7]) / 100 * int.Parse(datosOp[19]);//excedenteMin
            var excedenteMax = int.Parse(datosOp[7]) / 100 * int.Parse(datosOp[20]);//excedenteMax
            excedenteMin = int.Parse(datosOp[7]) - excedenteMin;
            excedenteMax = int.Parse(datosOp[7]) + excedenteMax;

            tbCantBolsasMin.Text = "MIN " + excedenteMin.ToString();
            tbCantBolsasMax.Text = "MAX " + excedenteMax.ToString();

            tbBolsasSolicitadas.Text = datosOp[7] + "|" + totalBolsasCreadas;
            

            btnReEtiquetar.Enabled = true;
            btnIp.Enabled = true;
            calc.porUnPaquete = datosOp.Count > 0 ? double.Parse(datosOp[12]) * double.Parse(datosOp[2]) : 0.0;           
        }

        public void limpiarEM()
        {
            dgvBobinasRegistradas.Rows.Clear();
            tbSumMetros.Clear();
            sumatoriaMtsBobinas = 0;
            tbCantPaquetes.Clear();
        }

        private void limpiarForm()
        {
            dgvBobinasRegistradas.Rows.Clear();
            tbSumMetros.Clear();
            sumatoriaMtsBobinas = 0;
            tbCantPaquetes.Clear();
            tbCantidadBolsas.Clear();
            tbRegistrarBobina.Clear();
        }

          private void ibtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ibtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        //KeyDown Componente tbOperario, tbAuxiliar01 y tbAuxiliar02
        private void tbOperario_KeyDown(object sender, KeyEventArgs e)
        {
            var componente = (TextBox)sender;
            switch (componente.Name)
            {
                case "tbOperario":
                    if (e.KeyData == Keys.Enter && tbOperario.Text.All(char.IsDigit) & !string.IsNullOrEmpty(tbOperario.Text))
                    {
                        var operario = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbOperario.Text));
                        if (operario != null)
                        {
                            gbOperario.Text = operario.Nombre + " " + operario.Apellido;
                            operadores[1] = operario.Legajo.ToString();
                            operadoresNomApe[1] = operario.Nombre + " " + operario.Apellido;
                        }
                        else
                        {
                            MessageBox.Show("No existe el legajo " + tbOperario.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gbOperario.Text = "Operario *";
                            tbOperario.Text = "";
                            tbOperario.Focus();
                        }
                    }
                    break;

                case "tbAuxiliar01":
                    if (e.KeyData == Keys.Enter & tbAuxiliar01.Text.All(char.IsDigit) & !string.IsNullOrEmpty(tbAuxiliar01.Text))
                    {
                        var auxiliar = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbAuxiliar01.Text));
                        if (auxiliar != null)
                        {
                            gbAuxiliar01.Text = auxiliar.Nombre + " " + auxiliar.Apellido;
                            operadores[2] = auxiliar.Legajo.ToString();
                            operadoresNomApe[2] = auxiliar.Nombre + " " + auxiliar.Apellido;
                        }
                        else
                        {
                            MessageBox.Show("No existe el legajo " + tbAuxiliar01.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gbAuxiliar01.Text = "Auxiliar";
                            tbAuxiliar01.Text = "";
                            tbAuxiliar01.Focus();
                        }
                    }
                    break;

                case "tbAuxiliar02":
                    if (e.KeyData == Keys.Enter && tbAuxiliar02.Text.All(char.IsDigit) & !string.IsNullOrEmpty(tbAuxiliar02.Text))
                    {
                        var auxiliar02 = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbAuxiliar02.Text));
                        if (auxiliar02 != null)
                        {
                            gbAuxiliar02.Text = auxiliar02.Nombre + " " + auxiliar02.Apellido;
                            operadores[3] = auxiliar02.Legajo.ToString();
                            operadoresNomApe[3] = auxiliar02.Nombre + " " + auxiliar02.Apellido;
                        }
                        else
                        {
                            MessageBox.Show("No existe el legajo " + tbAuxiliar02.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gbAuxiliar02.Text = "Auxiliar";
                            tbAuxiliar02.Text = "";
                            tbAuxiliar02.Focus();
                        }
                    }
                    break;
            }
        }

        private void ibtnOperarioOk_Click(object sender, EventArgs e)
        {
            cargarPersonal("00");
        }

        private void ibtnAuxiliar01Ok_Click(object sender, EventArgs e)
        {
            cargarPersonal("01");
        }

        private void ibtnAuxiliar02Ok_Click(object sender, EventArgs e)
        {
            cargarPersonal("02");
        }

        private void cargarEncargado(string personalLegajo)
        {
            if (!string.IsNullOrEmpty(personalLegajo))
            {
                var encargado = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(personalLegajo));
                if (encargado != null)
                {
                    lblOperariosEncargado.Text = "Operarios -" + " Encargado: " + encargado.Nombre + " " + encargado.Apellido;
                    operadores[0] = encargado.Legajo.ToString();
                    encargadoNomApe = encargado.Nombre + " " + encargado.Apellido;
                    operadoresNomApe[0] = encargado.Nombre + " " + encargado.Apellido;
                }
                else
                {
                    MessageBox.Show("No existe el legajo " + tbOperario.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblOperariosEncargado.Text = "Operarios";
                }
            }
            else
            {
                lblOperariosEncargado.Text = "Operarios";
                MessageBox.Show("Debe ingresar legajo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ibtnOperarioLimpiar_Click(object sender, EventArgs e)
        {
            tbOperario.Clear();
            gbOperario.Text = "Operario *";
        }      
        
        private void cargarPersonal(string perNum)
        {
            TextBox tbPersonal = new TextBox();
            GroupBox gbPersonal = new GroupBox();
            if (perNum == "00")
            {
                tbPersonal = Controls.Find("tbOperario", true)[0] as TextBox;
                gbPersonal = Controls.Find("gbOperario", true)[0] as GroupBox;

            }
            else
            {
                tbPersonal = Controls.Find("tbAuxiliar" + perNum, true)[0] as TextBox;
                gbPersonal = Controls.Find("gbAuxiliar" + perNum, true)[0] as GroupBox;

            }

            if (!string.IsNullOrEmpty(tbPersonal.Text))
            {
                var auxiliar = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbPersonal.Text));
                if (auxiliar != null)
                {
                    gbPersonal.Text = auxiliar.Nombre + " " + auxiliar.Apellido;
                    if (perNum == "00") { 
                        operadores[1] = auxiliar.Legajo.ToString();
                        operadoresNomApe[1] = auxiliar.Nombre + " " + auxiliar.Apellido;
                    }
                    if (perNum == "01") { 
                        operadores[2] = auxiliar.Legajo.ToString();
                        operadoresNomApe[2] = auxiliar.Nombre + " " + auxiliar.Apellido;
                    }
                    if (perNum == "02") { 
                        operadores[3] = auxiliar.Legajo.ToString();
                        operadoresNomApe[3] = auxiliar.Nombre + " " + auxiliar.Apellido;
                    }

                }
                else
                {
                    if (perNum == "00")
                    {
                        MessageBox.Show("No existe el legajo " + tbOperario.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gbPersonal.Text = "Operario *";
                        tbPersonal.Text = "";
                        tbPersonal.Focus();
                    }
                    else
                    {
                        MessageBox.Show("No existe el legajo " + tbPersonal.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gbPersonal.Text = "Auxiliar";
                        tbPersonal.Text = "";
                        tbPersonal.Focus();
                    }

                }
            }
            else
            {
                if (perNum == "00")
                {
                    gbPersonal.Text = "Operario *";
                    tbPersonal.Text = "";
                    tbPersonal.Focus();
                    MessageBox.Show("Debe ingresar legajo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    gbPersonal.Text = "Auxiliar";
                    tbPersonal.Text = "";
                    tbPersonal.Focus();
                    MessageBox.Show("Debe ingresar legajo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void ibtnAuxiliar01Limpiar_Click(object sender, EventArgs e)
        {
            tbAuxiliar01.Clear();
            gbAuxiliar01.Text = "Auxiliar";
        }      
        
        private void ibtnAuxiliar02Limpiar_Click(object sender, EventArgs e)
        {
            tbAuxiliar02.Clear();
            gbAuxiliar02.Text = "Auxiliar";
        }

        private void lblOp_Click(object sender, EventArgs e)
        {
            try
            {
                formCambiarOp cambiarOp = new formCambiarOp();
                cambiarOp.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void verificarBobina(int idBobina)
        {
            var respuesta = 0;
            var buscarBob = bobinasOp.FirstOrDefault(bob => bob.indice == idBobina) == null ? mySqlConexion.buscarBobina(idBobina.ToString(), datosOp[9], bobinaSector) : bobinasOp.FirstOrDefault(bob => bob.indice == idBobina);
            var totalMtsRemanentes = mySqlConexion.comprobarTc(buscarBob,bobinaSector);
            if (totalMtsRemanentes != -1) respuesta = comprobarPallet(totalMtsRemanentes, buscarBob);
            if (respuesta == -1) return;

            if (buscarBob.indice != 0)
            {
                if (buscarBob.mtsRemanentesRollo == 0 && respuesta != 0)
                {
                    MessageBox.Show("Esta bobina no tiene metros disponibles.", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbRegistrarBobina.Text = "";
                    return;
                }
            }
            else
            {
                MessageBox.Show("No existe bobina con ese identificador.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbRegistrarBobina.Text = "";
                return;
            }
            if (respuesta == 1)
            {
                bobinasOp.Add(buscarBob);
                sumatoriaMtsBobinas += buscarBob.mtsRemanentesRollo;
                dgvBobinasRegistradas.Rows.Add(buscarBob.indice, buscarBob.numRollo, buscarBob.longitudRollo, buscarBob.neto, buscarBob.mtsRemanentesRollo);
                tbSumMetros.Text = sumatoriaMtsBobinas.ToString();
                tbRegistrarBobina.Text = "";
            }
        }

        const int MTS_REMANENTES_BOBINA = 1;
        private int comprobarPallet(int totalMtsRemanentes, Bobina buscarBob)
        {
            var respuesta = -1;
            var porcentaje_al_10 = (totalMtsRemanentes * 10) / 100;
            //if () { 
            
            //}
            if (totalMtsRemanentes == 0)
            {
                if (buscarBob.idNTIntermedio != -1) mySqlConexion.bajaLogicaTc(buscarBob.idNTIntermedio);
                MessageBox.Show("No es posible cargar esta bobina. Porque su origen fue deshabilitado por el sistema.", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRegistrarBobina.Text = "";
                return respuesta;
            }
            if (totalMtsRemanentes < calc.porUnPaquete)
            {
                if (calc.porUnPaquete == 0) calc.porUnPaquete = double.Parse(tbCantidadBolsas.Text) * double.Parse(datosOp[2]);
                if (buscarBob.idNTIntermedio!=-1) mySqlConexion.bajaLogicaTc(buscarBob.idNTIntermedio);
                respuesta = 0;
                bobinasRemanentes.Clear();
                bobinasXPallet = mySqlConexion.buscarPalletBobinas(buscarBob, bobinaSector);
                formPalletBobinas palletBobinas = new formPalletBobinas();
                palletBobinas.ShowDialog();
                if (bobinasRemanentes.Count != 0)
                {
                    foreach (Bobina bobina in bobinasRemanentes)
                    {                     
                        var bobinaEncontrada = bobinasOp.FirstOrDefault(bob => bob.indice == bobina.indice);
                        if (bobinaEncontrada == null)
                        {
                            bobinasOp.Add(bobina);
                            sumatoriaMtsBobinas += bobina.mtsRemanentesRollo;
                            dgvBobinasRegistradas.Rows.Add(bobina.indice, bobina.numRollo, bobina.longitudRollo, bobina.neto, bobina.mtsRemanentesRollo);
                            tbSumMetros.Text = sumatoriaMtsBobinas.ToString();
                            tbRegistrarBobina.Text = "";
                        }
                        else {
                            sumatoriaMtsBobinas += bobina.mtsRemanentesRollo;
                            dgvBobinasRegistradas.Rows.Add(bobina.indice, bobina.numRollo, bobina.longitudRollo, bobina.neto, bobina.mtsRemanentesRollo);
                            tbSumMetros.Text = sumatoriaMtsBobinas.ToString();
                            tbRegistrarBobina.Text = "";
                        }
                        
                    }
                }
                else tbRegistrarBobina.Text = "";
            }
            else respuesta = 1;
            return respuesta;
        }

        private void tbCantPaquetes_TextChanged(object sender, EventArgs e)
        {
            if (tbCantidadBolsas.Text == "") {
                tbCantidadBolsas.Focus();
                MessageBox.Show("Debe ingresar cantidad de bolsas por paquete.", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            
            if (tbCantidadBolsas.Enabled == true)
            {
                if (!string.IsNullOrEmpty(tbCantPaquetes.Text) & !string.IsNullOrEmpty(tbCantidadBolsas.Text) & tbCantPaquetes.Text.All(char.IsDigit) & tbCantidadBolsas.Text.All(char.IsDigit) & tbCantPaquetes.Text != "0")
                {
                    var totalBolsas = int.Parse(tbCantidadBolsas.Text) * int.Parse(tbCantPaquetes.Text);
                    tbTotalBolsas.Text = totalBolsas.ToString();

                    calc.porUnPaquete = double.Parse(tbCantidadBolsas.Text) * double.Parse(datosOp[2]);
                    calc.porPaquete = double.Parse(tbCantidadBolsas.Text) * double.Parse(tbCantPaquetes.Text) * double.Parse(datosOp[2]);
                    tbSumPaquetes.Text = calc.porPaquete.ToString();
                }
                else tbSumPaquetes.Text = "";

            }
            else
            {
                if (!string.IsNullOrEmpty(tbCantPaquetes.Text) & tbCantPaquetes.Text.All(char.IsDigit) & tbCantPaquetes.Text != "0")
                {
                    var totalBolsas = int.Parse(tbCantidadBolsas.Text) * int.Parse(tbCantPaquetes.Text);
                    tbTotalBolsas.Text = totalBolsas.ToString();

                    calc.porUnPaquete = double.Parse(tbCantidadBolsas.Text) * double.Parse(datosOp[2]);
                    calc.porPaquete = double.Parse(tbCantidadBolsas.Text) * double.Parse(tbCantPaquetes.Text) * double.Parse(datosOp[2]);
                    tbSumPaquetes.Text = calc.porPaquete.ToString();
                }
                else tbSumPaquetes.Text = "";

            }

        }

        private void tbSumMetros_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSumMetros.Text) && !string.IsNullOrEmpty(tbSumPaquetes.Text))
            {
                if (double.Parse(tbSumMetros.Text) > double.Parse(tbSumPaquetes.Text)) btnEtiquetar.Enabled = true;
            }
        }

        private void tbRegistrarBobina_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si se apreta El boton Enter se ejecuta
            if (e.KeyChar == (char)Keys.Enter)
            {
                var regBobina = tbRegistrarBobina.Text.Replace(" ", string.Empty);
                var sector = regBobina.FirstOrDefault().ToString();
                if (regBobina.Count() > 1 & (sector == "e" | sector == "E" | sector == "i" | sector == "I") & regBobina.Remove(0, 1).All(char.IsDigit))
                {
                    if (datosOp.Count() != 0)
                    {
                        foreach (DataGridViewRow col in dgvBobinasRegistradas.Rows)
                        {
                            if (col.Cells[0].Value.ToString().Equals(tbRegistrarBobina.Text.Remove(0, 1)))
                            {
                                tbRegistrarBobina.Clear();
                                MessageBox.Show("Esta bobina ya esta registrada.", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        int idBob = int.Parse(regBobina.Remove(0, 1));
                        verificarBobina(idBob);
                    }
                    else MessageBox.Show("Debe ingresar OP.", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    tbRegistrarBobina.Clear();
                    MessageBox.Show("Ingrese una bobina valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void ibtnLimpiarRegistroBobina_Click(object sender, EventArgs e)
        {
            tbRegistrarBobina.Clear();
        }

        //KeyPress solo numeros
        private void tbCantPaquetes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void ibtnCantPaquetesLimpiar_Click(object sender, EventArgs e)
        {
            tbCantPaquetes.Clear();
        }

        private void ibtnCantidadBolsasLimpiar_Click(object sender, EventArgs e)
        {
            if (ibtnHabilitarCantBosas.IconChar == IconChar.ToggleOff)
            {
                MessageBox.Show("No se puede limpiar el valor establecido.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            }
            else tbCantidadBolsas.Clear();
        }

        private void tbCantidadBolsas_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = tbCantidadBolsas.SelectionStart;

            string nuevoTexto = new string(tbCantidadBolsas.Text.Where(char.IsDigit).ToArray());

            if (tbCantidadBolsas.Text != nuevoTexto)
            {
                tbCantidadBolsas.Text = nuevoTexto;
                tbCantidadBolsas.SelectionStart = cursorPosition - 1;
            }

            //if (!string.IsNullOrEmpty(tbCantidadBolsas.Text) & !string.IsNullOrEmpty(tbCantPaquetes.Text) & tbCantidadBolsas.Text.All(char.IsDigit) & tbCantPaquetes.Text.All(char.IsDigit))
            //{
            //    calcularMts(int.Parse(tbCantidadBolsas.Text));
            //    calc.porUnPaquete = double.Parse(tbCantidadBolsas.Text) * double.Parse(datosOp[2]);
            //    var totalBolsas = int.Parse(tbCantidadBolsas.Text) * int.Parse(tbCantPaquetes.Text);
            //    tbTotalBolsas.Text = totalBolsas.ToString();
            //}
            //else tbSumPaquetes.Text = "";
        }

        private void calcularMts(int numero)
        {
            if (datosOp.Count > 0)
            {
                var calculo = numero * double.Parse(datosOp[2]) * double.Parse(tbCantPaquetes.Text);
                tbSumPaquetes.Text = calculo.ToString();
            }
        }

        private void tbSumPaquetes_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCantPaquetes.Text)|| tbCantPaquetes.Text=="0")
            {
                btnEtiquetar.Enabled = false;
                return;
            }

            if (!string.IsNullOrEmpty(tbSumMetros.Text) && !string.IsNullOrEmpty(tbSumPaquetes.Text))
            {
                if (double.Parse(tbSumMetros.Text) > double.Parse(tbSumPaquetes.Text)) btnEtiquetar.Enabled = true;
                else btnEtiquetar.Enabled = false;
            }
        }

        private void btnEtiquetar_Click(object sender, EventArgs e)
        {           
            if (calc.porUnPaquete == 0) calc.porUnPaquete = double.Parse(tbCantidadBolsas.Text) * double.Parse(datosOp[2]);
            bolsasConfeccionadas = 0;
            var numBulto = mySqlConexion.buscarUltimoBulto(int.Parse(datosOp[11]));
            var desde = numBulto;
            string sqlActualizarMtsRemanentesP1 = "";
            string sqlActualizarMtsRemanentesP2 = "where indice in (";
            string sqlAgregarBultos = "insert into bultos(Id_Orden, Num_Bulto, Creado, Legajo, Cant_Bolsas, IdOrigen1, SectorOrigen) values ";
            calc.mtsRestantes = 0.0;
            if (string.IsNullOrEmpty(tbOperario.Text))
            {
                tbOperario.Focus();

                MessageBox.Show("Debe ingresar un operario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(tbCantidadBolsas.Text))
            {
                MessageBox.Show("Debe ingresar cantidad de bolsas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (bobinaSector == "i" | bobinaSector == "I")
            {
                sqlActualizarMtsRemanentesP1 = "update impresionesproductoterminado set metrosremanentes = (case";
            }

            if (bobinaSector == "e" | bobinaSector == "E")
            {
                sqlActualizarMtsRemanentesP1 = "update extrusiones set metrosremanentes = (case";
                
            }

            var bolsas = tbCantidadBolsas.Enabled != true ? datosOp[12] : tbCantidadBolsas.Text;
            string operarios;
            do
            {
                operarios = tbOperario.Text;
                if (!string.IsNullOrEmpty(tbAuxiliar01.Text) & !string.IsNullOrEmpty(tbAuxiliar02.Text))
                {
                    operarios = operarios + "-" + tbAuxiliar01.Text + "-" + tbAuxiliar02.Text;
                    break;
                }
                if (!string.IsNullOrEmpty(tbAuxiliar01.Text))
                {
                    operarios = operarios + "-" + tbAuxiliar01.Text;
                    break;
                }
                if (!string.IsNullOrEmpty(tbAuxiliar02.Text))
                {
                    operarios = operarios + "-" + tbAuxiliar02.Text;
                    break;
                }
                break;
            } while (true);
            var contador = 0;
            var oper = "'" + operarios + "'";
            var total = 0.0;
            var totalRestar = double.Parse(tbSumPaquetes.Text);
            foreach (DataGridViewRow row in dgvBobinasRegistradas.Rows)
            {           
                totalRestar = totalRestar - double.Parse(row.Cells[mtsDisponibles].Value.ToString());
                double restaTotal = double.Parse(row.Cells[mtsDisponibles].Value.ToString());

                if (calc.mtsRestantes != 0) restaTotal = restaTotal + calc.mtsRestantes;
                if (calc.mtsRestantes == 0 && double.Parse(row.Cells[mtsDisponibles].Value.ToString()) < calc.porUnPaquete) calc.mtsRestantes = double.Parse(row.Cells[mtsDisponibles].Value.ToString());
                while (restaTotal >= calc.porUnPaquete)
                {                
                    if (contador == int.Parse(tbCantPaquetes.Text)) break;
                    if (total == double.Parse(tbSumPaquetes.Text)) break;
                    restaTotal = restaTotal - calc.porUnPaquete;
                    calc.mtsRestantes = restaTotal;
                    total = total + calc.porUnPaquete;
                    sqlAgregarBultos = sqlAgregarBultos + "(" + datosOp[11] + "," + numBulto + ",current_timestamp," + oper + "," + bolsas + "," + row.Cells[identificador].Value.ToString() + "," + "'" + bobinaSector + "'" + "),";
                    bolsasConfeccionadas = bolsasConfeccionadas + int.Parse(bolsas);
                    numBulto++;
                    contador++;
                }

                sqlActualizarMtsRemanentesP2 = sqlActualizarMtsRemanentesP2 + row.Cells[identificador].Value.ToString() + ",";

                if (totalRestar > 0)
                {
                    row.Cells[mtsDisponibles].Value = 0;
                    sqlActualizarMtsRemanentesP1 = sqlActualizarMtsRemanentesP1 + " when indice = " + row.Cells[identificador].Value.ToString() + " then " + "0 ";
                }
                else
                {
                    row.Cells[mtsDisponibles].Value = Math.Abs(totalRestar);
                    sqlActualizarMtsRemanentesP1 = sqlActualizarMtsRemanentesP1 + " when indice = " + row.Cells[identificador].Value.ToString() + " then " + row.Cells[mtsDisponibles].Value.ToString().Replace(",", ".") + " ";
                    if (total == double.Parse(tbSumPaquetes.Text)) break;
                }
            }

            sqlActualizarMtsRemanentesP1 = sqlActualizarMtsRemanentesP1 + "end) ";
            sqlActualizarMtsRemanentesP2 = sqlActualizarMtsRemanentesP2.TrimEnd(',') + ");";
            sqlAgregarBultos = sqlAgregarBultos.TrimEnd(',') + ";";
            sqlActualizarMtsRemanentesP1 = sqlActualizarMtsRemanentesP1 + sqlActualizarMtsRemanentesP2;

            //Update bobinas involucradas en el dgv
            if (mySqlConexion.sqlSimpleQuery(sqlActualizarMtsRemanentesP1, sqlAgregarBultos))
            {
                List<string> datosPlanificacion = new List<string>();
                datosPlanificacion.Add(datosOp[orden]);
                datosPlanificacion.Add(datosOp[codigo]);
                datosPlanificacion.Add(datosOp[0]);//Cliente
                datosPlanificacion.Add(datosOp[1]);//Ancho
                datosPlanificacion.Add(datosOp[3]);//Espesor
                var lar = tbLargoBolsa.Text.Replace("cm","");
                datosPlanificacion.Add(lar);//Largo
                datosPlanificacion.Add(bolsasConfeccionadas.ToString());//CantidadBolsas
                datosPlanificacion.Add(gbOperario.Text);//Operario
                datosPlanificacion.Add(gbAuxiliar01.Text != "Auxiliar" ? gbAuxiliar01.Text : "No Hay, Auxiliar");//Legajo01
                datosPlanificacion.Add(gbAuxiliar02.Text != "Auxiliar" ? gbAuxiliar02.Text : "No Hay, Auxiliar");//Legajo02
                datosPlanificacion.Add(encargadoNomApe != "" ? encargadoNomApe : "Sin Encargado");//Encargado
                datosPlanificacion.Add(tbSumPaquetes.Text);//Metros
                datosPlanificacion.Add(datosOp[6]);//Maquina
                datosPlanificacion.Add(datosOp[10]);//FechaEntrega

                dgvBobinasRegistradas.Rows.Clear();
                tbSumMetros.Text = "0";
                sumatoriaMtsBobinas = 0;
                bobinasOp = mySqlConexion.buscarBobinas(datosOp[orden], datosOp[codigo], bobinaSector);
                tbCantPaquetes.Text = "0";            

                if (mySqlConexion.modificarCantidadConfeccionada(datosPlanificacion) != -1) {
                    tbBolsasSolicitadas.Text = datosOp[7] + "|" + mySqlConexion.totalBolsasCreadas(datosOp[11]);
                }

                crearArchivoZpl(desde, numBulto);
            }
            else
            {
                MessageBox.Show("Error, al actualizar bobinas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void crearArchivoZpl(int desde, int hasta)
        {
            List<string> numeroBultos = new List<string>();
            FileStream str = new FileStream(@"D:\ZplEtiquetado\ZPLArchivo.ejf", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(str);
            var bultosCreados = mySqlConexion.reEtiquetarBultos(desde, hasta, datosOp[11]);
            var cliente = datosOp[0];
            var ancho = datosOp[1];
            var largo = double.Parse(datosOp[2]) * 100;
            var contadorImpresiones = 0;
            //var espesor = datosOp[3];
            if (datosOp[0] == "ALGODONERA ACONCAGUA S. A.") contadorImpresiones = 2;
            else contadorImpresiones = 1;

            for (int i = 0; i < contadorImpresiones; i++)
            {
                foreach (Bulto bultoImprimir in bultosCreados)
                {
                    numeroBultos.Add(bultoImprimir.numBulto.ToString());
                    writer.WriteLine("^XA");
                    writer.WriteLine("^CI28");
                    writer.WriteLine("^FO10,5^GFA,315,315,7,,:N082,N081,N0418,N060C,N070E,M08706,M08307,M08387,M0C3878,L01C3878,L01C3C3C,:L0387C3C,L0387C3E,L0787C3E,L0F8FC7E,K01F0F87E,K03E1F87E,00600FE1F87E,003IF83F8FE,001IF07F0FE,1003FC0FF0FE,0CJ01FE1FE,0EJ07FE1FE,078001FFC3FC,03F007FF87FC,01LF07FC,40KFE0FF8,203JFC1FF8,301JF03FF8,1803FF807FF,1EK01FFE,0F8J07FFE,07EI01IFC,07FC00JF8,03NF,00MFE,007LFC,003LF,I0KFE,I03JF8,J07FFC,,^FS");
                    writer.WriteLine("^FO65,15^A0,30^FH_^FD" + cliente + "^FS");
                    writer.WriteLine("^FO65,68^A0,30^FH_^FDLargo:" + largo + "^FS");
                    writer.WriteLine("^FO250,68^A0,30^FH_^FDAncho:" + ancho + "^FS");
                    writer.WriteLine("^FO435,68^A0,30^FH_^FDLeg:" + bultoImprimir.legajo + "^FS");
                    writer.WriteLine("^FO65,105^A0,30^FH_^FDBulto:" + bultoImprimir.numBulto + "^FS");
                    writer.WriteLine("^FO250,105^A0,30^FH_^FDBolsas:" + bultoImprimir.cantBolsas + "^FS");
                    writer.WriteLine("^FO0,54");
                    writer.WriteLine("^GB712,5,3^FS");
                    writer.WriteLine("^FO711,0");
                    writer.WriteLine("^GB5,240,3^FS");
                    writer.WriteLine("^FWR");
                    writer.WriteLine("^FO750,20^A0,30^FDSANLUFILM S.A.^FS");
                    writer.WriteLine("^FO726,40^A0,20^FDIndustria Argentina^FS");
                    writer.WriteLine("^FO680,85^A0,25^FD" + DateTime.Now.ToString("dd/MM/yyyy") + "^FS");

                    if (datosOp[16] == "0") writer.WriteLine("^FO10,70^A0,25^FD ^FS");
                    else
                    {
                        writer.WriteLine("^FO35,65^A0,20^FDArt.Cliente^FS");
                        writer.WriteLine("^FO3,65^A0,30^FD" + datosOp[16] + "^FS");
                    }
                    writer.WriteLine("^FWN");
                    if (datosOp[17] == "2")
                    {
                        writer.WriteLine("^FO330,145^A0,30^FD" + "O " + datosOp[8] + "^FS");
                        writer.WriteLine("^FO460,145^A0,30^FD" + "P " + datosOp[9] + "^FS");
                        writer.WriteLine("^FO330,185^A0,30^FDProducto de EXPORTACION^FS");
                    }
                    else
                    {
                        writer.WriteLine("^FO435,145^A0,30^FD" + "O " + datosOp[8] + "^FS");
                        writer.WriteLine("^FO435,185^A0,30^FD" + "P " + datosOp[9] + "^FS");
                    }
                    writer.WriteLine("^FO65,143^BCN,70,Y,N,N,N^FD" + "P" + bultoImprimir.idBulto + "^FS");
                    writer.WriteLine("^XZ");
                }
            }
            writer.Close();
            ejecutarZPLBAT(numeroBultos);
        }

        public void Alerta(string msg, int intervalo)
        {
            formAlertaReEtiquetado frm = new formAlertaReEtiquetado();
            frm.showAlert(msg, intervalo);
        }

        private void ejecutarZPLBAT(List<string> numeroBultos)
        {
            var contador = 1;
            if (numeroBultos.Count != 0)
            {             
                Process proc = new Process();
                try
                {
                    string batDir = string.Format(@"D:\ZplEtiquetado");
                    proc.StartInfo.WorkingDirectory = batDir;
                    if (etiquetadoraSeleccionada == "0")
                    {
                        proc.StartInfo.FileName = "ZplEjecutableSECTORCONFECCION.bat";
                    }
                    if (etiquetadoraSeleccionada == "1")
                    {
                        proc.StartInfo.FileName = "ZplEjecutableMaquina10.bat";
                    }
                    if (etiquetadoraSeleccionada == "2")
                    {
                        proc.StartInfo.FileName = "ZplEjecutableMaquina11.bat";
                    }
                    if (etiquetadoraSeleccionada == "3")
                    {
                        proc.StartInfo.FileName = "ZplEjecutableMaquina12.bat";
                    }
                    if (etiquetadoraSeleccionada == "4")
                    {
                        proc.StartInfo.FileName = "ZplEjecutableMaquina49.bat";
                    }
                    proc.Start();
                    proc.WaitForExit();
                    foreach (string numBulto in numeroBultos)
                    {
                        Alerta("Bulto N° " + numBulto + " impreso", contador);
                        contador = contador + 1000;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al sacar etiquetas, reimprima");
                    Console.WriteLine(ex.StackTrace.ToString());
                }
            }
        }

        private void ibtnHabilitarCantBosas_Click(object sender, EventArgs e)
        {
            if (ibtnHabilitarCantBosas.IconChar == IconChar.ToggleOff)
            {
                tbCantidadBolsas.Enabled = true;
                ibtnHabilitarCantBosas.IconChar = IconChar.ToggleOn;
                tbCantidadBolsas.Text = "";
                tbSumPaquetes.Text = "";
            }
            else
            {
                tbCantidadBolsas.Enabled = false;
                ibtnHabilitarCantBosas.IconChar = IconChar.ToggleOff;
                tbCantidadBolsas.Text = datosOp[12];
                btnEtiquetar.Enabled = false;

            }
            if (string.IsNullOrEmpty(tbCantPaquetes.Text))
            {
                tbCantPaquetes.Focus();
            }
            else if (string.IsNullOrEmpty(tbCantidadBolsas.Text))
            {
                tbCantidadBolsas.Focus();
            }
        }


        private void dgvBobinasRegistradas_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSumMetros.Text))
            {
                sumatoriaMtsBobinas = sumatoriaMtsBobinas - int.Parse(e.Row.Cells[mtsDisponibles].Value.ToString());
                tbSumMetros.Text = sumatoriaMtsBobinas.ToString();
            }
        }

        private void ibtnManualBobinado_Click(object sender, EventArgs e)
        {
            try
            {
                manualDeUsuarioBobinado manualUsuarioBob = new manualDeUsuarioBobinado();

                manualUsuarioBob.ShowDialog();

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private void dgvBobinasRegistradas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 & e.RowIndex != -1)
            {
                try
                {
                    var mtsACambiar = double.Parse(dgvBobinasRegistradas.CurrentRow.Cells[mtsDisponibles].Value.ToString());
                    formCambiarValor.mtsNuevoValor = 0;
                    formCambiarValor.ShowDialog();
                    if (formCambiarValor.mtsNuevoValor != 0)
                    {
                        dgvBobinasRegistradas.CurrentRow.Cells[mtsOriginales].Value = formCambiarValor.mtsNuevoValor;
                        dgvBobinasRegistradas.CurrentRow.Cells[mtsDisponibles].Value = formCambiarValor.mtsNuevoValor;
                        var renovarCeldaMts = double.Parse(tbSumMetros.Text) - mtsACambiar;
                        sumatoriaMtsBobinas += -mtsACambiar;
                        renovarCeldaMts = renovarCeldaMts + formCambiarValor.mtsNuevoValor;
                        tbSumMetros.Text = renovarCeldaMts.ToString();
                        sumatoriaMtsBobinas += renovarCeldaMts;
                    }


                }
                catch (Exception)
                {

                    MessageBox.Show("Error");
                }

            }

        }

        private void dgvBobinasRegistradas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (formCambiarValor.mtsNuevoValor != 0)
                {
                    var idBobina = dgvBobinasRegistradas.SelectedRows[0].Cells[identificador].Value.ToString();
                    var mtsAsignados = formCambiarValor.mtsNuevoValor;
                    var legajo = formCambiarValor.nomApeVerificarCambiarValor;
                    if (mySqlConexion.modificarBobina(idBobina, mtsAsignados.ToString(), legajo, bobinaSector) != -1)
                    {
                        var bobinaModificada = bobinasOp.FirstOrDefault(bob => bob.indice == int.Parse(idBobina));
                        bobinasOp.Remove(bobinaModificada);
                        bobinaModificada.longitudRollo = mtsAsignados;
                        bobinaModificada.mtsRemanentesRollo = mtsAsignados;
                        bobinasOp.Add(bobinaModificada);
                    }
                    else MessageBox.Show("Error");

                }
            }
        }

        private void btnReEtiquetar_Click(object sender, EventArgs e)
        {
            try
            {
                formReEtiquetar reEtiquetar = new formReEtiquetar();
                reEtiquetar.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error al re etiquetar" + exc);
            }
        }

        private void btnIp_Click(object sender, EventArgs e)
        {
            try
            {
                formIp verificarIp = new formIp();
                verificarIp.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void tbOperario_TextChanged(object sender, EventArgs e)
        {
            var componente = (TextBox)sender;
            switch (componente.Name)
            {
                case "tbOperario":
                    if (!tbOperario.Text.All(char.IsDigit))
                    {
                        tbOperario.Clear();
                        MessageBox.Show("Expresar legajo solo en números.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;

                case "tbAuxiliar01":
                    if (!tbAuxiliar01.Text.All(char.IsDigit))
                    {
                        tbAuxiliar01.Clear();
                        MessageBox.Show("Expresar legajo solo en números.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case "tbAuxiliar02":
                    if (!tbAuxiliar02.Text.All(char.IsDigit))
                    {
                        tbAuxiliar02.Clear();
                        MessageBox.Show("Expresar legajo solo en números.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
            }
        }

        private void formPrincipal_Activated(object sender, EventArgs e)
        {           
            lblOp.Select();
        }

        private void dgvBobinasRegistradas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button != MouseButtons.Right) return;
                dgvBobinasRegistradas.ClearSelection();
                dgvBobinasRegistradas.Rows[e.RowIndex].Selected = true;
                cmsDgvBobinas.Show(MousePosition);
            }
        }

        private void itemEditar_Click(object sender, EventArgs e)
        {
            if (dgvBobinasRegistradas.SelectedRows.Count == 1)
            {
                try
                {
                    var mtsACambiar = double.Parse(dgvBobinasRegistradas.SelectedRows[0].Cells[mtsDisponibles].Value.ToString());
                    formCambiarValor.mtsNuevoValor = 0;
                    formCambiarValor.ShowDialog();
                    if (formCambiarValor.mtsNuevoValor != 0)
                    {
                        dgvBobinasRegistradas.SelectedRows[0].Cells[mtsOriginales].Value = formCambiarValor.mtsNuevoValor;
                        dgvBobinasRegistradas.SelectedRows[0].Cells[mtsDisponibles].Value = formCambiarValor.mtsNuevoValor;
                        var renovarCeldaMts = double.Parse(tbSumMetros.Text) - mtsACambiar;
                        sumatoriaMtsBobinas += -mtsACambiar;
                        renovarCeldaMts = renovarCeldaMts + formCambiarValor.mtsNuevoValor;
                        tbSumMetros.Text = renovarCeldaMts.ToString();
                        sumatoriaMtsBobinas += renovarCeldaMts;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }          
        }

        private void itemQuitar_Click(object sender, EventArgs e)
        {
            if (dgvBobinasRegistradas.SelectedRows.Count == 1)
            {
                try
                {
                    if (!string.IsNullOrEmpty(tbSumMetros.Text))
                    {                
                        sumatoriaMtsBobinas = sumatoriaMtsBobinas - int.Parse(dgvBobinasRegistradas.SelectedRows[0].Cells[mtsDisponibles].Value.ToString());
                        tbSumMetros.Text = sumatoriaMtsBobinas.ToString();            
                        dgvBobinasRegistradas.Rows.RemoveAt(dgvBobinasRegistradas.SelectedRows[0].Index);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
        }

        private void ibtnSeleccionarEti_Click(object sender, EventArgs e)
        {
            formSeleccionarEtiquetadora seleccionar = new formSeleccionarEtiquetadora();
            seleccionar.Show();
        }

        private void ibtnCambiarEncargado_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarFason_Click(object sender, EventArgs e)
        {
            fasonCantidad = "0";
            formGenerarFason formFason = new formGenerarFason();
            formFason.ShowDialog();
            if (fasonCantidad != "0") tbBolsasSolicitadas.Text = fasonCantidad;
        }
    }
}
