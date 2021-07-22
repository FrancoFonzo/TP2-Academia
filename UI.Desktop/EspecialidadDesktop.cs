using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class EspecialidadDesktop : ApplicationForm
    {
        private Especialidad EspecialidadActual { get; set; }
        public EspecialidadDesktop()
        {
            InitializeComponent();
        }
        public EspecialidadDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public EspecialidadDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            this.EspecialidadActual = new EspecialidadLogic().GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                this.EspecialidadActual = new Especialidad() { State = BusinessEntity.States.New };
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo == ModoForm.Modificacion)
                {
                    this.EspecialidadActual.ID = int.Parse(this.txtID.Text);
                    this.EspecialidadActual.State = BusinessEntity.States.Modified;
                }
                this.EspecialidadActual.DescEspecialidad = this.txtDescripcion.Text;
            }
            else if (Modo == ModoForm.Baja) EspecialidadActual.State = BusinessEntity.States.Deleted;
            else if (Modo == ModoForm.Consulta) EspecialidadActual.State = BusinessEntity.States.Unmodified;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            new EspecialidadLogic().Save(EspecialidadActual);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
