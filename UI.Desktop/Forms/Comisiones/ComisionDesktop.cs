using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;
using Util;

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

        public ComisionDesktop(int id, ModoForm modo) : this(modo)
        {
            try
            {
                ComisionActual = new ComisionLogic().GetOne(id);
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

            //TODO: comprobar que año sea número
            int.TryParse(txtAnioEspecialidad.Text, out int anio);
            if (anio < 1 || anio > 5)
            {
                throw new FormatException("El año debe ser un numero entre 1 y 5.");
            }
            ComisionActual.AnioEspecialidad = anio;
            ComisionActual.Descripcion = txtDescripcion.Text;
            ComisionActual.Plan = (Plan)cbxPlan.SelectedItem;
        }

        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                new ComisionLogic().Save(ComisionActual);
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto
                (new List<string> { txtDescripcion.Text, txtAnioEspecialidad.Text }))
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbxPlan.SelectedValue == null)
            {
                Notificar("Informacion invalida", "El plan especificada no existe.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
