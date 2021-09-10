namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        public string Descripcion { get; set; }
        public int HorasSemanales { get; set; }
        public int HorasTotales { get; set; }

        #region Propiedades de Navegacion
        public int PlanId { get; set; }
        private Plan _plan;
        public virtual Plan Plan
        {
            get
            {
                return _plan;
            }
            set
            {
                if (value != null)
                {
                    _plan = value;
                    PlanId = value.ID;
                }
            }
        }
        #endregion

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
