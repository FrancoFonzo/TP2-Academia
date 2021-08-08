namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        public string Descripcion { get; set; }
        public int AñoEspecialidad { get; set; }
        public Plan MiPlan { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
