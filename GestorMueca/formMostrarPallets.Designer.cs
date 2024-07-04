namespace EtiquetadoBultos
{
    partial class formMostrarPallets
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMostrarPallets));
            this.pnlOpPrincipal = new System.Windows.Forms.Panel();
            this.tcPallets = new System.Windows.Forms.TabControl();
            this.tpPalletDatos = new System.Windows.Forms.TabPage();
            this.pnlPalletDatos = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvPalletsRegistrados = new System.Windows.Forms.DataGridView();
            this.tlpPiePallets = new System.Windows.Forms.TableLayoutPanel();
            this.afButton1 = new EtiquetadoBultos.AFControles.AFButton();
            this.afButton2 = new EtiquetadoBultos.AFControles.AFButton();
            this.tpPalletEditar = new System.Windows.Forms.TabPage();
            this.pnlPalletEditar = new System.Windows.Forms.Panel();
            this.dgvBultosQuitar = new System.Windows.Forms.DataGridView();
            this.tlpPieBultos = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new EtiquetadoBultos.AFControles.AFButton();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnQuitar = new EtiquetadoBultos.AFControles.AFButton();
            this.btnVolver = new EtiquetadoBultos.AFControles.AFButton();
            this.seleccionImp = new System.Windows.Forms.PrintDialog();
            this.docImprimir = new System.Drawing.Printing.PrintDocument();
            this.cmsDgvPallets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemMenu = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.itemEditar = new FontAwesome.Sharp.IconMenuItem();
            this.tlpDgvCabeza = new System.Windows.Forms.TableLayoutPanel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.pnlOpPrincipal.SuspendLayout();
            this.tcPallets.SuspendLayout();
            this.tpPalletDatos.SuspendLayout();
            this.pnlPalletDatos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletsRegistrados)).BeginInit();
            this.tlpPiePallets.SuspendLayout();
            this.tpPalletEditar.SuspendLayout();
            this.pnlPalletEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBultosQuitar)).BeginInit();
            this.tlpPieBultos.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.cmsDgvPallets.SuspendLayout();
            this.tlpDgvCabeza.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpPrincipal
            // 
            this.pnlOpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.pnlOpPrincipal.Controls.Add(this.tcPallets);
            this.pnlOpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOpPrincipal.Location = new System.Drawing.Point(0, 66);
            this.pnlOpPrincipal.Name = "pnlOpPrincipal";
            this.pnlOpPrincipal.Size = new System.Drawing.Size(800, 534);
            this.pnlOpPrincipal.TabIndex = 21;
            // 
            // tcPallets
            // 
            this.tcPallets.Controls.Add(this.tpPalletDatos);
            this.tcPallets.Controls.Add(this.tpPalletEditar);
            this.tcPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPallets.Location = new System.Drawing.Point(0, 0);
            this.tcPallets.Multiline = true;
            this.tcPallets.Name = "tcPallets";
            this.tcPallets.SelectedIndex = 0;
            this.tcPallets.Size = new System.Drawing.Size(800, 534);
            this.tcPallets.TabIndex = 40;
            // 
            // tpPalletDatos
            // 
            this.tpPalletDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tpPalletDatos.Controls.Add(this.pnlPalletDatos);
            this.tpPalletDatos.Location = new System.Drawing.Point(4, 22);
            this.tpPalletDatos.Margin = new System.Windows.Forms.Padding(0);
            this.tpPalletDatos.Name = "tpPalletDatos";
            this.tpPalletDatos.Size = new System.Drawing.Size(792, 508);
            this.tpPalletDatos.TabIndex = 0;
            this.tpPalletDatos.Text = "Datos";
            // 
            // pnlPalletDatos
            // 
            this.pnlPalletDatos.BackColor = System.Drawing.Color.Transparent;
            this.pnlPalletDatos.Controls.Add(this.tableLayoutPanel2);
            this.pnlPalletDatos.Controls.Add(this.tlpPiePallets);
            this.pnlPalletDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPalletDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlPalletDatos.Name = "pnlPalletDatos";
            this.pnlPalletDatos.Size = new System.Drawing.Size(792, 508);
            this.pnlPalletDatos.TabIndex = 41;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvPalletsRegistrados, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(792, 452);
            this.tableLayoutPanel2.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 446);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.panel10, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel9, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel8, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 160);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(239, 227);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::EtiquetadoBultos.Properties.Resources.palletIPBulto01;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(161, 153);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(75, 71);
            this.panel10.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::EtiquetadoBultos.Properties.Resources.palletIPBulto01;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(82, 153);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(73, 71);
            this.panel9.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::EtiquetadoBultos.Properties.Resources.palletIPBulto01;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(161, 78);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(75, 69);
            this.panel8.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::EtiquetadoBultos.Properties.Resources.palletIPBulto01;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(82, 78);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(73, 69);
            this.panel7.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::EtiquetadoBultos.Properties.Resources.palletIPBulto01;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(73, 69);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::EtiquetadoBultos.Properties.Resources.palletIPBulto01;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(161, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(75, 69);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::EtiquetadoBultos.Properties.Resources.palletIPBulto01;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(82, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(73, 69);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::EtiquetadoBultos.Properties.Resources.palletIPBulto01;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(73, 69);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::EtiquetadoBultos.Properties.Resources.palletIPBulto01;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 71);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::EtiquetadoBultos.Properties.Resources.palletIP;
            this.pictureBox1.Location = new System.Drawing.Point(0, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 59);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvPalletsRegistrados
            // 
            this.dgvPalletsRegistrados.AllowUserToAddRows = false;
            this.dgvPalletsRegistrados.AllowUserToDeleteRows = false;
            this.dgvPalletsRegistrados.AllowUserToOrderColumns = true;
            this.dgvPalletsRegistrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPalletsRegistrados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPalletsRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPalletsRegistrados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPalletsRegistrados.Location = new System.Drawing.Point(245, 0);
            this.dgvPalletsRegistrados.Margin = new System.Windows.Forms.Padding(0);
            this.dgvPalletsRegistrados.MultiSelect = false;
            this.dgvPalletsRegistrados.Name = "dgvPalletsRegistrados";
            this.dgvPalletsRegistrados.ReadOnly = true;
            this.dgvPalletsRegistrados.RowHeadersWidth = 27;
            this.dgvPalletsRegistrados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPalletsRegistrados.Size = new System.Drawing.Size(547, 452);
            this.dgvPalletsRegistrados.TabIndex = 37;
            this.dgvPalletsRegistrados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletsRegistrados_CellClick);
            this.dgvPalletsRegistrados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPalletsRegistrados_CellMouseClick);
            this.dgvPalletsRegistrados.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletsRegistrados_CellValueChanged);
            this.dgvPalletsRegistrados.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPalletsRegistrados_DataBindingComplete);
            // 
            // tlpPiePallets
            // 
            this.tlpPiePallets.BackColor = System.Drawing.Color.AliceBlue;
            this.tlpPiePallets.ColumnCount = 3;
            this.tlpPiePallets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPiePallets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPiePallets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPiePallets.Controls.Add(this.afButton1, 0, 0);
            this.tlpPiePallets.Controls.Add(this.afButton2, 2, 0);
            this.tlpPiePallets.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpPiePallets.Location = new System.Drawing.Point(0, 452);
            this.tlpPiePallets.Name = "tlpPiePallets";
            this.tlpPiePallets.RowCount = 1;
            this.tlpPiePallets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPiePallets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlpPiePallets.Size = new System.Drawing.Size(792, 56);
            this.tlpPiePallets.TabIndex = 40;
            // 
            // afButton1
            // 
            this.afButton1.BackColor = System.Drawing.Color.Transparent;
            this.afButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.afButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.afButton1.BorderRadius = 4;
            this.afButton1.BorderSize = 2;
            this.afButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.afButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.afButton1.FlatAppearance.BorderSize = 0;
            this.afButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afButton1.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.afButton1.Location = new System.Drawing.Point(3, 3);
            this.afButton1.Name = "afButton1";
            this.afButton1.Size = new System.Drawing.Size(258, 50);
            this.afButton1.TabIndex = 2;
            this.afButton1.Text = "ReImprimir";
            this.afButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.afButton1.UseVisualStyleBackColor = false;
            this.afButton1.Click += new System.EventHandler(this.btnReImprimir_Click);
            // 
            // afButton2
            // 
            this.afButton2.BackColor = System.Drawing.Color.Transparent;
            this.afButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.afButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.afButton2.BorderRadius = 4;
            this.afButton2.BorderSize = 2;
            this.afButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.afButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.afButton2.FlatAppearance.BorderSize = 0;
            this.afButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afButton2.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.afButton2.Location = new System.Drawing.Point(531, 3);
            this.afButton2.Name = "afButton2";
            this.afButton2.Size = new System.Drawing.Size(258, 50);
            this.afButton2.TabIndex = 3;
            this.afButton2.Text = "Salir";
            this.afButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.afButton2.UseVisualStyleBackColor = false;
            this.afButton2.Click += new System.EventHandler(this.ibtnSalirOp_Click);
            // 
            // tpPalletEditar
            // 
            this.tpPalletEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpPalletEditar.Controls.Add(this.pnlPalletEditar);
            this.tpPalletEditar.Location = new System.Drawing.Point(4, 22);
            this.tpPalletEditar.Margin = new System.Windows.Forms.Padding(0);
            this.tpPalletEditar.Name = "tpPalletEditar";
            this.tpPalletEditar.Size = new System.Drawing.Size(879, 492);
            this.tpPalletEditar.TabIndex = 1;
            this.tpPalletEditar.Text = "Editar";
            // 
            // pnlPalletEditar
            // 
            this.pnlPalletEditar.Controls.Add(this.dgvBultosQuitar);
            this.pnlPalletEditar.Controls.Add(this.tlpPieBultos);
            this.pnlPalletEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPalletEditar.Location = new System.Drawing.Point(0, 0);
            this.pnlPalletEditar.Name = "pnlPalletEditar";
            this.pnlPalletEditar.Size = new System.Drawing.Size(879, 492);
            this.pnlPalletEditar.TabIndex = 41;
            // 
            // dgvBultosQuitar
            // 
            this.dgvBultosQuitar.AllowUserToAddRows = false;
            this.dgvBultosQuitar.AllowUserToDeleteRows = false;
            this.dgvBultosQuitar.AllowUserToOrderColumns = true;
            this.dgvBultosQuitar.AllowUserToResizeColumns = false;
            this.dgvBultosQuitar.AllowUserToResizeRows = false;
            this.dgvBultosQuitar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBultosQuitar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBultosQuitar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBultosQuitar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBultosQuitar.Location = new System.Drawing.Point(0, 0);
            this.dgvBultosQuitar.Margin = new System.Windows.Forms.Padding(0);
            this.dgvBultosQuitar.MultiSelect = false;
            this.dgvBultosQuitar.Name = "dgvBultosQuitar";
            this.dgvBultosQuitar.ReadOnly = true;
            this.dgvBultosQuitar.RowHeadersWidth = 27;
            this.dgvBultosQuitar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBultosQuitar.Size = new System.Drawing.Size(879, 436);
            this.dgvBultosQuitar.TabIndex = 38;
            this.dgvBultosQuitar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBultosQuitar_CellClick);
            this.dgvBultosQuitar.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBultosQuitar_CellValueChanged);
            // 
            // tlpPieBultos
            // 
            this.tlpPieBultos.BackColor = System.Drawing.Color.AliceBlue;
            this.tlpPieBultos.ColumnCount = 3;
            this.tlpPieBultos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPieBultos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPieBultos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpPieBultos.Controls.Add(this.btnSalir, 2, 0);
            this.tlpPieBultos.Controls.Add(this.pnlBotones, 0, 0);
            this.tlpPieBultos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpPieBultos.Location = new System.Drawing.Point(0, 436);
            this.tlpPieBultos.Name = "tlpPieBultos";
            this.tlpPieBultos.RowCount = 1;
            this.tlpPieBultos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPieBultos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlpPieBultos.Size = new System.Drawing.Size(879, 56);
            this.tlpPieBultos.TabIndex = 40;
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
            this.btnSalir.Location = new System.Drawing.Point(589, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(287, 50);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.ibtnSalirOp_Click);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnQuitar);
            this.pnlBotones.Controls.Add(this.btnVolver);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotones.Location = new System.Drawing.Point(3, 3);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(287, 50);
            this.pnlBotones.TabIndex = 4;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnQuitar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnQuitar.BorderRadius = 4;
            this.btnQuitar.BorderSize = 2;
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnQuitar.Location = new System.Drawing.Point(0, 0);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(287, 50);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Visible = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnVolver.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.btnVolver.BorderRadius = 4;
            this.btnVolver.BorderSize = 2;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.btnVolver.Location = new System.Drawing.Point(0, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(287, 50);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // seleccionImp
            // 
            this.seleccionImp.UseEXDialog = true;
            // 
            // docImprimir
            // 
            this.docImprimir.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.docImprimir_PrintPage);
            // 
            // cmsDgvPallets
            // 
            this.cmsDgvPallets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenu,
            this.toolStripSeparator3,
            this.itemEditar});
            this.cmsDgvPallets.Name = "cmsDgvBultos";
            this.cmsDgvPallets.Size = new System.Drawing.Size(146, 54);
            // 
            // itemMenu
            // 
            this.itemMenu.Enabled = false;
            this.itemMenu.IconChar = FontAwesome.Sharp.IconChar.Hammer;
            this.itemMenu.IconColor = System.Drawing.Color.Black;
            this.itemMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.itemMenu.IconSize = 30;
            this.itemMenu.Name = "itemMenu";
            this.itemMenu.Size = new System.Drawing.Size(145, 22);
            this.itemMenu.Text = "Herramientas";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(142, 6);
            // 
            // itemEditar
            // 
            this.itemEditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.itemEditar.IconColor = System.Drawing.Color.Black;
            this.itemEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.itemEditar.IconSize = 30;
            this.itemEditar.Name = "itemEditar";
            this.itemEditar.Size = new System.Drawing.Size(145, 22);
            this.itemEditar.Text = "Editar Pallet";
            this.itemEditar.Click += new System.EventHandler(this.itemEditar_Click);
            // 
            // tlpDgvCabeza
            // 
            this.tlpDgvCabeza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.tlpDgvCabeza.ColumnCount = 3;
            this.tlpDgvCabeza.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpDgvCabeza.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDgvCabeza.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDgvCabeza.Controls.Add(this.panel13, 1, 0);
            this.tlpDgvCabeza.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpDgvCabeza.Location = new System.Drawing.Point(0, 24);
            this.tlpDgvCabeza.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDgvCabeza.Name = "tlpDgvCabeza";
            this.tlpDgvCabeza.RowCount = 1;
            this.tlpDgvCabeza.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDgvCabeza.Size = new System.Drawing.Size(800, 42);
            this.tlpDgvCabeza.TabIndex = 39;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Transparent;
            this.panel13.Controls.Add(this.lblEmpresa);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(40, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(380, 42);
            this.panel13.TabIndex = 32;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmpresa.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblEmpresa.Location = new System.Drawing.Point(0, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(380, 42);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "SANLUFILM - Pallets";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formMostrarPallets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlOpPrincipal);
            this.Controls.Add(this.tlpDgvCabeza);
            this.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMostrarPallets";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnlOpPrincipal.ResumeLayout(false);
            this.tcPallets.ResumeLayout(false);
            this.tpPalletDatos.ResumeLayout(false);
            this.pnlPalletDatos.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletsRegistrados)).EndInit();
            this.tlpPiePallets.ResumeLayout(false);
            this.tpPalletEditar.ResumeLayout(false);
            this.pnlPalletEditar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBultosQuitar)).EndInit();
            this.tlpPieBultos.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.cmsDgvPallets.ResumeLayout(false);
            this.tlpDgvCabeza.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpPrincipal;
        private System.Windows.Forms.PrintDialog seleccionImp;
        private System.Drawing.Printing.PrintDocument docImprimir;
        private System.Windows.Forms.ContextMenuStrip cmsDgvPallets;
        private FontAwesome.Sharp.IconMenuItem itemMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private FontAwesome.Sharp.IconMenuItem itemEditar;
        private System.Windows.Forms.TabControl tcPallets;
        private System.Windows.Forms.TabPage tpPalletDatos;
        private System.Windows.Forms.DataGridView dgvPalletsRegistrados;
        private System.Windows.Forms.TabPage tpPalletEditar;
        private System.Windows.Forms.DataGridView dgvBultosQuitar;
        private System.Windows.Forms.TableLayoutPanel tlpPiePallets;
        private AFControles.AFButton afButton1;
        private AFControles.AFButton afButton2;
        private System.Windows.Forms.TableLayoutPanel tlpPieBultos;
        private AFControles.AFButton btnVolver;
        private AFControles.AFButton btnSalir;
        private System.Windows.Forms.Panel pnlPalletDatos;
        private System.Windows.Forms.Panel pnlPalletEditar;
        private System.Windows.Forms.Panel pnlBotones;
        private AFControles.AFButton btnQuitar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tlpDgvCabeza;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}