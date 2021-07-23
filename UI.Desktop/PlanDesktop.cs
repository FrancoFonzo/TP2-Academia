using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class PlanDesktop : ApplicationForm
    {
        public PlanDesktop()
        {
            InitializeComponent();
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
            this.txtID_Especialidad.Text = this.PlanActual.ID_Especialidad;

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
                this.PlanActual.Descripcion = this.chkHabilitado.Checked;

                var idPlan = this.cbxPlan.SelectedValue;
                if (idPlan == null) this.PlanActual.MiPersona = null;
                else this.PlanActual.MiPlan = new PlanLogic().GetOne((int)idPlan);
                /*if (idPer == null) return;
                if (int.TryParse(idPer.ToString(), out int id))
                {
                    this.UsuarioActual.MiPersona = new PersonaLogic().GetOne(id);
                }*/
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

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
