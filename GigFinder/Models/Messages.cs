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
    
    public partial class Messages
    {
        public int id { get; set; }
        public Nullable<int> chat_id { get; set; }
        public int sender { get; set; }
        public string content { get; set; }
        public Nullable<int> file_identifier { get; set; }
        public System.DateTime date { get; set; }
        public string type { get; set; }
    
        public virtual ChatRooms ChatRooms { get; set; }
        public virtual Files Files { get; set; }
        public virtual Users Users { get; set; }
    }
}
