
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.panelAdminReportes = new System.Windows.Forms.Panel();
            this.btnReportesPlanes = new System.Windows.Forms.Button();
            this.btnReportesCursos = new System.Windows.Forms.Button();
            this.btnABMUsuarios = new System.Windows.Forms.Button();
            this.btnABMPlanes = new System.Windows.Forms.Button();
            this.btnABMPersonas = new System.Windows.Forms.Button();
            this.btnABMMaterias = new System.Windows.Forms.Button();
            this.btnABMEspecialidades = new System.Windows.Forms.Button();
            this.btnABMDictados = new System.Windows.Forms.Button();
            this.btnABMCursos = new System.Windows.Forms.Button();
            this.btnABMComisiones = new System.Windows.Forms.Button();
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
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnNotas);
            this.panelMenu.Controls.Add(this.btnInscripcion);
            this.panelMenu.Controls.Add(this.btnAdministracion);
            this.panelMenu.Controls.Add(this.panelPerfil);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(188, 585);
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
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 539);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Size = new System.Drawing.Size(188, 46);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
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
            this.btnReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(4);
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
            this.btnNotas.Margin = new System.Windows.Forms.Padding(2);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Padding = new System.Windows.Forms.Padding(4);
            this.btnNotas.Size = new System.Drawing.Size(188, 46);
            this.btnNotas.TabIndex = 5;
            this.btnNotas.Text = "Registrar Notas";
            this.btnNotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Visible = false;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
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
            this.btnInscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Padding = new System.Windows.Forms.Padding(4);
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
            this.btnAdministracion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Padding = new System.Windows.Forms.Padding(4);
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
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(188, 32);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(772, 81);
            this.panelTitulo.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblTitulo.Location = new System.Drawing.Point(6, 14);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(117, 51);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.AllowDrop = true;
            this.panelFormLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panelFormLoader.BackgroundImage = global::UI.Desktop.Properties.Resources.graduation_cap_main;
            this.panelFormLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormLoader.Location = new System.Drawing.Point(188, 113);
            this.panelFormLoader.Margin = new System.Windows.Forms.Padding(0);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.panelFormLoader.Size = new System.Drawing.Size(772, 431);
            this.panelFormLoader.TabIndex = 8;
            this.panelFormLoader.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelFormLoader_ControlAdded);
            this.panelFormLoader.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panelFormLoader_ControlRemoved);
            // 
            // panelAdminReportes
            // 
            this.panelAdminReportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelAdminReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.panelAdminReportes.Controls.Add(this.btnReportesPlanes);
            this.panelAdminReportes.Controls.Add(this.btnReportesCursos);
            this.panelAdminReportes.Controls.Add(this.btnABMUsuarios);
            this.panelAdminReportes.Controls.Add(this.btnABMPlanes);
            this.panelAdminReportes.Controls.Add(this.btnABMPersonas);
            this.panelAdminReportes.Controls.Add(this.btnABMMaterias);
            this.panelAdminReportes.Controls.Add(this.btnABMEspecialidades);
            this.panelAdminReportes.Controls.Add(this.btnABMDictados);
            this.panelAdminReportes.Controls.Add(this.btnABMCursos);
            this.panelAdminReportes.Controls.Add(this.btnABMComisiones);
            this.panelAdminReportes.Location = new System.Drawing.Point(188, 32);
            this.panelAdminReportes.Margin = new System.Windows.Forms.Padding(0);
            this.panelAdminReportes.Name = "panelAdminReportes";
            this.panelAdminReportes.Size = new System.Drawing.Size(188, 552);
            this.panelAdminReportes.TabIndex = 9;
            this.panelAdminReportes.Visible = false;
            this.panelAdminReportes.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnReportesPlanes
            // 
            this.btnReportesPlanes.AutoSize = true;
            this.btnReportesPlanes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportesPlanes.FlatAppearance.BorderSize = 0;
            this.btnReportesPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesPlanes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesPlanes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnReportesPlanes.Location = new System.Drawing.Point(0, 414);
            this.btnReportesPlanes.Margin = new System.Windows.Forms.Padding(0);
            this.btnReportesPlanes.Name = "btnReportesPlanes";
            this.btnReportesPlanes.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnReportesPlanes.Size = new System.Drawing.Size(188, 46);
            this.btnReportesPlanes.TabIndex = 14;
            this.btnReportesPlanes.Text = "Reportes Planes";
            this.btnReportesPlanes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportesPlanes.UseVisualStyleBackColor = true;
            this.btnReportesPlanes.Visible = false;
            this.btnReportesPlanes.Click += new System.EventHandler(this.btnReportesPlanes_Click);
            this.btnReportesPlanes.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnReportesCursos
            // 
            this.btnReportesCursos.AutoSize = true;
            this.btnReportesCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportesCursos.FlatAppearance.BorderSize = 0;
            this.btnReportesCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesCursos.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesCursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnReportesCursos.Location = new System.Drawing.Point(0, 368);
            this.btnReportesCursos.Margin = new System.Windows.Forms.Padding(0);
            this.btnReportesCursos.Name = "btnReportesCursos";
            this.btnReportesCursos.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnReportesCursos.Size = new System.Drawing.Size(188, 46);
            this.btnReportesCursos.TabIndex = 15;
            this.btnReportesCursos.Text = "Reportes Cursos";
            this.btnReportesCursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportesCursos.UseVisualStyleBackColor = true;
            this.btnReportesCursos.Visible = false;
            this.btnReportesCursos.Click += new System.EventHandler(this.btnReportesCursos_Click);
            this.btnReportesCursos.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnABMUsuarios
            // 
            this.btnABMUsuarios.AutoSize = true;
            this.btnABMUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABMUsuarios.FlatAppearance.BorderSize = 0;
            this.btnABMUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMUsuarios.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnABMUsuarios.Location = new System.Drawing.Point(0, 322);
            this.btnABMUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.btnABMUsuarios.Name = "btnABMUsuarios";
            this.btnABMUsuarios.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnABMUsuarios.Size = new System.Drawing.Size(188, 46);
            this.btnABMUsuarios.TabIndex = 6;
            this.btnABMUsuarios.Text = "Usuarios";
            this.btnABMUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnABMUsuarios.UseVisualStyleBackColor = true;
            this.btnABMUsuarios.Visible = false;
            this.btnABMUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.btnABMUsuarios.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnABMPlanes
            // 
            this.btnABMPlanes.AutoSize = true;
            this.btnABMPlanes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABMPlanes.FlatAppearance.BorderSize = 0;
            this.btnABMPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMPlanes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMPlanes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnABMPlanes.Location = new System.Drawing.Point(0, 276);
            this.btnABMPlanes.Margin = new System.Windows.Forms.Padding(0);
            this.btnABMPlanes.Name = "btnABMPlanes";
            this.btnABMPlanes.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnABMPlanes.Size = new System.Drawing.Size(188, 46);
            this.btnABMPlanes.TabIndex = 11;
            this.btnABMPlanes.Text = "Planes";
            this.btnABMPlanes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnABMPlanes.UseVisualStyleBackColor = true;
            this.btnABMPlanes.Visible = false;
            this.btnABMPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            this.btnABMPlanes.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnABMPersonas
            // 
            this.btnABMPersonas.AutoSize = true;
            this.btnABMPersonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABMPersonas.FlatAppearance.BorderSize = 0;
            this.btnABMPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMPersonas.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMPersonas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnABMPersonas.Location = new System.Drawing.Point(0, 230);
            this.btnABMPersonas.Margin = new System.Windows.Forms.Padding(0);
            this.btnABMPersonas.Name = "btnABMPersonas";
            this.btnABMPersonas.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnABMPersonas.Size = new System.Drawing.Size(188, 46);
            this.btnABMPersonas.TabIndex = 7;
            this.btnABMPersonas.Text = "Personas";
            this.btnABMPersonas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnABMPersonas.UseVisualStyleBackColor = true;
            this.btnABMPersonas.Visible = false;
            this.btnABMPersonas.Click += new System.EventHandler(this.btnPersonas_Click);
            this.btnABMPersonas.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnABMMaterias
            // 
            this.btnABMMaterias.AutoSize = true;
            this.btnABMMaterias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABMMaterias.FlatAppearance.BorderSize = 0;
            this.btnABMMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMMaterias.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMMaterias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnABMMaterias.Location = new System.Drawing.Point(0, 184);
            this.btnABMMaterias.Margin = new System.Windows.Forms.Padding(0);
            this.btnABMMaterias.Name = "btnABMMaterias";
            this.btnABMMaterias.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnABMMaterias.Size = new System.Drawing.Size(188, 46);
            this.btnABMMaterias.TabIndex = 12;
            this.btnABMMaterias.Text = "Materias";
            this.btnABMMaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnABMMaterias.UseVisualStyleBackColor = true;
            this.btnABMMaterias.Visible = false;
            this.btnABMMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            this.btnABMMaterias.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnABMEspecialidades
            // 
            this.btnABMEspecialidades.AutoSize = true;
            this.btnABMEspecialidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABMEspecialidades.FlatAppearance.BorderSize = 0;
            this.btnABMEspecialidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMEspecialidades.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMEspecialidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnABMEspecialidades.Location = new System.Drawing.Point(0, 138);
            this.btnABMEspecialidades.Margin = new System.Windows.Forms.Padding(0);
            this.btnABMEspecialidades.Name = "btnABMEspecialidades";
            this.btnABMEspecialidades.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnABMEspecialidades.Size = new System.Drawing.Size(188, 46);
            this.btnABMEspecialidades.TabIndex = 10;
            this.btnABMEspecialidades.Text = "Especialidades";
            this.btnABMEspecialidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnABMEspecialidades.UseVisualStyleBackColor = true;
            this.btnABMEspecialidades.Visible = false;
            this.btnABMEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            this.btnABMEspecialidades.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnABMDictados
            // 
            this.btnABMDictados.AutoSize = true;
            this.btnABMDictados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABMDictados.FlatAppearance.BorderSize = 0;
            this.btnABMDictados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMDictados.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMDictados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnABMDictados.Location = new System.Drawing.Point(0, 114);
            this.btnABMDictados.Margin = new System.Windows.Forms.Padding(0);
            this.btnABMDictados.Name = "btnABMDictados";
            this.btnABMDictados.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnABMDictados.Size = new System.Drawing.Size(251, 57);
            this.btnABMDictados.TabIndex = 16;
            this.btnABMDictados.Text = "Dictados";
            this.btnABMDictados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnABMDictados.UseVisualStyleBackColor = true;
            this.btnABMDictados.Visible = false;
            this.btnABMDictados.Click += new System.EventHandler(this.btnDictados_Click);
            this.btnABMDictados.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnABMCursos
            // 
            this.btnABMCursos.AutoSize = true;
            this.btnABMCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABMCursos.FlatAppearance.BorderSize = 0;
            this.btnABMCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMCursos.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMCursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnABMCursos.Location = new System.Drawing.Point(0, 46);
            this.btnABMCursos.Margin = new System.Windows.Forms.Padding(0);
            this.btnABMCursos.Name = "btnABMCursos";
            this.btnABMCursos.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnABMCursos.Size = new System.Drawing.Size(188, 46);
            this.btnABMCursos.TabIndex = 13;
            this.btnABMCursos.Text = "Cursos";
            this.btnABMCursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnABMCursos.UseVisualStyleBackColor = true;
            this.btnABMCursos.Visible = false;
            this.btnABMCursos.Click += new System.EventHandler(this.btnCursos_Click);
            this.btnABMCursos.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // btnABMComisiones
            // 
            this.btnABMComisiones.AutoSize = true;
            this.btnABMComisiones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnABMComisiones.FlatAppearance.BorderSize = 0;
            this.btnABMComisiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMComisiones.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABMComisiones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnABMComisiones.Location = new System.Drawing.Point(0, 0);
            this.btnABMComisiones.Margin = new System.Windows.Forms.Padding(0);
            this.btnABMComisiones.Name = "btnABMComisiones";
            this.btnABMComisiones.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnABMComisiones.Size = new System.Drawing.Size(188, 46);
            this.btnABMComisiones.TabIndex = 8;
            this.btnABMComisiones.Text = "Comisiones";
            this.btnABMComisiones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnABMComisiones.UseVisualStyleBackColor = true;
            this.btnABMComisiones.Visible = false;
            this.btnABMComisiones.Click += new System.EventHandler(this.btnComisiones_Click);
            this.btnABMComisiones.MouseLeave += new System.EventHandler(this.panelAdminReportes_MouseLeave);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.panelTop.Controls.Add(this.btnMinimizar);
            this.panelTop.Controls.Add(this.btnMaximizar);
            this.panelTop.Controls.Add(this.btnCerrar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(188, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(772, 32);
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
            this.btnMinimizar.Location = new System.Drawing.Point(682, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnMaximizar.Location = new System.Drawing.Point(712, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnCerrar.Location = new System.Drawing.Point(742, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
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
            this.panelBottom.Location = new System.Drawing.Point(188, 544);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(772, 41);
            this.panelBottom.TabIndex = 12;
            this.panelBottom.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.Location = new System.Drawing.Point(621, 6);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(80, 27);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.AutoSize = true;
            this.btnSalir.Location = new System.Drawing.Point(708, 6);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 27);
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
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelAdminReportes);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3);
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
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox picPerfil;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Panel panelAdminReportes;
        private System.Windows.Forms.Button btnABMCursos;
        private System.Windows.Forms.Button btnABMMaterias;
        private System.Windows.Forms.Button btnABMPlanes;
        private System.Windows.Forms.Button btnABMEspecialidades;
        private System.Windows.Forms.Button btnABMComisiones;
        private System.Windows.Forms.Button btnABMPersonas;
        private System.Windows.Forms.Button btnABMUsuarios;
        private System.Windows.Forms.Button btnReportesCursos;
        private System.Windows.Forms.Button btnReportesPlanes;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.Panel panelFormLoader;
        private System.Windows.Forms.Button btnABMDictados;
    }
}