using System;
using System.Web.Security;
using System.Web.UI;
using Business.Entities;

namespace UI.Web
{
    public partial class Menu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                switch (Login.UsuarioActual.Persona.Tipo)
                {
                    case Persona.TiposPersonas.Administrador:
                        if (btnAdministracion != null && btnReportes != null &&
                            linkInscripciones != null && linkNotas != null)
                        {
                            btnAdministracion.Visible = true;
                            btnReportes.Visible = true;
                            linkInscripciones.Visible = true;
                            linkNotas.Visible = true;
                        }
                        break;
                    case Persona.TiposPersonas.Alumno:
                        if (linkInscripciones != null)
                        {
                            linkInscripciones.Visible = true;
                        }
                        break;
                    case Persona.TiposPersonas.Docente:
                        if (linkNotas != null)
                        {
                            linkNotas.Visible = true;
                        }
                        break;
                    default:
                        //Response.Redirect("Login.aspx");
                        break;
                }
            }
        }

        protected void linkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void comisiones_Click(object sender, EventArgs e)
        {
            Response.Redirect("Comisiones.aspx");
        }

        protected void cursos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cursos.aspx");
        }

        protected void dictados_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dictados.aspx");
        }

        protected void especialidades_Click(object sender, EventArgs e)
        {
            Response.Redirect("Especialidades.aspx");
        }

        protected void materias_Click(object sender, EventArgs e)
        {
            Response.Redirect("Materias.aspx");
        }

        protected void personas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Personas.aspx");
        }

        protected void planes_Click(object sender, EventArgs e)
        {
            Response.Redirect("Planes.aspx");
        }

        protected void usuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("Usuarios.aspx");
        }

        protected void reportAlumnos_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReporteAlumnos.aspx");
        }

        protected void reportPlanes_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReportePlanes.aspx");
        }

        protected void linkInscripciones_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inscripciones.aspx");
        }

        protected void linkNotas_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarNotas.aspx");
        }

        protected void linkCerrarSesion_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }
    }
}