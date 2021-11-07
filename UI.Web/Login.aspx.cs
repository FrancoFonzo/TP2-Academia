using Business.Entities;
using Business.Logic;
using System;
using System.Web.Security;
using System.Web.UI.WebControls;
using Util;

namespace UI.Web
{
    public partial class Login : Base
    {

        public static Usuario UsuarioActual { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                if (IsValid)
                {
                    Session["UsuarioGlobal"] = UsuarioActual;
                    FormsAuthentication.RedirectFromLoginPage(txtUsuario.Text, false);
                }
            }
            catch (Exception ex)
            {
                Notificar($"Se ha producido un error: {ex.Message}");
            }
        }

        protected void cvValidarUsuario_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                args.IsValid = Validar();
            }
            catch (Exception ex)
            {
                args.IsValid = false;
                Notificar(ex.Message);
            }
        }

        public bool Validar()
        {
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                cvValidarUsuario.ErrorMessage = "Usuario y/o contraseña incorrecta.";
                return false;
            }

            UsuarioActual = new UsuarioLogic().GetOneNombreUsuario(txtUsuario.Text);

            if (!Validaciones.ValidarClave(UsuarioActual?.Clave, txtClave.Text))
            {
                cvValidarUsuario.ErrorMessage = "Usuario y/o contraseña incorrecta.";
                return false;
            }
            if (!UsuarioActual.Habilitado)
            {
                cvValidarUsuario.ErrorMessage = "Usuario no habilitado.";
                return false;
            }
            return true;
        }

    }
}