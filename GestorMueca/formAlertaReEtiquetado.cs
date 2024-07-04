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
    public partial class formAlertaReEtiquetado : Form
    {
        public formAlertaReEtiquetado()
        {
            InitializeComponent();
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        private enmAction action;

        private int x, y;

        private void tiempoAlerta_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case enmAction.start:
                    tiempoAlerta.Interval = 1;
                    Opacity += 0.1;
                    if (x < Location.X)
                    {
                        Left--;
                    }
                    else
                    {
                        if (Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;

                case enmAction.wait:
                    tiempoAlerta.Interval = 2000;
                    action = enmAction.close;
                    break;


                case enmAction.close:
                    tiempoAlerta.Interval = 1;
                    Opacity -= 0.1;

                    Left -= 3;
                    if (Opacity == 0.0)
                    {
                        Close();
                    }
                    break;
            }
        }

        public void showAlert(string msg, int intervalo)
        {
            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alerta" + i.ToString();

                formAlertaReEtiquetado frm = (formAlertaReEtiquetado)Application.OpenForms[fname];

                if (frm == null)
                {
                    Name = fname;
                    x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                    y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(x, y);
                    break;

                }

            }

            x = Screen.PrimaryScreen.WorkingArea.Width - Width - 5;

            lblBobina.Text = msg;
            Show();
            action = enmAction.start;
            tiempoAlerta.Interval = intervalo;
            tiempoAlerta.Start();
        }

    }
}
