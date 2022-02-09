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
            this.pnlOpPrincipal = new System.Windows.Forms.Panel();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalirOp = new System.Windows.Forms.Button();
            this.btnCambiarOp = new System.Windows.Forms.Button();
            this.gbCambiarOp = new System.Windows.Forms.GroupBox();
            this.tlpOrdenCodigo = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCodigo = new System.Windows.Forms.Panel();
            this.ibtnCodigoLimpiar = new FontAwesome.Sharp.IconButton();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbl02 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOrden = new System.Windows.Forms.Panel();
            this.ibtnOrdenLimpiar = new FontAwesome.Sharp.IconButton();
            this.tbOrden = new System.Windows.Forms.TextBox();
            this.lbl01 = new System.Windows.Forms.Label();
            this.pnlSeparacion = new System.Windows.Forms.Panel();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ibtnSalirOp = new FontAwesome.Sharp.IconButton();
            this.pnlOpPrincipal.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.gbCambiarOp.SuspendLayout();
            this.tlpOrdenCodigo.SuspendLayout();
            this.pnlCodigo.SuspendLayout();
            this.pnlOrden.SuspendLayout();
            this.pnlHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpPrincipal
            // 
            this.pnlOpPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpPrincipal.Controls.Add(this.tlpBotones);
            this.pnlOpPrincipal.Controls.Add(this.gbCambiarOp);
            this.pnlOpPrincipal.Controls.Add(this.pnlSeparacion);
            this.pnlOpPrincipal.Controls.Add(this.pnlHead);
            this.pnlOpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlOpPrincipal.Name = "pnlOpPrincipal";
            this.pnlOpPrincipal.Size = new System.Drawing.Size(494, 205);
            this.pnlOpPrincipal.TabIndex = 15;
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 2;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Controls.Add(this.btnSalirOp, 0, 0);
            this.tlpBotones.Controls.Add(this.btnCambiarOp, 0, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBotones.Location = new System.Drawing.Point(0, 139);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Size = new System.Drawing.Size(492, 55);
            this.tlpBotones.TabIndex = 15;
            // 
            // btnSalirOp
            // 
            this.btnSalirOp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalirOp.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSalirOp.Location = new System.Drawing.Point(249, 3);
            this.btnSalirOp.Name = "btnSalirOp";
            this.btnSalirOp.Size = new System.Drawing.Size(240, 49);
            this.btnSalirOp.TabIndex = 14;
            this.btnSalirOp.Text = "Salir";
            this.btnSalirOp.UseVisualStyleBackColor = true;
            this.btnSalirOp.Click += new System.EventHandler(this.btnSalirOp_Click);
            // 
            // btnCambiarOp
            // 
            this.btnCambiarOp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCambiarOp.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarOp.Location = new System.Drawing.Point(3, 3);
            this.btnCambiarOp.Name = "btnCambiarOp";
            this.btnCambiarOp.Size = new System.Drawing.Size(240, 49);
            this.btnCambiarOp.TabIndex = 13;
            this.btnCambiarOp.Text = "Cambiar";
            this.btnCambiarOp.Click += new System.EventHandler(this.btnCambiarOp_Click);
            // 
            // gbCambiarOp
            // 
            this.gbCambiarOp.BackColor = System.Drawing.Color.Transparent;
            this.gbCambiarOp.Controls.Add(this.tlpOrdenCodigo);
            this.gbCambiarOp.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCambiarOp.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCambiarOp.ForeColor = System.Drawing.Color.DarkBlue;
            this.gbCambiarOp.Location = new System.Drawing.Point(0, 36);
            this.gbCambiarOp.Name = "gbCambiarOp";
            this.gbCambiarOp.Size = new System.Drawing.Size(492, 103);
            this.gbCambiarOp.TabIndex = 16;
            this.gbCambiarOp.TabStop = false;
            this.gbCambiarOp.Text = "Orden de produccion";
            // 
            // tlpOrdenCodigo
            // 
            this.tlpOrdenCodigo.ColumnCount = 3;
            this.tlpOrdenCodigo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOrdenCodigo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOrdenCodigo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOrdenCodigo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOrdenCodigo.Controls.Add(this.pnlCodigo, 2, 0);
            this.tlpOrdenCodigo.Controls.Add(this.label1, 1, 0);
            this.tlpOrdenCodigo.Controls.Add(this.pnlOrden, 0, 0);
            this.tlpOrdenCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpOrdenCodigo.Location = new System.Drawing.Point(3, 23);
            this.tlpOrdenCodigo.Name = "tlpOrdenCodigo";
            this.tlpOrdenCodigo.RowCount = 1;
            this.tlpOrdenCodigo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOrdenCodigo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tlpOrdenCodigo.Size = new System.Drawing.Size(486, 73);
            this.tlpOrdenCodigo.TabIndex = 20;
            // 
            // pnlCodigo
            // 
            this.pnlCodigo.Controls.Add(this.ibtnCodigoLimpiar);
            this.pnlCodigo.Controls.Add(this.tbCodigo);
            this.pnlCodigo.Controls.Add(this.lbl02);
            this.pnlCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCodigo.Location = new System.Drawing.Point(256, 3);
            this.pnlCodigo.Name = "pnlCodigo";
            this.pnlCodigo.Padding = new System.Windows.Forms.Padding(3);
            this.pnlCodigo.Size = new System.Drawing.Size(227, 67);
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
            this.ibtnCodigoLimpiar.IconSize = 17;
            this.ibtnCodigoLimpiar.Location = new System.Drawing.Point(195, 22);
            this.ibtnCodigoLimpiar.Name = "ibtnCodigoLimpiar";
            this.ibtnCodigoLimpiar.Size = new System.Drawing.Size(29, 27);
            this.ibtnCodigoLimpiar.TabIndex = 3;
            this.ibtnCodigoLimpiar.UseVisualStyleBackColor = true;
            this.ibtnCodigoLimpiar.Click += new System.EventHandler(this.ibtnCodigoLimpiar_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCodigo.Location = new System.Drawing.Point(3, 22);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(221, 27);
            this.tbCodigo.TabIndex = 19;
            this.tbCodigo.Text = "7480";
            this.tbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigo_KeyPress);
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl02.Location = new System.Drawing.Point(3, 3);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(60, 19);
            this.lbl02.TabIndex = 20;
            this.lbl02.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "/";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOrden
            // 
            this.pnlOrden.Controls.Add(this.ibtnOrdenLimpiar);
            this.pnlOrden.Controls.Add(this.tbOrden);
            this.pnlOrden.Controls.Add(this.lbl01);
            this.pnlOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrden.Location = new System.Drawing.Point(3, 3);
            this.pnlOrden.Name = "pnlOrden";
            this.pnlOrden.Padding = new System.Windows.Forms.Padding(3);
            this.pnlOrden.Size = new System.Drawing.Size(227, 67);
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
            this.ibtnOrdenLimpiar.IconSize = 17;
            this.ibtnOrdenLimpiar.Location = new System.Drawing.Point(195, 22);
            this.ibtnOrdenLimpiar.Name = "ibtnOrdenLimpiar";
            this.ibtnOrdenLimpiar.Size = new System.Drawing.Size(29, 27);
            this.ibtnOrdenLimpiar.TabIndex = 3;
            this.ibtnOrdenLimpiar.UseVisualStyleBackColor = true;
            this.ibtnOrdenLimpiar.Click += new System.EventHandler(this.ibtnOrdenLimpiar_Click);
            // 
            // tbOrden
            // 
            this.tbOrden.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbOrden.Location = new System.Drawing.Point(3, 22);
            this.tbOrden.Margin = new System.Windows.Forms.Padding(0);
            this.tbOrden.Name = "tbOrden";
            this.tbOrden.Size = new System.Drawing.Size(221, 27);
            this.tbOrden.TabIndex = 19;
            this.tbOrden.Text = "27860";
            this.tbOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOrden_KeyPress);
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl01.Location = new System.Drawing.Point(3, 3);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(53, 19);
            this.lbl01.TabIndex = 20;
            this.lbl01.Text = "Orden";
            // 
            // pnlSeparacion
            // 
            this.pnlSeparacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparacion.Location = new System.Drawing.Point(0, 26);
            this.pnlSeparacion.Name = "pnlSeparacion";
            this.pnlSeparacion.Size = new System.Drawing.Size(492, 10);
            this.pnlSeparacion.TabIndex = 18;
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.pnlHead.Controls.Add(this.lblTitulo);
            this.pnlHead.Controls.Add(this.ibtnSalirOp);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Margin = new System.Windows.Forms.Padding(6);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(492, 26);
            this.pnlHead.TabIndex = 17;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTitulo.Location = new System.Drawing.Point(6, 4);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(101, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cambiar O/P";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ibtnSalirOp
            // 
            this.ibtnSalirOp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnSalirOp.FlatAppearance.BorderSize = 0;
            this.ibtnSalirOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSalirOp.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ibtnSalirOp.IconColor = System.Drawing.Color.Brown;
            this.ibtnSalirOp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSalirOp.IconSize = 20;
            this.ibtnSalirOp.Location = new System.Drawing.Point(466, 5);
            this.ibtnSalirOp.Name = "ibtnSalirOp";
            this.ibtnSalirOp.Size = new System.Drawing.Size(20, 20);
            this.ibtnSalirOp.TabIndex = 12;
            this.ibtnSalirOp.UseVisualStyleBackColor = true;
            this.ibtnSalirOp.Click += new System.EventHandler(this.ibtnSalirOp_Click);
            // 
            // formCambiarOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 205);
            this.Controls.Add(this.pnlOpPrincipal);
            this.Font = new System.Drawing.Font("Roboto Light", 14.25F);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "formCambiarOp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formCambiarOp";
            this.Activated += new System.EventHandler(this.formCambiarOp_Activated);
            this.pnlOpPrincipal.ResumeLayout(false);
            this.tlpBotones.ResumeLayout(false);
            this.gbCambiarOp.ResumeLayout(false);
            this.tlpOrdenCodigo.ResumeLayout(false);
            this.pnlCodigo.ResumeLayout(false);
            this.pnlCodigo.PerformLayout();
            this.pnlOrden.ResumeLayout(false);
            this.pnlOrden.PerformLayout();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button btnSalirOp;
        private System.Windows.Forms.Button btnCambiarOp;
        private System.Windows.Forms.GroupBox gbCambiarOp;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton ibtnSalirOp;
        private System.Windows.Forms.Panel pnlSeparacion;
        private FontAwesome.Sharp.IconButton ibtnOrdenLimpiar;
        private System.Windows.Forms.TableLayoutPanel tlpOrdenCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCodigo;
        private FontAwesome.Sharp.IconButton ibtnCodigoLimpiar;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.Panel pnlOrden;
        private System.Windows.Forms.TextBox tbOrden;
        private System.Windows.Forms.Label lbl01;
    }
}