using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        public Persona MiAlumno { get; set; }

        public Curso MiCurso { get; set; }

        public string Condicion { get; set; }

        public float? Nota { get; set; }
    }
}
