using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Base : System.Web.UI.Page
    {

        public enum ModoForm
        {
            Alta,
            Baja,
            Modificacion,
            Consulta
        }

        public ModoForm Modo
        {
            get => (ModoForm)this.ViewState["FormMode"];
            set { this.ViewState["FormMode"] = value; }
        }

        protected int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }
            set { this.ViewState["SelectedID"] = value; }
        }

        protected bool IsRowSelected()
        {
            if (SelectedID == 0)
            {
                Notificar("Porfavor seleccione una fila.");
                return false;
            }
            return true;
        }

        public void ValidarPermisos(Persona.TiposPersonas tipo)
        {
            var usrTipo = ((Usuario)Session["UsuarioGlobal"])?.Persona?.Tipo;
            if (usrTipo != tipo && usrTipo != Persona.TiposPersonas.Administrador)
            {
                Response.Redirect("Home.aspx");
                Notificar("Acceso denegado.");
            }
        }

        protected void Notificar(string mensaje)
        {
            Type csType = this.GetType();

            // Obtiene una referencia del ClientScriptManager de la pagina.
            ClientScriptManager cs = Page.ClientScript;

            //Valida si el startup del script ya esta registrado.
            if (!cs.IsStartupScriptRegistered(csType, "PopupScript"))
            {
                String csText = $"alert('{mensaje}');";
                cs.RegisterStartupScript(csType, "PopupScript", csText, true);
            }
        }
    }
}