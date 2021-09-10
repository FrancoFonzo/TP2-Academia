using Business.Entities;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;

namespace UI.Desktop
{
    public partial class Main : ApplicationForm
    {
        private readonly string titulo;

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Main()
        {
            InitializeComponent();
            titulo = $"Bienvenido/a {Login.UsuarioActual.Persona}!";
            panelAdminReportes.Visible = false;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = titulo;
            lblUsuario.Text = $"{lblUsuario.Text} {Login.UsuarioActual.NombreUsuario}";
            lblLegajo.Text = $"{lblLegajo.Text} {Login.UsuarioActual.Persona.Legajo}";
            lblPersona.Text = $"{lblPersona.Text} {Login.UsuarioActual.Persona}";
            switch (Login.UsuarioActual.Persona.Tipo)
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
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnComisiones_Click(object sender, EventArgs e)
        {
            OpenForm(new Comisiones());
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
            OpenForm(new Cursos());
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            OpenForm(new Especialidades());
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            OpenForm(new Materias());
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            OpenForm(new Personas());
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            OpenForm(new Planes());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OpenForm(new Usuarios());
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            if (Login.UsuarioActual.Persona.Tipo == Persona.TiposPersonas.Administrador)
            {
                OpenForm(new Personas(Persona.TiposPersonas.Docente));
            }
            else
            {
                OpenForm(new RegistrarNotas(Login.UsuarioActual.Persona));
            }
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            if (Login.UsuarioActual.Persona.Tipo == Persona.TiposPersonas.Administrador)
            {
                OpenForm(new Personas(Persona.TiposPersonas.Alumno));
            }
            else
            {
                OpenForm(new Inscripciones(Login.UsuarioActual.Persona));
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
            panelFormLoader.Controls.OfType<ApplicationForm>().FirstOrDefault()?.Listar();
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

        internal void OpenForm(ApplicationForm form)
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
