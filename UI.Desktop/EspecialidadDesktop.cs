using System;
using Business.Logic;
using Business.Entities;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class EspecialidadDesktop : ApplicationForm
    {
        public EspecialidadDesktop()
        {
            InitializeComponent();
        }
        public EspecialidadDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public EspecialidadDesktop(int id, ModoForm modo) : this(modo)
        {
            EspecialidadActual = new EspecialidadLogic().GetOne(id);
            MapearDeDatos();
        }

        private Especialidad EspecialidadActual { get; set; }

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

        public override void MapearDeDatos()
        {
            txtID.Text = EspecialidadActual.ID.ToString();
            txtDescripcion.Text = EspecialidadActual.Descripcion;

            if (Modo == ModoForm.Consulta)
            {
                btnAceptar.Text = "Aceptar";
            }
            else if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                btnAceptar.Text = "Guardar";
            }
            else if (Modo == ModoForm.Baja)
            {
                btnAceptar.Text = "Eliminar";
            }
        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Baja:
                    EspecialidadActual.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Consulta:
                    EspecialidadActual.State = BusinessEntity.States.Unmodified;
                    return;
                case ModoForm.Alta:
                    EspecialidadActual = new Especialidad { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    EspecialidadActual.State = BusinessEntity.States.Modified;
                    break;
            }
            EspecialidadActual.Descripcion = txtDescripcion.Text;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            new EspecialidadLogic().Save(EspecialidadActual);
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto(new List<string> { txtDescripcion.Text }))
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
