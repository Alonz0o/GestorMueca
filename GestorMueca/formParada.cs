using EtiquetadoBultos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace EtiquetadoBultos
{
    public partial class formParada : Form
    {
        DateTime controlInicio, controlFin;
        int orden, codigo;
        string maquina,encargadoNomApe, operarioNomApe, auxiliar01NomApe, auxiliar02NomApe;
        public formParada()
        {
            InitializeComponent();
        }

        private void formParada_Load(object sender, EventArgs e)
        {
            //Ariel 17/03/2025
            maquina = formPrincipal.instancia.maquinaSeleccionada;
            encargadoNomApe = formPrincipal.instancia.operadoresNomApe[0];
            operarioNomApe = formPrincipal.instancia.operadoresNomApe[1];
            auxiliar01NomApe =formPrincipal.instancia.operadoresNomApe[2];
            auxiliar02NomApe= formPrincipal.instancia.operadoresNomApe[3];
            lblMaquina.Text = "Maquina: "+ maquina;
            lblEncargado.Text = "Encargado: " + encargadoNomApe;
            lblOperario.Text = "Operario: " + operarioNomApe;
            lblAuxiliar01.Text = "Auxiliar01: " + auxiliar01NomApe;
            lblAuxiliar02.Text = "Auxiliar02: " + auxiliar02NomApe;

            if (formPrincipal.instancia.datosOp.Count != 0)
            {
                orden = Convert.ToInt32(formPrincipal.instancia.datosOp[8]);
                codigo = Convert.ToInt32(formPrincipal.instancia.datosOp[9]);
                lblOP.Text = "OP: " + orden + "/"+ codigo;
            }

           

            lueOperarioMantenimiento.Properties.DataSource = formPrincipal.instancia.mySqlConexion.GetOperariosMantenimiento();

            lueRubro.Properties.DataSource = formPrincipal.instancia.mySqlConexion.GetRubros();
            dtpInicio.DateTimeOffset = DateTime.Now;

             controlInicio = DateTime.Now.AddHours(-24);
             controlFin = DateTime.Now.AddHours(+12);
            gcComienzo.Text = "Comienzo * Desde:" + controlInicio + " (-24hs)";
            gcFin.Text = "Finalización * Hasta:" + controlFin + " (+12hs)";

        }

        private void lueRubro_EditValueChanged(object sender, EventArgs e)
        {
            var descripciones = formPrincipal.instancia.mySqlConexion.GetRubroDescripciones(lueRubro.Text);
            if (descripciones.Count != 0) {
                gcDescripcion.Visible = true;
                lueMotivo.Properties.DataSource = descripciones;
                lueMotivo.ItemIndex = 0;
            }
            else {
                gcDescripcion.Visible = false;

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
        DateTime inicio, fin;
        private void btnAgregarParada_Click(object sender, EventArgs e)
        {
            if (dtpInicio.EditValue == null || dtpFin.EditValue == null) {
                MessageBox.Show("Debe seleccionar hora inicio y hora fin.");
                return;
            }
            var parada = new Parada();
            parada.FechaComienzo = inicio;
            parada.FechaFin = fin;

            var controlInicio = DateTime.Now.AddHours(-24);
            if (parada.FechaComienzo < controlInicio) {
                MessageBox.Show("Limite de fechas. La fecha ingresada debe ser menor a la fecha actual - 24 horas");
                return;
            }

            var controlFin =  DateTime.Now.AddHours(+12);
            if (parada.FechaFin > controlFin)
            {
                MessageBox.Show("Limite de fechas. La fecha ingresada debe ser mayor a la fecha actual + 12 horas");
                return;
            }
          
            //VERIFICAR RUBRO
            var lueRubroA = lueRubro.GetSelectedDataRow() as Rubro;
            if (lueRubroA == null)
            {
                MessageBox.Show("Debe seleccionar rubro.");
                return;
            }
            if (inicio < controlInicio)
            {
                MessageBox.Show("Limite de fechas. La fecha ingresada debe ser menor a la fecha actual - 24 horas");
                return;
            }
            if (fin > controlFin)
            {
                MessageBox.Show("Limite de fechas. La fecha ingresada debe ser mayor a la fecha actual + 12 horas");
                return;
            }

            //parada.TurnoEncargado = GetTurno();
            parada.Maquina = maquina;
            parada.TurnoEncargado = encargadoNomApe;
            parada.OperarioNombre = operarioNomApe;

            var lueOperarioMantA = lueOperarioMantenimiento.GetSelectedDataRow() as Usuario;
            if (lueOperarioMantA != null)
            { 
                parada.OperadorMantenimiento = lueOperarioMantA.Nombre + " " + lueOperarioMantA.Apellido;
            }

            parada.TotalHora = $"{(int)diferencia.TotalHours} h {diferencia.Minutes}''";
            parada.Rubro = lueRubroA.Nombre;
            parada.Motivo = lueMotivo.Text;
            parada.Auxiliar01 = auxiliar01NomApe=="0" ? "No Hay, Auxiliar" : lblAuxiliar01.Text;
            parada.Auxiliar02 = auxiliar02NomApe == "0" ? "No Hay, Auxiliar" : lblAuxiliar02.Text;
            parada.LiberacionSanitaria = Convert.ToInt32(cbLiberacion.Checked);
            parada.Observacion = rtbObservacion.Text;
            parada.FechaReal = DateTime.Now;
            parada.Orden = orden;
            parada.Codigo = codigo;
            if (formPrincipal.instancia.mySqlConexion.InsertParada(parada))
            {
                MessageBox.Show("Se agrego la parada correctamente");
                lueOperarioMantenimiento.Text = string.Empty;
                lblHorasParada.Text = "HORAS PARADA";
                lueRubro.Text = string.Empty;
                lueMotivo.Text = string.Empty;
                rtbObservacion.Text = string.Empty;
                cbLiberacion.Checked = false;
                dtpInicio.DateTimeOffset = DateTime.Now;
                dtpFin.EditValue = string.Empty;
            }
            else MessageBox.Show("Error al agregar parada");

        }

        private void dtpInicio_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtpInicio.EditValue.ToString())) return;                       
            inicio = dtpInicio.DateTimeOffset.DateTime;
            if (dtpFin.EditValue == null) return;
            if (string.IsNullOrEmpty(dtpFin.EditValue.ToString())) return;

            fin = dtpFin.DateTimeOffset.DateTime;

            if (inicio > fin)
            {
                dtpInicio.EditValue = fin.AddDays(-1);
                return;
            }

            if (inicio < controlInicio )
            {
                MessageBox.Show("Limite de fechas. La fecha ingresada debe ser menor a la fecha actual - 24 horas");
                return;
            }

            diferencia = fin - inicio;
            lblHorasParada.Text = $"Declaro: {(int)diferencia.TotalHours} hs y {diferencia.Minutes} min";
        }
        TimeSpan diferencia;

      

        private void dtpFin_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtpFin.EditValue.ToString())) return;
            fin = dtpFin.DateTimeOffset.DateTime;
            if (dtpInicio.EditValue == null) return;
            if (string.IsNullOrEmpty(dtpInicio.EditValue.ToString())) return;
            inicio = dtpInicio.DateTimeOffset.DateTime;

            if (fin < inicio)
            {
                dtpFin.EditValue = inicio;
                return;
            }

            if (fin > controlFin)
            {
                MessageBox.Show("Limite de fechas. La fecha ingresada debe ser mayor a la fecha actual + 12 horas");
                return;
            }
            diferencia = fin - inicio;
            lblHorasParada.Text = $"Declaro: {(int)diferencia.TotalHours} hs y {diferencia.Minutes} min";
        } 
        private void btnMostrarParadas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ir a desarrollo > Filtros > Paradas");
        }
    }
}
