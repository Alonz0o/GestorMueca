using EtiquetadoBultos.Models;
using MaterialSkin.Controls;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtiquetadoBultos
{
    public partial class formReEtiquetar : MaterialForm
    {
        ConexionMySql mySqlConexion = new ConexionMySql();
        int desde = 0;
        int hasta = 0;
        public static formReEtiquetar instancia;
        public string nomApeVerificarReEtiquetar;
        IList<Usuario> personal = new List<Usuario>();
        public string mensajeAlerta="";
        
        //Imprimir ZPL
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern SafeFileHandle CreateFile(string lpFileName, FileAccess dwDesiredAccess,
            uint dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition,
            uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        //Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public formReEtiquetar()
        {
            InitializeComponent();
            instancia = this;
            cargarDatosEnTextBox();
            var rangoDeBultos = mySqlConexion.buscarBultosSoloNumero(formPrincipal.instancia.datosOp[11]);
            cbDesdeBobina.DataSource = new BindingSource(rangoDeBultos, null);
            cbHastaBobina.DataSource = new BindingSource(rangoDeBultos, null);          
            verOperariosCargadosEnFormPrincipal();
        }

        private void ibtnSalirReEtiquetado_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalirReEtiquetado_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReEtiquetar_Click(object sender, EventArgs e)
        {
            List<string> numeroBultos = new List<string>();
            if (!string.IsNullOrEmpty(tbOperario.Text))
            {
                var au01 = string.IsNullOrEmpty(tbAuxiliar01.Text) ? "0" : tbAuxiliar01.Text;
                var au02 = string.IsNullOrEmpty(tbAuxiliar02.Text) ? "0" : tbAuxiliar02.Text;
                var operarios = tbOperario.Text + ", " + au01 + " y " + au02;
                mensajeAlerta = "Para poder reetiquetar se necesita la autorización de un encargado o jefe de producción.";
                formAutorizar autorizarForm = new formAutorizar();
                autorizarForm.ShowDialog();
                if (autorizarForm.autenticacion)
                {                  
                    var sqlActualizarBultosP1 = "update bultos set legajo = (case";
                    var sqlActualizarBultosP2 = ", observacion = (case";
                    var sqlActualizarBultosP3 = "where num_bulto in (";

                    var bultosReEtiquetar = mySqlConexion.reEtiquetarBultos(desde, hasta, formPrincipal.instancia.datosOp[11]);
                    foreach (Bulto bulto in bultosReEtiquetar)
                    {
                        bulto.observacion = "Reetiquetado el dia " + DateTime.Now + " autoriza " + autorizarForm.autoriza + " antes: " + bulto.legajo;
                        bulto.legajo = operarios;
                        sqlActualizarBultosP1 = sqlActualizarBultosP1 + " when num_bulto = " + bulto.numBulto + " then '" + bulto.legajo + "'";
                        sqlActualizarBultosP2 = sqlActualizarBultosP2 + " when num_bulto = " + bulto.numBulto + " then '" + bulto.observacion + "'";
                        sqlActualizarBultosP3 = sqlActualizarBultosP3 + bulto.numBulto + ",";
                    }
                    sqlActualizarBultosP1 = sqlActualizarBultosP1 + " end) ";
                    sqlActualizarBultosP2 = sqlActualizarBultosP2 + " end) ";
                    sqlActualizarBultosP3 = sqlActualizarBultosP3.TrimEnd(',') + ")";

                    sqlActualizarBultosP1 = sqlActualizarBultosP1 + sqlActualizarBultosP2;
                    sqlActualizarBultosP1 = sqlActualizarBultosP1 + sqlActualizarBultosP3 + " and id_orden=" + formPrincipal.instancia.datosOp[11] + ";";

                    //Update bultos reetiquetado
                    if (mySqlConexion.sqlSimpleQuery(sqlActualizarBultosP1, ""))
                    {                       
                        FileStream str = new FileStream(@"D:\ZplEtiquetado\ZPLArchivo.ejf", FileMode.Create, FileAccess.Write);
                        StreamWriter writer = new StreamWriter(str);
                        var cliente = formPrincipal.instancia.datosOp[0];
                        var ancho = formPrincipal.instancia.datosOp[1];
                        var largo = double.Parse(formPrincipal.instancia.datosOp[2])*100;
                        //var espesor = formPrincipal.instancia.datosOp[3];
                        
                        foreach (Bulto bultoImprimir in bultosReEtiquetar)
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
                            
                            if (formPrincipal.instancia.datosOp[16] == "0") writer.WriteLine("^FO10,70^A0,25^FD ^FS");
                            else
                            {
                                writer.WriteLine("^FO35,65^A0,20^FDArt.Cliente^FS");
                                writer.WriteLine("^FO3,65^A0,30^FD" + formPrincipal.instancia.datosOp[16] + "^FS");
                            }
                            writer.WriteLine("^FWN");
                            if (formPrincipal.instancia.datosOp[17] == "2")
                            {
                                writer.WriteLine("^FO330,145^A0,30^FD" + "O " + formPrincipal.instancia.datosOp[8] + "^FS");
                                writer.WriteLine("^FO460,145^A0,30^FD" + "P " + formPrincipal.instancia.datosOp[9] + "^FS");
                                writer.WriteLine("^FO330,185^A0,30^FDProducto de EXPORTACION^FS");
                            }
                            else
                            {
                                writer.WriteLine("^FO435,145^A0,30^FD" + "O " + formPrincipal.instancia.datosOp[8] + "^FS");
                                writer.WriteLine("^FO435,185^A0,30^FD" + "P " + formPrincipal.instancia.datosOp[9] + "^FS");
                            }
                            writer.WriteLine("^FO65,143^BCN,70,Y,N,N,N^FD"+"P"+bultoImprimir.idBulto +"^FS");
                            writer.WriteLine("^XZ");                                            
                        }
                        writer.Close();

                        ejecutarZPLBAT(numeroBultos);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Error, al actualizar bultos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                }
                
            }
            else {
                tbOperario.Focus();
                MessageBox.Show("Debe ingresar operario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
                    if (formPrincipal.instancia.etiquetadoraSeleccionada == "0")
                    {
                        proc.StartInfo.FileName = "ZplEjecutableSECTORCONFECCION.bat";
                    }
                    if (formPrincipal.instancia.etiquetadoraSeleccionada == "1")
                    {
                        proc.StartInfo.FileName = "ZplEjecutableMaquina10.bat";
                    }
                    if (formPrincipal.instancia.etiquetadoraSeleccionada == "2")
                    {
                        proc.StartInfo.FileName = "ZplEjecutableMaquina11.bat";
                    }
                    if (formPrincipal.instancia.etiquetadoraSeleccionada == "3")
                    {
                        proc.StartInfo.FileName = "ZplEjecutableMaquina12.bat";
                    }
                    if (formPrincipal.instancia.etiquetadoraSeleccionada == "4")
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

        private void cbDesdeBobina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDesdeBobina.SelectedValue == null || cbHastaBobina.SelectedValue == null) return;
            desde = int.Parse(cbDesdeBobina.SelectedValue.ToString());
            hasta = int.Parse(cbHastaBobina.SelectedValue.ToString());

            if (desde > hasta)
            {
                cbHastaBobina.SelectedIndex = cbDesdeBobina.SelectedIndex;
                return;

            }
        }

        private void cbHastaBobina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDesdeBobina.SelectedValue == null || cbHastaBobina.SelectedValue == null) return;

            desde = int.Parse(cbDesdeBobina.SelectedValue.ToString());
            hasta = int.Parse(cbHastaBobina.SelectedValue.ToString());
            if (desde > hasta)
            {
                cbHastaBobina.SelectedIndex = cbDesdeBobina.SelectedIndex;
                return;
            }
        }

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
            if (!string.IsNullOrEmpty(tbOperario.Text))
            {
                if (e.KeyData == Keys.Enter && tbOperario.Text.All(char.IsDigit))
                {
                    var operario = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbOperario.Text));
                    if (operario != null) tbLblOperario.Text = operario.Nombre + " " + operario.Apellido;
                    else
                    {
                        MessageBox.Show("No existe el legajo " + tbOperario.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbLblOperario.Text = "Operario *";
                        tbOperario.Text = "";
                        tbOperario.Focus();
                    }
                }
            }
        }

        private void tbAuxiliar01_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter & tbAuxiliar01.Text.All(char.IsDigit) & !string.IsNullOrEmpty(tbAuxiliar01.Text))
            {
                var auxiliar = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbAuxiliar01.Text));
                if (auxiliar != null) tbLblAuxiliar01.Text = auxiliar.Nombre + " " + auxiliar.Apellido;
                else
                {
                    MessageBox.Show("No existe el legajo " + tbAuxiliar01.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbLblAuxiliar01.Text = "Auxiliar";
                    tbAuxiliar01.Text = "";
                    tbAuxiliar01.Focus();
                }
            }
        }

        private void tbAuxiliar02_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && tbAuxiliar02.Text.All(char.IsDigit) & !string.IsNullOrEmpty(tbAuxiliar02.Text))
            {
                var auxiliar02 = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbAuxiliar02.Text));
                if (auxiliar02 != null) tbLblAuxiliar02.Text = auxiliar02.Nombre + " " + auxiliar02.Apellido;
                else
                {
                    MessageBox.Show("No existe el legajo " + tbAuxiliar02.Text + " registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbLblAuxiliar02.Text = "Auxiliar";
                    tbAuxiliar02.Text = "";
                    tbAuxiliar02.Focus();
                }
            }
        }

        private void tbOperario_TextChanged(object sender, EventArgs e)
        {           
            if (!tbOperario.Text.All(char.IsDigit))
            {
                MessageBox.Show("Expresar legajo en números.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbOperario.Clear();
                return;
            }
        }

        private void verOperariosCargadosEnFormPrincipal()
        {
            if (formPrincipal.instancia.operadores[1] != "0")
            {
                tbOperario.Text = formPrincipal.instancia.operadores[1];
                var operario = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbOperario.Text));
                tbLblOperario.Text = operario.Nombre + " " + operario.Apellido;
                                              
            }
            if (formPrincipal.instancia.operadores[2] != "0")
            {
                tbAuxiliar01.Text = formPrincipal.instancia.operadores[2];
                var auxiliar = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbAuxiliar01.Text));
                tbLblAuxiliar01.Text = auxiliar.Nombre + " " + auxiliar.Apellido;
                
            }
            if (formPrincipal.instancia.operadores[3] != "0")
            {
                tbAuxiliar02.Text = formPrincipal.instancia.operadores[3];
                var auxiliar = personal.SingleOrDefault(x => x.Legajo == Convert.ToInt32(tbAuxiliar02.Text));
                tbLblAuxiliar02.Text = auxiliar.Nombre + " " + auxiliar.Apellido;
                
            }
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
    }
}
