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
    
    public partial class DISIPLINE_DEPARTMENT
    {
        public int ID_DISDEP { get; set; }
        public int ID_DEPARTMENT { get; set; }
        public int ID_DISIPLINE { get; set; }
    
        public virtual DEPARTMENT DEPARTMENT { get; set; }
        public virtual DISIPLINE DISIPLINE { get; set; }
    }
}