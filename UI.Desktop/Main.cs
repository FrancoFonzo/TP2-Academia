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
        public Usuario UsuarioActual { get; set; }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Main()
        {
            InitializeComponent();
            panelAdminReportes.Visible = false;
            txtBusqueda.Visible = false;
        }
        public Main(Usuario UsuarioActual) : this()
        {
            this.UsuarioActual = UsuarioActual;
            titulo = $"Bienvenido {UsuarioActual.NombreUsuario}!";
        }

        private string titulo;

        private void formMain_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = titulo;
            lblUsuario.Text = $"{lblUsuario.Text} {UsuarioActual.NombreUsuario}";
            if (UsuarioActual.MiPersona != null)
            {
                lblLegajo.Text = $"{lblLegajo.Text} {UsuarioActual.MiPersona.Legajo}";
                lblPersona.Text = $"{lblPersona.Text} {UsuarioActual.MiPersona.NombreCompleto}";
            }
            // TODO: Segun permisos del usuario cargar x botones
            /*switch (UsuarioActual.MiPersona.Tipo)
            {
                case Persona.TiposPersonas.Administrador:
                    break;
                case Persona.TiposPersonas.Alumno:
                    btnAdministracion.Visible = false;
                    btnNotas.Visible = false;
                    btnReportes.Visible = false;
                    break;
                case Persona.TiposPersonas.Docente:
                    btnAdministracion.Visible = false;
                    btnReportes.Visible = false;
                    break;
                default:
                    btnInscripcion.Visible = false;
                    btnAdministracion.Visible = false;
                    btnNotas.Visible = false;
                    btnReportes.Visible = false;
                    break;
            }*/
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                this.btnMaximizar.Image = Properties.Resources.restore_window_32;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.btnMaximizar.Image = Properties.Resources.maximize_window_32;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            this.panelFormLoader.Controls.Clear();
            Usuarios formUsuarios = new Usuarios
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true
            };
            this.panelFormLoader.Controls.Add(formUsuarios);
            lblTitulo.Text = formUsuarios.Text;
            formUsuarios.Show();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            this.panelFormLoader.Controls.Clear();
            Personas formPersonas = new Personas
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true
            };
            this.panelFormLoader.Controls.Add(formPersonas);
            lblTitulo.Text = "Personas";
            formPersonas.Show();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            this.panelFormLoader.Controls.Clear();
            Especialidades formEspecialidades = new Especialidades
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true
            };
            this.panelFormLoader.Controls.Add(formEspecialidades);
            lblTitulo.Text = "Especialidades";
            formEspecialidades.Show();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            this.panelFormLoader.Controls.Clear();
            Planes formPlanes = new Planes
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true
            };
            this.panelFormLoader.Controls.Add(formPlanes);
            lblTitulo.Text = "Planes";
            formPlanes.Show();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            this.panelFormLoader.Controls.Clear();
            Materias formMaterias = new Materias
            {
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                TopMost = true
            };
            this.panelFormLoader.Controls.Add(formMaterias);
            lblTitulo.Text = "Materias";
            formMaterias.Show();
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
    }
}
