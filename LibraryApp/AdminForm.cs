using BaseBakend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            admin.Username = UserNametextBox.Text;

            admin.Password = PasswordtextBox.Text;

            if (admin.Password == "142")
            {
                ManagementForm frm = new ManagementForm();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid ID please try again:");
            }
        }
    }
}
