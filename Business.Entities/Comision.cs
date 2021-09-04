namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        public string Descripcion { get; set; }
        public int AnioEspecialidad { get; set; }

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
