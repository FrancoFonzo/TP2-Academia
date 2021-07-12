using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Persona : BusinessEntity
    {

        //List<AlumnoInscripcion> misInscripciones;
        //List<DocenteCurso> misDictados;
        public enum TiposPersonas
        {
            Administrador,
            Alumno,
            Docente
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string EMail { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int? Legajo { get; set; }
        public TiposPersonas Tipo { get; set; }
        //public Plan MiPlan { get; set; }
        //public List<AlumnoInscripcion> MisInscripciones { get => misInscripciones; set => misInscripciones = value; }
        //public List<DocenteCurso> MisDictados { get => misDictados; set => misDictados = value; }

        public string NombreCompleto { get { return this.ToString(); } }
    }
}
