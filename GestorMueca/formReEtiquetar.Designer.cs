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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReEtiquetar));
            this.pnlOpPrincipal = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHasta = new System.Windows.Forms.GroupBox();
            this.cbHastaBobina = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.GroupBox();
            this.cbDesdeBobina = new System.Windows.Forms.ComboBox();
            this.tlpAuxiliares = new System.Windows.Forms.TableLayoutPanel();
            this.tbLblAuxiliar02 = new System.Windows.Forms.GroupBox();
            this.ibtnAuxiliar02Limpiar = new FontAwesome.Sharp.IconButton();
            this.ibtnAuxiliar02Ok = new FontAwesome.Sharp.IconButton();
            this.tbAuxiliar02 = new System.Windows.Forms.TextBox();
            this.tbLblAuxiliar01 = new System.Windows.Forms.GroupBox();
            this.ibtnAuxiliar01Limpiar = new FontAwesome.Sharp.IconButton();
            this.ibtnAuxiliar01Ok = new FontAwesome.Sharp.IconButton();
            this.tbAuxiliar01 = new System.Windows.Forms.TextBox();
            this.tbLblOperario = new System.Windows.Forms.GroupBox();
            this.ibtnOperarioOk = new FontAwesome.Sharp.IconButton();
            this.ibtnOperarioLimpiar = new FontAwesome.Sharp.IconButton();
            this.tbOperario = new System.Windows.Forms.TextBox();
            this.tlpPie = new System.Windows.Forms.TableLayoutPanel();
            this.btnReEtiquetar = new EtiquetadoBultos.AFControles.AFButton();
            this.btnSalirReEtiquetado = new EtiquetadoBultos.AFControles.AFButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.pnlOpPrincipal.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.lblHasta.SuspendLayout();
            this.lblDesde.SuspendLayout();
            this.tlpAuxiliares.SuspendLayout();
            this.tbLblAuxiliar02.SuspendLayout();
            this.tbLblAuxiliar01.SuspendLayout();
            this.tbLblOperario.SuspendLayout();
            this.tlpPie.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpPrincipal
            // 
            this.pnlOpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.pnlOpPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpPrincipal.Controls.Add(this.tableLayoutPanel3);
            this.pnlOpPrincipal.Controls.Add(this.tlpAuxiliares);
            this.pnlOpPrincipal.Controls.Add(this.tlpPie);
            this.pnlOpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOpPrincipal.Location = new System.Drawing.Point(0, 66);
            this.pnlOpPrincipal.Name = "pnlOpPrincipal";
            this.pnlOpPrincipal.Size = new System.Drawing.Size(670, 204);
            this.pnlOpPrincipal.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.lblHasta, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblDesde, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 72);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(668, 72);
            this.tableLayoutPanel3.TabIndex = 42;
            // 
            // lblHasta
            // 
            this.lblHasta.BackColor = System.Drawing.Color.Transparent;
            this.lblHasta.Controls.Add(this.cbHastaBobina);
            this.lblHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHasta.Font = new System.Drawing.Font("Roboto Black", 11F, System.Drawing.FontStyle.Bold);
            this.lblHasta.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHasta.Location = new System.Drawing.Point(338, 6);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(324, 60);
            this.lblHasta.TabIndex = 10;
            this.lblHasta.TabStop = false;
            this.lblHasta.Text = "Hasta el bulto";
            // 
            // cbHastaBobina
            // 
            this.cbHastaBobina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbHastaBobina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHastaBobina.FormattingEnabled = true;
            this.cbHastaBobina.Location = new System.Drawing.Point(3, 21);
            this.cbHastaBobina.Name = "cbHastaBobina";
            this.cbHastaBobina.Size = new System.Drawing.Size(318, 26);
            this.cbHastaBobina.TabIndex = 21;
            this.cbHastaBobina.SelectedIndexChanged += new System.EventHandler(this.cbHastaBobina_SelectedIndexChanged);
            // 
            // lblDesde
            // 
            this.lblDesde.BackColor = System.Drawing.Color.Transparent;
            this.lblDesde.Controls.Add(this.cbDesdeBobina);
            this.lblDesde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDesde.Font = new System.Drawing.Font("Roboto Black", 11F, System.Drawing.FontStyle.Bold);
            this.lblDesde.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDesde.Location = new System.Drawing.Point(6, 6);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(323, 60);
            this.lblDesde.TabIndex = 9;
            this.lblDesde.TabStop = false;
            this.lblDesde.Text = "Desde el bulto";
            // 
            // cbDesdeBobina
            // 
            this.cbDesdeBobina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDesdeBobina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDesdeBobina.FormattingEnabled = true;
            this.cbDesdeBobina.Location = new System.Drawing.Point(3, 21);
            this.cbDesdeBobina.Name = "cbDesdeBobina";
            this.cbDesdeBobina.Size = new System.Drawing.Size(317, 26);
            this.cbDesdeBobina.TabIndex = 19;
            this.cbDesdeBobina.SelectedIndexChanged += new System.EventHandler(this.cbDesdeBobina_SelectedIndexChanged);
            // 
            // tlpAuxiliares
            // 
            this.tlpAuxiliares.BackColor = System.Drawing.Color.Transparent;
            this.tlpAuxiliares.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tlpAuxiliares.ColumnCount = 3;
            this.tlpAuxiliares.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAuxiliares.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAuxiliares.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpAuxiliares.Controls.Add(this.tbLblAuxiliar02, 0, 0);
            this.tlpAuxiliares.Controls.Add(this.tbLblAuxiliar01, 0, 0);
            this.tlpAuxiliares.Controls.Add(this.tbLblOperario, 0, 0);
            this.tlpAuxiliares.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpAuxiliares.Location = new System.Drawing.Point(0, 0);
            this.tlpAuxiliares.Name = "tlpAuxiliares";
            this.tlpAuxiliares.RowCount = 1;
            this.tlpAuxiliares.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAuxiliares.Size = new System.Drawing.Size(668, 72);
            this.tlpAuxiliares.TabIndex = 21;
            // 
            // tbLblAuxiliar02
            // 
            this.tbLblAuxiliar02.BackColor = System.Drawing.Color.Transparent;
            this.tbLblAuxiliar02.Controls.Add(this.ibtnAuxiliar02Limpiar);
            this.tbLblAuxiliar02.Controls.Add(this.ibtnAuxiliar02Ok);
            this.tbLblAuxiliar02.Controls.Add(this.tbAuxiliar02);
            this.tbLblAuxiliar02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLblAuxiliar02.Font = new System.Drawing.Font("Roboto Black", 11F, System.Drawing.FontStyle.Bold);
            this.tbLblAuxiliar02.ForeColor = System.Drawing.Color.DarkBlue;
            this.tbLblAuxiliar02.Location = new System.Drawing.Point(448, 6);
            this.tbLblAuxiliar02.Name = "tbLblAuxiliar02";
            this.tbLblAuxiliar02.Size = new System.Drawing.Size(214, 60);
            this.tbLblAuxiliar02.TabIndex = 11;
            this.tbLblAuxiliar02.TabStop = false;
            this.tbLblAuxiliar02.Text = "Auxiliar";
            // 
            // ibtnAuxiliar02Limpiar
            // 
            this.ibtnAuxiliar02Limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnAuxiliar02Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnAuxiliar02Limpiar.FlatAppearance.BorderSize = 0;
            this.ibtnAuxiliar02Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnAuxiliar02Limpiar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnAuxiliar02Limpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnAuxiliar02Limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAuxiliar02Limpiar.IconSize = 18;
            this.ibtnAuxiliar02Limpiar.Location = new System.Drawing.Point(182, 21);
            this.ibtnAuxiliar02Limpiar.Name = "ibtnAuxiliar02Limpiar";
            this.ibtnAuxiliar02Limpiar.Size = new System.Drawing.Size(29, 25);
            this.ibtnAuxiliar02Limpiar.TabIndex = 3;
            this.ibtnAuxiliar02Limpiar.UseVisualStyleBackColor = true;
            // 
            // ibtnAuxiliar02Ok
            // 
            this.ibtnAuxiliar02Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnAuxiliar02Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnAuxiliar02Ok.FlatAppearance.BorderSize = 0;
            this.ibtnAuxiliar02Ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnAuxiliar02Ok.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.ibtnAuxiliar02Ok.IconColor = System.Drawing.SystemColors.Highlight;
            this.ibtnAuxiliar02Ok.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAuxiliar02Ok.IconSize = 20;
            this.ibtnAuxiliar02Ok.Location = new System.Drawing.Point(154, 21);
            this.ibtnAuxiliar02Ok.Name = "ibtnAuxiliar02Ok";
            this.ibtnAuxiliar02Ok.Size = new System.Drawing.Size(29, 25);
            this.ibtnAuxiliar02Ok.TabIndex = 5;
            this.ibtnAuxiliar02Ok.UseVisualStyleBackColor = true;
            // 
            // tbAuxiliar02
            // 
            this.tbAuxiliar02.BackColor = System.Drawing.SystemColors.Info;
            this.tbAuxiliar02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAuxiliar02.Location = new System.Drawing.Point(3, 21);
            this.tbAuxiliar02.Margin = new System.Windows.Forms.Padding(0);
            this.tbAuxiliar02.MaxLength = 4;
            this.tbAuxiliar02.Name = "tbAuxiliar02";
            this.tbAuxiliar02.Size = new System.Drawing.Size(208, 25);
            this.tbAuxiliar02.TabIndex = 22;
            this.tbAuxiliar02.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAuxiliar02_KeyDown);
            this.tbAuxiliar02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAuxiliar02_KeyPress);
            // 
            // tbLblAuxiliar01
            // 
            this.tbLblAuxiliar01.BackColor = System.Drawing.Color.Transparent;
            this.tbLblAuxiliar01.Controls.Add(this.ibtnAuxiliar01Limpiar);
            this.tbLblAuxiliar01.Controls.Add(this.ibtnAuxiliar01Ok);
            this.tbLblAuxiliar01.Controls.Add(this.tbAuxiliar01);
            this.tbLblAuxiliar01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLblAuxiliar01.Font = new System.Drawing.Font("Roboto Black", 11F, System.Drawing.FontStyle.Bold);
            this.tbLblAuxiliar01.ForeColor = System.Drawing.Color.DarkBlue;
            this.tbLblAuxiliar01.Location = new System.Drawing.Point(227, 6);
            this.tbLblAuxiliar01.Name = "tbLblAuxiliar01";
            this.tbLblAuxiliar01.Size = new System.Drawing.Size(212, 60);
            this.tbLblAuxiliar01.TabIndex = 10;
            this.tbLblAuxiliar01.TabStop = false;
            this.tbLblAuxiliar01.Text = "Auxiliar";
            // 
            // ibtnAuxiliar01Limpiar
            // 
            this.ibtnAuxiliar01Limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnAuxiliar01Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnAuxiliar01Limpiar.FlatAppearance.BorderSize = 0;
            this.ibtnAuxiliar01Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnAuxiliar01Limpiar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnAuxiliar01Limpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnAuxiliar01Limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAuxiliar01Limpiar.IconSize = 18;
            this.ibtnAuxiliar01Limpiar.Location = new System.Drawing.Point(180, 21);
            this.ibtnAuxiliar01Limpiar.Name = "ibtnAuxiliar01Limpiar";
            this.ibtnAuxiliar01Limpiar.Size = new System.Drawing.Size(29, 25);
            this.ibtnAuxiliar01Limpiar.TabIndex = 3;
            this.ibtnAuxiliar01Limpiar.UseVisualStyleBackColor = true;
            // 
            // ibtnAuxiliar01Ok
            // 
            this.ibtnAuxiliar01Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnAuxiliar01Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnAuxiliar01Ok.FlatAppearance.BorderSize = 0;
            this.ibtnAuxiliar01Ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnAuxiliar01Ok.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.ibtnAuxiliar01Ok.IconColor = System.Drawing.SystemColors.Highlight;
            this.ibtnAuxiliar01Ok.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAuxiliar01Ok.IconSize = 20;
            this.ibtnAuxiliar01Ok.Location = new System.Drawing.Point(153, 21);
            this.ibtnAuxiliar01Ok.Name = "ibtnAuxiliar01Ok";
            this.ibtnAuxiliar01Ok.Size = new System.Drawing.Size(29, 25);
            this.ibtnAuxiliar01Ok.TabIndex = 5;
            this.ibtnAuxiliar01Ok.UseVisualStyleBackColor = true;
            // 
            // tbAuxiliar01
            // 
            this.tbAuxiliar01.BackColor = System.Drawing.SystemColors.Info;
            this.tbAuxiliar01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAuxiliar01.Location = new System.Drawing.Point(3, 21);
            this.tbAuxiliar01.Margin = new System.Windows.Forms.Padding(0);
            this.tbAuxiliar01.MaxLength = 4;
            this.tbAuxiliar01.Name = "tbAuxiliar01";
            this.tbAuxiliar01.Size = new System.Drawing.Size(206, 25);
            this.tbAuxiliar01.TabIndex = 22;
            this.tbAuxiliar01.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAuxiliar01_KeyDown);
            this.tbAuxiliar01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAuxiliar01_KeyPress);
            // 
            // tbLblOperario
            // 
            this.tbLblOperario.BackColor = System.Drawing.Color.Transparent;
            this.tbLblOperario.Controls.Add(this.ibtnOperarioOk);
            this.tbLblOperario.Controls.Add(this.ibtnOperarioLimpiar);
            this.tbLblOperario.Controls.Add(this.tbOperario);
            this.tbLblOperario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLblOperario.Font = new System.Drawing.Font("Roboto Black", 11F, System.Drawing.FontStyle.Bold);
            this.tbLblOperario.ForeColor = System.Drawing.Color.DarkBlue;
            this.tbLblOperario.Location = new System.Drawing.Point(6, 6);
            this.tbLblOperario.Name = "tbLblOperario";
            this.tbLblOperario.Size = new System.Drawing.Size(212, 60);
            this.tbLblOperario.TabIndex = 9;
            this.tbLblOperario.TabStop = false;
            this.tbLblOperario.Text = "Operario *";
            // 
            // ibtnOperarioOk
            // 
            this.ibtnOperarioOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnOperarioOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnOperarioOk.FlatAppearance.BorderSize = 0;
            this.ibtnOperarioOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnOperarioOk.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.ibtnOperarioOk.IconColor = System.Drawing.SystemColors.Highlight;
            this.ibtnOperarioOk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnOperarioOk.IconSize = 20;
            this.ibtnOperarioOk.Location = new System.Drawing.Point(153, 21);
            this.ibtnOperarioOk.Name = "ibtnOperarioOk";
            this.ibtnOperarioOk.Size = new System.Drawing.Size(29, 25);
            this.ibtnOperarioOk.TabIndex = 5;
            this.ibtnOperarioOk.UseVisualStyleBackColor = true;
            // 
            // ibtnOperarioLimpiar
            // 
            this.ibtnOperarioLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnOperarioLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnOperarioLimpiar.FlatAppearance.BorderSize = 0;
            this.ibtnOperarioLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnOperarioLimpiar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnOperarioLimpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnOperarioLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnOperarioLimpiar.IconSize = 18;
            this.ibtnOperarioLimpiar.Location = new System.Drawing.Point(180, 21);
            this.ibtnOperarioLimpiar.Name = "ibtnOperarioLimpiar";
            this.ibtnOperarioLimpiar.Size = new System.Drawing.Size(29, 25);
            this.ibtnOperarioLimpiar.TabIndex = 3;
            this.ibtnOperarioLimpiar.UseVisualStyleBackColor = true;
            // 
            // tbOperario
            // 
            this.tbOperario.BackColor = System.Drawing.SystemColors.Info;
            this.tbOperario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOperario.Location = new System.Drawing.Point(3, 21);
            this.tbOperario.Margin = new System.Windows.Forms.Padding(0);
            this.tbOperario.MaxLength = 4;
            this.tbOperario.Name = "tbOperario";
            this.tbOperario.Size = new System.Drawing.Size(206, 25);
            this.tbOperario.TabIndex = 21;
            this.tbOperario.TextChanged += new System.EventHandler(this.tbOperario_TextChanged);
            this.tbOperario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbOperario_KeyDown);
            this.tbOperario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOperario_KeyPress);
            // 
            // tlpPie
            // 
            this.tlpPie.BackColor = System.Drawing.Color.Transparent;
            this.tlpPie.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlpPie.ColumnCount = 2;
            this.tlpPie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPie.Controls.Add(this.btnReEtiquetar, 0, 0);
            this.tlpPie.Controls.Add(this.btnSalirReEtiquetado, 1, 0);
            this.tlpPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpPie.Location = new System.Drawing.Point(0, 146);
            this.tlpPie.Name = "tlpPie";
            this.tlpPie.RowCount = 1;
            this.tlpPie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPie.Size = new System.Drawing.Size(668, 56);
            this.tlpPie.TabIndex = 41;
            // 
            // btnReEtiquetar
            // 
            this.btnReEtiquetar.BackColor = System.Drawing.Color.Transparent;
            this.btnReEtiquetar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnReEtiquetar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.btnReEtiquetar.BorderRadius = 4;
            this.btnReEtiquetar.BorderSize = 2;
            this.btnReEtiquetar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReEtiquetar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReEtiquetar.FlatAppearance.BorderSize = 0;
            this.btnReEtiquetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReEtiquetar.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReEtiquetar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.btnReEtiquetar.Location = new System.Drawing.Point(5, 5);
            this.btnReEtiquetar.Name = "btnReEtiquetar";
            this.btnReEtiquetar.Size = new System.Drawing.Size(325, 46);
            this.btnReEtiquetar.TabIndex = 2;
            this.btnReEtiquetar.Text = "ReEtiquetar";
            this.btnReEtiquetar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.btnReEtiquetar.UseVisualStyleBackColor = false;
            this.btnReEtiquetar.Click += new System.EventHandler(this.btnReEtiquetar_Click);
            // 
            // btnSalirReEtiquetado
            // 
            this.btnSalirReEtiquetado.BackColor = System.Drawing.Color.Transparent;
            this.btnSalirReEtiquetado.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSalirReEtiquetado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnSalirReEtiquetado.BorderRadius = 4;
            this.btnSalirReEtiquetado.BorderSize = 2;
            this.btnSalirReEtiquetado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirReEtiquetado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalirReEtiquetado.FlatAppearance.BorderSize = 0;
            this.btnSalirReEtiquetado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirReEtiquetado.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirReEtiquetado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnSalirReEtiquetado.Location = new System.Drawing.Point(338, 5);
            this.btnSalirReEtiquetado.Name = "btnSalirReEtiquetado";
            this.btnSalirReEtiquetado.Size = new System.Drawing.Size(325, 46);
            this.btnSalirReEtiquetado.TabIndex = 3;
            this.btnSalirReEtiquetado.Text = "Salir";
            this.btnSalirReEtiquetado.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnSalirReEtiquetado.UseVisualStyleBackColor = false;
            this.btnSalirReEtiquetado.Click += new System.EventHandler(this.btnSalirReEtiquetado_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.11506F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.88494F));
            this.tableLayoutPanel2.Controls.Add(this.panel9, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(670, 42);
            this.tableLayoutPanel2.TabIndex = 42;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.lblEmpresa);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(40, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(328, 42);
            this.panel9.TabIndex = 32;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmpresa.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblEmpresa.Location = new System.Drawing.Point(0, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(328, 42);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "SANLUFILM - Reetiquetar bultos";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formReEtiquetar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 270);
            this.Controls.Add(this.pnlOpPrincipal);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(670, 270);
            this.Name = "formReEtiquetar";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formReEtiquetar";
            this.pnlOpPrincipal.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.lblHasta.ResumeLayout(false);
            this.lblDesde.ResumeLayout(false);
            this.tlpAuxiliares.ResumeLayout(false);
            this.tbLblAuxiliar02.ResumeLayout(false);
            this.tbLblAuxiliar02.PerformLayout();
            this.tbLblAuxiliar01.ResumeLayout(false);
            this.tbLblAuxiliar01.PerformLayout();
            this.tbLblOperario.ResumeLayout(false);
            this.tbLblOperario.PerformLayout();
            this.tlpPie.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpPrincipal;
        private System.Windows.Forms.ComboBox cbDesdeBobina;
        private System.Windows.Forms.ComboBox cbHastaBobina;
        private System.Windows.Forms.TextBox tbOperario;
        private System.Windows.Forms.TextBox tbAuxiliar01;
        private System.Windows.Forms.TextBox tbAuxiliar02;
        private System.Windows.Forms.TableLayoutPanel tlpPie;
        private AFControles.AFButton btnReEtiquetar;
        private AFControles.AFButton btnSalirReEtiquetado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TableLayoutPanel tlpAuxiliares;
        private System.Windows.Forms.GroupBox tbLblAuxiliar02;
        private FontAwesome.Sharp.IconButton ibtnAuxiliar02Ok;
        private FontAwesome.Sharp.IconButton ibtnAuxiliar02Limpiar;
        private System.Windows.Forms.GroupBox tbLblAuxiliar01;
        private FontAwesome.Sharp.IconButton ibtnAuxiliar01Ok;
        private FontAwesome.Sharp.IconButton ibtnAuxiliar01Limpiar;
        private System.Windows.Forms.GroupBox tbLblOperario;
        private FontAwesome.Sharp.IconButton ibtnOperarioOk;
        private FontAwesome.Sharp.IconButton ibtnOperarioLimpiar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox lblHasta;
        private System.Windows.Forms.GroupBox lblDesde;
    }
}