namespace EtiquetadoBultos
{
    partial class formEnsayoProduccion
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
            this.pnlPendientes = new System.Windows.Forms.Panel();
            this.gcItemsValor = new DevExpress.XtraGrid.GridControl();
            this.gvItemsValor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tbNumPaquete = new ScrapKP.AAFControles.AAFTextBox();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.tbPallet = new ScrapKP.AAFControles.AAFTextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarEnsayo = new ProtoculoSLF.AAFControles.AAFBoton();
            this.btnCancelar = new ProtoculoSLF.AAFControles.AAFBoton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRealizadas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRequeridas = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumBobina = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNumPaquete = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlPendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcItemsValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemsValor)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPendientes
            // 
            this.pnlPendientes.AutoScroll = true;
            this.pnlPendientes.BackColor = System.Drawing.Color.Transparent;
            this.pnlPendientes.Controls.Add(this.gcItemsValor);
            this.pnlPendientes.Controls.Add(this.tableLayoutPanel3);
            this.pnlPendientes.Controls.Add(this.tableLayoutPanel5);
            this.pnlPendientes.Controls.Add(this.groupControl3);
            this.pnlPendientes.Controls.Add(this.lblTitulo);
            this.pnlPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPendientes.Location = new System.Drawing.Point(0, 0);
            this.pnlPendientes.Name = "pnlPendientes";
            this.pnlPendientes.Size = new System.Drawing.Size(439, 448);
            this.pnlPendientes.TabIndex = 1;
            // 
            // gcItemsValor
            // 
            this.gcItemsValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcItemsValor.Location = new System.Drawing.Point(0, 224);
            this.gcItemsValor.MainView = this.gvItemsValor;
            this.gcItemsValor.Name = "gcItemsValor";
            this.gcItemsValor.Size = new System.Drawing.Size(439, 181);
            this.gcItemsValor.TabIndex = 97;
            this.gcItemsValor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvItemsValor});
            // 
            // gvItemsValor
            // 
            this.gvItemsValor.GridControl = this.gcItemsValor;
            this.gvItemsValor.Name = "gvItemsValor";
            this.gvItemsValor.OptionsView.ShowGroupPanel = false;
            this.gvItemsValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvItemsValor_KeyDown);
            this.gvItemsValor.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvItemsValor_ValidatingEditor);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupControl2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupControl4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 163);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(439, 61);
            this.tableLayoutPanel3.TabIndex = 98;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupControl2.Appearance.Options.UseBorderColor = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.tbNumPaquete);
            this.groupControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(219, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(220, 61);
            this.groupControl2.TabIndex = 94;
            this.groupControl2.Text = "Paquete N°";
            // 
            // tbNumPaquete
            // 
            this.tbNumPaquete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbNumPaquete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbNumPaquete.BackColor = System.Drawing.Color.White;
            this.tbNumPaquete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.tbNumPaquete.BorderFocusColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbNumPaquete.BorderSize = 2;
            this.tbNumPaquete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNumPaquete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbNumPaquete.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbNumPaquete.Location = new System.Drawing.Point(2, 23);
            this.tbNumPaquete.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumPaquete.Multiline = false;
            this.tbNumPaquete.Name = "tbNumPaquete";
            this.tbNumPaquete.Padding = new System.Windows.Forms.Padding(19, 8, 8, 8);
            this.tbNumPaquete.PasswordChar = false;
            this.tbNumPaquete.SelectionStart = 0;
            this.tbNumPaquete.Size = new System.Drawing.Size(216, 34);
            this.tbNumPaquete.TabIndex = 2;
            this.tbNumPaquete.Texts = "";
            this.tbNumPaquete.UnderlinedStyle = true;
            // 
            // groupControl4
            // 
            this.groupControl4.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupControl4.Appearance.Options.UseBorderColor = true;
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.tbPallet);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(219, 61);
            this.groupControl4.TabIndex = 96;
            this.groupControl4.Text = "Pallet *";
            // 
            // tbPallet
            // 
            this.tbPallet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbPallet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbPallet.BackColor = System.Drawing.Color.White;
            this.tbPallet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.tbPallet.BorderFocusColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbPallet.BorderSize = 2;
            this.tbPallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbPallet.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbPallet.Location = new System.Drawing.Point(2, 23);
            this.tbPallet.Margin = new System.Windows.Forms.Padding(4);
            this.tbPallet.Multiline = false;
            this.tbPallet.Name = "tbPallet";
            this.tbPallet.Padding = new System.Windows.Forms.Padding(19, 8, 8, 8);
            this.tbPallet.PasswordChar = false;
            this.tbPallet.SelectionStart = 0;
            this.tbPallet.Size = new System.Drawing.Size(215, 34);
            this.tbPallet.TabIndex = 1;
            this.tbPallet.Texts = "";
            this.tbPallet.UnderlinedStyle = true;
            this.tbPallet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPallet_KeyDown);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.btnAgregarEnsayo, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 405);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(439, 43);
            this.tableLayoutPanel5.TabIndex = 66;
            // 
            // btnAgregarEnsayo
            // 
            this.btnAgregarEnsayo.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarEnsayo.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAgregarEnsayo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAgregarEnsayo.BorderRadius = 4;
            this.btnAgregarEnsayo.BorderSize = 3;
            this.btnAgregarEnsayo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarEnsayo.FlatAppearance.BorderSize = 0;
            this.btnAgregarEnsayo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEnsayo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAgregarEnsayo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAgregarEnsayo.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarEnsayo.Name = "btnAgregarEnsayo";
            this.btnAgregarEnsayo.Size = new System.Drawing.Size(213, 37);
            this.btnAgregarEnsayo.TabIndex = 1;
            this.btnAgregarEnsayo.Text = "Agregar";
            this.btnAgregarEnsayo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAgregarEnsayo.UseVisualStyleBackColor = false;
            this.btnAgregarEnsayo.Click += new System.EventHandler(this.btnAgregarEnsayo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnCancelar.BorderRadius = 4;
            this.btnCancelar.BorderSize = 3;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnCancelar.Location = new System.Drawing.Point(222, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(214, 37);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupControl3.Appearance.Options.UseBorderColor = true;
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.panel2);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(0, 44);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(439, 119);
            this.groupControl3.TabIndex = 92;
            this.groupControl3.Text = "Datos estadísticos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 94);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblRealizadas, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(435, 42);
            this.tableLayoutPanel2.TabIndex = 99;
            // 
            // lblRealizadas
            // 
            this.lblRealizadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRealizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblRealizadas.Location = new System.Drawing.Point(5, 2);
            this.lblRealizadas.Name = "lblRealizadas";
            this.lblRealizadas.Size = new System.Drawing.Size(208, 38);
            this.lblRealizadas.TabIndex = 97;
            this.lblRealizadas.Text = "Realizadas:";
            this.lblRealizadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRequeridas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(221, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 32);
            this.panel1.TabIndex = 91;
            // 
            // lblRequeridas
            // 
            this.lblRequeridas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRequeridas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblRequeridas.Location = new System.Drawing.Point(0, 0);
            this.lblRequeridas.Name = "lblRequeridas";
            this.lblRequeridas.Size = new System.Drawing.Size(209, 32);
            this.lblRequeridas.TabIndex = 90;
            this.lblRequeridas.Text = "Requeridas:";
            this.lblRequeridas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblNumBobina, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 42);
            this.tableLayoutPanel1.TabIndex = 100;
            // 
            // lblNumBobina
            // 
            this.lblNumBobina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumBobina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblNumBobina.Location = new System.Drawing.Point(5, 2);
            this.lblNumBobina.Name = "lblNumBobina";
            this.lblNumBobina.Size = new System.Drawing.Size(208, 38);
            this.lblNumBobina.TabIndex = 97;
            this.lblNumBobina.Text = "Bobina N°:";
            this.lblNumBobina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblNumPaquete);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(221, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 32);
            this.panel3.TabIndex = 91;
            // 
            // lblNumPaquete
            // 
            this.lblNumPaquete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumPaquete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblNumPaquete.Location = new System.Drawing.Point(0, 0);
            this.lblNumPaquete.Name = "lblNumPaquete";
            this.lblNumPaquete.Size = new System.Drawing.Size(209, 32);
            this.lblNumPaquete.TabIndex = 90;
            this.lblNumPaquete.Text = "Paquete N°:";
            this.lblNumPaquete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(439, 44);
            this.lblTitulo.TabIndex = 89;
            this.lblTitulo.Text = "Ensayo para: ";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formEnsayoProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 448);
            this.Controls.Add(this.pnlPendientes);
            this.Name = "formEnsayoProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SLFCalidad";
            this.Load += new System.EventHandler(this.formEnsayoProduccion_Load);
            this.pnlPendientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcItemsValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemsValor)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPendientes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private ProtoculoSLF.AAFControles.AAFBoton btnAgregarEnsayo;
        private ProtoculoSLF.AAFControles.AAFBoton btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRequeridas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNumBobina;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNumPaquete;
        private System.Windows.Forms.Label lblRealizadas;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private ScrapKP.AAFControles.AAFTextBox tbPallet;
        private DevExpress.XtraGrid.GridControl gcItemsValor;
        private DevExpress.XtraGrid.Views.Grid.GridView gvItemsValor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private ScrapKP.AAFControles.AAFTextBox tbNumPaquete;
    }
}