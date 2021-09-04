using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class PlanDesktop : ApplicationForm
    {
        private Plan PlanActual { get; set; }

        public PlanDesktop()
        {
            InitializeComponent();
            cbxEspecialidad.DataSource = new EspecialidadLogic().GetAll();
        }

        public PlanDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public PlanDesktop(int id, ModoForm modo) : this(modo)
        {
            PlanActual = new PlanLogic().GetOne(id);
            MapearDeDatos();
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

        public override void MapearDeDatos()
        {
            txtID.Text = PlanActual.ID.ToString();
            txtDescripcion.Text = PlanActual.Descripcion;
            cbxEspecialidad.SelectedItem = PlanActual.Especialidad;

            if (Modo == ModoForm.Consulta)
            {
                btnAceptar.Text = "Aceptar";
            }
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                btnAceptar.Text = "Guardar";
            }
            else if (Modo == ModoForm.Baja)
            {
                btnAceptar.Text = "Eliminar";
            }
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
            MapearADatos();
            new PlanLogic().Save(PlanActual);
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto(new List<string> { txtDescripcion.Text }))
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxEspecialidad.SelectedItem == null)
            {
                Notificar("Informacion invalida", "Porfavor seleccione una especialidad valida.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                return true;
            }
            return false;
        }
    }
}
