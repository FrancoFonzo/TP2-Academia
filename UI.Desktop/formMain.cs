using Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class formMain : ApplicationForm
    {
        public Usuario UsuarioActual { get; set; }

        public formMain()
        {
            InitializeComponent();
            panelAdministracion.Visible = false;
            txtBusqueda.Visible = false;
        }
        public formMain(Usuario UsuarioActual) : this()
        {
            this.UsuarioActual = UsuarioActual;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = $"Bienvenido {UsuarioActual.NombreUsuario}";
            lblUsuario.Text = $"Usuario: {UsuarioActual.NombreUsuario}";
            lblRol.Text = $"Rol: {UsuarioActual.MiPersona.Tipo.ToString()}";
            // TODO: Segun permisos del usuario cargar x botones
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
            panelAdministracion.BringToFront();
            panelAdministracion.Visible = true;
        }

        private void panelAdministracion_MouseLeave(object sender, EventArgs e)
        {
            if (!panelAdministracion.ClientRectangle.Contains(panelAdministracion.PointToClient(Cursor.Position))
                && !btnAdministracion.ClientRectangle.Contains(btnAdministracion.PointToClient(Cursor.Position)))
            {
                panelAdministracion.SendToBack();
                panelAdministracion.Visible = false;
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.panelFormLoader.Controls.Clear();
            Usuarios formUsuarios = new Usuarios()
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
    }
}
