using System.Collections.Generic;

namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
        public string Descripcion { get; set; }

        #region Propiedades de Navegacion
        public Especialidad MiEspecialidad { get; set; }
        /*public IList<Comision> MisComisiones { get; set; }
        public IList<Materia> MisMaterias { get; set; }
        public IList<Persona> MisPersonas { get; set; }*/ 
        #endregion

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
