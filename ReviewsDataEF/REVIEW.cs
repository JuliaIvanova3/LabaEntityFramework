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
    
    public partial class REVIEW
    {
        public int ID_REVIEW { get; set; }
        public int ID_PROFESSOR { get; set; }
        public int ID_STUDENT { get; set; }
        public int ID_RATE { get; set; }
        public string INFO_REVIEW { get; set; }
    
        public virtual PROFESSOR PROFESSOR { get; set; }
        public virtual RATE RATE { get; set; }
        public virtual STUDENT STUDENT { get; set; }
    }
}
