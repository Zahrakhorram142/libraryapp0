using BaseBackend.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Models
{
    public class Admin : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public override bool IsActivateItem()
        {
            if (Password is not null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
