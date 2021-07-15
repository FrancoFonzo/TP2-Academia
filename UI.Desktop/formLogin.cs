using System;
using System.Drawing;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace UI.Desktop
{
    public partial class formLogin : ApplicationForm
    {
        public formLogin()
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
            if (sender == txtUsuario) configTxtUsuario();
            else configTxtClave();
        }

        private void configTxtClave()
        {
            if (txtClave.Text == "Contraseña")
            {
                txtClave.PasswordChar = (new TextBox() { UseSystemPasswordChar = true }).PasswordChar;
                txtClave.Text = "";
                txtClave.ForeColor = Color.Silver;    
            }
            else if (txtClave.Text == "")
            {
                txtClave.PasswordChar = '\0';
                txtClave.ForeColor = Color.DarkGray;
                txtClave.Text = "Contraseña";
            }
        }

        private void configTxtUsuario()
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Silver;
            }
            else if (txtUsuario.Text == "")
            {
                txtUsuario.ForeColor = Color.DarkGray;
                txtUsuario.Text = "Usuario";
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

            UsuarioLogic usrLogic = new UsuarioLogic();
            Usuario UsuarioActual = usrLogic.GetOneNombreUsuario(this.txtUsuario.Text);
            if (UsuarioActual == null) ;
            else if (Validaciones.ValidarClave(UsuarioActual.Clave, txtClave.Text))
            {
                Notificar("Login", "Usted ha ingresado al sistema correctamente.",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                return true;
            }
            Notificar("Login", "Usuario y/o contraseña incorrectos",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

}
