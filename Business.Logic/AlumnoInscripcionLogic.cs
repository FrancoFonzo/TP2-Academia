using System.Collections.Generic;
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
		
		public List<AlumnoInscripcion> GetAllByCursos(int idCurso)
        {
            return InscripcionData.GetAllByCursos(idCurso);
        }

        public AlumnoInscripcion GetOne(int id)
        {
            return InscripcionData.GetOne(id);
        }

        public void Save(AlumnoInscripcion inscripcion)
        {
            InscripcionData.Save(inscripcion);
        }
    }
}
