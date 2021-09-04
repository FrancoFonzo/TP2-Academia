namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
        public string Descripcion { get; set; }

        #region Propiedades de Navegacion
        public int EspecialidadId { get; set; }
        private Especialidad _especialidad;
        public virtual Especialidad Especialidad
        {
            get
            {
                return _especialidad;
            }
            set
            {
                if (value != null)
                {
                    _especialidad = value;
                    EspecialidadId = value.ID;
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
