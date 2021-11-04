using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class CursoDesktop : ApplicationForm
    {
        private Curso CursoActual { get; set; }

        public CursoDesktop()
        {
            InitializeComponent();
        }

        public CursoDesktop(ModoForm modo) : this()
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

        public CursoDesktop(int id, ModoForm modo) : this(modo)
        {
            try
            {
            CursoActual = new CursoLogic().GetOne(id);
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
            cbxMateria.DataSource = new MateriaLogic().GetAll();
            cbxComision.DataSource = new ComisionLogic().GetAll();
            cbxDocente.DataSource = new PersonaLogic().GetAllTipo(Persona.TiposPersonas.Docente);

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
            txtID.Text = CursoActual.ID.ToString();
            txtDescripcion.Text = CursoActual.Descripcion;
            txtAñoCalendario.Text = CursoActual.AnioCalendario.ToString();
            txtCupo.Text = CursoActual.Cupo.ToString();
            cbxMateria.SelectedItem = CursoActual.Materia;
            cbxComision.SelectedItem= CursoActual.Comision;
            cbxDocente.SelectedItem = new DocenteCursoLogic().GetOneByCurso(CursoActual.ID).Docente;
        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Baja:
                    CursoActual.State = BusinessEntity.States.Deleted;
                    return;
                case ModoForm.Consulta:
                    CursoActual.State = BusinessEntity.States.Unmodified;
                    return;
                case ModoForm.Alta:
                    CursoActual = new Curso { State = BusinessEntity.States.New };
                    break;
                case ModoForm.Modificacion:
                    CursoActual.State = BusinessEntity.States.Modified;
                    break;
            }

            //TODO: Que año y cupo sea número
            int.TryParse(txtAñoCalendario.Text, out int anio);
            int.TryParse(txtCupo.Text, out int cupo);
            if (anio < 1 || cupo < 1)
            {
                throw new Exception("El año y el cupo deben ser numeros positivos.");
            }
            CursoActual.AnioCalendario = anio;
            CursoActual.Cupo = cupo;
            CursoActual.Materia = (Materia)cbxMateria.SelectedItem;
            CursoActual.Comision = (Comision)cbxComision.SelectedItem;
        }

        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                new CursoLogic().Save(CursoActual);
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override bool Validar()
        {
            int planComision = ((Comision)cbxComision.SelectedItem).PlanId;
            int planMateria = ((Materia)cbxMateria.SelectedItem).PlanId;

            if (!Validaciones.FormularioCompleto
                (new List<string> { txtCupo.Text, txtAñoCalendario.Text }))
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbxMateria.SelectedValue == null)
            {
                Notificar("Informacion invalida", "La materia especificada no existe.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbxComision.SelectedValue == null)
            {
                Notificar("Informacion invalida", "La comision especificada no existe.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (planComision != planMateria)
            {
                Notificar("Informacion invalida", "La comision y la materia deben pertenecer al mismo plan.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
