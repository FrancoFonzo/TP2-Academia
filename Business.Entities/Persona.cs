using System;

namespace Business.Entities
{
    public class Persona : BusinessEntity
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? Legajo { get; set; }
        public string EMail { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public TiposPersonas Tipo { get; set; }

        #region Propiedades de Navegacion
        public int? PlanId { get; set; }
        private Plan _plan;
        public virtual Plan Plan
        {
            get
            {
                return _plan;
            }
            set
            {
                _plan = value;
                if (value == null)
                {
                    PlanId = null;
                }
                else
                {
                    PlanId = value.ID;
                }
            }
        }
        #endregion

        #region Propiedades Auxiliares
        public string NombreCompleto => ToString();
        #endregion

        public enum TiposPersonas
        {
            Administrador,
            Alumno,
            Docente
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
