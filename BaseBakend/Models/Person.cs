using BaseBackend.Contract;
using BaseBackend.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Models
{
    public partial class Person : BaseEntity
    {
        public Gender Gender { get; set; }
        public string NationalCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public override bool IsActivateItem()
        {
            if (BirthDate is not null)
            {
                if (BirthDate < DateTime.Now)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
    }
}
