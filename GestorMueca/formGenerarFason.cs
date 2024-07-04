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
    public partial class formGenerarFason : MaterialForm
    {
        ConexionMySql mySqlConexion = new ConexionMySql();
        public formGenerarFason()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEtiquetarFason_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCantPaquetes.Text))
            {
                MessageBox.Show("Debe ingresar cantidad de paquetes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(tbCantidadBolsas.Text))
            {
                MessageBox.Show("Debe ingresar cantidad de bolsas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var bolsasConfeccionadas = 0;
            var numBulto = mySqlConexion.buscarUltimoBulto(int.Parse(formPrincipal.instancia.datosOp[11]));
            var desde = numBulto;
            string sqlAgregarBultos = "insert into bultos(Id_Orden, Num_Bulto, Creado, Legajo, Cant_Bolsas, IdOrigen1, SectorOrigen) values ";
        
            var bolsas = tbCantidadBolsas.Text;
            var operarios = formPrincipal.instancia.operadores;
            var personal = "";
            for (int o = 0; o < operarios.Count(); o++) if (operarios[o]!="0") personal = personal + operarios[o] + "-";
            personal = "'" + personal.TrimEnd('-') + "'";
            var contador = 0;
            
            for (int i = 0; i < int.Parse(tbCantPaquetes.Text); i++)
            {
                sqlAgregarBultos = sqlAgregarBultos + "(" + Utils.idOrden + "," + numBulto + ",current_timestamp," +personal + "," + bolsas + "," + "-1" + "," + "'" + "F" + "'" + "),";
                numBulto++;
                contador++;
                bolsasConfeccionadas = bolsasConfeccionadas + int.Parse(bolsas);
            }

            var metrosXBolsa = bolsasConfeccionadas * double.Parse(Utils.largo);
            sqlAgregarBultos = sqlAgregarBultos.TrimEnd(',') + ";";

            if (mySqlConexion.sqlSimpleQuery(sqlAgregarBultos,""))
            {
                List<string> datosPlanificacion = new List<string>();
                datosPlanificacion.Add(Utils.orden);
                datosPlanificacion.Add(Utils.codigo);
                datosPlanificacion.Add(Utils.cliente);
                datosPlanificacion.Add(Utils.ancho);
                datosPlanificacion.Add(Utils.espesor);
                var largoCm = double.Parse(Utils.largo) * 100;
                datosPlanificacion.Add(largoCm.ToString());
                datosPlanificacion.Add(bolsasConfeccionadas.ToString());//CantidadBolsas
                datosPlanificacion.Add(formPrincipal.instancia.operadoresNomApe[1]);//Operario
                datosPlanificacion.Add(formPrincipal.instancia.operadoresNomApe[2] != "0" ? formPrincipal.instancia.operadoresNomApe[2] : "No Hay, Auxiliar");
                datosPlanificacion.Add(formPrincipal.instancia.operadoresNomApe[3] != "0" ? formPrincipal.instancia.operadoresNomApe[3] : "No Hay, Auxiliar");
                datosPlanificacion.Add(formPrincipal.instancia.operadoresNomApe[0] != "0" ? formPrincipal.instancia.operadoresNomApe[0] : "No Hay, Encargado");
                datosPlanificacion.Add(metrosXBolsa.ToString());
                datosPlanificacion.Add(Utils.maquina);
                datosPlanificacion.Add(Utils.fechaEntrega);

                tbCantPaquetes.Text = "";
                tbCantPaquetes.Text = "";
                tbCantidadBolsas.Text = "";
                if (mySqlConexion.modificarCantidadConfeccionada(datosPlanificacion) != -1)
                {
                    formPrincipal.instancia.fasonCantidad = Utils.bolsasPedidas + "|" + mySqlConexion.totalBolsasCreadas(Utils.idOrden);
                }

                
                Utils.crearArchivoZpl(desde, numBulto);
                Close();
            }
            else
            {
                MessageBox.Show("Error, al actualizar bobinas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            var componente = (TextBox)sender;
            switch (componente.Name)
            {
                case "tbCantPaquetes":
                    if (!componente.Text.All(char.IsDigit))
                    {
                        componente.Clear();
                        MessageBox.Show("Expresar legajo solo en números.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;

                case "tbCantidadBolsas":
                    if (!componente.Text.All(char.IsDigit))
                    {
                        componente.Clear();
                        MessageBox.Show("Expresar legajo solo en números.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
            }
        }
    }
}
