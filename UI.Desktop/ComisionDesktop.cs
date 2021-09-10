using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class ComisionDesktop : ApplicationForm
    {
        private Comision ComisionActual { get; set; }

        public ComisionDesktop()
        {
            InitializeComponent();
        }

        public ComisionDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            MapearInicial();
        }

        public ComisionDesktop(int id, ModoForm modo) : this(modo)
        {
            ComisionActual = new ComisionLogic().GetOne(id);
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

        private void MapearInicial()
        {
            cbxPlan.DataSource = new PlanLogic().GetAll();
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
            txtID.Text = ComisionActual.ID.ToString();
            txtDescripcion.Text = ComisionActual.Descripcion;
            txtAnioEspecialidad.Text = ComisionActual.AnioEspecialidad.ToString();
            cbxPlan.SelectedItem = ComisionActual.Plan;
        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Baja:
                    ComisionActual.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Consulta:
                    ComisionActual.State = BusinessEntity.States.Unmodified;
                    return;
                case ModoForm.Alta:
                    ComisionActual = new Comision { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    ComisionActual.State = BusinessEntity.States.Modified;
                    break;
            }
            ComisionActual.Descripcion = txtDescripcion.Text;
            ComisionActual.AnioEspecialidad = int.Parse(txtAnioEspecialidad.Text);

            if (cbxPlan.SelectedValue != null)
            {
                ComisionActual.Plan = new PlanLogic().GetOne((int)cbxPlan.SelectedValue);
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            new ComisionLogic().Save(ComisionActual);
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto
                (new List<string> { txtDescripcion.Text, txtAnioEspecialidad.Text }))
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxPlan.SelectedValue == null)
            {
                Notificar("Informacion invalida", "El plan especificada no existe.",
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
