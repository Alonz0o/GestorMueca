namespace EtiquetadoBultos
{
    partial class formCambiarOp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCambiarOp));
            this.pnlOpPrincipal = new System.Windows.Forms.Panel();
            this.tlpAuxiliares = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCodigo = new System.Windows.Forms.Panel();
            this.ibtnCodigoLimpiar = new FontAwesome.Sharp.IconButton();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbl02 = new System.Windows.Forms.Label();
            this.pnlOrden = new System.Windows.Forms.Panel();
            this.ibtnOrdenLimpiar = new FontAwesome.Sharp.IconButton();
            this.tbOrden = new System.Windows.Forms.TextBox();
            this.lbl01 = new System.Windows.Forms.Label();
            this.tlpPie = new System.Windows.Forms.TableLayoutPanel();
            this.btnCambiarOp = new EtiquetadoBultos.AFControles.AFButton();
            this.btnSalirOp = new EtiquetadoBultos.AFControles.AFButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlOpPrincipal.SuspendLayout();
            this.tlpAuxiliares.SuspendLayout();
            this.pnlCodigo.SuspendLayout();
            this.pnlOrden.SuspendLayout();
            this.tlpPie.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpPrincipal
            // 
            this.pnlOpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.pnlOpPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpPrincipal.Controls.Add(this.tlpAuxiliares);
            this.pnlOpPrincipal.Controls.Add(this.tlpPie);
            this.pnlOpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOpPrincipal.Location = new System.Drawing.Point(0, 66);
            this.pnlOpPrincipal.Name = "pnlOpPrincipal";
            this.pnlOpPrincipal.Size = new System.Drawing.Size(548, 128);
            this.pnlOpPrincipal.TabIndex = 15;
            // 
            // tlpAuxiliares
            // 
            this.tlpAuxiliares.BackColor = System.Drawing.Color.Transparent;
            this.tlpAuxiliares.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tlpAuxiliares.ColumnCount = 2;
            this.tlpAuxiliares.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAuxiliares.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAuxiliares.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAuxiliares.Controls.Add(this.pnlCodigo, 1, 0);
            this.tlpAuxiliares.Controls.Add(this.pnlOrden, 0, 0);
            this.tlpAuxiliares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAuxiliares.Location = new System.Drawing.Point(0, 0);
            this.tlpAuxiliares.Name = "tlpAuxiliares";
            this.tlpAuxiliares.RowCount = 1;
            this.tlpAuxiliares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAuxiliares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpAuxiliares.Size = new System.Drawing.Size(546, 70);
            this.tlpAuxiliares.TabIndex = 43;
            // 
            // pnlCodigo
            // 
            this.pnlCodigo.Controls.Add(this.ibtnCodigoLimpiar);
            this.pnlCodigo.Controls.Add(this.tbCodigo);
            this.pnlCodigo.Controls.Add(this.lbl02);
            this.pnlCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCodigo.Location = new System.Drawing.Point(277, 6);
            this.pnlCodigo.Name = "pnlCodigo";
            this.pnlCodigo.Padding = new System.Windows.Forms.Padding(3);
            this.pnlCodigo.Size = new System.Drawing.Size(263, 58);
            this.pnlCodigo.TabIndex = 6;
            // 
            // ibtnCodigoLimpiar
            // 
            this.ibtnCodigoLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnCodigoLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnCodigoLimpiar.FlatAppearance.BorderSize = 0;
            this.ibtnCodigoLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnCodigoLimpiar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnCodigoLimpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnCodigoLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCodigoLimpiar.IconSize = 18;
            this.ibtnCodigoLimpiar.Location = new System.Drawing.Point(231, 21);
            this.ibtnCodigoLimpiar.Name = "ibtnCodigoLimpiar";
            this.ibtnCodigoLimpiar.Size = new System.Drawing.Size(29, 25);
            this.ibtnCodigoLimpiar.TabIndex = 3;
            this.ibtnCodigoLimpiar.UseVisualStyleBackColor = true;
            this.ibtnCodigoLimpiar.Click += new System.EventHandler(this.ibtnCodigoLimpiar_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackColor = System.Drawing.SystemColors.Info;
            this.tbCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCodigo.Font = new System.Drawing.Font("Roboto Black", 11F, System.Drawing.FontStyle.Bold);
            this.tbCodigo.Location = new System.Drawing.Point(3, 21);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.tbCodigo.MaxLength = 11;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(257, 25);
            this.tbCodigo.TabIndex = 19;
            this.tbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigo_KeyPress);
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl02.Font = new System.Drawing.Font("Roboto Black", 11F, System.Drawing.FontStyle.Bold);
            this.lbl02.Location = new System.Drawing.Point(3, 3);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(55, 18);
            this.lbl02.TabIndex = 20;
            this.lbl02.Text = "Codigo";
            // 
            // pnlOrden
            // 
            this.pnlOrden.Controls.Add(this.ibtnOrdenLimpiar);
            this.pnlOrden.Controls.Add(this.tbOrden);
            this.pnlOrden.Controls.Add(this.lbl01);
            this.pnlOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrden.Location = new System.Drawing.Point(6, 6);
            this.pnlOrden.Name = "pnlOrden";
            this.pnlOrden.Padding = new System.Windows.Forms.Padding(3);
            this.pnlOrden.Size = new System.Drawing.Size(262, 58);
            this.pnlOrden.TabIndex = 5;
            // 
            // ibtnOrdenLimpiar
            // 
            this.ibtnOrdenLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnOrdenLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnOrdenLimpiar.FlatAppearance.BorderSize = 0;
            this.ibtnOrdenLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnOrdenLimpiar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnOrdenLimpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnOrdenLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnOrdenLimpiar.IconSize = 18;
            this.ibtnOrdenLimpiar.Location = new System.Drawing.Point(230, 21);
            this.ibtnOrdenLimpiar.Name = "ibtnOrdenLimpiar";
            this.ibtnOrdenLimpiar.Size = new System.Drawing.Size(29, 25);
            this.ibtnOrdenLimpiar.TabIndex = 3;
            this.ibtnOrdenLimpiar.UseVisualStyleBackColor = true;
            this.ibtnOrdenLimpiar.Click += new System.EventHandler(this.ibtnOrdenLimpiar_Click);
            // 
            // tbOrden
            // 
            this.tbOrden.BackColor = System.Drawing.SystemColors.Info;
            this.tbOrden.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbOrden.Font = new System.Drawing.Font("Roboto Black", 11F, System.Drawing.FontStyle.Bold);
            this.tbOrden.Location = new System.Drawing.Point(3, 21);
            this.tbOrden.Margin = new System.Windows.Forms.Padding(0);
            this.tbOrden.MaxLength = 11;
            this.tbOrden.Name = "tbOrden";
            this.tbOrden.Size = new System.Drawing.Size(256, 25);
            this.tbOrden.TabIndex = 19;
            this.tbOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbOrden.TextChanged += new System.EventHandler(this.tbOrden_TextChanged);
            this.tbOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOrden_KeyPress);
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl01.Font = new System.Drawing.Font("Roboto Black", 11F, System.Drawing.FontStyle.Bold);
            this.lbl01.Location = new System.Drawing.Point(3, 3);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(48, 18);
            this.lbl01.TabIndex = 20;
            this.lbl01.Text = "Orden";
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
            this.tlpPie.Location = new System.Drawing.Point(0, 70);
            this.tlpPie.Name = "tlpPie";
            this.tlpPie.RowCount = 1;
            this.tlpPie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPie.Size = new System.Drawing.Size(546, 56);
            this.tlpPie.TabIndex = 42;
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
            this.btnCambiarOp.Size = new System.Drawing.Size(264, 46);
            this.btnCambiarOp.TabIndex = 2;
            this.btnCambiarOp.Text = "Cambiar";
            this.btnCambiarOp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.btnCambiarOp.UseVisualStyleBackColor = false;
            this.btnCambiarOp.Click += new System.EventHandler(this.btnCambiarOp_Click);
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
            this.btnSalirOp.Location = new System.Drawing.Point(277, 5);
            this.btnSalirOp.Name = "btnSalirOp";
            this.btnSalirOp.Size = new System.Drawing.Size(264, 46);
            this.btnSalirOp.TabIndex = 3;
            this.btnSalirOp.Text = "Salir";
            this.btnSalirOp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnSalirOp.UseVisualStyleBackColor = false;
            this.btnSalirOp.Click += new System.EventHandler(this.ibtnSalirOp_Click);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(548, 42);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.lblTitulo);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(40, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(254, 42);
            this.panel9.TabIndex = 32;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(254, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SANLUFILM - Cambiar O/P";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formCambiarOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 194);
            this.Controls.Add(this.pnlOpPrincipal);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Roboto Light", 14.25F);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(548, 194);
            this.Name = "formCambiarOp";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formCambiarOp";
            this.Activated += new System.EventHandler(this.formCambiarOp_Activated);
            this.pnlOpPrincipal.ResumeLayout(false);
            this.tlpAuxiliares.ResumeLayout(false);
            this.pnlCodigo.ResumeLayout(false);
            this.pnlCodigo.PerformLayout();
            this.pnlOrden.ResumeLayout(false);
            this.pnlOrden.PerformLayout();
            this.tlpPie.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpPrincipal;
        private FontAwesome.Sharp.IconButton ibtnOrdenLimpiar;
        private System.Windows.Forms.Panel pnlCodigo;
        private FontAwesome.Sharp.IconButton ibtnCodigoLimpiar;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.Panel pnlOrden;
        private System.Windows.Forms.TextBox tbOrden;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tlpPie;
        private AFControles.AFButton btnCambiarOp;
        private AFControles.AFButton btnSalirOp;
        private System.Windows.Forms.TableLayoutPanel tlpAuxiliares;
    }
}