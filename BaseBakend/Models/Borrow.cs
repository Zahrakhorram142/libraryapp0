using BaseBackend.Contract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Models;

public class Borrow : BaseEntity
{
    public string BorrowedBookName { get; set; }
    public DateTime BorrowingDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public override bool IsActivateItem()
    {
        if (BorrowedBookName != null) return true;
        return false;
    }
}
