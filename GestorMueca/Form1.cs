using FontAwesome.Sharp;
using EtiquetadoBultos.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EtiquetadoBultos
{

    public partial class formPrincipal : Form
    {
        //Constantes
        const int identificador = 0;
        const int mtsDisponibles = 4;
        const int mtsOriginales = 2;

        //Variables
        private int borderSize = 3;
        private Size formSize;
        public static formPrincipal instancia;
        ConexionMySql mySqlConexion = new ConexionMySql();
        private double sumatoriaMtsBobinas;
        IList<Usuario> personal = new List<Usuario>();
        public IList<string> datosOp = new List<string>();
        public IList<Bobina> bobinasOp = new List<Bobina>();
        Calculo calc = new Calculo();
        formCambiarValorLongitud formCambiarValor = new formCambiarValorLongitud();

        public formPrincipal()
        {
            InitializeComponent();
            Padding = new Padding(borderSize);//Border size
            BackColor = Color.FromArgb(145, 163, 177);//Border color
            instancia = this;
            cargarDatosEnTextBox();
            dgvBobinasRegistradas.AllowUserToAddRows = false;
            dgvBobinasRegistradas.Columns.Add("cIdentificador", "Identificador");
            dgvBobinasRegistradas.Columns.Add("cNumRollo", "Num Bobina");
            dgvBobinasRegistradas.Columns.Add("cLongRollo", "Mts Originales");
            dgvBobinasRegistradas.Columns.Add("cPesoRollo", "Neto");
            dgvBobinasRegistradas.Columns.Add("cMtsRemanentes", "Mts Disponibles");
        }
        public void cambiarDatos()
        {
            var largoMostrar = double.Parse(datosOp[2]) * 100;
            lblOp.Text = datosOp[8] +" / "+ datosOp[9];
            tbCliente.Text = datosOp[0];
            lblMaquina.Text = datosOp[6];
            lblSoldadura.Text = datosOp[5];
            tbBolsasXPaquete.Text = datosOp[12];
            tbAnchoBolsa.Text = datosOp[1] + "mm";
            tbLargoBolsa.Text = largoMostrar.ToString() + "mm";
            tbEspesorBolsa.Text = datosOp[3] + "µm";
            tbBolsasSolicitadas.Text = datosOp[7];
        }

        //Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlHead_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        //Metodos Override
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            ajustarFormulario();
        }

        //Metodos Privados
        private void ajustarFormulario()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }
        private void ibtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ibtnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                formSize = ClientSize;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                Size = formSize;
            }
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

        private void tbOperario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && tbOperario.Text.All(char.IsDigit))
            {

                var operario = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbOperario.Text));
                if (operario != null)
                {
                    gbOperario.Text = operario.Nombre + " " + operario.Apellido;

                }
                else
                {
                    MessageBox.Show("No existe el legajo " + tbOperario.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gbOperario.Text = "Operario *";
                    tbOperario.Text = "";
                    tbOperario.Focus();
                }
            }
        }

        private void ibtnOperarioOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbOperario.Text))
            {
                var operario = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbOperario.Text));
                if (operario != null)
                {
                    gbOperario.Text = operario.Nombre + " " + operario.Apellido;

                }
                else
                {
                    MessageBox.Show("No existe el legajo " + tbOperario.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gbOperario.Text = "Operario *";
                    tbOperario.Text = "";
                    tbOperario.Focus();
                }
            }
            else {
                gbOperario.Text = "Operario *";
                tbOperario.Text = "";
                tbOperario.Focus();
                MessageBox.Show("Debe ingresar legajo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void ibtnOperarioDetalle_Click(object sender, EventArgs e)
        {

        }

        private void ibtnOperarioLimpiar_Click(object sender, EventArgs e)
        {
            tbOperario.Clear();
            gbOperario.Text = "Operario *";
        }

        private void tbAuxiliar01_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && tbAuxiliar01.Text.All(char.IsDigit))
            {
                var auxiliar = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbAuxiliar01.Text));
                if (auxiliar != null)
                {
                    gbAuxiliar01.Text = auxiliar.Nombre + " " + auxiliar.Apellido;
                }
                else
                {
                    MessageBox.Show("No existe el legajo " + tbAuxiliar01.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gbAuxiliar01.Text = "Auxiliar";
                    tbAuxiliar01.Text = "";
                    tbAuxiliar01.Focus();
                }
            }
        }

        private void ibtnAuxiliar01Ok_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAuxiliar01.Text))
            {
                var auxiliar = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbAuxiliar01.Text));
                if (auxiliar != null)
                {
                    gbAuxiliar01.Text = auxiliar.Nombre + " " + auxiliar.Apellido;
                }
                else
                {
                    MessageBox.Show("No existe el legajo " + tbAuxiliar01.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gbAuxiliar01.Text = "Auxiliar";
                    tbAuxiliar01.Text = "";
                    tbAuxiliar01.Focus();
                }
            }
            else
            {
                gbAuxiliar01.Text = "Auxiliar";
                tbAuxiliar01.Text = "";
                tbAuxiliar01.Focus();
                MessageBox.Show("Debe ingresar legajo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ibtnAuxiliar01Detalle_Click(object sender, EventArgs e)
        {

        }

        private void ibtnAuxiliar01Limpiar_Click(object sender, EventArgs e)
        {
            tbAuxiliar01.Clear();
            gbAuxiliar01.Text = "Auxiliar";
        }

        private void tbAuxiliar02_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && tbAuxiliar02.Text.All(char.IsDigit))
            {

                var auxiliar02 = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbAuxiliar02.Text));
                if (auxiliar02 != null)
                {
                    gbAuxiliar02.Text = auxiliar02.Nombre + " " + auxiliar02.Apellido;
                }
                else
                {
                    MessageBox.Show("No existe el legajo " + tbAuxiliar02.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gbAuxiliar02.Text = "Auxiliar";
                    tbAuxiliar02.Text = "";
                    tbAuxiliar02.Focus();
                }
            }
        }

        private void ibtnAuxiliar02Ok_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAuxiliar02.Text))
            {

                var auxiliar02 = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbAuxiliar02.Text));
                if (auxiliar02 != null)
                {
                    gbAuxiliar02.Text = auxiliar02.Nombre + " " + auxiliar02.Apellido;
                }
                else
                {
                    MessageBox.Show("No existe el legajo " + tbAuxiliar02.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gbAuxiliar02.Text = "Auxiliar";
                    tbAuxiliar02.Text = "";
                    tbAuxiliar02.Focus();
                }
            }
            else
            {
                gbAuxiliar02.Text = "Auxiliar";
                tbAuxiliar02.Text = "";
                tbAuxiliar02.Focus();
                MessageBox.Show("Debe ingresar legajo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ibtnAuxiliar02Detalle_Click(object sender, EventArgs e)
        {

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
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }


        private void verificarBobina(int idBobina)
        {
            if (bobinasOp.FirstOrDefault(bob => bob.indice == idBobina) == null)
            {
                var bobinaBuscar = mySqlConexion.buscarBobina(idBobina.ToString(), datosOp[9]);
                if (bobinaBuscar.indice != 0)
                {
                    bobinasOp.Add(bobinaBuscar);
                }            
            }

            var buscarBob = bobinasOp.FirstOrDefault(bob => bob.indice == idBobina);
            if (buscarBob == null)
            {
                
                MessageBox.Show("No se encontró ninguna bobina con ese identificador.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (buscarBob.mtsRemanentesRollo == 0)
                {
                    MessageBox.Show("Esta bobina no tiene metros disponibles.", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbRegistrarBobina.Text = "";
                }
                else
                {
                    sumatoriaMtsBobinas += buscarBob.mtsRemanentesRollo;
                    dgvBobinasRegistradas.Rows.Add(buscarBob.indice, buscarBob.numRollo, buscarBob.longitudRollo, buscarBob.neto, buscarBob.mtsRemanentesRollo);
                    tbSumMetros.Text = sumatoriaMtsBobinas.ToString();
                    tbRegistrarBobina.Text = "";
                }


            }


        }

        private void tbCantPaquetes_TextChanged(object sender, EventArgs e)
        {

            if (datosOp.Count > 0)
            {
                if (tbCantidadBolsas.Enabled == true)
                {
                    if (!string.IsNullOrEmpty(tbCantPaquetes.Text) && !string.IsNullOrEmpty(tbCantidadBolsas.Text) && tbCantPaquetes.Text.All(char.IsDigit) && tbCantidadBolsas.Text.All(char.IsDigit))
                    {

                        calc.porUnPaquete = double.Parse(tbCantidadBolsas.Text) * double.Parse(datosOp[2]);
                        calc.porPaquete = double.Parse(tbCantidadBolsas.Text) * double.Parse(tbCantPaquetes.Text) * double.Parse(datosOp[2]);
                        tbSumPaquetes.Text = calc.porPaquete.ToString();
                    }
                    else tbSumPaquetes.Text = "";

                }
                else
                {

                    if (!string.IsNullOrEmpty(tbCantPaquetes.Text) && tbCantPaquetes.Text.All(char.IsDigit))
                    {
                        calc.porUnPaquete = double.Parse(datosOp[12]) * double.Parse(datosOp[2]);
                        calc.porPaquete = double.Parse(datosOp[12]) * double.Parse(tbCantPaquetes.Text) * double.Parse(datosOp[2]);
                        tbSumPaquetes.Text = calc.porPaquete.ToString();
                    }
                    else tbSumPaquetes.Text = "";

                }

                
            }

        }

        private void tbSumMetros_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSumMetros.Text) && !string.IsNullOrEmpty(tbSumPaquetes.Text)) {

                if (double.Parse(tbSumMetros.Text) > double.Parse(tbSumPaquetes.Text)) {
                    btnEtiquetar.Enabled = true;

                }
            }
        }

        private void tbRegistrarBobina_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si se apreta El boton Enter se ejecuta esto
            if (e.KeyChar == (char)Keys.Enter)
            {              
                var regBobina = tbRegistrarBobina.Text.Replace(" ", string.Empty);
                var sector = regBobina.FirstOrDefault().ToString();
                if (regBobina.Count() > 1 && (sector == "e" || sector == "E") && regBobina.Remove(0, 1).All(char.IsDigit))
                {
                    if (datosOp.Count() != 0) {                                                        
                    foreach (DataGridViewRow col in dgvBobinasRegistradas.Rows)
                    {
                        if (col.Cells[0].Value.ToString().Equals(tbRegistrarBobina.Text.Remove(0, 1)))
                        {
                            MessageBox.Show("Esta bobina ya esta registrada.", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    int idBob = int.Parse(regBobina.Remove(0, 1));
                    verificarBobina(idBob);
                    }else MessageBox.Show("Debe ingresar OP.", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else {
                    
                    MessageBox.Show("Ingrese una bobina valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } 

            }
        }
     
        private void ibtnLimpiarRegistroBobina_Click(object sender, EventArgs e)
        {
            tbRegistrarBobina.Clear();
        }

        private void tbCantPaquetes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ibtnCantPaquetesLimpiar_Click(object sender, EventArgs e)
        {
            tbCantPaquetes.Clear();
        }

        private void ibtnCantidadBolsasLimpiar_Click(object sender, EventArgs e)
        {
            tbCantidadBolsas.Clear();
        }

        private void tbCantidadBolsas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void tbCantidadBolsas_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCantidadBolsas.Text) && !string.IsNullOrEmpty(tbCantPaquetes.Text) && tbCantidadBolsas.Text.All(char.IsDigit) && tbCantPaquetes.Text.All(char.IsDigit))
            {
                calcularMts(int.Parse(tbCantidadBolsas.Text));
            }
            else tbSumPaquetes.Text = "";
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
            if (!string.IsNullOrEmpty(tbSumMetros.Text) && !string.IsNullOrEmpty(tbSumPaquetes.Text)) {
                if (double.Parse(tbSumMetros.Text) >= double.Parse(tbSumPaquetes.Text))
                {
                    btnEtiquetar.Enabled = true;

                }
                else {
                    btnEtiquetar.Enabled = false;
                }
            }          
        }

        private void btnEtiquetar_Click(object sender, EventArgs e)
        {
            var numBulto = mySqlConexion.buscarUltimoBulto(int.Parse(datosOp[11]));
            var sqlActualizarMtsRemanentesP1 = "update extrusiones set metrosremanentes = (case";
            var sqlActualizarMtsRemanentesP2 = "where Indice in (";
            var sqlAgregarBultos = "insert into bultos(Id_Orden, Num_Bulto, Creado, Legajo, Cant_Bolsas, IdOrigen1, SectorOrigen)" + 
                "values ";
            calc.mtsRestantes = 0.0;
            if(string.IsNullOrEmpty(tbOperario.Text)) {
                tbOperario.Focus();

                MessageBox.Show("Debe ingresar un operario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var au01 = string.IsNullOrEmpty(tbAuxiliar01.Text) ? "0" : tbAuxiliar01.Text;
            var au02 = string.IsNullOrEmpty(tbAuxiliar02.Text) ? "0" : tbAuxiliar02.Text;
            var bolsas = tbCantidadBolsas.Enabled != true ? datosOp[12] : tbCantidadBolsas.Text;

            var total = 0.0;
            var totalRestar = double.Parse(tbSumPaquetes.Text);
            foreach (DataGridViewRow row in dgvBobinasRegistradas.Rows)
            {
                
                totalRestar = totalRestar - double.Parse(row.Cells[4].Value.ToString());
                double restaTotal = double.Parse(row.Cells[4].Value.ToString());
                
                if (calc.mtsRestantes != 0) restaTotal = restaTotal + calc.mtsRestantes;
                if (calc.mtsRestantes == 0 && double.Parse(row.Cells[4].Value.ToString()) < calc.porUnPaquete) calc.mtsRestantes = double.Parse(row.Cells[4].Value.ToString());
                while (restaTotal >= calc.porUnPaquete)
                {
                    var operarios = "'"+tbOperario.Text + ", " + au01 + " y " + au02 + "'";
                    if (total == double.Parse(tbSumPaquetes.Text)) break;
                    restaTotal = restaTotal - calc.porUnPaquete;
                    calc.mtsRestantes = restaTotal;
                    total = total + calc.porUnPaquete;
                    sqlAgregarBultos = sqlAgregarBultos + "("+datosOp[11]+","+numBulto+ ",current_timestamp,"+operarios+","+bolsas+ ","+row.Cells[0].Value.ToString()+",'E'"+"),";
                    numBulto++;
                }

                sqlActualizarMtsRemanentesP2 = sqlActualizarMtsRemanentesP2 + row.Cells[0].Value.ToString() + ",";


                if  (totalRestar > 0){ 
                    row.Cells[4].Value = 0;
                    sqlActualizarMtsRemanentesP1 = sqlActualizarMtsRemanentesP1 + " when Indice = " + row.Cells[0].Value.ToString() + " then " + "0 ";
                } 
                else {                  
                    row.Cells[4].Value = Math.Abs(totalRestar);
                    sqlActualizarMtsRemanentesP1 = sqlActualizarMtsRemanentesP1 + " when Indice = " + row.Cells[0].Value.ToString() + " then " + row.Cells[4].Value.ToString()+ " ";
                    if (total == double.Parse(tbSumPaquetes.Text)) break;
                }
            }
            sqlActualizarMtsRemanentesP1 = sqlActualizarMtsRemanentesP1 + "end) ";
            sqlActualizarMtsRemanentesP2 = sqlActualizarMtsRemanentesP2.TrimEnd(',') + ");";
            sqlAgregarBultos = sqlAgregarBultos.TrimEnd(',') + ";";
            sqlActualizarMtsRemanentesP1 = sqlActualizarMtsRemanentesP1 + sqlActualizarMtsRemanentesP2;

            //Update bobinas involucradas en el dgv
            if (mySqlConexion.sqlSimpleQuery(sqlActualizarMtsRemanentesP1))
            {
                dgvBobinasRegistradas.Rows.Clear();
                tbSumMetros.Text = "0";
                sumatoriaMtsBobinas = 0;
                bobinasOp = mySqlConexion.buscarBobinas(datosOp[8], datosOp[9]);
            }
            else { 
                MessageBox.Show("Error, al actualizar bobinas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //Agregar Bultos true si agrego
            if (mySqlConexion.sqlSimpleQuery(sqlAgregarBultos))
            {
                MessageBox.Show("Bultos agregados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvBobinasRegistradas.Rows.Clear();
                tbSumMetros.Text = "0";
                sumatoriaMtsBobinas = 0;
            }
            else MessageBox.Show("Error, no es posible agregar estos bultos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void tbOperario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void tbAuxiliar01_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void tbAuxiliar02_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void ibtnHabilitarCantBosas_Click(object sender, EventArgs e)
        {
            if (ibtnHabilitarCantBosas.Tag == "off")
            {
                tbCantidadBolsas.Enabled = true;
                ibtnHabilitarCantBosas.Tag = "on";
                ibtnHabilitarCantBosas.IconChar = IconChar.ToggleOn;
                tbSumPaquetes.Text = "";
            }
            else {
                tbCantidadBolsas.Enabled = false;
                ibtnHabilitarCantBosas.Tag = "off";
                ibtnHabilitarCantBosas.IconChar = IconChar.ToggleOff;
                tbCantidadBolsas.Text = "";
                tbSumPaquetes.Text = "";
                tbCantPaquetes.Tag = tbCantPaquetes.Text;
                tbCantPaquetes.Text = "";
                tbCantPaquetes.Text = tbCantPaquetes.Tag.ToString();
                btnEtiquetar.Enabled = false;
      
            }
        }

      
        private void dgvBobinasRegistradas_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSumMetros.Text)) {
                
                sumatoriaMtsBobinas = sumatoriaMtsBobinas - int.Parse(e.Row.Cells[4].Value.ToString());

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
                    if (formCambiarValor.mtsNuevoValor != 0) {
                        dgvBobinasRegistradas.CurrentCell.Value = formCambiarValor.mtsNuevoValor;
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
            if (e.ColumnIndex == 2) {
                if (formCambiarValor.mtsNuevoValor != 0)
                {
                    var idBobina = dgvBobinasRegistradas.CurrentRow.Cells[identificador].Value.ToString();
                    var mtsAsignados = formCambiarValor.mtsNuevoValor;
                    var legajo = formCambiarValor.legajoVerificar;
                    if (mySqlConexion.modificarBobina(idBobina, mtsAsignados.ToString(), legajo) != -1)
                    {
                        MessageBox.Show("Modicicaion correcta");
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
                reEtiquetar.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error al re etiquetar" + exc);
            }
        }
    }
}
