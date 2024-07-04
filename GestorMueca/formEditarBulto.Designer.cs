namespace EtiquetadoBultos
{
    partial class formEditarBulto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEditarBulto));
            this.pnlOpPrincipal = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbNumBulto = new System.Windows.Forms.TextBox();
            this.tbLblNumBulto = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbCantBolsas = new System.Windows.Forms.TextBox();
            this.tbLblCantBolsas = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSector = new System.Windows.Forms.TextBox();
            this.tbLblSector = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.tlpPie = new System.Windows.Forms.TableLayoutPanel();
            this.btnCambiarOp = new EtiquetadoBultos.AFControles.AFButton();
            this.btnSalirOp = new EtiquetadoBultos.AFControles.AFButton();
            this.pnlOpPrincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tlpPie.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpPrincipal
            // 
            this.pnlOpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.pnlOpPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpPrincipal.Controls.Add(this.tlpPie);
            this.pnlOpPrincipal.Controls.Add(this.groupBox1);
            this.pnlOpPrincipal.Controls.Add(this.panel2);
            this.pnlOpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOpPrincipal.Location = new System.Drawing.Point(0, 66);
            this.pnlOpPrincipal.Name = "pnlOpPrincipal";
            this.pnlOpPrincipal.Size = new System.Drawing.Size(512, 180);
            this.pnlOpPrincipal.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 103);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bulto";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 73);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbNumBulto);
            this.panel3.Controls.Add(this.tbLblNumBulto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Roboto Black", 12.25F, System.Drawing.FontStyle.Bold);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(162, 67);
            this.panel3.TabIndex = 5;
            // 
            // tbNumBulto
            // 
            this.tbNumBulto.BackColor = System.Drawing.SystemColors.Info;
            this.tbNumBulto.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNumBulto.Location = new System.Drawing.Point(3, 23);
            this.tbNumBulto.Margin = new System.Windows.Forms.Padding(0);
            this.tbNumBulto.MaxLength = 4;
            this.tbNumBulto.Name = "tbNumBulto";
            this.tbNumBulto.Size = new System.Drawing.Size(156, 27);
            this.tbNumBulto.TabIndex = 21;
            // 
            // tbLblNumBulto
            // 
            this.tbLblNumBulto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbLblNumBulto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLblNumBulto.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbLblNumBulto.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLblNumBulto.ForeColor = System.Drawing.Color.DarkBlue;
            this.tbLblNumBulto.Location = new System.Drawing.Point(3, 3);
            this.tbLblNumBulto.Name = "tbLblNumBulto";
            this.tbLblNumBulto.ReadOnly = true;
            this.tbLblNumBulto.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbLblNumBulto.Size = new System.Drawing.Size(156, 20);
            this.tbLblNumBulto.TabIndex = 22;
            this.tbLblNumBulto.Text = "Numero";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbCantBolsas);
            this.panel4.Controls.Add(this.tbLblCantBolsas);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Roboto Black", 12.25F, System.Drawing.FontStyle.Bold);
            this.panel4.Location = new System.Drawing.Point(339, 3);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(162, 67);
            this.panel4.TabIndex = 7;
            // 
            // tbCantBolsas
            // 
            this.tbCantBolsas.BackColor = System.Drawing.SystemColors.Info;
            this.tbCantBolsas.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCantBolsas.Location = new System.Drawing.Point(3, 23);
            this.tbCantBolsas.Margin = new System.Windows.Forms.Padding(0);
            this.tbCantBolsas.MaxLength = 4;
            this.tbCantBolsas.Name = "tbCantBolsas";
            this.tbCantBolsas.Size = new System.Drawing.Size(156, 27);
            this.tbCantBolsas.TabIndex = 22;
            this.tbCantBolsas.TextChanged += new System.EventHandler(this.tbCantBolsas_TextChanged);
            // 
            // tbLblCantBolsas
            // 
            this.tbLblCantBolsas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbLblCantBolsas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLblCantBolsas.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbLblCantBolsas.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLblCantBolsas.ForeColor = System.Drawing.Color.DarkBlue;
            this.tbLblCantBolsas.Location = new System.Drawing.Point(3, 3);
            this.tbLblCantBolsas.Name = "tbLblCantBolsas";
            this.tbLblCantBolsas.ReadOnly = true;
            this.tbLblCantBolsas.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbLblCantBolsas.Size = new System.Drawing.Size(156, 20);
            this.tbLblCantBolsas.TabIndex = 23;
            this.tbLblCantBolsas.Text = "Cantidad de bolsas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSector);
            this.panel1.Controls.Add(this.tbLblSector);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Roboto Black", 12.25F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(171, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(162, 67);
            this.panel1.TabIndex = 6;
            // 
            // tbSector
            // 
            this.tbSector.BackColor = System.Drawing.SystemColors.Info;
            this.tbSector.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSector.Location = new System.Drawing.Point(3, 23);
            this.tbSector.Margin = new System.Windows.Forms.Padding(0);
            this.tbSector.Name = "tbSector";
            this.tbSector.Size = new System.Drawing.Size(156, 27);
            this.tbSector.TabIndex = 22;
            // 
            // tbLblSector
            // 
            this.tbLblSector.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbLblSector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLblSector.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbLblSector.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLblSector.ForeColor = System.Drawing.Color.DarkBlue;
            this.tbLblSector.Location = new System.Drawing.Point(3, 3);
            this.tbLblSector.Name = "tbLblSector";
            this.tbLblSector.ReadOnly = true;
            this.tbLblSector.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbLblSector.Size = new System.Drawing.Size(156, 20);
            this.tbLblSector.TabIndex = 23;
            this.tbLblSector.Text = "Creado";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 10);
            this.panel2.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel9, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(512, 42);
            this.tableLayoutPanel2.TabIndex = 41;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.lblEmpresa);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(40, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(236, 42);
            this.panel9.TabIndex = 32;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmpresa.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblEmpresa.Location = new System.Drawing.Point(0, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(236, 42);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "SANLUFILM - Editar bulto";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpPie
            // 
            this.tlpPie.BackColor = System.Drawing.Color.Transparent;
            this.tlpPie.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlpPie.ColumnCount = 2;
            this.tlpPie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPie.Controls.Add(this.btnCambiarOp, 0, 0);
            this.tlpPie.Controls.Add(this.btnSalirOp, 1, 0);
            this.tlpPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpPie.Location = new System.Drawing.Point(0, 122);
            this.tlpPie.Name = "tlpPie";
            this.tlpPie.RowCount = 1;
            this.tlpPie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPie.Size = new System.Drawing.Size(510, 56);
            this.tlpPie.TabIndex = 43;
            // 
            // btnCambiarOp
            // 
            this.btnCambiarOp.BackColor = System.Drawing.Color.Transparent;
            this.btnCambiarOp.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCambiarOp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.btnCambiarOp.BorderRadius = 4;
            this.btnCambiarOp.BorderSize = 2;
            this.btnCambiarOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarOp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCambiarOp.FlatAppearance.BorderSize = 0;
            this.btnCambiarOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarOp.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarOp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.btnCambiarOp.Location = new System.Drawing.Point(5, 5);
            this.btnCambiarOp.Name = "btnCambiarOp";
            this.btnCambiarOp.Size = new System.Drawing.Size(246, 46);
            this.btnCambiarOp.TabIndex = 2;
            this.btnCambiarOp.Text = "Reetiquetar";
            this.btnCambiarOp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.btnCambiarOp.UseVisualStyleBackColor = false;
            this.btnCambiarOp.Click += new System.EventHandler(this.btnEditarBulto_Click);
            // 
            // btnSalirOp
            // 
            this.btnSalirOp.BackColor = System.Drawing.Color.Transparent;
            this.btnSalirOp.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSalirOp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnSalirOp.BorderRadius = 4;
            this.btnSalirOp.BorderSize = 2;
            this.btnSalirOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirOp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalirOp.FlatAppearance.BorderSize = 0;
            this.btnSalirOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirOp.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirOp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnSalirOp.Location = new System.Drawing.Point(259, 5);
            this.btnSalirOp.Name = "btnSalirOp";
            this.btnSalirOp.Size = new System.Drawing.Size(246, 46);
            this.btnSalirOp.TabIndex = 3;
            this.btnSalirOp.Text = "Salir";
            this.btnSalirOp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnSalirOp.UseVisualStyleBackColor = false;
            this.btnSalirOp.Click += new System.EventHandler(this.btnSalirReEtiquetado_Click);
            // 
            // formEditarBulto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 246);
            this.Controls.Add(this.pnlOpPrincipal);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(512, 246);
            this.Name = "formEditarBulto";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formEditarBulto";
            this.pnlOpPrincipal.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.tlpPie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpPrincipal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbSector;
        private System.Windows.Forms.TextBox tbLblSector;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbNumBulto;
        private System.Windows.Forms.TextBox tbLblNumBulto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbCantBolsas;
        private System.Windows.Forms.TextBox tbLblCantBolsas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TableLayoutPanel tlpPie;
        private AFControles.AFButton btnCambiarOp;
        private AFControles.AFButton btnSalirOp;
    }
}