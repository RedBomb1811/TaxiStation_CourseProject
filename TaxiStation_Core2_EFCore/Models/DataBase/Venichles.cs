//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestExample.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venichles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venichles()
        {
            this.Turns = new HashSet<Turns>();
        }
    
        public int id { get; set; }
        public string id_driver { get; set; }
        public string number { get; set; }
        public bool child { get; set; }
        public bool pets { get; set; }
        public string model { get; set; }
        public int venicle_type { get; set; }

        //public virtual Drivers Drivers { get; set; }
        //public virtual Order_types Order_types { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turns> Turns { get; set; }
    }
}
