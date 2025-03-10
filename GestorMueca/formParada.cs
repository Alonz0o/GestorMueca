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
    public partial class formParada : Form
    {
        public formParada()
        {
            InitializeComponent();
        }

        private void formParada_Load(object sender, EventArgs e)
        {
            lueMaquina.Properties.DataSource = formPrincipal.instancia.mySqlConexion.GetMaquinas().OrderBy(m => m.Nombre);
            lueOperario.Properties.DataSource = formPrincipal.instancia.mySqlConexion.GetOperarios();
            lueEncargado.Properties.DataSource = formPrincipal.instancia.mySqlConexion.GetEncargados();
            lueOperarioMantenimiento.Properties.DataSource = formPrincipal.instancia.mySqlConexion.GetOperariosMantenimiento();
            lueRubro.Properties.DataSource = formPrincipal.instancia.mySqlConexion.GetRubros();
        }

        private void lueRubro_EditValueChanged(object sender, EventArgs e)
        {
            lueDescripcion.Properties.DataSource = formPrincipal.instancia.mySqlConexion.GetRubroDescripciones(lueRubro.Text);
        }
    }
}
