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
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static Usuario UsuarioActual { get; private set; }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkRecuperarClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Notificar("Login","Funcion no implementada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtUserPass_EnterLeave(object sender, EventArgs e)
        {
            if (sender == txtUsuario)
            {
                UpdateTxt(txtUsuario, "Usuario");
            }
            else
            {
                UpdateTxt(txtClave, "Contraseña");
            }
        }

        private void UpdateTxt(TextBox txt, string cadena)
        {
            if (txt.Text == cadena)
            {
                txt.Text = "";
                txt.ForeColor = Color.LightGray;
                if (txt.Equals(txtClave))
                {
                    txt.PasswordChar = new TextBox { UseSystemPasswordChar = true }.PasswordChar;
                }
            }
            else if (txt.Text == "")
            {
                txt.ForeColor = Color.DarkGray;
                txt.Text = cadena;
                if (txt.Equals(txtClave))
                {
                    txt.PasswordChar = '\0';
                }
            }
        }

        // Cada evento MouseDown en el login sera manejado por este evento.
        private void appLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        public override bool Validar()
        {
            if (txtUsuario.Text.Equals("Usuario") || txtClave.Text.Equals("Contraseña") ||
                !Validaciones.FormularioCompleto(new List<string> { txtUsuario.Text, txtClave.Text }))
            {
                Notificar("Informacion invalida","Complete todos los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            UsuarioActual = new UsuarioLogic().GetOneNombreUsuario(txtUsuario.Text);
            if (!Validaciones.ValidarClave(UsuarioActual?.Clave, txtClave.Text))
            {
                Notificar("Informacion invalida", "Usuario y/o contraseña incorrectos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!UsuarioActual.Habilitado)
            {
                Notificar("Error", "Usuario no habilitado",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DialogResult = DialogResult.OK;
            return true;
        }
    }

}
