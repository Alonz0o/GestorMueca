namespace EtiquetadoBultos
{
    partial class formReEtiquetar
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
            this.btnSalirReEtiquetado = new System.Windows.Forms.Button();
            this.btnReEtiquetar = new System.Windows.Forms.Button();
            this.gbCambiarOp = new System.Windows.Forms.GroupBox();
            this.tlpOrdenCodigo = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCodigo = new System.Windows.Forms.Panel();
            this.cbHastaBobina = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOrden = new System.Windows.Forms.Panel();
            this.cbDesdeBobina = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.pnlSeparacion = new System.Windows.Forms.Panel();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ibtnSalirReEtiquetado = new FontAwesome.Sharp.IconButton();
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
            this.pnlOpPrincipal.TabIndex = 16;
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 2;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Controls.Add(this.btnSalirReEtiquetado, 0, 0);
            this.tlpBotones.Controls.Add(this.btnReEtiquetar, 0, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBotones.Location = new System.Drawing.Point(0, 139);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Size = new System.Drawing.Size(492, 55);
            this.tlpBotones.TabIndex = 15;
            // 
            // btnSalirReEtiquetado
            // 
            this.btnSalirReEtiquetado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalirReEtiquetado.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSalirReEtiquetado.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSalirReEtiquetado.Location = new System.Drawing.Point(249, 3);
            this.btnSalirReEtiquetado.Name = "btnSalirReEtiquetado";
            this.btnSalirReEtiquetado.Size = new System.Drawing.Size(240, 49);
            this.btnSalirReEtiquetado.TabIndex = 14;
            this.btnSalirReEtiquetado.Text = "Salir";
            this.btnSalirReEtiquetado.UseVisualStyleBackColor = true;
            this.btnSalirReEtiquetado.Click += new System.EventHandler(this.btnSalirReEtiquetado_Click);
            // 
            // btnReEtiquetar
            // 
            this.btnReEtiquetar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReEtiquetar.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReEtiquetar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnReEtiquetar.Location = new System.Drawing.Point(3, 3);
            this.btnReEtiquetar.Name = "btnReEtiquetar";
            this.btnReEtiquetar.Size = new System.Drawing.Size(240, 49);
            this.btnReEtiquetar.TabIndex = 13;
            this.btnReEtiquetar.Text = "Reetiquetar";
            this.btnReEtiquetar.Click += new System.EventHandler(this.btnReEtiquetar_Click);
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
            this.gbCambiarOp.Text = "Ingrese rango de bultos a reetiquetar";
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
            this.pnlCodigo.Controls.Add(this.cbHastaBobina);
            this.pnlCodigo.Controls.Add(this.lblHasta);
            this.pnlCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCodigo.Location = new System.Drawing.Point(256, 3);
            this.pnlCodigo.Name = "pnlCodigo";
            this.pnlCodigo.Padding = new System.Windows.Forms.Padding(3);
            this.pnlCodigo.Size = new System.Drawing.Size(227, 67);
            this.pnlCodigo.TabIndex = 6;
            // 
            // cbHastaBobina
            // 
            this.cbHastaBobina.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbHastaBobina.FormattingEnabled = true;
            this.cbHastaBobina.Location = new System.Drawing.Point(3, 22);
            this.cbHastaBobina.Name = "cbHastaBobina";
            this.cbHastaBobina.Size = new System.Drawing.Size(221, 27);
            this.cbHastaBobina.TabIndex = 21;
            this.cbHastaBobina.SelectedIndexChanged += new System.EventHandler(this.cbHastaBobina_SelectedIndexChanged);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHasta.Location = new System.Drawing.Point(3, 3);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(52, 19);
            this.lblHasta.TabIndex = 20;
            this.lblHasta.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "||";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlOrden
            // 
            this.pnlOrden.Controls.Add(this.cbDesdeBobina);
            this.pnlOrden.Controls.Add(this.lblDesde);
            this.pnlOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrden.Location = new System.Drawing.Point(3, 3);
            this.pnlOrden.Name = "pnlOrden";
            this.pnlOrden.Padding = new System.Windows.Forms.Padding(3);
            this.pnlOrden.Size = new System.Drawing.Size(227, 67);
            this.pnlOrden.TabIndex = 5;
            // 
            // cbDesdeBobina
            // 
            this.cbDesdeBobina.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDesdeBobina.FormattingEnabled = true;
            this.cbDesdeBobina.Location = new System.Drawing.Point(3, 22);
            this.cbDesdeBobina.Name = "cbDesdeBobina";
            this.cbDesdeBobina.Size = new System.Drawing.Size(221, 27);
            this.cbDesdeBobina.TabIndex = 19;
            this.cbDesdeBobina.SelectedIndexChanged += new System.EventHandler(this.cbDesdeBobina_SelectedIndexChanged);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDesde.Location = new System.Drawing.Point(3, 3);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(54, 19);
            this.lblDesde.TabIndex = 20;
            this.lblDesde.Text = "Desde";
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
            this.pnlHead.Controls.Add(this.ibtnSalirReEtiquetado);
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
            this.lblTitulo.Size = new System.Drawing.Size(141, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Reetiquetar bultos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ibtnSalirReEtiquetado
            // 
            this.ibtnSalirReEtiquetado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnSalirReEtiquetado.FlatAppearance.BorderSize = 0;
            this.ibtnSalirReEtiquetado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSalirReEtiquetado.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ibtnSalirReEtiquetado.IconColor = System.Drawing.Color.Brown;
            this.ibtnSalirReEtiquetado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSalirReEtiquetado.IconSize = 20;
            this.ibtnSalirReEtiquetado.Location = new System.Drawing.Point(466, 5);
            this.ibtnSalirReEtiquetado.Name = "ibtnSalirReEtiquetado";
            this.ibtnSalirReEtiquetado.Size = new System.Drawing.Size(20, 20);
            this.ibtnSalirReEtiquetado.TabIndex = 12;
            this.ibtnSalirReEtiquetado.UseVisualStyleBackColor = true;
            this.ibtnSalirReEtiquetado.Click += new System.EventHandler(this.ibtnSalirReEtiquetado_Click);
            // 
            // formReEtiquetar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 205);
            this.Controls.Add(this.pnlOpPrincipal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formReEtiquetar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formReEtiquetar";
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
        private System.Windows.Forms.Button btnSalirReEtiquetado;
        private System.Windows.Forms.Button btnReEtiquetar;
        private System.Windows.Forms.GroupBox gbCambiarOp;
        private System.Windows.Forms.TableLayoutPanel tlpOrdenCodigo;
        private System.Windows.Forms.Panel pnlCodigo;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Panel pnlOrden;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Panel pnlSeparacion;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton ibtnSalirReEtiquetado;
        private System.Windows.Forms.ComboBox cbDesdeBobina;
        private System.Windows.Forms.ComboBox cbHastaBobina;
        private System.Windows.Forms.Label label1;
    }
}