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
    
    public partial class Firing
    {
        public int Id { get; set; }
        public int employeeId { get; set; }
        public string fireDescription { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
