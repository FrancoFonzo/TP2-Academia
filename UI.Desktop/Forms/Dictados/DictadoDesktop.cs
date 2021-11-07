using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Util;

namespace UI.Desktop
{
    public partial class DictadoDesktop : ApplicationForm
    {
        private DocenteCurso DictadoActual { get; set; }

        public DictadoDesktop()
        {
            InitializeComponent();
        }

        public DictadoDesktop(ModoForm modo) : this()
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

        public DictadoDesktop(int id, ModoForm modo) : this(modo)
        {
            try
            {
                DictadoActual = new DocenteCursoLogic().GetOne(id);
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
            cbxCursos.DataSource = new CursoLogic().GetAll();
            cbxDocentes.DataSource = new PersonaLogic().GetAllTipo(Persona.TiposPersonas.Docente);
            cbxTiposCargos.DataSource = Enum.GetValues(typeof(DocenteCurso.TiposCargos));

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
            txtID.Text = DictadoActual.ID.ToString();
            cbxCursos.SelectedValue = DictadoActual.Curso.ID;
            cbxDocentes.SelectedItem = DictadoActual.Docente;
            cbxTiposCargos.SelectedItem = DictadoActual.Cargo;
        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Baja:
                    DictadoActual.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Consulta:
                    DictadoActual.State = BusinessEntity.States.Unmodified;
                    return;
                case ModoForm.Alta:
                    DictadoActual = new DocenteCurso { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    DictadoActual.State = BusinessEntity.States.Modified;
                    break;
            }
            DictadoActual.Curso = (Curso)cbxCursos.SelectedItem;
            DictadoActual.Docente = (Persona)cbxDocentes.SelectedItem;
            DictadoActual.Cargo = (DocenteCurso.TiposCargos)Enum.Parse(typeof(DocenteCurso.TiposCargos), cbxTiposCargos.SelectedValue.ToString());
        }
        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                new DocenteCursoLogic().Save(DictadoActual);
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto(
                new List<string> {
                    cbxCursos.SelectedValue.ToString(),
                    cbxDocentes.SelectedValue.ToString(),
                    cbxCursos.SelectedValue.ToString()
                }))
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
