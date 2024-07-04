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
    public partial class formPalletBobinas : MaterialForm
    {
        DataTable dt = new DataTable("bobinas");
        DataView dv = null;
        public formPalletBobinas()
        {
            InitializeComponent();
            //Agregar imgBoton columna            
            DataGridViewImageColumn imgRollo = new DataGridViewImageColumn();
            imgRollo.HeaderText = "";
            imgRollo.Name = "imgRollo";
            imgRollo.Image = Properties.Resources.rollo32px;
            dgvPalletsBobinas.Columns.Add(imgRollo);

            DataColumn columna01 = new DataColumn("N°", typeof(int));
            DataColumn columna02 = new DataColumn("Código", typeof(int));
            DataColumn columna03 = new DataColumn("Metros disponibles", typeof(int));
            dt.Columns.Add(columna01);
            dt.Columns.Add(columna02);
            dt.Columns.Add(columna03);
            if (formPrincipal.instancia.bobinasXPallet.Count != 0) {
                foreach (Bobina bobina in formPrincipal.instancia.bobinasXPallet)
                {
                    DataRow dataRow = dt.NewRow();
                    dataRow["N°"] = bobina.numRollo;
                    dataRow["Código"] = bobina.indice;
                    dataRow["Metros disponibles"] = bobina.mtsRemanentesRollo;
                    dt.Rows.Add(dataRow);
                }

                lblPalletNum.Text = "Pallet N°: " + formPrincipal.instancia.bobinasXPallet[0].numPallet + "";

                dgvPalletsBobinas.DataSource = dt;
                dgvPalletsBobinas.Columns[0].Width = 32;
                dgvPalletsBobinas.Columns[1].Width = 32;
                dgvPalletsBobinas.AllowUserToAddRows = false;

                EnumerableRowCollection<DataRow> query = from bobinas in dt.AsEnumerable() select bobinas;

                dv = query.AsDataView();
                lblTotalMts.Text = "Metros: " + dv.ToTable().Compute("sum([Metros disponibles])", "").ToString();
                lblTotalBobinas.Text = "= " + dv.ToTable().Compute("count([N°])", "").ToString();
                var contadorRemanentes = int.Parse(dv.ToTable().Compute("count([Metros disponibles])", "[Metros disponibles] <> 0").ToString());

                if (contadorRemanentes > 1) lblAlertaPallet.Text = "Este pallet para confección esta dado de baja. Sin embargo, dispone de " + contadorRemanentes + " bobinas restantes las cuales por criterio estadístico se inhabilitaron del sistema.";
                else lblAlertaPallet.Text = "Este pallet para confección esta dado de baja. Sin embargo, dispone de una bobina restante la cual por criterio estadístico se inhabilitó del sistema.";


            }



        }

   

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void ibtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsarMR_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPalletsBobinas.Rows)
            {
                if (int.Parse(row.Cells[3].Value.ToString()) != 0)
                {
                    var bobinaRemanente = formPrincipal.instancia.bobinasXPallet.FirstOrDefault(bob => bob.indice == int.Parse(row.Cells[2].Value.ToString()));
                    formPrincipal.instancia.bobinasRemanentes.Add(bobinaRemanente);
                }
            }
            Close();
        }
    }
}
