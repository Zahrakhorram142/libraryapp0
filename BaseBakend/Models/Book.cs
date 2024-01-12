using BaseBackend.Contract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Models;

public class Book : BaseEntity
{
    public string Name { get; set; }
    public string Writer { get; set; }
    public string Subject { get; set; }
    public string Publishers { get; set; }
    public int YearOfPublication { get; set; }
    public string Edition { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreationDate { get; set; }
    public override bool IsActivateItem()
    {
        if(Name is not null)
        {
            return true;
        }
        else
        {
            return false; 
        }
    }
}
