using System;
using System.Collections.Generic;
using Business.Logic;
using Business.Entities;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class MateriaDesktop : ApplicationForm
    {
        public MateriaDesktop()
        {
            InitializeComponent();
        }

        public MateriaDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            MapearInicial();
        }

        public MateriaDesktop(int ID, ModoForm modo) : this(modo)
        {
            MateriaActual = new MateriaLogic().GetOne(ID);
            MapearDeDatos();
        }

        private Materia MateriaActual { get; set; }

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
                int semanales = int.Parse(txtHsSemanales.Text);
                int totales = int.Parse(txtHsTotales.Text);
                if (semanales > 0 && totales > 0)
                {
                    MateriaActual.Descripcion = txtDescripcion.Text;
                    MateriaActual.HorasSemanales = semanales;
                    MateriaActual.HorasTotales = totales;
                    MateriaActual.Plan = (Plan)cbxPlan.SelectedItem;
                }
                else
                {
                    Notificar("Informacion invalida", "Las horas deben ser positivas.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                Notificar("Informacion invalida", "Las horas deben ser positivas.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            new MateriaLogic().Save(MateriaActual);
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto
                (new List<string> { txtDescripcion.Text, txtHsSemanales.Text, txtHsTotales.Text }))
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxPlan.SelectedValue == null)
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
