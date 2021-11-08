using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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
                }
            }
        }

        protected void linkInscripciones_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inscripciones.aspx");
        }

        protected void linkNotas_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarNotas.aspx");
        }

        protected void linkAcercaDe_Click(object sender, EventArgs e)
        {
            Response.Redirect("AcercaDe.aspx");
        }

        protected void linkCerrarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void comisiones_Click(object sender, EventArgs e)
        {
            Response.Redirect("Comisiones.aspx");
        }

        protected void cursos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cursos.aspx");
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
            Response.Redirect("Home.aspx");
        }

        protected void reportPlanes_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void linkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}