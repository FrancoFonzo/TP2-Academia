using System.Collections.Generic;

namespace Business.Entities
{
    public class Especialidad : BusinessEntity
    {
        public string Descripcion { get; set; }

        #region Propiedades de Navegacion
        //public IList<Plan> MisPlanes { get; set; }
        #endregion

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
