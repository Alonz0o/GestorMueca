namespace EtiquetadoBultos
{
    partial class formParada
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
            this.tlpRealizados = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPendientes = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMostrarParadas = new EtiquetadoBultos.AFControles.AFButton();
            this.btnAgregarParada = new EtiquetadoBultos.AFControles.AFButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl13 = new DevExpress.XtraEditors.GroupControl();
            this.cbLiberacion = new System.Windows.Forms.CheckBox();
            this.rtbObservacion = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gcDescripcion = new DevExpress.XtraEditors.GroupControl();
            this.lueMotivo = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl11 = new DevExpress.XtraEditors.GroupControl();
            this.lueRubro = new DevExpress.XtraEditors.LookUpEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lueOperarioMantenimiento = new DevExpress.XtraEditors.LookUpEdit();
            this.lblHorasParada = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gcFin = new DevExpress.XtraEditors.GroupControl();
            this.dtpFin = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.gcComienzo = new DevExpress.XtraEditors.GroupControl();
            this.dtpInicio = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblOP = new DevExpress.XtraEditors.LabelControl();
            this.lblOperario = new DevExpress.XtraEditors.LabelControl();
            this.lblAuxiliar01 = new DevExpress.XtraEditors.LabelControl();
            this.lblAuxiliar02 = new DevExpress.XtraEditors.LabelControl();
            this.lblEncargado = new DevExpress.XtraEditors.LabelControl();
            this.lblMaquina = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tlpRealizados.SuspendLayout();
            this.pnlPendientes.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl13)).BeginInit();
            this.groupControl13.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDescripcion)).BeginInit();
            this.gcDescripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueMotivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl11)).BeginInit();
            this.groupControl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueRubro.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueOperarioMantenimiento.Properties)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFin)).BeginInit();
            this.gcFin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComienzo)).BeginInit();
            this.gcComienzo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRealizados
            // 
            this.tlpRealizados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tlpRealizados.ColumnCount = 2;
            this.tlpRealizados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpRealizados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRealizados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRealizados.Controls.Add(this.pnlPendientes, 1, 0);
            this.tlpRealizados.Controls.Add(this.panel2, 0, 0);
            this.tlpRealizados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRealizados.Location = new System.Drawing.Point(0, 0);
            this.tlpRealizados.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tlpRealizados.Name = "tlpRealizados";
            this.tlpRealizados.RowCount = 1;
            this.tlpRealizados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRealizados.Size = new System.Drawing.Size(800, 587);
            this.tlpRealizados.TabIndex = 4;
            // 
            // pnlPendientes
            // 
            this.pnlPendientes.AutoScroll = true;
            this.pnlPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.pnlPendientes.Controls.Add(this.tableLayoutPanel6);
            this.pnlPendientes.Controls.Add(this.tableLayoutPanel5);
            this.pnlPendientes.Controls.Add(this.tableLayoutPanel4);
            this.pnlPendientes.Controls.Add(this.tableLayoutPanel1);
            this.pnlPendientes.Controls.Add(this.lblHorasParada);
            this.pnlPendientes.Controls.Add(this.tableLayoutPanel2);
            this.pnlPendientes.Controls.Add(this.groupControl6);
            this.pnlPendientes.Controls.Add(this.labelControl1);
            this.pnlPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPendientes.Location = new System.Drawing.Point(16, 3);
            this.pnlPendientes.Name = "pnlPendientes";
            this.pnlPendientes.Size = new System.Drawing.Size(781, 581);
            this.pnlPendientes.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.btnMostrarParadas, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnAgregarParada, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 538);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(781, 43);
            this.tableLayoutPanel6.TabIndex = 80;
            // 
            // btnMostrarParadas
            // 
            this.btnMostrarParadas.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarParadas.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMostrarParadas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnMostrarParadas.BorderRadius = 4;
            this.btnMostrarParadas.BorderSize = 3;
            this.btnMostrarParadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarParadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMostrarParadas.FlatAppearance.BorderSize = 0;
            this.btnMostrarParadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarParadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnMostrarParadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnMostrarParadas.Location = new System.Drawing.Point(393, 3);
            this.btnMostrarParadas.Name = "btnMostrarParadas";
            this.btnMostrarParadas.Size = new System.Drawing.Size(385, 37);
            this.btnMostrarParadas.TabIndex = 8;
            this.btnMostrarParadas.Text = "Mostrar Paradas";
            this.btnMostrarParadas.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnMostrarParadas.UseVisualStyleBackColor = false;
            this.btnMostrarParadas.Click += new System.EventHandler(this.btnMostrarParadas_Click);
            // 
            // btnAgregarParada
            // 
            this.btnAgregarParada.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarParada.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAgregarParada.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAgregarParada.BorderRadius = 4;
            this.btnAgregarParada.BorderSize = 3;
            this.btnAgregarParada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarParada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarParada.FlatAppearance.BorderSize = 0;
            this.btnAgregarParada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarParada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAgregarParada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAgregarParada.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarParada.Name = "btnAgregarParada";
            this.btnAgregarParada.Size = new System.Drawing.Size(384, 37);
            this.btnAgregarParada.TabIndex = 7;
            this.btnAgregarParada.Text = "Guardar Parada";
            this.btnAgregarParada.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAgregarParada.UseVisualStyleBackColor = false;
            this.btnAgregarParada.Click += new System.EventHandler(this.btnAgregarParada_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.groupControl13, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 409);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(781, 125);
            this.tableLayoutPanel5.TabIndex = 79;
            // 
            // groupControl13
            // 
            this.groupControl13.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupControl13.Appearance.Options.UseBorderColor = true;
            this.groupControl13.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.groupControl13.AppearanceCaption.Options.UseFont = true;
            this.groupControl13.Controls.Add(this.cbLiberacion);
            this.groupControl13.Controls.Add(this.rtbObservacion);
            this.groupControl13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl13.Location = new System.Drawing.Point(0, 0);
            this.groupControl13.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl13.Name = "groupControl13";
            this.groupControl13.Size = new System.Drawing.Size(781, 125);
            this.groupControl13.TabIndex = 94;
            this.groupControl13.Text = "Observación";
            // 
            // cbLiberacion
            // 
            this.cbLiberacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLiberacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.cbLiberacion.Checked = true;
            this.cbLiberacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLiberacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.cbLiberacion.Location = new System.Drawing.Point(600, 1);
            this.cbLiberacion.Name = "cbLiberacion";
            this.cbLiberacion.Size = new System.Drawing.Size(178, 20);
            this.cbLiberacion.TabIndex = 2;
            this.cbLiberacion.Text = "Liberación Sanitaria";
            this.cbLiberacion.UseVisualStyleBackColor = false;
            // 
            // rtbObservacion
            // 
            this.rtbObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.rtbObservacion.Location = new System.Drawing.Point(2, 23);
            this.rtbObservacion.Name = "rtbObservacion";
            this.rtbObservacion.Size = new System.Drawing.Size(777, 100);
            this.rtbObservacion.TabIndex = 1;
            this.rtbObservacion.Text = "";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.gcDescripcion, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupControl11, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 339);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(781, 70);
            this.tableLayoutPanel4.TabIndex = 78;
            // 
            // gcDescripcion
            // 
            this.gcDescripcion.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.gcDescripcion.Appearance.Options.UseBorderColor = true;
            this.gcDescripcion.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.gcDescripcion.AppearanceCaption.Options.UseFont = true;
            this.gcDescripcion.Controls.Add(this.lueMotivo);
            this.gcDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDescripcion.Location = new System.Drawing.Point(390, 0);
            this.gcDescripcion.Margin = new System.Windows.Forms.Padding(0);
            this.gcDescripcion.Name = "gcDescripcion";
            this.gcDescripcion.Size = new System.Drawing.Size(391, 70);
            this.gcDescripcion.TabIndex = 95;
            this.gcDescripcion.Text = "Descripción";
            this.gcDescripcion.Visible = false;
            // 
            // lueMotivo
            // 
            this.lueMotivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lueMotivo.EditValue = "";
            this.lueMotivo.Location = new System.Drawing.Point(2, 23);
            this.lueMotivo.Name = "lueMotivo";
            this.lueMotivo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lueMotivo.Properties.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lueMotivo.Properties.Appearance.Options.UseFont = true;
            this.lueMotivo.Properties.Appearance.Options.UseForeColor = true;
            this.lueMotivo.Properties.AutoHeight = false;
            this.lueMotivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMotivo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueMotivo.Properties.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lueMotivo.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueMotivo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueMotivo.Size = new System.Drawing.Size(387, 45);
            this.lueMotivo.TabIndex = 65;
            // 
            // groupControl11
            // 
            this.groupControl11.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupControl11.Appearance.Options.UseBorderColor = true;
            this.groupControl11.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.groupControl11.AppearanceCaption.Options.UseFont = true;
            this.groupControl11.Controls.Add(this.lueRubro);
            this.groupControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl11.Location = new System.Drawing.Point(0, 0);
            this.groupControl11.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl11.Name = "groupControl11";
            this.groupControl11.Size = new System.Drawing.Size(390, 70);
            this.groupControl11.TabIndex = 94;
            this.groupControl11.Text = "Rubro";
            // 
            // lueRubro
            // 
            this.lueRubro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lueRubro.EditValue = "";
            this.lueRubro.Location = new System.Drawing.Point(2, 23);
            this.lueRubro.Name = "lueRubro";
            this.lueRubro.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lueRubro.Properties.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lueRubro.Properties.Appearance.Options.UseFont = true;
            this.lueRubro.Properties.Appearance.Options.UseForeColor = true;
            this.lueRubro.Properties.AutoHeight = false;
            this.lueRubro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueRubro.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.lueRubro.Properties.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lueRubro.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueRubro.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueRubro.Size = new System.Drawing.Size(386, 45);
            this.lueRubro.TabIndex = 65;
            this.lueRubro.EditValueChanged += new System.EventHandler(this.lueRubro_EditValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 269);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 70);
            this.tableLayoutPanel1.TabIndex = 76;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupControl2.Appearance.Options.UseBorderColor = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.lueOperarioMantenimiento);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(781, 70);
            this.groupControl2.TabIndex = 95;
            this.groupControl2.Text = "OP. Mantenimiento";
            // 
            // lueOperarioMantenimiento
            // 
            this.lueOperarioMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lueOperarioMantenimiento.EditValue = "";
            this.lueOperarioMantenimiento.Location = new System.Drawing.Point(2, 23);
            this.lueOperarioMantenimiento.Name = "lueOperarioMantenimiento";
            this.lueOperarioMantenimiento.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lueOperarioMantenimiento.Properties.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lueOperarioMantenimiento.Properties.Appearance.Options.UseFont = true;
            this.lueOperarioMantenimiento.Properties.Appearance.Options.UseForeColor = true;
            this.lueOperarioMantenimiento.Properties.AutoHeight = false;
            this.lueOperarioMantenimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueOperarioMantenimiento.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Apellido", "Apellido"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Legajo", "Legajo")});
            this.lueOperarioMantenimiento.Properties.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lueOperarioMantenimiento.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lueOperarioMantenimiento.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueOperarioMantenimiento.Size = new System.Drawing.Size(777, 45);
            this.lueOperarioMantenimiento.TabIndex = 66;
            // 
            // lblHorasParada
            // 
            this.lblHorasParada.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblHorasParada.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.lblHorasParada.Appearance.Options.UseFont = true;
            this.lblHorasParada.Appearance.Options.UseForeColor = true;
            this.lblHorasParada.Appearance.Options.UseTextOptions = true;
            this.lblHorasParada.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblHorasParada.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblHorasParada.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblHorasParada.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHorasParada.Location = new System.Drawing.Point(0, 222);
            this.lblHorasParada.Name = "lblHorasParada";
            this.lblHorasParada.Size = new System.Drawing.Size(781, 47);
            this.lblHorasParada.TabIndex = 96;
            this.lblHorasParada.Text = "HORAS PARADA";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gcFin, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.gcComienzo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 152);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(781, 70);
            this.tableLayoutPanel2.TabIndex = 75;
            // 
            // gcFin
            // 
            this.gcFin.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.gcFin.Appearance.Options.UseBorderColor = true;
            this.gcFin.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.gcFin.AppearanceCaption.Options.UseFont = true;
            this.gcFin.Controls.Add(this.dtpFin);
            this.gcFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFin.Location = new System.Drawing.Point(390, 0);
            this.gcFin.Margin = new System.Windows.Forms.Padding(0);
            this.gcFin.Name = "gcFin";
            this.gcFin.Size = new System.Drawing.Size(391, 70);
            this.gcFin.TabIndex = 95;
            this.gcFin.Text = "Finalización *";
            // 
            // dtpFin
            // 
            this.dtpFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFin.EditValue = null;
            this.dtpFin.Location = new System.Drawing.Point(2, 23);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.dtpFin.Properties.Appearance.Options.UseFont = true;
            this.dtpFin.Properties.Appearance.Options.UseTextOptions = true;
            this.dtpFin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dtpFin.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dtpFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFin.Properties.MaskSettings.Set("mask", "F");
            this.dtpFin.Properties.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.dtpFin.Size = new System.Drawing.Size(387, 44);
            this.dtpFin.TabIndex = 1;
            this.dtpFin.EditValueChanged += new System.EventHandler(this.dtpFin_EditValueChanged);
            // 
            // gcComienzo
            // 
            this.gcComienzo.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.gcComienzo.Appearance.Options.UseBorderColor = true;
            this.gcComienzo.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.gcComienzo.AppearanceCaption.Options.UseFont = true;
            this.gcComienzo.Controls.Add(this.dtpInicio);
            this.gcComienzo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcComienzo.Location = new System.Drawing.Point(0, 0);
            this.gcComienzo.Margin = new System.Windows.Forms.Padding(0);
            this.gcComienzo.Name = "gcComienzo";
            this.gcComienzo.Size = new System.Drawing.Size(390, 70);
            this.gcComienzo.TabIndex = 94;
            this.gcComienzo.Text = "Comienzo *";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpInicio.EditValue = null;
            this.dtpInicio.Location = new System.Drawing.Point(2, 23);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.dtpInicio.Properties.Appearance.Options.UseFont = true;
            this.dtpInicio.Properties.Appearance.Options.UseTextOptions = true;
            this.dtpInicio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dtpInicio.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dtpInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpInicio.Properties.MaskSettings.Set("mask", "F");
            this.dtpInicio.Properties.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.dtpInicio.Size = new System.Drawing.Size(386, 44);
            this.dtpInicio.TabIndex = 2;
            this.dtpInicio.EditValueChanged += new System.EventHandler(this.dtpInicio_EditValueChanged);
            // 
            // groupControl6
            // 
            this.groupControl6.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupControl6.Appearance.Options.UseBorderColor = true;
            this.groupControl6.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.groupControl6.AppearanceCaption.Options.UseFont = true;
            this.groupControl6.Controls.Add(this.tableLayoutPanel3);
            this.groupControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl6.Location = new System.Drawing.Point(0, 51);
            this.groupControl6.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(781, 101);
            this.groupControl6.TabIndex = 95;
            this.groupControl6.Text = "Datos cargados";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblOP, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblOperario, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblAuxiliar01, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblAuxiliar02, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblEncargado, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblMaquina, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(777, 76);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblOP
            // 
            this.lblOP.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblOP.Appearance.Options.UseFont = true;
            this.lblOP.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOP.Location = new System.Drawing.Point(3, 3);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(382, 19);
            this.lblOP.TabIndex = 87;
            this.lblOP.Text = "OP:";
            // 
            // lblOperario
            // 
            this.lblOperario.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblOperario.Appearance.Options.UseFont = true;
            this.lblOperario.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblOperario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOperario.Location = new System.Drawing.Point(3, 28);
            this.lblOperario.Name = "lblOperario";
            this.lblOperario.Size = new System.Drawing.Size(382, 19);
            this.lblOperario.TabIndex = 84;
            this.lblOperario.Text = "Operario:";
            // 
            // lblAuxiliar01
            // 
            this.lblAuxiliar01.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblAuxiliar01.Appearance.Options.UseFont = true;
            this.lblAuxiliar01.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAuxiliar01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuxiliar01.Location = new System.Drawing.Point(3, 53);
            this.lblAuxiliar01.Name = "lblAuxiliar01";
            this.lblAuxiliar01.Size = new System.Drawing.Size(382, 20);
            this.lblAuxiliar01.TabIndex = 85;
            this.lblAuxiliar01.Text = "Auxiliar01:";
            // 
            // lblAuxiliar02
            // 
            this.lblAuxiliar02.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblAuxiliar02.Appearance.Options.UseFont = true;
            this.lblAuxiliar02.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAuxiliar02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuxiliar02.Location = new System.Drawing.Point(391, 53);
            this.lblAuxiliar02.Name = "lblAuxiliar02";
            this.lblAuxiliar02.Size = new System.Drawing.Size(383, 20);
            this.lblAuxiliar02.TabIndex = 86;
            this.lblAuxiliar02.Text = "Auxiliar02:";
            // 
            // lblEncargado
            // 
            this.lblEncargado.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblEncargado.Appearance.Options.UseFont = true;
            this.lblEncargado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEncargado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEncargado.Location = new System.Drawing.Point(391, 28);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Size = new System.Drawing.Size(383, 19);
            this.lblEncargado.TabIndex = 83;
            this.lblEncargado.Text = "Encargado:";
            // 
            // lblMaquina
            // 
            this.lblMaquina.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblMaquina.Appearance.Options.UseFont = true;
            this.lblMaquina.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMaquina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaquina.Location = new System.Drawing.Point(391, 3);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(383, 19);
            this.lblMaquina.TabIndex = 82;
            this.lblMaquina.Text = "Maquina:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(781, 51);
            this.labelControl1.TabIndex = 81;
            this.labelControl1.Text = "Paradas de máquinas confección";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 581);
            this.panel2.TabIndex = 1;
            // 
            // formParada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.tlpRealizados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formParada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paradas Confeccion";
            this.Load += new System.EventHandler(this.formParada_Load);
            this.tlpRealizados.ResumeLayout(false);
            this.pnlPendientes.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl13)).EndInit();
            this.groupControl13.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDescripcion)).EndInit();
            this.gcDescripcion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueMotivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl11)).EndInit();
            this.groupControl11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueRubro.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueOperarioMantenimiento.Properties)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFin)).EndInit();
            this.gcFin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcComienzo)).EndInit();
            this.gcComienzo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRealizados;
        private System.Windows.Forms.Panel pnlPendientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private AFControles.AFButton btnAgregarParada;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraEditors.GroupControl groupControl13;
        private System.Windows.Forms.RichTextBox rtbObservacion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.GroupControl gcDescripcion;
        private DevExpress.XtraEditors.LookUpEdit lueMotivo;
        private DevExpress.XtraEditors.GroupControl groupControl11;
        private DevExpress.XtraEditors.LookUpEdit lueRubro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.GroupControl gcFin;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dtpFin;
        private DevExpress.XtraEditors.GroupControl gcComienzo;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dtpInicio;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lueOperarioMantenimiento;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private System.Windows.Forms.CheckBox cbLiberacion;
        private DevExpress.XtraEditors.LabelControl lblHorasParada;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.LabelControl lblMaquina;
        private DevExpress.XtraEditors.LabelControl lblEncargado;
        private DevExpress.XtraEditors.LabelControl lblOP;
        private DevExpress.XtraEditors.LabelControl lblOperario;
        private DevExpress.XtraEditors.LabelControl lblAuxiliar01;
        private DevExpress.XtraEditors.LabelControl lblAuxiliar02;
        private AFControles.AFButton btnMostrarParadas;
    }
}