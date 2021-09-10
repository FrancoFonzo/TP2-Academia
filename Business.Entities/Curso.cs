namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        public int AnioCalendario { get; set; }
        public int Cupo { get; set; }
        public string Descripcion
        {
            get
            {
                return $"{Materia} - {Comision} - {AnioCalendario}";
            }
        }

        #region Propiedades de Navegacion
        public int MateriaId { get; set; }
        private Materia _materia;
        public virtual Materia Materia
        {
            get
            {
                return _materia;
            }
            set
            {
                if (value != null)
                {
                    _materia = value;
                    MateriaId = value.ID;
                }
            }
        }
        public int ComisionId { get; set; }
        private Comision _comision;
        public virtual Comision Comision
        {
            get
            {
                return _comision;
            }
            set
            {
                if (value != null)
                {
                    _comision = value;
                    ComisionId = value.ID;
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
