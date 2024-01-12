using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            BookForm frmBook = new BookForm();
            frmBook.ShowDialog();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            EmployeeForm frm = new EmployeeForm();
            frm.ShowDialog();
        }

        private void MembersButton_Click(object sender, EventArgs e)
        {
            MemberForm frm = new MemberForm();
            frm.ShowDialog();
        }

        private void ShelfsButton_Click(object sender, EventArgs e)
        {
            ShelfForm frm = new ShelfForm();
            frm.ShowDialog();
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            BorrowForm frm = new BorrowForm();
            frm.ShowDialog();
        }

        private void AddressesButton_Click(object sender, EventArgs e)
        {
            AddressForm frm = new AddressForm();
            frm.ShowDialog();
        }
    }
}
