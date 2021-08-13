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
                return $"{MiMateria.Descripcion} - {MiComision.Descripcion} - {AnioCalendario}";
            }
        }

        #region Propiedades de Navegacion
        public Materia MiMateria { get; set; }
        public Comision MiComision { get; set; }
        #endregion

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
