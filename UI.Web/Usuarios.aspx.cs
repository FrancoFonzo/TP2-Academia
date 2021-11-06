using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Usuarios : Base
    {
        private static UsuarioLogic UsuarioLogic = new UsuarioLogic();

        private Usuario UsuarioActual { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidarPermisos(Persona.TiposPersonas.Administrador);
            if (!Page.IsPostBack)
            {
                Listar();
            }
        }

        protected void gvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedID = (int)gvUsuarios.SelectedValue;
        }

        protected void linkNuevo_Click(object sender, EventArgs e)
        {
            Modo = ModoForm.Alta;
            MapearInicial();
            ShowForm(true);
        }

        protected void linkEditar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected())
            {
                Modo = ModoForm.Modificacion;
                MapearInicial();
                ShowForm(true);
                MapearForm(SelectedID);
            }
        }

        protected void linkEliminar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected())
            {
                Modo = ModoForm.Baja;
                MapearInicial();
                ShowForm(true);
                MapearForm(SelectedID);
            }
        }

        protected void linkAceptar_Click(object sender, EventArgs e)
        {
            Validate();
            if (IsValid)
            {
                SaveEntity(SelectedID);
                ShowForm(false);
                Listar();
            }
        }

        protected void linkCancelar_Click(object sender, EventArgs e)
        {
            ShowForm(false);
        }

        private void ShowForm(bool visible)
        {
            ClearForm();
            formPanel.Visible = visible;
            gridPanel.Visible = !visible;
        }

        private void ClearForm()
        {
            txtUsuario.Text = string.Empty;
            txtClave.Text = string.Empty;
            txtRepetirClave.Text = string.Empty;
            chkHabilitado.Checked = false;
        }

        private void MapearInicial()
        {
            List<Persona> personas = new PersonaLogic().GetAllSinUsuario();

            if (Modo != ModoForm.Alta)
            {
                UsuarioActual = UsuarioLogic.GetOne(SelectedID);
                if (UsuarioActual.Persona != null)
                {
                    personas.Add(UsuarioActual.Persona);
                }
            }

            switch (Modo)
            {
                case ModoForm.Alta:
                case ModoForm.Modificacion:
                    linkAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    linkAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Consulta:
                    linkAceptar.Text = "Aceptar";
                    break;
            }

            ddlPersona.DataSource = personas;
            ddlPersona.DataBind();
            ddlPersona.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        private void MapearForm(int id)
        {
            UsuarioActual = UsuarioLogic.GetOne(id);

            txtUsuario.Text = UsuarioActual.NombreUsuario;
            txtClave.Text = UsuarioActual.Clave;
            ddlPersona.SelectedValue = UsuarioActual.Persona?.ID.ToString();
            chkHabilitado.Checked = UsuarioActual.Habilitado;
        }

        private void MapearEntidad()
        {
            UsuarioActual = UsuarioLogic.GetOne(SelectedID);
            switch (Modo)
            {
                case ModoForm.Baja:
                    SelectedID.ToString();
                    UsuarioActual.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Alta:
                    UsuarioActual = new Usuario { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    UsuarioActual.State = BusinessEntity.States.Modified;
                    break;
            }
            UsuarioActual.NombreUsuario = txtUsuario.Text;
            UsuarioActual.Clave = txtClave.Text;
            UsuarioActual.Persona = new PersonaLogic().GetOne(int.Parse(ddlPersona.SelectedValue));
            UsuarioActual.Habilitado = chkHabilitado.Checked;
        }

        private void SaveEntity(int id)
        {
            UsuarioActual = UsuarioLogic.GetOne(id);
            MapearEntidad();
            UsuarioLogic.Save(UsuarioActual);
            if (Modo == ModoForm.Baja)
            {
                //Resetear ID seleccionado cuando se borra un registro, ya que el ID dejara de existir.
                SelectedID = 0;
            }
        }

        private void Listar()
        {
            try
            {
                gvUsuarios.DataSource = UsuarioLogic.GetAll();
                gvUsuarios.DataBind();
            }
            catch (Exception)
            {
                Notificar("Error al recuperar los datos del usuario.");
            }
        }
    }
}