using EtiquetadoBultos.Models;
using MaterialSkin.Controls;
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
    public partial class formMostrarPallets : MaterialForm
    {
        ConexionMySql mySqlConexion = new ConexionMySql();
        DataTable dt = new DataTable("pallets"), dtPalletBultos = new DataTable("bultos");
        bool soloUno;
        IList<NtIp> palletsRegistrados = new List<NtIp>();
        int idPalletSeleccionado = 0;
        NtIp ntIp = null;
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

        public formMostrarPallets()
        {
            InitializeComponent();
            tcPallets.Appearance = TabAppearance.FlatButtons;
            tcPallets.ItemSize = new Size(0, 1);
            tcPallets.SizeMode = TabSizeMode.Fixed;

            //DGVPallet
            dt.Columns.Add(new DataColumn("idpallet", typeof(int)));
            dt.Columns.Add(new DataColumn("idnt", typeof(int)));
            dt.Columns.Add(new DataColumn("N°", typeof(int)));
            dt.Columns.Add(new DataColumn("Detalle", typeof(string)));
            dt.Columns.Add(new DataColumn("Bolsas", typeof(string)));
            dt.Columns.Add(new DataColumn("Peso tarima", typeof(double)));
            dt.Columns.Add(new DataColumn("Neto", typeof(int)));
            dt.Columns.Add(new DataColumn("Creación Pallet", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("seleccionarPallet", typeof(bool)));

            var op = formPrincipal.instancia.datosOp[8] + "/" + formPrincipal.instancia.datosOp[9];
            palletsRegistrados = mySqlConexion.buscarPalletsReImp(op);
            //gbPalletsGen.Text = "Pallets generados de la O/P: " + op;
            foreach (NtIp pallet in palletsRegistrados)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["idpallet"] = pallet.id;
                dataRow["idnt"] = pallet.idNt;
                dataRow["N°"] = pallet.pallets;
                dataRow["Detalle"] = pallet.bobinas;
                dataRow["Bolsas"] = pallet.totalBolsas;
                dataRow["Peso tarima"] = pallet.pesoTarimaVacia;
                dataRow["Neto"] = pallet.neto;
                dataRow["Creación Pallet"] = pallet.fechaCreado;               
                dt.Rows.Add(dataRow);
                
            }

            dgvPalletsRegistrados.DataSource = dt;
            dgvPalletsRegistrados.Columns["seleccionarPallet"].HeaderText = "";
            dgvPalletsRegistrados.Columns["idpallet"].Visible = false;
            dgvPalletsRegistrados.Columns["idnt"].HeaderText = "IP";
            dgvPalletsRegistrados.Columns["N°"].HeaderText = "Pallet N°";
        }

        private void ibtnSalirOp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvPalletsRegistrados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //dgvPalletsRegistrados.Columns["seleccionarPallet"].MinimumWidth = 21;
            //dgvPalletsRegistrados.Columns["seleccionarPallet"].Width = 21;
            //dgvPalletsRegistrados.Columns["N°"].Width = 40;
            //dgvPalletsRegistrados.Columns["idnt"].Width = 60;

        }

        private void dgvPalletsRegistrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                if (soloUno && (bool)dgvPalletsRegistrados["seleccionarPallet", e.RowIndex].FormattedValue == true) { 
                    dgvPalletsRegistrados["seleccionarPallet", e.RowIndex].Value = false;
                    soloUno = false;
                    return;
                }

                if (soloUno) {
                    MessageBox.Show("Solo se puede seleccionar un pallet.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; 
                }
                if (dgvPalletsRegistrados.SelectedCells.Count == 1 && (bool)dgvPalletsRegistrados["seleccionarPallet", e.RowIndex].FormattedValue == true)
                {
                    dgvPalletsRegistrados["seleccionarPallet", e.RowIndex].Value = false;
                    return;
                }
                else
                {
                    soloUno = true;
                    dgvPalletsRegistrados["seleccionarPallet", e.RowIndex].Value = true;
                }
            }
        }

        private void dgvPalletsRegistrados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button != MouseButtons.Right) return;
                dgvPalletsRegistrados.ClearSelection();
                dgvPalletsRegistrados.Rows[e.RowIndex].Selected = true;
                cmsDgvPallets.Show(MousePosition);             
            }
        }

        private void dgvPalletsRegistrados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 8 && e.RowIndex != -1)
            {
                if (soloUno)
                {
                    if ((bool)dgvPalletsRegistrados["seleccionarPallet", e.RowIndex].FormattedValue == true)
                    {
                        idPalletSeleccionado = int.Parse(dgvPalletsRegistrados["idpallet", e.RowIndex].Value.ToString());
                        //lblPallet.Text = "Pallet N°: " + dgvPalletsRegistrados["N°", e.RowIndex].Value.ToString();
                    }
                    else
                    {
                        //lblPallet.Text = "Seleccione pallet";

                    }
                }
            }
        }

        private void btnReImprimir_Click(object sender, EventArgs e)
        {
            if (idPalletSeleccionado != 0)
            {
                ntIp = palletsRegistrados.FirstOrDefault(pal => pal.id == idPalletSeleccionado);
            }
            else
            {
                MessageBox.Show("Seleccione pallet.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ntIp==null) {
                MessageBox.Show("No se encontro ningun pallet.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
                docImprimir.Print();
                docImprimir.Dispose();
                Close();
            }
            
        }

        private void docImprimir_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Primera columna cabecera
            e.Graphics.DrawString(formPrincipal.instancia.datosOp[0], robotoMedium, Brushes.Black, new RectangleF(20, 20, 300, 25));
            e.Graphics.DrawString("IP: " + ntIp.idNt, robotoLight, Brushes.Black, new RectangleF(20, 65, 300, 25));
            e.Graphics.DrawString("O/P: " + ntIp.op, robotoLight, Brushes.Black, new RectangleF(580, 65, 200, 25));

            //Segunda columna cabecera
            //Empresa SANLUFILM S.A.
            e.Graphics.DrawString("SANLUFILM S.A.", robotoMediumMini, Brushes.Black, new RectangleF(580, 20, 180, 15));
            //Fecha realizado
            e.Graphics.DrawString("Impresión realizada el: " + DateTime.Now, robotoMini, Brushes.Black, new RectangleF(580, 30, 250, 15));
            //Duplicado
            e.Graphics.DrawString("|DUPLICADO|" + DateTime.Now, robotoMini, Brushes.Black, new RectangleF(580, 50, 250, 15));


            //Largo/Espesor/Ancho
            e.Graphics.DrawString("Largo: " +ntIp.largo+"cm", robotoLight, Brushes.Black, new RectangleF(20, 100, 180, 25));
            e.Graphics.DrawString("Espesor: " +ntIp.espesor+ "μm", robotoLight, Brushes.Black, new RectangleF(310, 100, 180, 25));
            e.Graphics.DrawString("Ancho: " +ntIp.ancho+"cm", robotoLight, Brushes.Black, new RectangleF(580, 100, 180, 25));

            //Primera Linea
            e.Graphics.DrawLine(lapizNegro3Px, 20, 125, 830, 125);

            //Primera columna
            //Numero pallet
            e.Graphics.DrawString("N° de pallet: " + ntIp.pallets.ToString(), robotoLight, Brushes.Black, new RectangleF(20, 130, 180, 25));
            //Bultos
            e.Graphics.DrawString("Bultos: " + ntIp.cantBobinas, robotoLight, Brushes.Black, new RectangleF(20, 160, 180, 20));
            //Maquina
            e.Graphics.DrawString("Maquina: " + ntIp.maquina, robotoLight, Brushes.Black, new RectangleF(20, 190, 300, 25));
            //Fecha
            e.Graphics.DrawString("Creado el: " + ntIp.fechaCreado.ToString(), robotoLight, Brushes.Black, new RectangleF(20, 220, 300, 25));

            //Segunda columna
            //Peso tarima
            e.Graphics.DrawString("Peso tarima: " + ntIp.pesoTarimaVacia + "Kgs", robotoLight, Brushes.Black, new RectangleF(310, 130, 300, 25));
            //Total bolsas
            e.Graphics.DrawString("Total de bolsas: " + ntIp.totalBolsas.ToString(), robotoLight, Brushes.Black, new RectangleF(310, 160, 300, 25));
            //Peso teorico
            e.Graphics.DrawString("Peso teórico(neto): " + string.Format("{0:0.00}", ntIp.neto) + "Kgs", robotoLight, Brushes.Black, new RectangleF(310, 190, 300, 25));
            //Operarios
            e.Graphics.DrawString("Operario/s: " + ntIp.operario, robotoLight, Brushes.Black, new RectangleF(310, 220, 300, 25));
            //Segunda Linea
            e.Graphics.DrawLine(lapizNegro3Px, 20, 250, 830, 250);

            //Ficha embalaje
            e.Graphics.DrawString("Ficha de embalaje: " + ntIp.embalaje_pDescripcion + " EE:" + ntIp.idEmbalaje, robotoMedium, Brushes.Black, new RectangleF(20, 260, 500, 30));
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            lblEmpresa.Text = "SANLUFILM - Pallets";
            tcPallets.SelectedTab = tcPallets.TabPages["tpPalletDatos"];
        }

        private void dgvBultosQuitar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 & e.ColumnIndex != -1 & e.RowIndex != -1)
            {
                if ((bool)dgvBultosQuitar["quitarBulto", e.RowIndex].FormattedValue == true)
                {
                    dgvBultosQuitar["quitarBulto", e.RowIndex].Value = false;
                    return;
                }
                else dgvBultosQuitar["quitarBulto", e.RowIndex].Value = true;
            }
        }

        private void dgvBultosQuitar_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 & e.ColumnIndex != -1 & e.RowIndex != -1)
            {
                var contador = 0;
                foreach (DataGridViewRow row in dgvBultosQuitar.Rows)
                {
                    if (row.Cells[5].FormattedValue.Equals(false)) contador++;
                }
                if (contador == 0)
                {
                    btnVolver.Visible = true;
                    btnQuitar.Visible = false;                 
                }
                else {
                    btnVolver.Visible = false;
                    btnQuitar.Visible = true;
                }
                
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            List<MinMax> minMax = new List<MinMax>();
            string sqlModificarNT = "update nt set bobinas = ";
            string sqlQuitarBultos1 = "update bultos set idNT = (case";
            string sqlQuitarBultos2 = "where id in (";

            int sumBolsasBolsas = 0;



            var cantBultos = dgvBultosQuitar.Rows.Count;
            foreach (DataGridViewRow row in dgvBultosQuitar.Rows)
            {

                if (row.Cells[5].FormattedValue.Equals(true))
                {
                    sumBolsasBolsas += int.Parse(row.Cells[2].Value.ToString());

                    MinMax numBulto = new MinMax();
                    numBulto.numero = int.Parse(row.Cells[1].Value.ToString());
                    
                    numBulto.indice = int.Parse(row.Cells[0].Value.ToString().Remove(0, 1));
                    numBulto.cantPorPaquete = int.Parse(row.Cells[2].Value.ToString());
     
                    minMax.Add(numBulto);

                }
                else
                {
                    cantBultos--;
                    //row.Cells[identificadorBulto]
                    sqlQuitarBultos1 = sqlQuitarBultos1 + " when id = " + row.Cells[0].Value.ToString().Remove(0, 1) + " then " + "-1 ";

                    //row.Cells[identificadorBulto]
                    sqlQuitarBultos2 = sqlQuitarBultos2 + row.Cells[0].Value.ToString().Remove(0, 1) + ",";
                }

                

            }

            var paquetesXBolsas = "";
            var distintosPaquetes = minMax.GroupBy(a => a.cantPorPaquete).Select(p => new { paquete = p.Key, cantidad = p.ToList().Count }).ToList();
            foreach (var i in distintosPaquetes)
            {
                paquetesXBolsas = paquetesXBolsas + "[" + i.cantidad.ToString() + "x" + i.paquete.ToString() + "]";
            }

            var datosExtrusion = mySqlConexion.buscarExtrusion(formPrincipal.instancia.datosOp[9]);
            var ancho = double.Parse(formPrincipal.instancia.datosOp[1]);
            var largo = double.Parse(formPrincipal.instancia.datosOp[2])*100;
            var espesor = double.Parse(formPrincipal.instancia.datosOp[3]);
            var pesoMtsTeorico = double.Parse(datosExtrusion[5]);
            var pesoTeoMin = double.Parse(datosExtrusion[6]);
            var pesoTeoMax = double.Parse(datosExtrusion[7]);
            var pesoMillar = double.Parse(formPrincipal.instancia.datosOp[13]);
            var metros = sumBolsasBolsas * double.Parse(formPrincipal.instancia.datosOp[2]);
            var netoTeorico = sumBolsasBolsas * pesoMillar;
            double nominal;
            double maximo;
            double minimo;

            if (formPrincipal.instancia.datosOp[5] == "Lateral")
            {
                var tempDensidad = double.Parse(datosExtrusion[3]); //0.922
                var tempPeso = ancho * (espesor / 10000000) * largo * 2 * tempDensidad;
                nominal = sumBolsasBolsas * tempPeso;
                minimo = nominal * 0.9;
                maximo = nominal * 1.1;
            }
            else
            {
                nominal = sumBolsasBolsas * (largo * pesoMtsTeorico) / 100000;
                minimo = sumBolsasBolsas * (largo * (pesoMtsTeorico - pesoTeoMin)) / 100000;
                maximo = sumBolsasBolsas * (largo * (pesoMtsTeorico + pesoTeoMax)) / 100000;
            }

            var palletSeleccionado = dgvPalletsRegistrados.SelectedRows[0].Cells[0].Value;
            sqlModificarNT = sqlModificarNT + "'" + paquetesXBolsas + "'" + ",cant_bobinas =" + cantBultos + ",total_bolsas = " + sumBolsasBolsas + ",teorico_minimo = " + minimo.ToString().Replace(",", ".") + ",teorico_nominal=" + nominal.ToString().Replace(",", ".") + ",teorico_maximo=" + maximo.ToString().Replace(",", ".") + ",neto=" + netoTeorico.ToString().Replace(",", ".") + ",metros=" + Math.Round(metros)+ " where id="+ palletSeleccionado+";";

            sqlQuitarBultos1 = sqlQuitarBultos1 + "end) ";
            sqlQuitarBultos2 = sqlQuitarBultos2.TrimEnd(',') + ");";
            sqlQuitarBultos1 = sqlQuitarBultos1 + sqlQuitarBultos2;
            if (mySqlConexion.sqlSimpleQuery(sqlQuitarBultos1, sqlModificarNT)) {
                formIp.instancia.palletModificado = true;
                Close();
            }
            else MessageBox.Show("Error, no se pudo modificar este NT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void itemEditar_Click(object sender, EventArgs e)
        {
            lblEmpresa.Text = "SANLUFILM - Bultos del pallet";
            tcPallets.SelectedTab = tcPallets.TabPages["tpPalletEditar"];   
            dtPalletBultos = new DataTable("bultos");         
            var bultosDelPallet = mySqlConexion.buscarBultosPorIdPallet(dgvPalletsRegistrados.SelectedRows[0].Cells[1].Value.ToString());
           
            //DGVBultosDelPallet
            dtPalletBultos.Columns.Add(new DataColumn("Identificador", typeof(string)));
            dtPalletBultos.Columns.Add(new DataColumn("Bulto N°", typeof(int)));
            dtPalletBultos.Columns.Add(new DataColumn("Cantidad de bolsas", typeof(int)));
            dtPalletBultos.Columns.Add(new DataColumn("Origen", typeof(int)));
            dtPalletBultos.Columns.Add(new DataColumn("Creación Bulto", typeof(DateTime)));
            dtPalletBultos.Columns.Add(new DataColumn("quitarBulto", typeof(bool)));

            //gbPalletsGen.Text = "Pallets generados de la O/P: " + op;
            foreach (Bulto bulto in bultosDelPallet)
            {
                DataRow dataRow = dtPalletBultos.NewRow();
                dataRow["Identificador"] = "P"+bulto.idBulto;
                dataRow["Bulto N°"] = bulto.numBulto;
                dataRow["Cantidad de bolsas"] = bulto.cantBolsas;
                dataRow["Origen"] = bulto.idOrigen1;
                dataRow["Creación Bulto"] = bulto.fechaCreado;
                dataRow["quitarBulto"] = true;
                dtPalletBultos.Rows.Add(dataRow);

            }
            dgvBultosQuitar.DataSource = dtPalletBultos;
        }
    }
}
