using System;

namespace Business.Entities
{
    public class Persona : BusinessEntity
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string EMail { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int? Legajo { get; set; }
        public TiposPersonas Tipo { get; set; }
        public Plan MiPlan { get; set; }

        public enum TiposPersonas
        {
            Administrador,
            Alumno,
            Docente
        }

        public string NombreCompleto 
        { 
            get 
            { 
                return $"{Nombre} {Apellido}"; 
            } 
        }
    }
}
