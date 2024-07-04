using EtiquetadoBultos.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetadoBultos
{

    public class Utils
    {
        public static string cliente = formPrincipal.instancia.datosOp[0];
        public static string ancho = formPrincipal.instancia.datosOp[1];
        public static string largo = formPrincipal.instancia.datosOp[2];
        public static string espesor = formPrincipal.instancia.datosOp[3];
        public static string idOrden = formPrincipal.instancia.datosOp[11];
        public static string artCliente = formPrincipal.instancia.datosOp[16];
        public static string bolsasPedidas = formPrincipal.instancia.datosOp[7];
        public static string orden = formPrincipal.instancia.datosOp[8];
        public static string codigo = formPrincipal.instancia.datosOp[9];
        public static string tipo = formPrincipal.instancia.datosOp[17];
        public static string maquina = formPrincipal.instancia.maquinaSeleccionada;
        public static string fechaEntrega = formPrincipal.instancia.datosOp[10];
        public static ConexionMySql mySqlConexion = new ConexionMySql();
        public static void crearArchivoZpl(int desde, int hasta)
        {
            List<string> numeroBultos = new List<string>();
            FileStream str = new FileStream(@"D:\ZplEtiquetado\ZPLArchivo.ejf", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(str);
            var bultosCreados = mySqlConexion.reEtiquetarBultos(desde, hasta, idOrden);
            var largoCm = double.Parse(largo) * 100;
            //var espesor = datosOp[3];

            foreach (Bulto bultoImprimir in bultosCreados)
            {
                numeroBultos.Add(bultoImprimir.numBulto.ToString());
                writer.WriteLine("^XA");
                writer.WriteLine("^CI28");
                writer.WriteLine("^FO10,5^GFA,315,315,7,,:N082,N081,N0418,N060C,N070E,M08706,M08307,M08387,M0C3878,L01C3878,L01C3C3C,:L0387C3C,L0387C3E,L0787C3E,L0F8FC7E,K01F0F87E,K03E1F87E,00600FE1F87E,003IF83F8FE,001IF07F0FE,1003FC0FF0FE,0CJ01FE1FE,0EJ07FE1FE,078001FFC3FC,03F007FF87FC,01LF07FC,40KFE0FF8,203JFC1FF8,301JF03FF8,1803FF807FF,1EK01FFE,0F8J07FFE,07EI01IFC,07FC00JF8,03NF,00MFE,007LFC,003LF,I0KFE,I03JF8,J07FFC,,^FS");
                writer.WriteLine("^FO65,15^A0,30^FH_^FD" + cliente + "^FS");
                writer.WriteLine("^FO65,68^A0,30^FH_^FDLargo:" + largoCm.ToString() + "^FS");
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

                if (artCliente == "0") writer.WriteLine("^FO10,70^A0,25^FD ^FS");
                else
                {
                    writer.WriteLine("^FO35,65^A0,20^FDArt.Cliente^FS");
                    writer.WriteLine("^FO3,65^A0,30^FD" + artCliente + "^FS");
                }
                writer.WriteLine("^FWN");
                if (tipo == "2")
                {
                    writer.WriteLine("^FO330,145^A0,30^FD" + "O " + orden + "^FS");
                    writer.WriteLine("^FO460,145^A0,30^FD" + "P " + codigo + "^FS");
                    writer.WriteLine("^FO330,185^A0,30^FDProducto de EXPORTACION^FS");
                }
                else
                {
                    writer.WriteLine("^FO435,145^A0,30^FD" + "O " + orden + "^FS");
                    writer.WriteLine("^FO435,185^A0,30^FD" + "P " + codigo + "^FS");
                }
                writer.WriteLine("^FO65,143^BCN,70,Y,N,N,N^FD" + "P" + bultoImprimir.idBulto + "^FS");
                writer.WriteLine("^XZ");
            }
            writer.Close();

            ejecutarZPLBAT(numeroBultos);
        }

        public static void ejecutarZPLBAT(List<string> numeroBultos)
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
                    //MessageBox.Show("Error al sacar etiquetas, reimprima");
                    Console.WriteLine(ex.StackTrace.ToString());
                }
            }
        }
        public static void Alerta(string msg, int intervalo)
        {
            formAlertaReEtiquetado frm = new formAlertaReEtiquetado();
            frm.showAlert(msg, intervalo);
        }
    }
}
