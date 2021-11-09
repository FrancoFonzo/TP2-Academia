using System.Collections.Generic;
using System.Windows.Forms;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class AlumnoInscripcionLogic : BusinessLogic
    {
        public AlumnoInscripcionLogic()
        {
            InscripcionData = new AlumnoInscripcionAdapter();
        }

        private AlumnoInscripcionAdapter InscripcionData { get; set; }

        public List<AlumnoInscripcion> GetAll()
        {
            return InscripcionData.GetAll();
        }

        public List<AlumnoInscripcion> GetAllAlumno(int id)
        {
            return InscripcionData.GetAllByAlumno(id);
        }
		
		public List<AlumnoInscripcion> GetAllByCurso(int idCurso)
        {
            return InscripcionData.GetAllByCurso(idCurso);
        }

        public AlumnoInscripcion GetOne(int id)
        {
            return InscripcionData.GetOne(id);
        }

        public void Save(AlumnoInscripcion inscripcion)
        {
            InscripcionData.Save(inscripcion);
        }

        public int CountInscripcionesByCursos(int idCurso)
        {
            return InscripcionData.CountInscripcionesByCursos(idCurso);
        }
        public bool ValidarCupo(Curso curso)
        {
            if (new AlumnoInscripcionLogic().CountInscripcionesByCursos(curso.ID) >= curso.Cupo)
            {
                MessageBox.Show("Sin cupos", "El curso no tiene mas cupos disponibles.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
