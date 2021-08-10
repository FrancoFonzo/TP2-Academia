using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.cbxPlan.DataSource = new PlanLogic().GetAll();
        }
        public ComisionDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }
        public ComisionDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            ComisionActual = new ComisionLogic().GetOne(ID);
            MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.ComisionActual.ID.ToString();
            this.txtDescripcion.Text = this.ComisionActual.Descripcion;
            this.txtAnioEspecialidad.Text = this.ComisionActual.AnioEspecialidad.ToString();
            
            this.cbxPlan.SelectedValue = this.ComisionActual.MiPlan.ID;
            
            if (Modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (Modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";

        }
        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                this.ComisionActual = new Comision { State = BusinessEntity.States.New };
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo == ModoForm.Modificacion)
                {
                    this.ComisionActual.State = BusinessEntity.States.Modified;
                }

                this.ComisionActual.Descripcion = this.txtDescripcion.Text;
                this.ComisionActual.AnioEspecialidad = int.Parse(this.txtAnioEspecialidad.Text);
          
                this.ComisionActual.MiPlan = new PlanLogic().GetOne((int)this.cbxPlan.SelectedValue);
               


            }
            else if (Modo == ModoForm.Baja) ComisionActual.State = BusinessEntity.States.Deleted;
            else if (Modo == ModoForm.Consulta) ComisionActual.State = BusinessEntity.States.Unmodified;
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            new ComisionLogic().Save(ComisionActual);
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
                        {txtDescripcion.Text,  txtAnioEspecialidad.Text})
                )
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.cbxPlan.SelectedValue == null)
            {
                Notificar("Informacion invalida", "El plan especificada no existe.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else return true;
            return false;
        }


    }
}
