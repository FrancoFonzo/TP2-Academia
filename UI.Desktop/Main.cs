using Business.Entities;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
using Business.Logic;

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
            UsuarioActual = usuarioActual;
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

        private void btnComisiones_Click(object sender, EventArgs e)
        {
           openForm<Comisiones>();
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            LoadSubMenu("ABM");
        }

        private void panelAdminReportes_MouseLeave(object sender, EventArgs e)
        {
            if (panelAdminReportes.ClientRectangle.Contains(panelAdminReportes.PointToClient(Cursor.Position)))
            {
                return;
            }
            if (!btnReportesCursos.Visible)
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

        private void btnCursos_Click(object sender, EventArgs e)
        {
            openForm<Cursos>();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            openForm<Especialidades>();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            openForm<Materias>();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            openForm<Personas>();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            openForm<Planes>();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            openForm<Usuarios>();
        }


        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            if( UsuarioActual.MiPersona.Tipo == Persona.TiposPersonas.Administrador)
            {
                panelFormLoader.Controls.Clear();
                /*ModalLegajo ModalLegajo = new ModalLegajo();
                ModalLegajo.ShowDialog();
                int legajo = ModalLegajo.Legajo;*/
                openForm("Alumnos");
            }
            else
            {
                panelFormLoader.Controls.Clear();
                openForm("Inscripciones");
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            LoadSubMenu("Reportes");
        }

        private void LoadSubMenu(string btnName)
        {
            panelAdminReportes.BringToFront();
            panelAdminReportes.Visible = true;
            panelAdminReportes.Controls
                .OfType<Button>()
                .ToList()
                .ForEach(b => b.Visible = b.Name.Contains(btnName));
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
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

        private void openForm<T>() where T : ApplicationForm
        {
            panelFormLoader.Controls.Clear();
            T form = Activator.CreateInstance<T>();
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.TopMost = true;
            panelFormLoader.Controls.Add(form);
            lblTitulo.Text = form.Text;
            form.Show();
        }

        private void openForm(string tipoForm)
        {
            panelFormLoader.Controls.Clear();
            ApplicationForm form;
            switch (tipoForm)
            {
                case "Inscripciones":
                    form = new Inscripciones(UsuarioActual.MiPersona);
                    lblTitulo.Text = form.Text;
                    break;
                case "Alumnos":
                    form = new Personas(Persona.TiposPersonas.Alumno);
                    lblTitulo.Text = "Inscripcion Alumnos";
                    break;
                case "Docentes":
                    throw new NotImplementedException();
                default:
                    throw new InvalidOperationException("Tipo de formulario desconocido");
            }
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.TopMost = true;
            panelFormLoader.Controls.Add(form);
            form.Show();
        }

        internal void openForm(ApplicationForm form)
        {
            panelFormLoader.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.TopMost = true;
            panelFormLoader.Controls.Add(form);
            lblTitulo.Text = form.Text;
            form.Show();
        }
    }
}
