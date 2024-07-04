namespace EtiquetadoBultos
{
    partial class formMotivoBaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMotivoBaja));
            this.pnlOpPrincipal = new System.Windows.Forms.Panel();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new EtiquetadoBultos.AFControles.AFButton();
            this.btnAceptar = new EtiquetadoBultos.AFControles.AFButton();
            this.gbCambiarOp = new System.Windows.Forms.GroupBox();
            this.pnlOrden = new System.Windows.Forms.Panel();
            this.ibtnLimpiarMotivo = new FontAwesome.Sharp.IconButton();
            this.tbMotivo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.pnlOpPrincipal.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.gbCambiarOp.SuspendLayout();
            this.pnlOrden.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpPrincipal
            // 
            this.pnlOpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.pnlOpPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpPrincipal.Controls.Add(this.gbCambiarOp);
            this.pnlOpPrincipal.Controls.Add(this.tlpBotones);
            this.pnlOpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOpPrincipal.Location = new System.Drawing.Point(0, 66);
            this.pnlOpPrincipal.Name = "pnlOpPrincipal";
            this.pnlOpPrincipal.Size = new System.Drawing.Size(579, 253);
            this.pnlOpPrincipal.TabIndex = 16;
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 2;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Controls.Add(this.btnSalir, 0, 0);
            this.tlpBotones.Controls.Add(this.btnAceptar, 0, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpBotones.Location = new System.Drawing.Point(0, 196);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 1;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Size = new System.Drawing.Size(577, 55);
            this.tlpBotones.TabIndex = 15;
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
            this.btnSalir.Location = new System.Drawing.Point(291, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(283, 49);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.ibtnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.btnAceptar.BorderRadius = 4;
            this.btnAceptar.BorderSize = 2;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.btnAceptar.Location = new System.Drawing.Point(3, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(282, 49);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbCambiarOp
            // 
            this.gbCambiarOp.BackColor = System.Drawing.Color.Transparent;
            this.gbCambiarOp.Controls.Add(this.ibtnLimpiarMotivo);
            this.gbCambiarOp.Controls.Add(this.pnlOrden);
            this.gbCambiarOp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCambiarOp.Font = new System.Drawing.Font("Roboto Black", 12.25F, System.Drawing.FontStyle.Bold);
            this.gbCambiarOp.ForeColor = System.Drawing.Color.DarkBlue;
            this.gbCambiarOp.Location = new System.Drawing.Point(0, 0);
            this.gbCambiarOp.Name = "gbCambiarOp";
            this.gbCambiarOp.Size = new System.Drawing.Size(577, 196);
            this.gbCambiarOp.TabIndex = 16;
            this.gbCambiarOp.TabStop = false;
            this.gbCambiarOp.Text = "Motivo:";
            // 
            // pnlOrden
            // 
            this.pnlOrden.Controls.Add(this.tbMotivo);
            this.pnlOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrden.Location = new System.Drawing.Point(3, 23);
            this.pnlOrden.Name = "pnlOrden";
            this.pnlOrden.Padding = new System.Windows.Forms.Padding(3);
            this.pnlOrden.Size = new System.Drawing.Size(571, 170);
            this.pnlOrden.TabIndex = 6;
            // 
            // ibtnLimpiarMotivo
            // 
            this.ibtnLimpiarMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnLimpiarMotivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnLimpiarMotivo.FlatAppearance.BorderSize = 0;
            this.ibtnLimpiarMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLimpiarMotivo.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnLimpiarMotivo.IconColor = System.Drawing.Color.Black;
            this.ibtnLimpiarMotivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLimpiarMotivo.IconSize = 20;
            this.ibtnLimpiarMotivo.Location = new System.Drawing.Point(542, 0);
            this.ibtnLimpiarMotivo.Name = "ibtnLimpiarMotivo";
            this.ibtnLimpiarMotivo.Size = new System.Drawing.Size(29, 27);
            this.ibtnLimpiarMotivo.TabIndex = 3;
            this.ibtnLimpiarMotivo.UseVisualStyleBackColor = true;
            this.ibtnLimpiarMotivo.Click += new System.EventHandler(this.ibtnLimpiarMotivo_Click);
            // 
            // tbMotivo
            // 
            this.tbMotivo.BackColor = System.Drawing.SystemColors.Info;
            this.tbMotivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMotivo.Location = new System.Drawing.Point(3, 3);
            this.tbMotivo.Margin = new System.Windows.Forms.Padding(0);
            this.tbMotivo.Multiline = true;
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMotivo.Size = new System.Drawing.Size(565, 164);
            this.tbMotivo.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.05195F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.94805F));
            this.tableLayoutPanel1.Controls.Add(this.panel9, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(579, 42);
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
            this.panel9.Size = new System.Drawing.Size(259, 42);
            this.panel9.TabIndex = 32;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmpresa.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblEmpresa.Location = new System.Drawing.Point(0, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(259, 42);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "SANLUFILM - Eliminar bulto";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formMotivoBaja
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 319);
            this.Controls.Add(this.pnlOpPrincipal);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(579, 319);
            this.Name = "formMotivoBaja";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formMotivoBaja";
            this.pnlOpPrincipal.ResumeLayout(false);
            this.tlpBotones.ResumeLayout(false);
            this.gbCambiarOp.ResumeLayout(false);
            this.pnlOrden.ResumeLayout(false);
            this.pnlOrden.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.GroupBox gbCambiarOp;
        private System.Windows.Forms.Panel pnlOrden;
        private FontAwesome.Sharp.IconButton ibtnLimpiarMotivo;
        private System.Windows.Forms.TextBox tbMotivo;
        private AFControles.AFButton btnSalir;
        private AFControles.AFButton btnAceptar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblEmpresa;
    }
}