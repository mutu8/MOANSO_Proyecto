
namespace CapaPresentacion
{
    partial class frmTiposLicencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposLicencia));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLicenciaCompensada = new System.Windows.Forms.CheckBox();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTL = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoGRS)).BeginInit();
            this.barraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).BeginInit();
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
            this.panelMenu.Size = new System.Drawing.Size(180, 571);
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
            this.logoGRS.Size = new System.Drawing.Size(177, 91);
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
            this.barraSuperior.Size = new System.Drawing.Size(618, 91);
            this.barraSuperior.TabIndex = 1;
            this.barraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraSuperior_MouseDown);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.test.Location = new System.Drawing.Point(33, 25);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(496, 49);
            this.test.TabIndex = 4;
            this.test.Text = "Registro de tipos de licencias";
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
            this.btnHome.Location = new System.Drawing.Point(528, 0);
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
            this.pictureBox1.Size = new System.Drawing.Size(618, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.chkLicenciaCompensada);
            this.groupBox1.Controls.Add(this.btnDeshabilitar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(186, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 162);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // chkLicenciaCompensada
            // 
            this.chkLicenciaCompensada.AutoSize = true;
            this.chkLicenciaCompensada.Location = new System.Drawing.Point(21, 75);
            this.chkLicenciaCompensada.Name = "chkLicenciaCompensada";
            this.chkLicenciaCompensada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkLicenciaCompensada.Size = new System.Drawing.Size(118, 20);
            this.chkLicenciaCompensada.TabIndex = 18;
            this.chkLicenciaCompensada.Text = "Compensada";
            this.chkLicenciaCompensada.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeshabilitar.Location = new System.Drawing.Point(391, 114);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(157, 30);
            this.btnDeshabilitar.TabIndex = 16;
            this.btnDeshabilitar.Text = "Eliminar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.Location = new System.Drawing.Point(207, 114);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(157, 30);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrar.Location = new System.Drawing.Point(18, 114);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(157, 30);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNombre.Location = new System.Drawing.Point(187, 31);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(361, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // dgvTL
            // 
            this.dgvTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTL.Location = new System.Drawing.Point(330, 265);
            this.dgvTL.Name = "dgvTL";
            this.dgvTL.Size = new System.Drawing.Size(344, 294);
            this.dgvTL.TabIndex = 12;
            this.dgvTL.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTL_CellDoubleClick);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtID.Location = new System.Drawing.Point(187, 72);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(361, 23);
            this.txtID.TabIndex = 19;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(18, 114);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 30);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmTiposLicencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(798, 571);
            this.Controls.Add(this.dgvTL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.barraSuperior);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTiposLicencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoGRS)).EndInit();
            this.barraSuperior.ResumeLayout(false);
            this.barraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.DataGridView dgvTL;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnTL;
        private System.Windows.Forms.Button btnModificar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnTC;
        private System.Windows.Forms.CheckBox chkLicenciaCompensada;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnGuardar;
    }
}

