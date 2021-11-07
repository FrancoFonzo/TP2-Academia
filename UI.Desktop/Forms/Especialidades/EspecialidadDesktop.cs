using System;
using Business.Logic;
using Business.Entities;
using System.Collections.Generic;
using System.Windows.Forms;
using Util;

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
            Modo = modo;
        }

        public EspecialidadDesktop(int id, ModoForm modo) : this(modo)
        {
            try
            {
                EspecialidadActual = new EspecialidadLogic().GetOne(id);
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

        public override void MapearDeDatos()
        {
            txtID.Text = EspecialidadActual.ID.ToString();
            txtDescripcion.Text = EspecialidadActual.Descripcion;

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
            try
            {
                MapearADatos();
                new EspecialidadLogic().Save(EspecialidadActual);
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
