namespace EtiquetadoBultos
{
    partial class manualDeUsuarioBobinado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manualDeUsuarioBobinado));
            this.pnlHead = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ibtnSalirOp = new FontAwesome.Sharp.IconButton();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.tlpManualMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPrimeraParte = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHead.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.tlpManualMain.SuspendLayout();
            this.pnlPrimeraParte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.pnlHead.Controls.Add(this.lblTitulo);
            this.pnlHead.Controls.Add(this.ibtnSalirOp);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Margin = new System.Windows.Forms.Padding(7);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(590, 30);
            this.pnlHead.TabIndex = 18;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTitulo.Location = new System.Drawing.Point(7, 5);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(146, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Manual De Usuario";
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
            this.ibtnSalirOp.Location = new System.Drawing.Point(560, 6);
            this.ibtnSalirOp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ibtnSalirOp.Name = "ibtnSalirOp";
            this.ibtnSalirOp.Size = new System.Drawing.Size(23, 23);
            this.ibtnSalirOp.TabIndex = 12;
            this.ibtnSalirOp.UseVisualStyleBackColor = true;
            this.ibtnSalirOp.Click += new System.EventHandler(this.ibtnSalirOp_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.tlpManualMain);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 30);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(590, 489);
            this.pnlPrincipal.TabIndex = 19;
            // 
            // tlpManualMain
            // 
            this.tlpManualMain.ColumnCount = 1;
            this.tlpManualMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpManualMain.Controls.Add(this.pnlPrimeraParte, 0, 0);
            this.tlpManualMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpManualMain.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpManualMain.Location = new System.Drawing.Point(0, 0);
            this.tlpManualMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpManualMain.Name = "tlpManualMain";
            this.tlpManualMain.RowCount = 5;
            this.tlpManualMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.6484F));
            this.tlpManualMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.3516F));
            this.tlpManualMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.589041F));
            this.tlpManualMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpManualMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpManualMain.Size = new System.Drawing.Size(590, 438);
            this.tlpManualMain.TabIndex = 1;
            // 
            // pnlPrimeraParte
            // 
            this.pnlPrimeraParte.Controls.Add(this.pictureBox1);
            this.pnlPrimeraParte.Controls.Add(this.label1);
            this.pnlPrimeraParte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrimeraParte.Location = new System.Drawing.Point(3, 3);
            this.pnlPrimeraParte.Name = "pnlPrimeraParte";
            this.pnlPrimeraParte.Size = new System.Drawing.Size(584, 137);
            this.pnlPrimeraParte.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::EtiquetadoBultos.Properties.Resources.registrarBobina;
            this.pictureBox1.Location = new System.Drawing.Point(0, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(584, 103);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primero se debe introducir el número identificador de la bobina madre de manera m" +
    "anual o mediante el lector de codigo de barras por Ejemplo:";
            // 
            // manualDeUsuarioBobinado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 519);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlHead);
            this.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "manualDeUsuarioBobinado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "manualDeUsuarioBobinado";
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            this.tlpManualMain.ResumeLayout(false);
            this.pnlPrimeraParte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton ibtnSalirOp;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpManualMain;
        private System.Windows.Forms.Panel pnlPrimeraParte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}