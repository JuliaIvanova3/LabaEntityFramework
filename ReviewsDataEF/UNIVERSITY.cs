//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReviewsDataEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class UNIVERSITY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UNIVERSITY()
        {
            this.FACULTY = new HashSet<FACULTY>();
        }
    
        public int ID_UNIVERSITY { get; set; }
        public string NAME_UNIVERSITY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACULTY> FACULTY { get; set; }
    }
}