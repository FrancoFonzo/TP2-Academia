using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class formLogin : ApplicationForm
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            UsuarioLogic usrLogic = new UsuarioLogic();
            Usuario UsuarioActual = usrLogic.GetOneNombreUsuario(this.txtUsuario.Text);

            if(UsuarioActual == null || 
                !Validaciones.ValidarClave(UsuarioActual.Clave, txtClave.Text))
            {
                    Notificar("Login", "Usuario y/o contraseña incorrectos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Notificar("Login", "Usted ha ingresado al sistema correctamente.",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Application.Run(new formMain());
            this.DialogResult = DialogResult.OK;
        }

        private void lnkRecuperarClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Notificar("Login", "Funcion no implementada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
