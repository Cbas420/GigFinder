//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GigFinder.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Musicians
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musicians()
        {
            this.Events = new HashSet<Events>();
        }
    
        public int id { get; set; }
        public byte size { get; set; }
        public int price { get; set; }
        public int songs_lang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Events> Events { get; set; }
        public virtual Languages Languages { get; set; }
        public virtual Users Users { get; set; }
    }
}
