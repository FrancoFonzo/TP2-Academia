using System;
using System.Drawing;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace UI.Desktop
{
    public partial class Login : ApplicationForm
    {
        public Usuario UsuarioActual { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Validar();
        }

        private void lnkRecuperarClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Notificar("Login", "Funcion no implementada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUserPass_EnterLeave(object sender, EventArgs e)
        {
            if (sender == txtUsuario) configTxt(txtUsuario, "Usuario");
            else configTxt(txtClave, "Contraseña");
        }

        private void configTxt(TextBox txt, String cadena)
        {
            if (txt.Text == cadena)
            {
                txt.Text = "";
                txt.ForeColor = Color.Silver;
                if (txt.Equals(txtClave)) txt.PasswordChar = '*';
            }
            else if (txt.Text == "")
            {
                txt.ForeColor = Color.DarkGray;
                txt.Text = cadena;
                if (txt.Equals(txtClave)) txt.PasswordChar = '\0';
            }
        }

        // Cada evento MouseDown en el login sera manejado por este evento.
        private void appLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public override bool Validar()
        {
            if (txtUsuario.Text.Equals("Usuario") || txtClave.Text.Equals("Contraseña") ||
                !Validaciones.FormularioCompleto(
                    new List<string> { txtUsuario.Text, txtClave.Text }))
            {
                Notificar("Informacion invalida", "Complete todos los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            this.UsuarioActual = new UsuarioLogic().GetOneNombreUsuario(this.txtUsuario.Text);
            if (!Validaciones.ValidarClave(UsuarioActual?.Clave, txtClave.Text))
            {
                Notificar("Login", "Usuario y/o contraseña incorrectos",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            this.DialogResult = DialogResult.OK;
            return true;
        }
    }

}
