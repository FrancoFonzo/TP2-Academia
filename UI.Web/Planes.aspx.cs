using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Planes : Base
    {
        private static PlanLogic PlanLogic = new PlanLogic();

        private Plan PlanActual { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidarPermisos(Persona.TiposPersonas.Administrador);
            if (!Page.IsPostBack)
            {
                Listar();
            }
        }

        protected void gvPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedID = (int)gvPlan.SelectedValue;
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
        }

        private void ClearForm()
        {
            txtDescripcion.Text = string.Empty;
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

            ddlEspecialidad.DataSource = new EspecialidadLogic().GetAll();
            ddlEspecialidad.DataBind();
            ddlEspecialidad.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        private void MapearForm(int id)
        {
            PlanActual = PlanLogic.GetOne(id);

            txtDescripcion.Text = PlanActual.Descripcion;

            ddlEspecialidad.SelectedValue = PlanActual.Especialidad?.ID.ToString();
        }

        private void MapearEntidad()
        {
            PlanActual = PlanLogic.GetOne(SelectedID);
            switch (Modo)
            {
                case ModoForm.Baja:
                    SelectedID.ToString();
                    PlanActual.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Alta:
                    PlanActual = new Plan { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    PlanActual.State = BusinessEntity.States.Modified;
                    break;
            }
            PlanActual.Descripcion = txtDescripcion.Text;
            int.TryParse(ddlEspecialidad.SelectedValue, out int idEspecilidad);
            PlanActual.Especialidad = new EspecialidadLogic().GetOne(idEspecilidad);

        }

        private void SaveEntity(int id)
        {
            try
            {
                PlanActual = PlanLogic.GetOne(id);
                MapearEntidad();
                PlanLogic.Save(PlanActual);
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
                gvPlan.DataSource = PlanLogic.GetAll();
                gvPlan.DataBind();
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
        }
    }
}
