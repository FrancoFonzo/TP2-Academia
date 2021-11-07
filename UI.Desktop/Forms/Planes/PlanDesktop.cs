using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;
using Util;

namespace UI.Desktop
{
    public partial class PlanDesktop : ApplicationForm
    {
        private Plan PlanActual { get; set; }

        public PlanDesktop()
        {
            InitializeComponent();
        }

        public PlanDesktop(ModoForm modo) : this()
        {
            try
            {
                Modo = modo;
                MapearInicial();
            }
            catch (Exception ex)
            {
                throw ex;
            }   
        }

        public PlanDesktop(int id, ModoForm modo) : this(modo)
        {
            try
            {
                PlanActual = new PlanLogic().GetOne(id);
                MapearDeDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MapearInicial()
        {
            cbxEspecialidad.DataSource = new EspecialidadLogic().GetAll();

            switch (Modo)
            {
                case ModoForm.Alta:
                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Consulta:
                    btnAceptar.Text = "Aceptar";
                    break;
            }
        }

        public override void MapearDeDatos()
        {
            txtID.Text = PlanActual.ID.ToString();
            txtDescripcion.Text = PlanActual.Descripcion;
            cbxEspecialidad.SelectedItem = PlanActual.Especialidad;
        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Baja:
                    PlanActual.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Consulta:
                    PlanActual.State = BusinessEntity.States.Unmodified;
                    return;
                case ModoForm.Alta:
                    PlanActual = new Plan { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    PlanActual.State = BusinessEntity.States.Modified;
                    break;
            }
            PlanActual.Descripcion = txtDescripcion.Text;
            PlanActual.Especialidad = (Especialidad)cbxEspecialidad.SelectedItem;
        }

        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                new PlanLogic().Save(PlanActual);
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto(new List<string> { txtDescripcion.Text }))
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbxEspecialidad.SelectedItem == null)
            {
                Notificar("Informacion invalida", "Porfavor seleccione una especialidad valida.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
