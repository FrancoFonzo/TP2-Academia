using System;
using Business.Logic;
using Business.Entities;
using System.Collections.Generic;
using System.Windows.Forms;

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

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.EspecialidadActual.ID.ToString();
            this.txtDescripcion.Text = this.EspecialidadActual.Descripcion;

            if (Modo == ModoForm.Consulta) this.btnAceptar.Text = "Aceptar";
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion) this.btnAceptar.Text = "Guardar";
            else if (Modo == ModoForm.Baja) this.btnAceptar.Text = "Eliminar";

        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                this.EspecialidadActual = new Especialidad { State = BusinessEntity.States.New };
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (Modo == ModoForm.Modificacion)
                {
                    this.EspecialidadActual.State = BusinessEntity.States.Modified;
                }
                this.EspecialidadActual.Descripcion = this.txtDescripcion.Text;
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

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto(new List<string>
                        {txtDescripcion.Text})
                )
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else return true;
            return false;
        }
    }
}
