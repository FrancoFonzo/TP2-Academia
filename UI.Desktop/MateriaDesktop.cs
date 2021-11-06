using System;
using System.Collections.Generic;
using Business.Logic;
using Business.Entities;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class MateriaDesktop : ApplicationForm
    {
        private Materia MateriaActual { get; set; }

        public MateriaDesktop()
        {
            InitializeComponent();
        }

        public MateriaDesktop(ModoForm modo) : this()
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

        public MateriaDesktop(int ID, ModoForm modo) : this(modo)
        {
            try
            {
                MateriaActual = new MateriaLogic().GetOne(ID);
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
            txtID.Text = MateriaActual.ID.ToString();
            txtDescripcion.Text = MateriaActual.Descripcion;
            txtHsSemanales.Text = MateriaActual.HorasSemanales.ToString();
            txtHsTotales.Text = MateriaActual.HorasTotales.ToString();
            cbxPlan.SelectedValue = MateriaActual.Plan.ID;
        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Baja:
                    MateriaActual.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Consulta:
                    MateriaActual.State = BusinessEntity.States.Unmodified;
                    return;
                case ModoForm.Alta:
                    MateriaActual = new Materia { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    MateriaActual.State = BusinessEntity.States.Modified;
                    break;
            }


            //TODO: horas número
            try
            {
                int.TryParse(txtHsSemanales.Text, out int hsSemana);
                int.TryParse(txtHsTotales.Text, out int hsTotal);
                if (hsSemana < 1 || hsTotal < 1)
                {
                    throw new Exception("Las horas deben ser numeros positivos.");
                }
                MateriaActual.Descripcion = txtDescripcion.Text;
                MateriaActual.HorasSemanales = hsSemana;
                MateriaActual.HorasTotales = hsTotal;
                MateriaActual.Plan = (Plan)cbxPlan.SelectedItem;
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                new MateriaLogic().Save(MateriaActual);
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto
                (new List<string> { txtDescripcion.Text, txtHsSemanales.Text, txtHsTotales.Text }))
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbxPlan.SelectedValue == null)
            {
                Notificar("Informacion invalida", "Porfavor seleccione una especialidad valida.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
