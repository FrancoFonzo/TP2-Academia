using Business.Entities;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace UI.Desktop
{
    public partial class Main : ApplicationForm
    {
        private Usuario UsuarioActual { get; }
        private readonly string titulo;
        
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Main()
        {
            InitializeComponent();
            panelAdminReportes.Visible = false;
        }

        public Main(Usuario usuarioActual) : this()
        {
            this.UsuarioActual = usuarioActual;
            titulo = $"Bienvenido/a {UsuarioActual.MiPersona?.NombreCompleto}!";
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = titulo;
            lblUsuario.Text = $"{lblUsuario.Text} {UsuarioActual.NombreUsuario}";
            if (UsuarioActual.MiPersona != null)
            {
                lblLegajo.Text = $"{lblLegajo.Text} {UsuarioActual.MiPersona.Legajo}";
                lblPersona.Text = $"{lblPersona.Text} {UsuarioActual.MiPersona.NombreCompleto}";
            }
            // Segun TipoPersona del usuario visibilizar botones
            switch (UsuarioActual.MiPersona?.Tipo)
            {
                case Persona.TiposPersonas.Administrador:
                    panelMenu.Controls.OfType<Button>().ToList().ForEach(b => b.Visible = true);
                    break;
                case Persona.TiposPersonas.Alumno:
                    btnInscripcion.Visible = true;
                    break;
                case Persona.TiposPersonas.Docente:
                    btnNotas.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
                btnMaximizar.Image = Properties.Resources.restore_window_32;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                btnMaximizar.Image = Properties.Resources.maximize_window_32;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            panelAdminReportes.BringToFront();
            panelAdminReportes.Visible = true;
            btnReporteCursos.Visible = false;
            btnReportePlanes.Visible = false;
            List<Button> btns = panelAdminReportes.Controls.OfType<Button>().Where(c => !c.Text.Contains("Reportes")).ToList();
            btns.ForEach(b => b.Visible = true);
        }

        private void panelAdminReportes_MouseLeave(object sender, EventArgs e)
        {
            if (panelAdminReportes.ClientRectangle.Contains(panelAdminReportes.PointToClient(Cursor.Position)))
            {
                return;
            }
            if (!btnReporteCursos.Visible)
            {
                if (btnAdministracion.ClientRectangle.Contains(btnAdministracion.PointToClient(Cursor.Position)))
                {
                    return;
                }
            }
            else if (btnReportes.ClientRectangle.Contains(btnReportes.PointToClient(Cursor.Position)))
            {
                return;
            }
            panelAdminReportes.SendToBack();
            panelAdminReportes.Visible = false;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            openForm<Usuarios>();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            openForm<Personas>();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            openForm<Especialidades>();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            openForm<Planes>();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            openForm<Materias>();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            panelAdminReportes.BringToFront();
            panelAdminReportes.Visible = true;
            List<Button> btns = panelAdminReportes.Controls.OfType<Button>().Where(c => !c.Text.Contains("Reportes")).ToList();
            btns.ForEach(b => b.Visible = false);
            btnReporteCursos.Visible = true;
            btnReportePlanes.Visible = true;
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            openForm<Cursos>();
        }

        private void panelFormLoader_ControlAdded(object sender, ControlEventArgs e)
        {
            panelBottom.Visible = true;
        }

        private void panelFormLoader_ControlRemoved(object sender, ControlEventArgs e)
        {
            panelBottom.Visible = false;
            lblTitulo.Text = titulo;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            panelFormLoader.Controls.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ApplicationForm form = panelFormLoader.Controls.OfType<ApplicationForm>().SingleOrDefault();
            form.Listar();
        }

        private void openForm<T>(bool user = false) where T : ApplicationForm
        {
            panelFormLoader.Controls.Clear();

            /*T form;

            if (user)
            {
                form = (T)Activator.CreateInstance(typeof(T), UsuarioActual);
            }
            else
            {
                form = (T)Activator.CreateInstance(typeof(T));
            }*/
            T form = (T)Activator.CreateInstance(typeof(T));
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.TopMost = true;
            panelFormLoader.Controls.Add(form);
            lblTitulo.Text = form.Text;
            form.Show();
        }

        private void openForm()
        {
            panelFormLoader.Controls.Clear();
            Inscripciones inscripciones = new Inscripciones(UsuarioActual)
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true
            };
            panelFormLoader.Controls.Add(inscripciones);
            lblTitulo.Text = inscripciones.Text;
            inscripciones.Show();
        }
    }
}
