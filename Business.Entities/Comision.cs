using System.Collections.Generic;

namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        public string Descripcion { get; set; }
        public int AnioEspecialidad { get; set; }

        #region Propiedades de Navegacion
        public Plan MiPlan { get; set; }
        #endregion

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
