using Business.Entities;
using Business.Logic;
using System;
using System.Web.UI;

namespace UI.Web
{
    public partial class Personas : Base
    {
        private static PersonaLogic PersonaLogic = new PersonaLogic();

        private Persona PersonaActual { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidarPermisos(Persona.TiposPersonas.Administrador);
            if (!Page.IsPostBack)
            {
                Listar();
            }
        }
      

        protected void gvPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedID = (int)gvPersonas.SelectedValue;
        }

        protected void linkNuevo_Click(object sender, EventArgs e)
        {
            Modo = ModoForm.Alta;
            try
            {
                MapearInicial();
                ShowForm(true);
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
        }

        protected void linkEditar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected())
            {
                Modo = ModoForm.Modificacion;
                try
                {
                    MapearInicial();
                    ShowForm(true);
                    MapearForm(SelectedID);
                }
                catch (Exception ex)
                {
                    Notificar(ex.Message);
                }
            }
        }

        protected void linkEliminar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected())
            {
                Modo = ModoForm.Baja;
                try
                {
                    MapearInicial();
                    ShowForm(true);
                    MapearForm(SelectedID);
                }
                catch (Exception ex)
                {
                    Notificar(ex.Message);
                }
            }
        }

        protected void linkAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                if (IsValid)
                {
                    SaveEntity(SelectedID);
                    ShowForm(false);
                    Listar();
                }
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
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
            linkAgregar.Visible = !visible;
        }

        private void ClearForm()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtLegajo.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

        private void MapearInicial()
        {
          
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

            ddlTipo.DataSource = Enum.GetValues(typeof(Persona.TiposPersonas));
            ddlTipo.DataBind();
            ddlTipo.Items.Insert(0, "[Seleccionar]");

            ddlPlan.DataSource = new PlanLogic().GetAll();
            ddlPlan.DataBind();
            ddlPlan.Items.Insert(0, "[Seleccionar]");
        }

        private void MapearForm(int id)
        {
            PersonaActual = PersonaLogic.GetOne(id);

            txtNombre.Text = PersonaActual.Nombre;
            txtApellido.Text = PersonaActual.Apellido;
            txtEmail.Text = PersonaActual.EMail;
            txtLegajo.Text = PersonaActual.Legajo?.ToString();
            ddlPlan.SelectedValue = PersonaActual.Plan?.ID.ToString();
            txtDireccion.Text = PersonaActual.Direccion;
            txtTelefono.Text = PersonaActual.Telefono;
            calendarFecha.SelectedDate = DateTime.Parse(PersonaActual.FechaNacimiento.ToString());
            ddlTipo.SelectedValue = PersonaActual.Tipo.ToString();
        }

        private void MapearEntidad()
        {
            PersonaActual = PersonaLogic.GetOne(SelectedID);
            switch (Modo)
            {
                case ModoForm.Baja:
                    SelectedID.ToString();
                    PersonaActual.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Alta:
                    PersonaActual = new Persona { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    PersonaActual.State = BusinessEntity.States.Modified;
                    break;
            }
            PersonaActual.Nombre = txtNombre.Text;
            PersonaActual.Apellido = txtApellido.Text;
            PersonaActual.EMail = txtEmail.Text;

            int.TryParse(txtLegajo.Text, out int legajo);
            if (legajo != 0)
            {
                PersonaActual.Legajo = legajo;
            }
            else
            {
                PersonaActual.Legajo = null;
            }
            if (ddlPlan.SelectedIndex > 0)
            {
                int.TryParse(ddlPlan.SelectedValue, out int idPlan);
                PersonaActual.Plan = new PlanLogic().GetOne(idPlan);
            }
            else
            {
                PersonaActual.Plan = null;
            }
            PersonaActual.Direccion = txtDireccion.Text;
            PersonaActual.Telefono = txtTelefono.Text;
            PersonaActual.FechaNacimiento = calendarFecha.SelectedDate;
            PersonaActual.Tipo = (Persona.TiposPersonas)Enum.Parse(typeof(Persona.TiposPersonas), ddlTipo.SelectedValue);
        }

        private void SaveEntity(int id)
        {
            try
            {
                PersonaActual = PersonaLogic.GetOne(id);
                MapearEntidad();
                PersonaLogic.Save(PersonaActual);
                if (Modo == ModoForm.Baja)
                {
                    //Resetear ID seleccionado cuando se borra un registro, ya que el ID dejara de existir.
                    SelectedID = 0;
                }
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
        }

        private void Listar()
        {
            try
            {
                gvPersonas.DataSource = PersonaLogic.GetAll();
                gvPersonas.DataBind();
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
        }

        protected void linkAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inscripciones.aspx");
        }
    }
}