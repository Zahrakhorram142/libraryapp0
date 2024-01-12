using BaseBackend.Contract;
using BaseBakend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Models
{
    public class Member : Person
    {
        public DateTime MembershipDate { get; set; }
    }
}
