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
            this.pnlOpPrincipal = new System.Windows.Forms.Panel();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalirOp = new System.Windows.Forms.Button();
            this.btnCambiarLongitud = new System.Windows.Forms.Button();
            this.gbCambiarOp = new System.Windows.Forms.GroupBox();
            this.tlpMetrosEncargado = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCodigo = new System.Windows.Forms.Panel();
            this.ibtnEncargadoLimpiar = new FontAwesome.Sharp.IconButton();
            this.tbEncargado = new System.Windows.Forms.TextBox();
            this.lblEncargado = new System.Windows.Forms.Label();
            this.pnlOrden = new System.Windows.Forms.Panel();
            this.ibtnMetrosLimpiar = new FontAwesome.Sharp.IconButton();
            this.tbMetros = new System.Windows.Forms.TextBox();
            this.lbl01 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ibtnSalirOp = new FontAwesome.Sharp.IconButton();
            this.pnlOpPrincipal.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.gbCambiarOp.SuspendLayout();
            this.tlpMetrosEncargado.SuspendLayout();
            this.pnlCodigo.SuspendLayout();
            this.pnlOrden.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpPrincipal
            // 
            this.pnlOpPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpPrincipal.Controls.Add(this.tlpBotones);
            this.pnlOpPrincipal.Controls.Add(this.gbCambiarOp);
            this.pnlOpPrincipal.Controls.Add(this.panel1);
            this.pnlOpPrincipal.Controls.Add(this.panel2);
            this.pnlOpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlOpPrincipal.Name = "pnlOpPrincipal";
            this.pnlOpPrincipal.Size = new System.Drawing.Size(494, 205);
            this.pnlOpPrincipal.TabIndex = 19;
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 2;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Controls.Add(this.btnSalirOp, 0, 0);
            this.tlpBotones.Controls.Add(this.btnCambiarLongitud, 0, 0);
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
            this.btnSalirOp.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSalirOp.Location = new System.Drawing.Point(249, 3);
            this.btnSalirOp.Name = "btnSalirOp";
            this.btnSalirOp.Size = new System.Drawing.Size(240, 49);
            this.btnSalirOp.TabIndex = 14;
            this.btnSalirOp.Text = "Salir";
            this.btnSalirOp.UseVisualStyleBackColor = true;
            this.btnSalirOp.Click += new System.EventHandler(this.btnSalirOp_Click);
            // 
            // btnCambiarLongitud
            // 
            this.btnCambiarLongitud.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCambiarLongitud.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarLongitud.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCambiarLongitud.Location = new System.Drawing.Point(3, 3);
            this.btnCambiarLongitud.Name = "btnCambiarLongitud";
            this.btnCambiarLongitud.Size = new System.Drawing.Size(240, 49);
            this.btnCambiarLongitud.TabIndex = 13;
            this.btnCambiarLongitud.Text = "Cambiar";
            this.btnCambiarLongitud.UseVisualStyleBackColor = true;
            this.btnCambiarLongitud.Click += new System.EventHandler(this.btnCambiarLongitud_Click);
            // 
            // gbCambiarOp
            // 
            this.gbCambiarOp.BackColor = System.Drawing.Color.Transparent;
            this.gbCambiarOp.Controls.Add(this.tlpMetrosEncargado);
            this.gbCambiarOp.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCambiarOp.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCambiarOp.ForeColor = System.Drawing.Color.DarkBlue;
            this.gbCambiarOp.Location = new System.Drawing.Point(0, 36);
            this.gbCambiarOp.Name = "gbCambiarOp";
            this.gbCambiarOp.Size = new System.Drawing.Size(492, 103);
            this.gbCambiarOp.TabIndex = 16;
            this.gbCambiarOp.TabStop = false;
            this.gbCambiarOp.Text = "Asignar nueva longitud";
            // 
            // tlpMetrosEncargado
            // 
            this.tlpMetrosEncargado.ColumnCount = 3;
            this.tlpMetrosEncargado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMetrosEncargado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMetrosEncargado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMetrosEncargado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMetrosEncargado.Controls.Add(this.pnlCodigo, 2, 0);
            this.tlpMetrosEncargado.Controls.Add(this.pnlOrden, 0, 0);
            this.tlpMetrosEncargado.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMetrosEncargado.Location = new System.Drawing.Point(3, 23);
            this.tlpMetrosEncargado.Name = "tlpMetrosEncargado";
            this.tlpMetrosEncargado.RowCount = 1;
            this.tlpMetrosEncargado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMetrosEncargado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tlpMetrosEncargado.Size = new System.Drawing.Size(486, 73);
            this.tlpMetrosEncargado.TabIndex = 20;
            // 
            // pnlCodigo
            // 
            this.pnlCodigo.Controls.Add(this.ibtnEncargadoLimpiar);
            this.pnlCodigo.Controls.Add(this.tbEncargado);
            this.pnlCodigo.Controls.Add(this.lblEncargado);
            this.pnlCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCodigo.Location = new System.Drawing.Point(256, 3);
            this.pnlCodigo.Name = "pnlCodigo";
            this.pnlCodigo.Padding = new System.Windows.Forms.Padding(3);
            this.pnlCodigo.Size = new System.Drawing.Size(227, 67);
            this.pnlCodigo.TabIndex = 6;
            // 
            // ibtnEncargadoLimpiar
            // 
            this.ibtnEncargadoLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnEncargadoLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnEncargadoLimpiar.FlatAppearance.BorderSize = 0;
            this.ibtnEncargadoLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnEncargadoLimpiar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnEncargadoLimpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnEncargadoLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEncargadoLimpiar.IconSize = 17;
            this.ibtnEncargadoLimpiar.Location = new System.Drawing.Point(195, 22);
            this.ibtnEncargadoLimpiar.Name = "ibtnEncargadoLimpiar";
            this.ibtnEncargadoLimpiar.Size = new System.Drawing.Size(29, 27);
            this.ibtnEncargadoLimpiar.TabIndex = 3;
            this.ibtnEncargadoLimpiar.UseVisualStyleBackColor = true;
            this.ibtnEncargadoLimpiar.Click += new System.EventHandler(this.ibtnEncargadoLimpiar_Click);
            // 
            // tbEncargado
            // 
            this.tbEncargado.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbEncargado.Location = new System.Drawing.Point(3, 22);
            this.tbEncargado.Margin = new System.Windows.Forms.Padding(0);
            this.tbEncargado.Name = "tbEncargado";
            this.tbEncargado.Size = new System.Drawing.Size(221, 27);
            this.tbEncargado.TabIndex = 19;
            this.tbEncargado.Text = "22";
            this.tbEncargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEncargado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEncargado_KeyDown);
            this.tbEncargado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEncargado_KeyPress);
            // 
            // lblEncargado
            // 
            this.lblEncargado.AutoSize = true;
            this.lblEncargado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEncargado.Location = new System.Drawing.Point(3, 3);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Size = new System.Drawing.Size(71, 19);
            this.lblEncargado.TabIndex = 20;
            this.lblEncargado.Text = "Autoriza";
            // 
            // pnlOrden
            // 
            this.pnlOrden.Controls.Add(this.ibtnMetrosLimpiar);
            this.pnlOrden.Controls.Add(this.tbMetros);
            this.pnlOrden.Controls.Add(this.lbl01);
            this.pnlOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrden.Location = new System.Drawing.Point(3, 3);
            this.pnlOrden.Name = "pnlOrden";
            this.pnlOrden.Padding = new System.Windows.Forms.Padding(3);
            this.pnlOrden.Size = new System.Drawing.Size(227, 67);
            this.pnlOrden.TabIndex = 5;
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
            this.ibtnMetrosLimpiar.Location = new System.Drawing.Point(195, 22);
            this.ibtnMetrosLimpiar.Name = "ibtnMetrosLimpiar";
            this.ibtnMetrosLimpiar.Size = new System.Drawing.Size(29, 27);
            this.ibtnMetrosLimpiar.TabIndex = 3;
            this.ibtnMetrosLimpiar.UseVisualStyleBackColor = true;
            this.ibtnMetrosLimpiar.Click += new System.EventHandler(this.ibtnMetrosLimpiar_Click);
            // 
            // tbMetros
            // 
            this.tbMetros.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbMetros.Location = new System.Drawing.Point(3, 22);
            this.tbMetros.Margin = new System.Windows.Forms.Padding(0);
            this.tbMetros.Name = "tbMetros";
            this.tbMetros.Size = new System.Drawing.Size(221, 27);
            this.tbMetros.TabIndex = 19;
            this.tbMetros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMetros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMetros_KeyPress);
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl01.Location = new System.Drawing.Point(3, 3);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(61, 19);
            this.lbl01.TabIndex = 20;
            this.lbl01.Text = "Metros";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 10);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ibtnSalirOp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 26);
            this.panel2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(6, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cambiar Metros";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // formCambiarValorLongitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 205);
            this.Controls.Add(this.pnlOpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCambiarValorLongitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formCambiarValorLongitud";
            this.Activated += new System.EventHandler(this.formCambiarValorLongitud_Activated);
            this.pnlOpPrincipal.ResumeLayout(false);
            this.tlpBotones.ResumeLayout(false);
            this.gbCambiarOp.ResumeLayout(false);
            this.tlpMetrosEncargado.ResumeLayout(false);
            this.pnlCodigo.ResumeLayout(false);
            this.pnlCodigo.PerformLayout();
            this.pnlOrden.ResumeLayout(false);
            this.pnlOrden.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button btnSalirOp;
        private System.Windows.Forms.Button btnCambiarLongitud;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton ibtnSalirOp;
        private System.Windows.Forms.GroupBox gbCambiarOp;
        private System.Windows.Forms.TableLayoutPanel tlpMetrosEncargado;
        private System.Windows.Forms.Panel pnlCodigo;
        private FontAwesome.Sharp.IconButton ibtnEncargadoLimpiar;
        private System.Windows.Forms.TextBox tbEncargado;
        private System.Windows.Forms.Label lblEncargado;
        private System.Windows.Forms.Panel pnlOrden;
        private FontAwesome.Sharp.IconButton ibtnMetrosLimpiar;
        private System.Windows.Forms.TextBox tbMetros;
        private System.Windows.Forms.Label lbl01;
    }
}