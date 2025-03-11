using EtiquetadoBultos.Models;
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
    public partial class formEnsayoProduccion: Form
    {
        public int orden = 0, codigo = 0, idop = 0, aConfeccionar = 0, idBobinaMadre = 0, legajo = 0;
        string maquina = "";
        Especificacion espAncho = new Especificacion();
        Especificacion espLargo = new Especificacion();
        private void formEnsayoProduccion_Load(object sender, EventArgs e)
        {
            orden = Convert.ToInt32(formPrincipal.instancia.datosOp[8]);
            codigo = Convert.ToInt32(formPrincipal.instancia.datosOp[9]);
            idop = Convert.ToInt32(formPrincipal.instancia.datosOp[11]);
            aConfeccionar = Convert.ToInt32(formPrincipal.instancia.datosOp[7]);
            idBobinaMadre = formPrincipal.instancia.bobinaMadre;
            maquina = formPrincipal.instancia.maquinaAsignada;
            legajo = Convert.ToInt32(formPrincipal.instancia.operarioAsignado);

            var muestreo = formPrincipal.instancia.mySqlConexion.VerificarMuestreo(idop, aConfeccionar);

            lblRealizadas.Text = "Realizadas: " + muestreo.Realizadas;
            lblRequeridas.Text = "Requeridas: " + muestreo.Requeridas;

            lblTitulo.Text = "Ensayo para: " + orden + "/" + codigo;
            espAncho = formPrincipal.instancia.mySqlConexion.GetFichaTecnicaConfeccionAncho(codigo);
            btnEspAncho.Text = espAncho.Medio + "±" + espAncho.Maximo;
            espLargo = formPrincipal.instancia.mySqlConexion.GetFichaTecnicaConfeccionLargo(codigo);
            btnEspLargo.Text = espLargo.Medio + "±" + espLargo.Maximo;
           
        }


        public formEnsayoProduccion()
        {
            InitializeComponent();
            
        }

        private void btnAgregarEnsayo_Click(object sender, EventArgs e)
        {

        }
    }
}
