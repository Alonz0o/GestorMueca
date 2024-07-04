namespace EtiquetadoBultos
{
    partial class formAutorizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAutorizar));
            this.pnlOpPrincipal = new System.Windows.Forms.Panel();
            this.pnlBoton = new System.Windows.Forms.Panel();
            this.btnVerificarUsuario = new System.Windows.Forms.Button();
            this.gbContraseña = new System.Windows.Forms.GroupBox();
            this.pnlContrasena = new System.Windows.Forms.Panel();
            this.ibtnVerContrasena = new FontAwesome.Sharp.IconButton();
            this.ibtnContraseñaLimpiar = new FontAwesome.Sharp.IconButton();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.pnlSeparacion = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbEncargado = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ibtnSalirVerificacion = new FontAwesome.Sharp.IconButton();
            this.pnlOpPrincipal.SuspendLayout();
            this.pnlBoton.SuspendLayout();
            this.gbContraseña.SuspendLayout();
            this.pnlContrasena.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.pnlHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpPrincipal
            // 
            this.pnlOpPrincipal.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlOpPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpPrincipal.Controls.Add(this.pnlBoton);
            this.pnlOpPrincipal.Controls.Add(this.gbContraseña);
            this.pnlOpPrincipal.Controls.Add(this.pnlSeparacion);
            this.pnlOpPrincipal.Controls.Add(this.groupBox1);
            this.pnlOpPrincipal.Controls.Add(this.panel4);
            this.pnlOpPrincipal.Controls.Add(this.panel3);
            this.pnlOpPrincipal.Controls.Add(this.panel2);
            this.pnlOpPrincipal.Controls.Add(this.pnlHead);
            this.pnlOpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlOpPrincipal.Name = "pnlOpPrincipal";
            this.pnlOpPrincipal.Size = new System.Drawing.Size(364, 303);
            this.pnlOpPrincipal.TabIndex = 16;
            // 
            // pnlBoton
            // 
            this.pnlBoton.Controls.Add(this.btnVerificarUsuario);
            this.pnlBoton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBoton.Location = new System.Drawing.Point(0, 243);
            this.pnlBoton.Name = "pnlBoton";
            this.pnlBoton.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBoton.Size = new System.Drawing.Size(362, 59);
            this.pnlBoton.TabIndex = 20;
            // 
            // btnVerificarUsuario
            // 
            this.btnVerificarUsuario.BackColor = System.Drawing.Color.Maroon;
            this.btnVerificarUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerificarUsuario.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarUsuario.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnVerificarUsuario.Location = new System.Drawing.Point(5, 5);
            this.btnVerificarUsuario.Name = "btnVerificarUsuario";
            this.btnVerificarUsuario.Size = new System.Drawing.Size(352, 49);
            this.btnVerificarUsuario.TabIndex = 19;
            this.btnVerificarUsuario.Text = "Verificar";
            this.btnVerificarUsuario.UseVisualStyleBackColor = false;
            this.btnVerificarUsuario.Click += new System.EventHandler(this.btnVerificarUsuario_Click);
            // 
            // gbContraseña
            // 
            this.gbContraseña.BackColor = System.Drawing.Color.Transparent;
            this.gbContraseña.Controls.Add(this.pnlContrasena);
            this.gbContraseña.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbContraseña.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContraseña.ForeColor = System.Drawing.Color.DarkBlue;
            this.gbContraseña.Location = new System.Drawing.Point(0, 181);
            this.gbContraseña.Name = "gbContraseña";
            this.gbContraseña.Size = new System.Drawing.Size(362, 62);
            this.gbContraseña.TabIndex = 16;
            this.gbContraseña.TabStop = false;
            this.gbContraseña.Text = "Ingrese contraseña";
            // 
            // pnlContrasena
            // 
            this.pnlContrasena.Controls.Add(this.ibtnVerContrasena);
            this.pnlContrasena.Controls.Add(this.ibtnContraseñaLimpiar);
            this.pnlContrasena.Controls.Add(this.tbContraseña);
            this.pnlContrasena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContrasena.Location = new System.Drawing.Point(3, 23);
            this.pnlContrasena.Name = "pnlContrasena";
            this.pnlContrasena.Padding = new System.Windows.Forms.Padding(3);
            this.pnlContrasena.Size = new System.Drawing.Size(356, 36);
            this.pnlContrasena.TabIndex = 6;
            // 
            // ibtnVerContrasena
            // 
            this.ibtnVerContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnVerContrasena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnVerContrasena.FlatAppearance.BorderSize = 0;
            this.ibtnVerContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnVerContrasena.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.ibtnVerContrasena.IconColor = System.Drawing.Color.Black;
            this.ibtnVerContrasena.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnVerContrasena.IconSize = 25;
            this.ibtnVerContrasena.Location = new System.Drawing.Point(297, 3);
            this.ibtnVerContrasena.Name = "ibtnVerContrasena";
            this.ibtnVerContrasena.Size = new System.Drawing.Size(29, 27);
            this.ibtnVerContrasena.TabIndex = 20;
            this.ibtnVerContrasena.UseVisualStyleBackColor = true;
            this.ibtnVerContrasena.Click += new System.EventHandler(this.ibtnVerContrasena_Click);
            // 
            // ibtnContraseñaLimpiar
            // 
            this.ibtnContraseñaLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnContraseñaLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnContraseñaLimpiar.FlatAppearance.BorderSize = 0;
            this.ibtnContraseñaLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnContraseñaLimpiar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnContraseñaLimpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnContraseñaLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnContraseñaLimpiar.IconSize = 20;
            this.ibtnContraseñaLimpiar.Location = new System.Drawing.Point(325, 3);
            this.ibtnContraseñaLimpiar.Name = "ibtnContraseñaLimpiar";
            this.ibtnContraseñaLimpiar.Size = new System.Drawing.Size(29, 27);
            this.ibtnContraseñaLimpiar.TabIndex = 3;
            this.ibtnContraseñaLimpiar.UseVisualStyleBackColor = true;
            this.ibtnContraseñaLimpiar.Click += new System.EventHandler(this.ibtnContraseñaLimpiar_Click);
            // 
            // tbContraseña
            // 
            this.tbContraseña.BackColor = System.Drawing.SystemColors.Info;
            this.tbContraseña.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbContraseña.ForeColor = System.Drawing.Color.Black;
            this.tbContraseña.Location = new System.Drawing.Point(3, 3);
            this.tbContraseña.Margin = new System.Windows.Forms.Padding(0);
            this.tbContraseña.MaxLength = 20;
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(350, 27);
            this.tbContraseña.TabIndex = 19;
            this.tbContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbContraseña.UseSystemPasswordChar = true;
            this.tbContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbContraseña_KeyDown);
            // 
            // pnlSeparacion
            // 
            this.pnlSeparacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparacion.Location = new System.Drawing.Point(0, 171);
            this.pnlSeparacion.Name = "pnlSeparacion";
            this.pnlSeparacion.Size = new System.Drawing.Size(362, 10);
            this.pnlSeparacion.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 62);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autoridad pertinente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbEncargado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 23);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(356, 36);
            this.panel1.TabIndex = 6;
            // 
            // cbEncargado
            // 
            this.cbEncargado.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbEncargado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEncargado.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbEncargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncargado.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbEncargado.Location = new System.Drawing.Point(3, 3);
            this.cbEncargado.Name = "cbEncargado";
            this.cbEncargado.Size = new System.Drawing.Size(350, 27);
            this.cbEncargado.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(362, 10);
            this.panel4.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 36);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(362, 63);
            this.panel3.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblAlerta, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.iconPictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblAlerta
            // 
            this.lblAlerta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAlerta.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta.Location = new System.Drawing.Point(53, 0);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(300, 57);
            this.lblAlerta.TabIndex = 14;
            this.lblAlerta.Text = "Para ejecutar dicha acción se necesita autorización de un encargado o jefe de pro" +
    "ducción.";
            this.lblAlerta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Brown;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Brown;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 44;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(44, 51);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 15;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 10);
            this.panel2.TabIndex = 22;
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.Maroon;
            this.pnlHead.Controls.Add(this.lblTitulo);
            this.pnlHead.Controls.Add(this.ibtnSalirVerificacion);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Margin = new System.Windows.Forms.Padding(6);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(362, 26);
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
            this.lblTitulo.Size = new System.Drawing.Size(100, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Autorización";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ibtnSalirVerificacion
            // 
            this.ibtnSalirVerificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnSalirVerificacion.BackColor = System.Drawing.Color.Transparent;
            this.ibtnSalirVerificacion.FlatAppearance.BorderSize = 0;
            this.ibtnSalirVerificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSalirVerificacion.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ibtnSalirVerificacion.IconColor = System.Drawing.Color.AliceBlue;
            this.ibtnSalirVerificacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSalirVerificacion.IconSize = 20;
            this.ibtnSalirVerificacion.Location = new System.Drawing.Point(339, 3);
            this.ibtnSalirVerificacion.Name = "ibtnSalirVerificacion";
            this.ibtnSalirVerificacion.Size = new System.Drawing.Size(20, 20);
            this.ibtnSalirVerificacion.TabIndex = 12;
            this.ibtnSalirVerificacion.UseVisualStyleBackColor = false;
            this.ibtnSalirVerificacion.Click += new System.EventHandler(this.ibtnSalirVerificacion_Click);
            // 
            // formAutorizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 303);
            this.Controls.Add(this.pnlOpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAutorizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formAutorizar";
            this.Activated += new System.EventHandler(this.formAutorizar_Activated);
            this.pnlOpPrincipal.ResumeLayout(false);
            this.pnlBoton.ResumeLayout(false);
            this.gbContraseña.ResumeLayout(false);
            this.pnlContrasena.ResumeLayout(false);
            this.pnlContrasena.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpPrincipal;
        private System.Windows.Forms.GroupBox gbContraseña;
        private System.Windows.Forms.Panel pnlSeparacion;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton ibtnSalirVerificacion;
        private System.Windows.Forms.Panel pnlContrasena;
        private FontAwesome.Sharp.IconButton ibtnContraseñaLimpiar;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Panel pnlBoton;
        private System.Windows.Forms.Button btnVerificarUsuario;
        private FontAwesome.Sharp.IconButton ibtnVerContrasena;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbEncargado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAlerta;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}