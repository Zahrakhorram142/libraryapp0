using BaseBackend.Contract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace BaseBakend.Models;

public class Address : BaseEntity
{
    public int PersonId { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string FullAddress { get; set; }
    public string Pelak { get; set; }
    public string PostalCode { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreationDate { get; set; }
    public override bool IsActivateItem()
    {
        if (PostalCode is not null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


