using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRolManagementSystem.Models
{
    class EmployeeModelClass
    {
        public int emp_id { get; set; }
        public string emp_name { get; set; }
        public string emp_contact { get; set; }
        public string emp_cnic { get; set; }
        public Nullable<System.DateTime> emp_dob { get; set; }
        public string emp_image { get; set; }
        public Nullable<bool> emp_gender { get; set; }
        public string emp_email { get; set; }
        public Nullable<System.DateTime> emp_hireDate { get; set; }
        public Nullable<bool> emp_status { get; set; }

        // Working Status
        public int status_id { get; set; }
        public Nullable<int> status_emp_fk { get; set; }
        public Nullable<int> status_dep_fk { get; set; }
        public Nullable<int> status_year { get; set; }
        public Nullable<double> status_basicSalary { get; set; }
        public Nullable<double> status_bonus { get; set; }
        public Nullable<double> status_medical { get; set; }
        public Nullable<int> staus_casualLeave { get; set; }
        public Nullable<int> staus_sickLeave { get; set; }
        public Nullable<int> staus_halfDays { get; set; }
        public Nullable<int> staus_anualLeave { get; set; }

        // Departments
        public string dept_name { get; set; }
    
    }
}
