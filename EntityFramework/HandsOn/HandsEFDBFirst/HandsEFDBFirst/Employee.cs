//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HandsEFDBFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int employee_code { get; set; }
        public string employee_name { get; set; }
        public Nullable<System.DateTime> join_date { get; set; }
        public string designation { get; set; }
        public Nullable<decimal> salary { get; set; }
        public string project_code { get; set; }
    
        public virtual Project Project { get; set; }
    }
}
