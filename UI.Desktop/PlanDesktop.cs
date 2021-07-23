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
            this.cbxEspecialidad.DataSource = new EspecialidadLogic().GetAll();
        }

        public PlanDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            this.PlanActual = new PlanLogic().GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.PlanActual.ID.ToString();
            this.txtDescripcion.Text = this.PlanActual.Descripcion;
            this.cbxEspecialidad.Text = this.PlanActual.MiEspecialidad.Descripcion;

            if (Modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (Modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";

        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                this.PlanActual = new Plan() { State = BusinessEntity.States.New };
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo == ModoForm.Modificacion)
                {
                    this.PlanActual.ID = int.Parse(this.txtID.Text);
                    this.PlanActual.State = BusinessEntity.States.Modified;
                }
                this.PlanActual.Descripcion = this.txtDescripcion.Text;
                var idEsp = this.cbxEspecialidad.SelectedValue;
                this.PlanActual.MiEspecialidad = new EspecialidadLogic().GetOne((int)idEsp);
            }
            else if (Modo == ModoForm.Baja) PlanActual.State = BusinessEntity.States.Deleted;
            else if (Modo == ModoForm.Consulta) PlanActual.State = BusinessEntity.States.Unmodified;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            new PlanLogic().Save(PlanActual);
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
                        {txtDescripcion.Text, cbxEspecialidad.Text})
                )
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.cbxEspecialidad.SelectedValue == null)
            {
                Notificar("Informacion invalida", "La especialidad especificada no existe.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else return true;
            return false;
        }
    }
}
