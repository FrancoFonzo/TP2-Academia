//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class cursos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cursos()
        {
            this.alumnos_inscripciones = new HashSet<alumnos_inscripciones>();
            this.docentes_cursos = new HashSet<docentes_cursos>();
        }
    
        public int id_curso { get; set; }
        public int id_materia { get; set; }
        public int id_comision { get; set; }
        public int anio_calendario { get; set; }
        public int cupo { get; set; }
        public string descripcion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alumnos_inscripciones> alumnos_inscripciones { get; set; }
        public virtual comisiones comisiones { get; set; }
        public virtual materias materias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<docentes_cursos> docentes_cursos { get; set; }
    }
}
