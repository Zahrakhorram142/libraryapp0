using BaseBackend.Contract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Models;

public class Employee : Person
{
    public string JobTitle { get; set; }
    public DateTime EmployeementDate { get; set; }
    public DateTime CreationDate { get; set; }
    public bool IsActive { get; set; }
    public override bool IsActivateItem()
    {
        if (JobTitle is not null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
