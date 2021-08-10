
namespace UI.Desktop
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnAcerdaDe = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.btnInscripcion = new System.Windows.Forms.Button();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.panelPerfil = new System.Windows.Forms.Panel();
            this.lblPersona = new System.Windows.Forms.Label();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.panelAdminReportes = new System.Windows.Forms.Panel();
            this.btnReporteCursos = new System.Windows.Forms.Button();
            this.btnReportePlanes = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.btnEspecialidades = new System.Windows.Forms.Button();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnPersonas = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.panelAdminReportes.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.btnAcerdaDe);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnNotas);
            this.panelMenu.Controls.Add(this.btnInscripcion);
            this.panelMenu.Controls.Add(this.btnAdministracion);
            this.panelMenu.Controls.Add(this.panelPerfil);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 32);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(188, 499);
            this.panelMenu.TabIndex = 3;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.btnCerrarSesion.Image = global::UI.Desktop.Properties.Resources.sign_out_32;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 453);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarSesion.Size = new System.Drawing.Size(188, 46);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnAcerdaDe
            // 
            this.btnAcerdaDe.AutoSize = true;
            this.btnAcerdaDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcerdaDe.FlatAppearance.BorderSize = 0;
            this.btnAcerdaDe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.btnAcerdaDe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.btnAcerdaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcerdaDe.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcerdaDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.btnAcerdaDe.Image = global::UI.Desktop.Properties.Resources.info_32;
            this.btnAcerdaDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcerdaDe.Location = new System.Drawing.Point(0, 387);
            this.btnAcerdaDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAcerdaDe.Name = "btnAcerdaDe";
            this.btnAcerdaDe.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAcerdaDe.Size = new System.Drawing.Size(188, 46);
            this.btnAcerdaDe.TabIndex = 5;
            this.btnAcerdaDe.Text = "Acerca De";
            this.btnAcerdaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcerdaDe.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            this.btnReportes.AutoSize = true;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.btnReportes.Image = global::UI.Desktop.Properties.Resources.report_32;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 341);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReportes.Size = new System.Drawing.Size(188, 46);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Visible = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            this.btnReportes.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnNotas
            // 
            this.btnNotas.AutoSize = true;
            this.btnNotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotas.FlatAppearance.BorderSize = 0;
            this.btnNotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.btnNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotas.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.btnNotas.Image = global::UI.Desktop.Properties.Resources.exam_32;
            this.btnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotas.Location = new System.Drawing.Point(0, 295);
            this.btnNotas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNotas.Size = new System.Drawing.Size(188, 46);
            this.btnNotas.TabIndex = 5;
            this.btnNotas.Text = "Registrar Notas";
            this.btnNotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Visible = false;
            // 
            // btnInscripcion
            // 
            this.btnInscripcion.AutoSize = true;
            this.btnInscripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInscripcion.FlatAppearance.BorderSize = 0;
            this.btnInscripcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.btnInscripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.btnInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscripcion.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.btnInscripcion.Image = global::UI.Desktop.Properties.Resources.test_passed_32;
            this.btnInscripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscripcion.Location = new System.Drawing.Point(0, 249);
            this.btnInscripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInscripcion.Size = new System.Drawing.Size(188, 46);
            this.btnInscripcion.TabIndex = 5;
            this.btnInscripcion.Text = "Inscripcion";
            this.btnInscripcion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInscripcion.UseVisualStyleBackColor = true;
            this.btnInscripcion.Visible = false;
            this.btnInscripcion.Click += new System.EventHandler(this.btnInscripcion_Click);
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.AutoSize = true;
            this.btnAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministracion.FlatAppearance.BorderSize = 0;
            this.btnAdministracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.btnAdministracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministracion.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.btnAdministracion.Image = global::UI.Desktop.Properties.Resources.microsoft_admin_32;
            this.btnAdministracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministracion.Location = new System.Drawing.Point(0, 203);
            this.btnAdministracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdministracion.Size = new System.Drawing.Size(188, 46);
            this.btnAdministracion.TabIndex = 5;
            this.btnAdministracion.Text = "Administracion";
            this.btnAdministracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdministracion.UseVisualStyleBackColor = true;
            this.btnAdministracion.Visible = false;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            this.btnAdministracion.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // panelPerfil
            // 
            this.panelPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.panelPerfil.Controls.Add(this.lblPersona);
            this.panelPerfil.Controls.Add(this.picPerfil);
            this.panelPerfil.Controls.Add(this.lblLegajo);
            this.panelPerfil.Controls.Add(this.lblUsuario);
            this.panelPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPerfil.Location = new System.Drawing.Point(0, 0);
            this.panelPerfil.Margin = new System.Windows.Forms.Padding(0);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(188, 203);
            this.panelPerfil.TabIndex = 4;
            // 
            // lblPersona
            // 
            this.lblPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersona.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblPersona.Location = new System.Drawing.Point(0, 159);
            this.lblPersona.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(188, 19);
            this.lblPersona.TabIndex = 3;
            this.lblPersona.Text = "Persona:";
            this.lblPersona.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picPerfil
            // 
            this.picPerfil.BackColor = System.Drawing.Color.Transparent;
            this.picPerfil.Image = global::UI.Desktop.Properties.Resources.profile_128;
            this.picPerfil.Location = new System.Drawing.Point(56, 12);
            this.picPerfil.Margin = new System.Windows.Forms.Padding(11, 12, 11, 0);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(75, 81);
            this.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPerfil.TabIndex = 2;
            this.picPerfil.TabStop = false;
            // 
            // lblLegajo
            // 
            this.lblLegajo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLegajo.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblLegajo.Location = new System.Drawing.Point(0, 132);
            this.lblLegajo.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(188, 19);
            this.lblLegajo.TabIndex = 1;
            this.lblLegajo.Text = "Legajo:";
            this.lblLegajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblUsuario.Location = new System.Drawing.Point(0, 106);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(188, 19);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panelTitulo.Controls.Add(this.txtBusqueda);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(188, 32);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(624, 81);
            this.panelTitulo.TabIndex = 4;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBusqueda.Location = new System.Drawing.Point(436, 32);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(8, 8, 38, 8);
            this.txtBusqueda.Multiline = true;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(150, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.Text = "Busqueda";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblTitulo.Location = new System.Drawing.Point(6, 14);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(117, 51);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panelFormLoader.BackgroundImage = global::UI.Desktop.Properties.Resources.graduation_cap_main;
            this.panelFormLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormLoader.Location = new System.Drawing.Point(188, 113);
            this.panelFormLoader.Margin = new System.Windows.Forms.Padding(0);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.panelFormLoader.Size = new System.Drawing.Size(624, 377);
            this.panelFormLoader.TabIndex = 8;
            this.panelFormLoader.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelFormLoader_ControlAdded);
            this.panelFormLoader.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panelFormLoader_ControlRemoved);
            // 
            // panelAdminReportes
            // 
            this.panelAdminReportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelAdminReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.panelAdminReportes.Controls.Add(this.btnReporteCursos);
            this.panelAdminReportes.Controls.Add(this.btnReportePlanes);
            this.panelAdminReportes.Controls.Add(this.btnCursos);
            this.panelAdminReportes.Controls.Add(this.btnMaterias);
            this.panelAdminReportes.Controls.Add(this.btnPlanes);
            this.panelAdminReportes.Controls.Add(this.btnEspecialidades);
            this.panelAdminReportes.Controls.Add(this.btnDocentes);
            this.panelAdminReportes.Controls.Add(this.btnAlumnos);
            this.panelAdminReportes.Controls.Add(this.btnPersonas);
            this.panelAdminReportes.Controls.Add(this.btnUsuarios);
            this.panelAdminReportes.Location = new System.Drawing.Point(188, 32);
            this.panelAdminReportes.Margin = new System.Windows.Forms.Padding(0);
            this.panelAdminReportes.Name = "panelAdminReportes";
            this.panelAdminReportes.Size = new System.Drawing.Size(188, 498);
            this.panelAdminReportes.TabIndex = 9;
            this.panelAdminReportes.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnReporteCursos
            // 
            this.btnReporteCursos.AutoSize = true;
            this.btnReporteCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteCursos.FlatAppearance.BorderSize = 0;
            this.btnReporteCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteCursos.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnReporteCursos.Location = new System.Drawing.Point(0, 369);
            this.btnReporteCursos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReporteCursos.Name = "btnReporteCursos";
            this.btnReporteCursos.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnReporteCursos.Size = new System.Drawing.Size(188, 41);
            this.btnReporteCursos.TabIndex = 15;
            this.btnReporteCursos.Text = "Reportes Cursos";
            this.btnReporteCursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporteCursos.UseVisualStyleBackColor = true;
            this.btnReporteCursos.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnReportePlanes
            // 
            this.btnReportePlanes.AutoSize = true;
            this.btnReportePlanes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportePlanes.FlatAppearance.BorderSize = 0;
            this.btnReportePlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportePlanes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportePlanes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnReportePlanes.Location = new System.Drawing.Point(0, 328);
            this.btnReportePlanes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReportePlanes.Name = "btnReportePlanes";
            this.btnReportePlanes.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnReportePlanes.Size = new System.Drawing.Size(188, 41);
            this.btnReportePlanes.TabIndex = 14;
            this.btnReportePlanes.Text = "Reportes Planes";
            this.btnReportePlanes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportePlanes.UseVisualStyleBackColor = true;
            this.btnReportePlanes.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnCursos
            // 
            this.btnCursos.AutoSize = true;
            this.btnCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCursos.FlatAppearance.BorderSize = 0;
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCursos.Location = new System.Drawing.Point(0, 287);
            this.btnCursos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnCursos.Size = new System.Drawing.Size(188, 41);
            this.btnCursos.TabIndex = 13;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            this.btnCursos.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnMaterias
            // 
            this.btnMaterias.AutoSize = true;
            this.btnMaterias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterias.FlatAppearance.BorderSize = 0;
            this.btnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterias.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnMaterias.Location = new System.Drawing.Point(0, 246);
            this.btnMaterias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnMaterias.Size = new System.Drawing.Size(188, 41);
            this.btnMaterias.TabIndex = 12;
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaterias.UseVisualStyleBackColor = true;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            this.btnMaterias.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnPlanes
            // 
            this.btnPlanes.AutoSize = true;
            this.btnPlanes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlanes.FlatAppearance.BorderSize = 0;
            this.btnPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnPlanes.Location = new System.Drawing.Point(0, 205);
            this.btnPlanes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnPlanes.Size = new System.Drawing.Size(188, 41);
            this.btnPlanes.TabIndex = 11;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlanes.UseVisualStyleBackColor = true;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            this.btnPlanes.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.AutoSize = true;
            this.btnEspecialidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEspecialidades.FlatAppearance.BorderSize = 0;
            this.btnEspecialidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspecialidades.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspecialidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnEspecialidades.Location = new System.Drawing.Point(0, 164);
            this.btnEspecialidades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnEspecialidades.Size = new System.Drawing.Size(188, 41);
            this.btnEspecialidades.TabIndex = 10;
            this.btnEspecialidades.Text = "Especialidades";
            this.btnEspecialidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEspecialidades.UseVisualStyleBackColor = true;
            this.btnEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            this.btnEspecialidades.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnDocentes
            // 
            this.btnDocentes.AutoSize = true;
            this.btnDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocentes.FlatAppearance.BorderSize = 0;
            this.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocentes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDocentes.Location = new System.Drawing.Point(0, 123);
            this.btnDocentes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnDocentes.Size = new System.Drawing.Size(188, 41);
            this.btnDocentes.TabIndex = 9;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocentes.UseVisualStyleBackColor = true;
            this.btnDocentes.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.AutoSize = true;
            this.btnAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnAlumnos.Location = new System.Drawing.Point(0, 82);
            this.btnAlumnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnAlumnos.Size = new System.Drawing.Size(188, 41);
            this.btnAlumnos.TabIndex = 8;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnPersonas
            // 
            this.btnPersonas.AutoSize = true;
            this.btnPersonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonas.FlatAppearance.BorderSize = 0;
            this.btnPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonas.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnPersonas.Location = new System.Drawing.Point(0, 41);
            this.btnPersonas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnPersonas.Size = new System.Drawing.Size(188, 41);
            this.btnPersonas.TabIndex = 7;
            this.btnPersonas.Text = "Personas";
            this.btnPersonas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonas.UseVisualStyleBackColor = true;
            this.btnPersonas.Click += new System.EventHandler(this.btnPersonas_Click);
            this.btnPersonas.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AutoSize = true;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnUsuarios.Size = new System.Drawing.Size(188, 41);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.btnUsuarios.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.panelTop.Controls.Add(this.btnMinimizar);
            this.panelTop.Controls.Add(this.btnMaximizar);
            this.panelTop.Controls.Add(this.btnCerrar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(812, 32);
            this.panelTop.TabIndex = 10;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::UI.Desktop.Properties.Resources.minimize_window_32;
            this.btnMinimizar.Location = new System.Drawing.Point(722, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnMinimizar.Size = new System.Drawing.Size(30, 32);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::UI.Desktop.Properties.Resources.maximize_window_32;
            this.btnMaximizar.Location = new System.Drawing.Point(752, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnMaximizar.Size = new System.Drawing.Size(30, 32);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::UI.Desktop.Properties.Resources.delete_32;
            this.btnCerrar.Location = new System.Drawing.Point(782, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.btnCerrar.Size = new System.Drawing.Size(30, 32);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panelBottom.Controls.Add(this.btnActualizar);
            this.panelBottom.Controls.Add(this.btnSalir);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(188, 490);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(624, 41);
            this.panelBottom.TabIndex = 12;
            this.panelBottom.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.Location = new System.Drawing.Point(490, 10);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(63, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.AutoSize = true;
            this.btnSalir.Location = new System.Drawing.Point(560, 10);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(812, 531);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelAdminReportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelPerfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelAdminReportes.ResumeLayout(false);
            this.panelAdminReportes.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnAcerdaDe;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox picPerfil;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Panel panelFormLoader;
        private System.Windows.Forms.Panel panelAdminReportes;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnPersonas;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnReporteCursos;
        private System.Windows.Forms.Button btnReportePlanes;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblPersona;
    }
}