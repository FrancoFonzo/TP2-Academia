using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Login : System.Web.UI.Page
    {

        public static Usuario UsuarioActual { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (this.IsValid)
            {
                Session["UsuarioGlobal"] = UsuarioActual;
                Response.Redirect("Default.aspx");
            }
        }

        protected void cvValidarUsuario_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = Validar();
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