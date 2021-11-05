using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class RegistrarNotas : ApplicationForm
    {
        private Persona PersonaActual { get; }

        public RegistrarNotas()
        {
            InitializeComponent();
            dgvAlumnos.AutoGenerateColumns = false;
        }

        public RegistrarNotas(Persona personaActual) : this()
        {
            PersonaActual = personaActual;
            try
            {
                cbxCursos.DataSource = new DocenteCursoLogic().GetAllByDocente(PersonaActual.ID);
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void Cursos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void cbxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                var alumno = (AlumnoInscripcion)dgvAlumnos.SelectedRows[0].DataBoundItem;
                try
                {
                    int.TryParse(txtNota.Text, out int nota);
                    if (nota < 1 || nota > 10)
                    {
                        throw new Exception("La nota debe ser un numero entre 1 y 10");
                    }
                    alumno.Nota = nota;
                    alumno.State = BusinessEntity.States.Modified;
                    SetCondicion(alumno);
                    new AlumnoInscripcionLogic().Save(alumno);
                }
                catch (Exception ex)
                {
                    Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Listar();
            }            
        }

        private static void SetCondicion(AlumnoInscripcion alumno)
        {
            if (alumno.Nota >= 6)
            {
                alumno.Condicion = AlumnoInscripcion.Condiciones.Aprobado;
            }
            else if (alumno.Nota >= 4)
            {
                alumno.Condicion = AlumnoInscripcion.Condiciones.Regular;
            }
            else
            {
                alumno.Condicion = AlumnoInscripcion.Condiciones.Inscripto;
            }
        }

        public override void Listar()
        {
            try
            {
                var idCurso = cbxCursos.SelectedValue;
                if (idCurso != null)
                {
                    dgvAlumnos.DataSource = new AlumnoInscripcionLogic().GetAllByCursos((int)idCurso);
                }
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto(new List<string> { txtNota.Text }))
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbxCursos.SelectedValue == null)
            {
                Notificar("Informacion invalida", "El curso especificado no existe.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return IsRowSelected(dgvAlumnos);
        }
    }
}
