using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class EmployeeClass:PersonClass
    {
        public string employeeCode {  get; set; }   
        public string nationalCode { get; set;}
        public DateTime birthDate { get; set;} 
        public DateTime employeementDate { get; set;} 



    }
}
