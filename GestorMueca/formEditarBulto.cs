using EtiquetadoBultos.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtiquetadoBultos
{
    public partial class formEditarBulto : MaterialForm
    {
        string cantBolsasOriginal;
        ConexionMySql mySqlConexion = new ConexionMySql();

        public formEditarBulto()
        {
            InitializeComponent();
            if (formIp.instancia.columnaSelecionadaEditar.Count != 0)
            {
                cantBolsasOriginal = formIp.instancia.columnaSelecionadaEditar[2];
                tbNumBulto.Text = formIp.instancia.columnaSelecionadaEditar[0];
                tbSector.Text = formIp.instancia.columnaSelecionadaEditar[1];
                tbCantBolsas.Text = formIp.instancia.columnaSelecionadaEditar[2];
               
            }
           
        }

        private void btnSalirReEtiquetado_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditarBulto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCantBolsas.Text))
            {
                MessageBox.Show("Debe ingresar cantidad de bolsas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCantBolsas.Focus();
                return;
            }
            string operarios;
            var ope = formPrincipal.instancia.operadores[1];
            var aux1 = formPrincipal.instancia.operadores[2];
            var aux2 = formPrincipal.instancia.operadores[3];
            do
            {
                operarios = ope;
                if (aux1 != "0" & aux2 != "0")
                {
                    operarios = operarios + "-" + aux1 + "-" + aux2;
                    break;
                }
                if (aux1 != "0")
                {
                    operarios = operarios + "-" + aux1;
                    break;
                }
                if (aux2 != "0")
                {
                    operarios = operarios + "-" + aux2;
                    break;
                }
                break;
            } while (true);

            var idBulto = formIp.instancia.columnaSelecionadaEditar[3];
            var deBolsasAMts = 0.0;
            var sql01 = $"update bultos b set b.cant_bolsas = '{tbCantBolsas.Text}', b.observacion = '{operarios}'" +
                $" where b.id = '{idBulto}';";

            string sql02 = "";
            var idBobina = formIp.instancia.columnaSelecionadaEditar[4];
            var sector = formPrincipal.instancia.bobinaSector;
            if (sector == "i" | sector == "I")
            {
                sql02 = $"update impresionesproductoterminado ipt set ipt.metrosremanentes = ipt.metrosremanentes + '{Math.Round(deBolsasAMts)}', ipt.observaciones ='{operarios}'" +
                        $" where ipt.indice = '{idBobina}';";
            }
            if (sector == "e" | sector == "E")
            {
                sql02 = $"update extrusiones e set e.metrosremanentes = e.metrosremanentes + '{Math.Round(deBolsasAMts)}', e.observaciones ='{operarios}'" +
                        $" where e.indice = '{idBobina}';";
            }
            deBolsasAMts = (double.Parse(formIp.instancia.columnaSelecionadaEditar[2]) - double.Parse(tbCantBolsas.Text)) * double.Parse(formPrincipal.instancia.datosOp[2]);
            

            if (mySqlConexion.sqlSimpleQuery(sql01, sql02))
            {
                formIp.instancia.cantEditada = int.Parse(tbCantBolsas.Text);
                var bobModificada = formPrincipal.instancia.bobinasOp.FirstOrDefault(bob => bob.indice == int.Parse(idBobina));
                if (bobModificada != null) {
                    formPrincipal.instancia.bobinasOp.FirstOrDefault(bob => bob.indice == int.Parse(idBobina)).mtsRemanentesRollo += (int)deBolsasAMts;
                    (formPrincipal.instancia.Controls.Find("tbBolsasSolicitadas", true).FirstOrDefault() as TextBox).Text = formPrincipal.instancia.datosOp[7] + "|" + mySqlConexion.totalBolsasCreadas(formPrincipal.instancia.datosOp[11]); ;

                }
                Close();
                crearArchivoZpl(operarios);
            }
        }

        private void crearArchivoZpl(string operadores)
        {
            var idBulto = formIp.instancia.columnaSelecionadaEditar[3];
            FileStream str = new FileStream(@"D:\ZplEtiquetado\ZPLArchivo.ejf", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(str);
            var cliente = formPrincipal.instancia.datosOp[0];
            var ancho = formPrincipal.instancia.datosOp[1];
            var largo = double.Parse(formPrincipal.instancia.datosOp[2]) * 100;
            //var espesor = datosOp[3];
            writer.WriteLine("^XA");
            writer.WriteLine("^CI28");      
            writer.WriteLine("^FO10,5^GFA,315,315,7,,:N082,N081,N0418,N060C,N070E,M08706,M08307,M08387,M0C3878,L01C3878,L01C3C3C,:L0387C3C,L0387C3E,L0787C3E,L0F8FC7E,K01F0F87E,K03E1F87E,00600FE1F87E,003IF83F8FE,001IF07F0FE,1003FC0FF0FE,0CJ01FE1FE,0EJ07FE1FE,078001FFC3FC,03F007FF87FC,01LF07FC,40KFE0FF8,203JFC1FF8,301JF03FF8,1803FF807FF,1EK01FFE,0F8J07FFE,07EI01IFC,07FC00JF8,03NF,00MFE,007LFC,003LF,I0KFE,I03JF8,J07FFC,,^FS");
            writer.WriteLine("^FO65,15^A0,30^FH_^FD" + cliente + "^FS");
            writer.WriteLine("^FO65,68^A0,30^FH_^FDLargo:" + largo + "^FS");
            writer.WriteLine("^FO250,68^A0,30^FH_^FDAncho:" + ancho + "^FS");
            writer.WriteLine("^FO435,68^A0,30^FH_^FDLeg:" + operadores + "^FS");
            writer.WriteLine("^FO65,105^A0,30^FH_^FDBulto:" + tbNumBulto.Text + "^FS");
            writer.WriteLine("^FO250,105^A0,30^FH_^FDBolsas:" + tbCantBolsas.Text + "^FS");
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

            writer.WriteLine("^FO65,143^BCN,70,Y,N,N,N^FD" + "P" + idBulto + "^FS");
            writer.WriteLine("^XZ");
            writer.Close();
            ejecutarZPLBAT();
        }
        public void Alerta(string msg, int intervalo)
        {
            formAlertaReEtiquetado frm = new formAlertaReEtiquetado();
            frm.showAlert(msg, intervalo);
        }
        private void ejecutarZPLBAT()
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
                Alerta("Bulto N° " + tbNumBulto.Text + " impreso", 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al sacar etiquetas, reimprima");
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }
        private void tbCantBolsas_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCantBolsas.Text))
            {
                if (tbCantBolsas.Text == "0") tbCantBolsas.Text = "1";
                if (int.Parse(tbCantBolsas.Text) > int.Parse(cantBolsasOriginal))
                {
                    MessageBox.Show("El valor ingresado debe ser menor al original.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbCantBolsas.Text = int.Parse(cantBolsasOriginal) + "";
                    tbCantBolsas.Focus();
                }
            }
        }
    }
}
