using EtiquetadoBultos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace EtiquetadoBultos
{
    public partial class formParada : Form
    {
        public formParada()
        {
            InitializeComponent();
        }

        private void formParada_Load(object sender, EventArgs e)
        {
            var operarios = formPrincipal.instancia.mySqlConexion.GetOperarios();
            lblMaquina.Text = "Maquina: "+formPrincipal.instancia.maquinaAsignada;
            lblEncargado.Text = "Encargado: " + formPrincipal.instancia.operadoresNomApe[0];
            lblOperario.Text = "Operario: " + formPrincipal.instancia.operadoresNomApe[1];
            lblOP.Text = "OP: " + formPrincipal.instancia.operadoresNomApe[1];

            orden = Convert.ToInt32(formPrincipal.instancia.datosOp[8]);
            codigo = Convert.ToInt32(formPrincipal.instancia.datosOp[9]);
            //lueMaquina.Properties.DataSource = formPrincipal.instancia.mySqlConexion.GetMaquinas().OrderBy(m => m.Nombre);
            //lueEncargado.Properties.DataSource = formPrincipal.instancia.mySqlConexion.GetEncargados();
            lueOperarioMantenimiento.Properties.DataSource = formPrincipal.instancia.mySqlConexion.GetOperariosMantenimiento();
            //lueOperario.Properties.DataSource = operarios;
            //lueAuxiliar01.Properties.DataSource = operarios;
            //lueAuxiliar02.Properties.DataSource = operarios;
            //lueAuxiliar03.Properties.DataSource = operarios;

            lueRubro.Properties.DataSource = formPrincipal.instancia.mySqlConexion.GetRubros();
        }

        private void lueRubro_EditValueChanged(object sender, EventArgs e)
        {
            lueMotivo.Properties.DataSource = formPrincipal.instancia.mySqlConexion.GetRubroDescripciones(lueRubro.Text);
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
            var parada = new Parada();
            //parada.TurnoEncargado = GetTurno();

            parada.Maquina = lblMaquina.Text;

            if (dtpInicio.EditValue == null || dtpFin.EditValue == null) {
                MessageBox.Show("Debe seleccionar hora inicio y hora fin.");
                return;
            }

            parada.FechaComienzo = inicio;
            parada.FechaFin = fin;

            parada.OperarioNombre = lblOperario.Text;

            //VERIFICAR OPERARIO MANT
            var lueOperarioMantenimientoA = lueOperarioMantenimiento.GetSelectedDataRow() as Usuario;
            if (lueOperarioMantenimientoA == null)
            {
                MessageBox.Show("Debe seleccionar operario de mantenimiento.");
                return;
            }
            parada.OperadorMantenimiento = lueOperarioMantenimientoA.Nombre;
            parada.TurnoEncargado = lblEncargado.Text;

            //VERIFICAR RUBRO
            var lueRubroA = lueRubro.GetSelectedDataRow() as Rubro;
            if (lueRubroA == null)
            {
                MessageBox.Show("Debe seleccionar rubro.");
                return;
            }

            parada.TotalHora = $"{(int)diferencia.TotalHours} h {diferencia.Minutes}''";
            parada.Rubro = lueRubroA.Nombre;
            parada.Motivo = lueMotivo.Text;
            //parada.Auxiliar01 = lueAuxiliar01.Text;
            //parada.Auxiliar02 = lueAuxiliar02.Text;
            parada.LiberacionSanitaria = Convert.ToInt32(cbLiberacion.Checked);
            parada.Observacion = rtbObservacion.Text;
            parada.FechaReal = DateTime.Now;
            if (formPrincipal.instancia.mySqlConexion.InsertParada(parada))
            {
                MessageBox.Show("Se agrego la parada correctamente");
                lueOperarioMantenimiento.Text = string.Empty;
                lblHorasParada.Text = "HORAS PARADA";
                lueRubro.Text = string.Empty;
                lueMotivo.Text = string.Empty;
                rtbObservacion.Text = string.Empty;
                cbLiberacion.Checked = false;
                dtpInicio.EditValue = string.Empty;
                dtpFin.EditValue = string.Empty;
            }
            else MessageBox.Show("Error al agregar parada");

        }

        private void dtpInicio_EditValueChanged(object sender, EventArgs e)
        {
            inicio = dtpInicio.DateTimeOffset.DateTime;
            if (dtpFin.EditValue == null) return;
            fin = dtpFin.DateTimeOffset.DateTime;

            if (inicio > fin)
            {
                dtpInicio.EditValue = fin.AddDays(-1);
                return;
            }
            diferencia = fin - inicio;
            lblHorasParada.Text = $"La maquina estará parada por: {(int)diferencia.TotalHours} hs y {diferencia.Minutes} min";
        }
        TimeSpan diferencia;
        private void dtpFin_EditValueChanged(object sender, EventArgs e)
        {
            fin = dtpFin.DateTimeOffset.DateTime;
            if (dtpInicio.EditValue == null) return;
            inicio = dtpInicio.DateTimeOffset.DateTime;

            if (fin < inicio)
            {
                dtpFin.EditValue = inicio;
                return;
            }
            diferencia = fin - inicio;
            lblHorasParada.Text = $"La maquina estará parada por: {(int)diferencia.TotalHours} hs y {diferencia.Minutes} min";
        }
    }
}
