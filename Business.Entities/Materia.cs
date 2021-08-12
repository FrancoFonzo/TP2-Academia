using System.Collections.Generic;

namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        public string Descripcion { get; set; }
        public int HorasSemanales { get; set; }
        public int HorasTotales { get; set; }

        #region Propiedades de Navegacion
        public Plan MiPlan { get; set; }
        //public IList<Curso> MisCursos { get; set; } 
        #endregion

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
