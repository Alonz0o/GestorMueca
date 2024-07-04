namespace EtiquetadoBultos
{
    partial class formAlertaReEtiquetado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAlertaReEtiquetado));
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lblBobina = new System.Windows.Forms.Label();
            this.tiempoAlerta = new System.Windows.Forms.Timer(this.components);
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPrincipal.Controls.Add(this.lblBobina);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(301, 48);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // lblBobina
            // 
            this.lblBobina.AutoSize = true;
            this.lblBobina.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBobina.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.lblBobina.ForeColor = System.Drawing.Color.White;
            this.lblBobina.Location = new System.Drawing.Point(0, 0);
            this.lblBobina.Name = "lblBobina";
            this.lblBobina.Size = new System.Drawing.Size(252, 23);
            this.lblBobina.TabIndex = 0;
            this.lblBobina.Text = "Bobina N° 1 Reetiquetada";
            // 
            // tiempoAlerta
            // 
            this.tiempoAlerta.Tick += new System.EventHandler(this.tiempoAlerta_Tick);
            // 
            // formAlertaReEtiquetado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(301, 48);
            this.Controls.Add(this.pnlPrincipal);
            this.Font = new System.Drawing.Font("Roboto Light", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "formAlertaReEtiquetado";
            this.Text = "formAlertaReEtiquetado";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label lblBobina;
        private System.Windows.Forms.Timer tiempoAlerta;
    }
}