//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DJ_TPA_Program.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HeaderAttraction
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int AttractionId { get; set; }
        public int Area_Quantity { get; set; }
    
        public virtual Attraction Attraction { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
