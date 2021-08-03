namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        public string Descripcion { get; set; }
        public int HorasSemanales { get; set; }
        public int HorasTotales { get; set; }
        public Plan MiPlan { get; set; }
    }
}
