using System;
using System.Web.UI;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Especialidades : Base
    {
        private static EspecialidadLogic EspecialidadLogic = new EspecialidadLogic();

        private Especialidad EspecialidadActual { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidarPermisos(Persona.TiposPersonas.Administrador);
            if (!Page.IsPostBack)
            {
                Listar();
            }
        }

        protected void gvEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedID = (int)gvEspecialidad.SelectedValue;
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
        }

        private void MapearForm(int id)
        {
            EspecialidadActual = EspecialidadLogic.GetOne(id);

            txtDescripcion.Text = EspecialidadActual.Descripcion;
        }

        private void MapearEntidad()
        {
            EspecialidadActual = EspecialidadLogic.GetOne(SelectedID);
            switch (Modo)
            {
                case ModoForm.Baja:
                    SelectedID.ToString();
                    EspecialidadActual.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Alta:
                    EspecialidadActual = new Especialidad { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    EspecialidadActual.State = BusinessEntity.States.Modified;
                    break;
            }
            EspecialidadActual.Descripcion = txtDescripcion.Text;
        }

        private void SaveEntity(int id)
        {
            try
            {
                EspecialidadActual = EspecialidadLogic.GetOne(id);
                MapearEntidad();
                EspecialidadLogic.Save(EspecialidadActual);
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
                gvEspecialidad.DataSource = EspecialidadLogic.GetAll();
                gvEspecialidad.DataBind();
            }
            catch (Exception ex)
            {
                Notificar(ex.Message);
            }
        }
    }
}
