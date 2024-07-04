namespace EtiquetadoBultos
{
    partial class formCambiarValorLongitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCambiarValorLongitud));
            this.pnlOpPrincipal = new System.Windows.Forms.Panel();
            this.tlpPie = new System.Windows.Forms.TableLayoutPanel();
            this.btnEtiquetar = new EtiquetadoBultos.AFControles.AFButton();
            this.btnSalir = new EtiquetadoBultos.AFControles.AFButton();
            this.gbCambiarOp = new System.Windows.Forms.GroupBox();
            this.pnlMetros = new System.Windows.Forms.Panel();
            this.ibtnMetrosLimpiar = new FontAwesome.Sharp.IconButton();
            this.tbMetros = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlOpPrincipal.SuspendLayout();
            this.tlpPie.SuspendLayout();
            this.gbCambiarOp.SuspendLayout();
            this.pnlMetros.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpPrincipal
            // 
            this.pnlOpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.pnlOpPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpPrincipal.Controls.Add(this.tlpPie);
            this.pnlOpPrincipal.Controls.Add(this.gbCambiarOp);
            this.pnlOpPrincipal.Controls.Add(this.panel2);
            this.pnlOpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOpPrincipal.Location = new System.Drawing.Point(0, 66);
            this.pnlOpPrincipal.Name = "pnlOpPrincipal";
            this.pnlOpPrincipal.Size = new System.Drawing.Size(598, 135);
            this.pnlOpPrincipal.TabIndex = 19;
            // 
            // tlpPie
            // 
            this.tlpPie.BackColor = System.Drawing.Color.Transparent;
            this.tlpPie.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlpPie.ColumnCount = 2;
            this.tlpPie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPie.Controls.Add(this.btnEtiquetar, 0, 0);
            this.tlpPie.Controls.Add(this.btnSalir, 1, 0);
            this.tlpPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpPie.Location = new System.Drawing.Point(0, 77);
            this.tlpPie.Name = "tlpPie";
            this.tlpPie.RowCount = 1;
            this.tlpPie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPie.Size = new System.Drawing.Size(596, 56);
            this.tlpPie.TabIndex = 41;
            // 
            // btnEtiquetar
            // 
            this.btnEtiquetar.BackColor = System.Drawing.Color.Transparent;
            this.btnEtiquetar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEtiquetar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.btnEtiquetar.BorderRadius = 4;
            this.btnEtiquetar.BorderSize = 2;
            this.btnEtiquetar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEtiquetar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEtiquetar.FlatAppearance.BorderSize = 0;
            this.btnEtiquetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtiquetar.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtiquetar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.btnEtiquetar.Location = new System.Drawing.Point(5, 5);
            this.btnEtiquetar.Name = "btnEtiquetar";
            this.btnEtiquetar.Size = new System.Drawing.Size(289, 46);
            this.btnEtiquetar.TabIndex = 2;
            this.btnEtiquetar.Text = "Asignar";
            this.btnEtiquetar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.btnEtiquetar.UseVisualStyleBackColor = false;
            this.btnEtiquetar.Click += new System.EventHandler(this.btnCambiarLongitud_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSalir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnSalir.BorderRadius = 4;
            this.btnSalir.BorderSize = 2;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnSalir.Location = new System.Drawing.Point(302, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(289, 46);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalirOp_Click);
            // 
            // gbCambiarOp
            // 
            this.gbCambiarOp.BackColor = System.Drawing.Color.Transparent;
            this.gbCambiarOp.Controls.Add(this.pnlMetros);
            this.gbCambiarOp.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCambiarOp.Font = new System.Drawing.Font("Roboto Black", 12.25F, System.Drawing.FontStyle.Bold);
            this.gbCambiarOp.ForeColor = System.Drawing.Color.DarkBlue;
            this.gbCambiarOp.Location = new System.Drawing.Point(0, 10);
            this.gbCambiarOp.Name = "gbCambiarOp";
            this.gbCambiarOp.Size = new System.Drawing.Size(596, 63);
            this.gbCambiarOp.TabIndex = 16;
            this.gbCambiarOp.TabStop = false;
            this.gbCambiarOp.Text = "Asignar nueva longitud";
            // 
            // pnlMetros
            // 
            this.pnlMetros.Controls.Add(this.ibtnMetrosLimpiar);
            this.pnlMetros.Controls.Add(this.tbMetros);
            this.pnlMetros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMetros.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold);
            this.pnlMetros.ForeColor = System.Drawing.Color.DarkBlue;
            this.pnlMetros.Location = new System.Drawing.Point(3, 23);
            this.pnlMetros.Name = "pnlMetros";
            this.pnlMetros.Padding = new System.Windows.Forms.Padding(3);
            this.pnlMetros.Size = new System.Drawing.Size(590, 37);
            this.pnlMetros.TabIndex = 5;
            // 
            // ibtnMetrosLimpiar
            // 
            this.ibtnMetrosLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnMetrosLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnMetrosLimpiar.FlatAppearance.BorderSize = 0;
            this.ibtnMetrosLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnMetrosLimpiar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnMetrosLimpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnMetrosLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMetrosLimpiar.IconSize = 17;
            this.ibtnMetrosLimpiar.Location = new System.Drawing.Point(558, 3);
            this.ibtnMetrosLimpiar.Name = "ibtnMetrosLimpiar";
            this.ibtnMetrosLimpiar.Size = new System.Drawing.Size(29, 25);
            this.ibtnMetrosLimpiar.TabIndex = 3;
            this.ibtnMetrosLimpiar.UseVisualStyleBackColor = true;
            this.ibtnMetrosLimpiar.Click += new System.EventHandler(this.ibtnMetrosLimpiar_Click);
            // 
            // tbMetros
            // 
            this.tbMetros.BackColor = System.Drawing.SystemColors.Info;
            this.tbMetros.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbMetros.Font = new System.Drawing.Font("Roboto Black", 11F, System.Drawing.FontStyle.Bold);
            this.tbMetros.Location = new System.Drawing.Point(3, 3);
            this.tbMetros.Margin = new System.Windows.Forms.Padding(0);
            this.tbMetros.Name = "tbMetros";
            this.tbMetros.Size = new System.Drawing.Size(584, 25);
            this.tbMetros.TabIndex = 19;
            this.tbMetros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMetros.TextChanged += new System.EventHandler(this.tbMetros_TextChanged);
            this.tbMetros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMetros_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel9, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(598, 42);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.lblEmpresa);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(40, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(279, 42);
            this.panel9.TabIndex = 32;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmpresa.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblEmpresa.Location = new System.Drawing.Point(0, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(279, 42);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "SANLUFILM - Cambiar metros";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 10);
            this.panel2.TabIndex = 43;
            // 
            // formCambiarValorLongitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 201);
            this.Controls.Add(this.pnlOpPrincipal);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(598, 201);
            this.Name = "formCambiarValorLongitud";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formCambiarValorLongitud";
            this.Activated += new System.EventHandler(this.formCambiarValorLongitud_Activated);
            this.pnlOpPrincipal.ResumeLayout(false);
            this.tlpPie.ResumeLayout(false);
            this.gbCambiarOp.ResumeLayout(false);
            this.pnlMetros.ResumeLayout(false);
            this.pnlMetros.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpPrincipal;
        private System.Windows.Forms.GroupBox gbCambiarOp;
        private System.Windows.Forms.Panel pnlMetros;
        private FontAwesome.Sharp.IconButton ibtnMetrosLimpiar;
        private System.Windows.Forms.TextBox tbMetros;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TableLayoutPanel tlpPie;
        private AFControles.AFButton btnEtiquetar;
        private AFControles.AFButton btnSalir;
        private System.Windows.Forms.Panel panel2;
    }
}