//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PayRolManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VW_GETEMPLOYEE
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string CNIC { get; set; }
        public Nullable<System.DateTime> Date_of_Birth { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> Hire_Date { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<double> Basic_Salary { get; set; }
        public Nullable<double> Annual_Bonus { get; set; }
        public Nullable<double> Medical_Alowance { get; set; }
        public Nullable<int> Annual_Casual_Leaves { get; set; }
        public Nullable<int> Sick_Leaves { get; set; }
        public Nullable<int> Annual_Leaves { get; set; }
    }
}
