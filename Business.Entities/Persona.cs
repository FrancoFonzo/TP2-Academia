using System;
using System.Collections.Generic;

namespace Business.Entities
{
    public class Persona : BusinessEntity
    {
        public Persona()
        {
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string EMail { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int? Legajo { get; set; }
        public TiposPersonas Tipo { get; set; }

        #region Propiedades de Navegacion
        public virtual Plan MiPlan { get; set; }
        public virtual IList<AlumnoInscripcion> MisInscripciones { get; set; }
        public virtual IList<DocenteCurso> MisDictados { get; set; }
        #endregion

        #region Propiedades Auxiliares/DataPropertyName
        public string NombreCompleto
        {
            get
            {
                return $"{Nombre} {Apellido}";
            }
        } 
        #endregion

        public enum TiposPersonas
        {
            Administrador,
            Alumno,
            Docente
        }
    }
}
