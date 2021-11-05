using Business.Entities;
using Business.Logic;
using System;
using System.Web.UI;

namespace UI.Web
{
    public partial class Comisiones : Base
    {
        private static ComisionLogic ComisionLogic = new ComisionLogic();
        private Comision ComisionActual { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ValidaSesion();
                Listar();
            }
        }

        protected void gvComisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gvComisiones.SelectedValue;
        }

        protected void linkNuevo_Click(object sender, EventArgs e)
        {
            Modo = ModoForm.Alta;
            try
            {
                MapearInicial();
                ShowForm(true);
            }catch(Exception ex)
            {
                Notificar(ex.Message);
            }
        }

        protected void linkEditar_Click(object sender, EventArgs e)
        {
            if (IsRowSelected())
            {
                Modo = ModoForm.Modificacion;
                try { 
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
                try { 
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
            try { 
                this.Validate();
                if (this.IsValid)
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
            this.ClearForm();
            formPanel.Visible = visible;
            gridPanel.Visible = !visible;
        }

        private void ClearForm()
        {
            txtAnio.Text = string.Empty;
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

            try { 
                ddlPlan.DataSource = new PlanLogic().GetAll();
                ddlPlan.DataBind();
                ddlPlan.Items.Insert(0, "[Seleccionar]");
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
        }

        private void MapearForm(int id)
        {
            try { 
                ComisionActual = ComisionLogic.GetOne(id);

                txtAnio.Text = ComisionActual.AnioEspecialidad.ToString();
                txtDescripcion.Text = ComisionActual.Descripcion;
                ddlPlan.SelectedValue = ComisionActual.Plan.ID.ToString();
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
        }

        private void MapearEntidad()
        {
            try { 
                ComisionActual = ComisionLogic.GetOne(SelectedID);
                switch (Modo)
                {
                    case ModoForm.Baja:
                        SelectedID.ToString();
                        ComisionActual.State = BusinessEntity.States.Deleted;
                        return;
                    case ModoForm.Alta:
                        ComisionActual = new Comision { State = BusinessEntity.States.New };
                        break;
                    case ModoForm.Modificacion:
                        ComisionActual.State = BusinessEntity.States.Modified;
                        break;
                }

                if(int.Parse(txtAnio.Text) > 0 && int.Parse(txtDescripcion.Text) > 0)
                {
                    ComisionActual.AnioEspecialidad = int.Parse(txtAnio.Text);
                    ComisionActual.Descripcion = txtDescripcion.Text;
                    ComisionActual.Plan = new PlanLogic().GetOne(int.Parse(ddlPlan.SelectedValue));
                }
                else
                {
                    Notificar("Año y comisión deben ser positivos");
                }
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
        }

        private void SaveEntity(int id)
        {
            try { 
                ComisionActual = ComisionLogic.GetOne(id);
                MapearEntidad();
                ComisionLogic.Save(ComisionActual);
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
                this.gvComisiones.DataSource = ComisionLogic.GetAll();
                this.gvComisiones.DataBind();
            }
            catch (Exception)
            {
                Notificar("Error al recuperar los datos de las comisiones.");
            }
        }
    }
}