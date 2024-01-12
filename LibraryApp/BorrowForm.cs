using BaseBackend.Enums;
using BaseBakend.Models;
using BaseBakend.Repository;
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
    public partial class BorrowForm : Form
    {
        Borrow selectedBorrow = null;
        public delegate void RefreshDataDelegate();
        public event RefreshDataDelegate RefreshDataEvent;
        public BorrowForm()
        {
            InitializeComponent();
            RefreshDataEvent += LoadFormdata;
            RefreshDataEvent?.Invoke();
        }

        private void LoadFormdata()
        {
            BorrowRepository borrowRepository = new BorrowRepository();
            List<Borrow> borrows = borrowRepository.GetAll();
            BorrowDataGridView.DataSource = null;
            BorrowDataGridView.DataSource = borrows;
            BorrowDataGridView.Refresh();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Borrow borrow = new();
            try
            {
                borrow.BorrowedBookName = Person.IsValidInput(borrowedBookNameTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            borrow.BorrowingDate = BorrowingDateDataTimePicker.Value;
            borrow.ReturnDate = ReturnDateDataTimePicker.Value;
            BorrowRepository borrowRepository = new BorrowRepository();
            borrowRepository.AddItem(borrow);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }

        private void ClearForm()
        {
            borrowedBookNameTextBox = default;

        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (selectedBorrow is null)
            {
                MessageBox.Show("Please Select An Item");
                return;
            }
            BorrowRepository borrowRepository = new BorrowRepository();
            borrowRepository.DeleteItem(id: selectedBorrow.Id);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }

        private void BorrowDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (BorrowDataGridView.SelectedCells.Count > 0)
            {
                var selectedRowindex = BorrowDataGridView.SelectedCells[0].RowIndex;
                var row = BorrowDataGridView.Rows[selectedRowindex];
                int id = int.Parse(row.Cells["Id"].Value.ToString());
                BorrowRepository borrowRepository = new BorrowRepository();
                Borrow borrow = borrowRepository.GetById(id);
                borrowedBookNameTextBox.Text = borrow.BorrowedBookName;
                BorrowingDateDataTimePicker.Value = borrow.BorrowingDate;
                ReturnDateDataTimePicker.Value = borrow.ReturnDate;
                selectedBorrow = borrow;


            }

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (selectedBorrow is null)
            {
                MessageBox.Show("Please Select An Item");
                return;
            }
            BorrowRepository borrowRepository = new BorrowRepository();
            selectedBorrow.BorrowedBookName = borrowedBookNameTextBox.Text;
            selectedBorrow.BorrowingDate = BorrowingDateDataTimePicker.Value;
            selectedBorrow.ReturnDate = ReturnDateDataTimePicker.Value;
            borrowRepository.UpdateItem(selectedBorrow);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }
    }
}


