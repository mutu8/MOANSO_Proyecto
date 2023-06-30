
namespace CapaPresentacion
{
    partial class frmLL
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLL));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnTC = new FontAwesome.Sharp.IconButton();
            this.btnTL = new FontAwesome.Sharp.IconButton();
            this.btnContratos = new FontAwesome.Sharp.IconButton();
            this.btnLicencias = new FontAwesome.Sharp.IconButton();
            this.btnAsistencias = new FontAwesome.Sharp.IconButton();
            this.btnCargos = new FontAwesome.Sharp.IconButton();
            this.btnEmpleados = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.logoGRS = new System.Windows.Forms.PictureBox();
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.test = new System.Windows.Forms.Label();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdLicencia = new System.Windows.Forms.TextBox();
            this.chkEstC = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoLicencia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoGRS)).BeginInit();
            this.barraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.btnTC);
            this.panelMenu.Controls.Add(this.btnTL);
            this.panelMenu.Controls.Add(this.btnContratos);
            this.panelMenu.Controls.Add(this.btnLicencias);
            this.panelMenu.Controls.Add(this.btnAsistencias);
            this.panelMenu.Controls.Add(this.btnCargos);
            this.panelMenu.Controls.Add(this.btnEmpleados);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 568);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 509);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(180, 59);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.Text = "Salir";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnTC
            // 
            this.btnTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.btnTC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTC.FlatAppearance.BorderSize = 0;
            this.btnTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTC.IconChar = FontAwesome.Sharp.IconChar.LinesLeaning;
            this.btnTC.IconColor = System.Drawing.Color.White;
            this.btnTC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTC.IconSize = 32;
            this.btnTC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTC.Location = new System.Drawing.Point(0, 450);
            this.btnTC.Name = "btnTC";
            this.btnTC.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTC.Size = new System.Drawing.Size(180, 59);
            this.btnTC.TabIndex = 12;
            this.btnTC.Text = "Tipos de contratos";
            this.btnTC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTC.UseVisualStyleBackColor = false;
            this.btnTC.Click += new System.EventHandler(this.btnTC_Click);
            // 
            // btnTL
            // 
            this.btnTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.btnTL.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTL.FlatAppearance.BorderSize = 0;
            this.btnTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTL.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnTL.IconColor = System.Drawing.Color.White;
            this.btnTL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTL.IconSize = 32;
            this.btnTL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTL.Location = new System.Drawing.Point(0, 391);
            this.btnTL.Name = "btnTL";
            this.btnTL.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTL.Size = new System.Drawing.Size(180, 59);
            this.btnTL.TabIndex = 7;
            this.btnTL.Text = "Tipos de licencias";
            this.btnTL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTL.UseVisualStyleBackColor = false;
            this.btnTL.Click += new System.EventHandler(this.btnTL_Click);
            // 
            // btnContratos
            // 
            this.btnContratos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.btnContratos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContratos.FlatAppearance.BorderSize = 0;
            this.btnContratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContratos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnContratos.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.btnContratos.IconColor = System.Drawing.Color.White;
            this.btnContratos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContratos.IconSize = 32;
            this.btnContratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContratos.Location = new System.Drawing.Point(0, 331);
            this.btnContratos.Name = "btnContratos";
            this.btnContratos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnContratos.Size = new System.Drawing.Size(180, 60);
            this.btnContratos.TabIndex = 5;
            this.btnContratos.Text = "Contratos";
            this.btnContratos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContratos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContratos.UseVisualStyleBackColor = false;
            this.btnContratos.Click += new System.EventHandler(this.btnContratos_Click);
            // 
            // btnLicencias
            // 
            this.btnLicencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.btnLicencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLicencias.FlatAppearance.BorderSize = 0;
            this.btnLicencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLicencias.ForeColor = System.Drawing.Color.Transparent;
            this.btnLicencias.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.btnLicencias.IconColor = System.Drawing.Color.White;
            this.btnLicencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLicencias.IconSize = 32;
            this.btnLicencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLicencias.Location = new System.Drawing.Point(0, 271);
            this.btnLicencias.Name = "btnLicencias";
            this.btnLicencias.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLicencias.Size = new System.Drawing.Size(180, 60);
            this.btnLicencias.TabIndex = 4;
            this.btnLicencias.Text = "Licencias laborales";
            this.btnLicencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLicencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLicencias.UseVisualStyleBackColor = false;
            this.btnLicencias.Click += new System.EventHandler(this.btnLicencias_Click);
            // 
            // btnAsistencias
            // 
            this.btnAsistencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.btnAsistencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsistencias.FlatAppearance.BorderSize = 0;
            this.btnAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencias.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAsistencias.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnAsistencias.IconColor = System.Drawing.Color.White;
            this.btnAsistencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAsistencias.IconSize = 32;
            this.btnAsistencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistencias.Location = new System.Drawing.Point(0, 211);
            this.btnAsistencias.Name = "btnAsistencias";
            this.btnAsistencias.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAsistencias.Size = new System.Drawing.Size(180, 60);
            this.btnAsistencias.TabIndex = 3;
            this.btnAsistencias.Text = "Asistencia";
            this.btnAsistencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsistencias.UseVisualStyleBackColor = false;
            this.btnAsistencias.Click += new System.EventHandler(this.btnAsistencias_Click);
            // 
            // btnCargos
            // 
            this.btnCargos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.btnCargos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargos.FlatAppearance.BorderSize = 0;
            this.btnCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCargos.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.btnCargos.IconColor = System.Drawing.Color.White;
            this.btnCargos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargos.IconSize = 32;
            this.btnCargos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargos.Location = new System.Drawing.Point(0, 151);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCargos.Size = new System.Drawing.Size(180, 60);
            this.btnCargos.TabIndex = 2;
            this.btnCargos.Text = "Cargos";
            this.btnCargos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargos.UseVisualStyleBackColor = false;
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnEmpleados.IconColor = System.Drawing.Color.White;
            this.btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleados.IconSize = 32;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 91);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(180, 60);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.panelLogo.Controls.Add(this.logoGRS);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(180, 91);
            this.panelLogo.TabIndex = 0;
            // 
            // logoGRS
            // 
            this.logoGRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.logoGRS.Image = ((System.Drawing.Image)(resources.GetObject("logoGRS.Image")));
            this.logoGRS.Location = new System.Drawing.Point(3, 0);
            this.logoGRS.Name = "logoGRS";
            this.logoGRS.Size = new System.Drawing.Size(177, 88);
            this.logoGRS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoGRS.TabIndex = 1;
            this.logoGRS.TabStop = false;
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.barraSuperior.Controls.Add(this.test);
            this.barraSuperior.Controls.Add(this.btnHome);
            this.barraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraSuperior.Location = new System.Drawing.Point(180, 0);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(1029, 91);
            this.barraSuperior.TabIndex = 1;
            this.barraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraSuperior_MouseDown);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.test.Location = new System.Drawing.Point(269, 17);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(512, 49);
            this.test.TabIndex = 4;
            this.test.Text = "Registro de licencias laborales";
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 50;
            this.btnHome.Location = new System.Drawing.Point(937, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Size = new System.Drawing.Size(92, 91);
            this.btnHome.TabIndex = 2;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1029, 477);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(247, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(919, 165);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.dgvConsulta);
            this.groupBox2.Controls.Add(this.txtConsulta);
            this.groupBox2.Controls.Add(this.btnConsultar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(767, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 288);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultas";
            // 
            // txtConsulta
            // 
            this.txtConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtConsulta.Location = new System.Drawing.Point(33, 28);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(187, 30);
            this.txtConsulta.TabIndex = 21;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultar.Location = new System.Drawing.Point(235, 28);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(164, 30);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Buscar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.txtIdLicencia);
            this.groupBox1.Controls.Add(this.chkEstC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblHora);
            this.groupBox1.Controls.Add(this.dateTimePickerFin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickerInicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboTipoLicencia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnDeshabilitar);
            this.groupBox1.Controls.Add(this.cboEmpleado);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(186, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 288);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // txtIdLicencia
            // 
            this.txtIdLicencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtIdLicencia.Location = new System.Drawing.Point(187, 249);
            this.txtIdLicencia.Multiline = true;
            this.txtIdLicencia.Name = "txtIdLicencia";
            this.txtIdLicencia.Size = new System.Drawing.Size(187, 30);
            this.txtIdLicencia.TabIndex = 26;
            // 
            // chkEstC
            // 
            this.chkEstC.AutoSize = true;
            this.chkEstC.Location = new System.Drawing.Point(18, 220);
            this.chkEstC.Name = "chkEstC";
            this.chkEstC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkEstC.Size = new System.Drawing.Size(79, 20);
            this.chkEstC.TabIndex = 25;
            this.chkEstC.Text = "Vigente";
            this.chkEstC.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(15, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Hora de realización";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHora.Location = new System.Drawing.Point(184, 187);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(367, 16);
            this.lblHora.TabIndex = 23;
            this.lblHora.Text = "_____________________________________________";
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(187, 152);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(361, 22);
            this.dateTimePickerFin.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(19, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fecha fin";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(187, 109);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(361, 22);
            this.dateTimePickerInicio.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(15, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fecha Inicio";
            // 
            // cboTipoLicencia
            // 
            this.cboTipoLicencia.FormattingEnabled = true;
            this.cboTipoLicencia.Location = new System.Drawing.Point(187, 69);
            this.cboTipoLicencia.Name = "cboTipoLicencia";
            this.cboTipoLicencia.Size = new System.Drawing.Size(361, 24);
            this.cboTipoLicencia.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(15, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tipo de licencia";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeshabilitar.Location = new System.Drawing.Point(391, 249);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(157, 30);
            this.btnDeshabilitar.TabIndex = 16;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(187, 30);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(361, 24);
            this.cboEmpleado.TabIndex = 14;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrar.Location = new System.Drawing.Point(18, 249);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(157, 30);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(33, 75);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(366, 165);
            this.dgvConsulta.TabIndex = 22;
            // 
            // frmLL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1209, 568);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.barraSuperior);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoGRS)).EndInit();
            this.barraSuperior.ResumeLayout(false);
            this.barraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnContratos;
        private FontAwesome.Sharp.IconButton btnLicencias;
        private FontAwesome.Sharp.IconButton btnAsistencias;
        private FontAwesome.Sharp.IconButton btnCargos;
        private FontAwesome.Sharp.IconButton btnEmpleados;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox logoGRS;
        private System.Windows.Forms.Panel barraSuperior;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label test;
        private FontAwesome.Sharp.IconButton btnTL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTipoLicencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnTC;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.CheckBox chkEstC;
        private System.Windows.Forms.TextBox txtIdLicencia;
        private System.Windows.Forms.DataGridView dgvConsulta;
    }
}

