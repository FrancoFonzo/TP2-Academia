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
            this.cbxPlan.DataSource = new PlanLogic().GetAll();
        }

        public MateriaDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public MateriaDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            MateriaActual = new MateriaLogic().GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.MateriaActual.ID.ToString();
            this.txtDescripcion.Text = this.MateriaActual.Descripcion;
            this.txtHsSemanales.Text = this.MateriaActual.HorasSemanales.ToString();
            this.txtHsTotales.Text = this.MateriaActual.HorasTotales.ToString();
            this.cbxPlan.SelectedValue = this.MateriaActual.MiPlan.ID;

            if (Modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) 
                this.btnAceptar.Text = "Guardar";
            else if (Modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";

        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                this.MateriaActual = new Materia { State = BusinessEntity.States.New };
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo == ModoForm.Modificacion)
                {
                    this.MateriaActual.State = BusinessEntity.States.Modified;
                }
                this.MateriaActual.Descripcion = this.txtDescripcion.Text;
                this.MateriaActual.HorasSemanales = int.Parse(this.txtHsSemanales.Text);
                this.MateriaActual.HorasTotales = int.Parse(this.txtHsTotales.Text);
                this.MateriaActual.MiPlan = new PlanLogic().GetOne((int)this.cbxPlan.SelectedValue);
            }
            else if (Modo == ModoForm.Baja) MateriaActual.State = BusinessEntity.States.Deleted;
            else if (Modo == ModoForm.Consulta) MateriaActual.State = BusinessEntity.States.Unmodified;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            new MateriaLogic().Save(MateriaActual);
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto(new List<string>
                        {txtDescripcion.Text, txtHsSemanales.Text, txtHsTotales.Text})
                )
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.cbxPlan.SelectedValue == null)
            {
                Notificar("Informacion invalida", "Porfavor seleccione una especialidad valida.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else return true;
            return false;
        }
    }
}
