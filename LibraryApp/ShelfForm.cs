using BaseBackend.Enums;
using BaseBakend.Models;
using BaseBakend.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class ShelfForm : Form
    {
        Shelf selectedShelf = null;
        public delegate void RefreshDataDelegate();
        public event RefreshDataDelegate RefreshDataEvent;
        public ShelfForm()
        {
            InitializeComponent();
            RefreshDataEvent += LoadFormData;
            RefreshDataEvent?.Invoke();
        }

        private void LoadFormData()
        {
            ShelfRepository shelfRepository = new ShelfRepository();
            List<Shelf> shelfs = shelfRepository.GetAll();
            ShelfDataGridView.DataSource = null;
            ShelfDataGridView.DataSource = shelfs;
            ShelfDataGridView.Refresh();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Shelf shelf = new();
            try
            {
                shelf.Floor = Person.IsValidInput(FloorTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                shelf.Title = Person.IsValidInput(TitleTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            ShelfRepository shelfRepository = new ShelfRepository();
            shelfRepository.AddItem(shelf);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }
        private void ClearForm()
        {
            FloorTextBox.Text = default;
            TitleTextBox.Text = default;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (selectedShelf is null)
            {
                MessageBox.Show("Please Select An Item");
                return;
            }
            ShelfRepository shelfRepository = new ShelfRepository();
            shelfRepository.DeleteItem(id: selectedShelf.Id);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }

        private void ShelfDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ShelfDataGridView.SelectedCells.Count > 0)
            {
                var selectedRowindex = ShelfDataGridView.SelectedCells[0].RowIndex;
                var row = ShelfDataGridView.Rows[selectedRowindex];
                int id = int.Parse(row.Cells["Id"].Value.ToString());
                ShelfRepository shelfRepository = new ShelfRepository();
                Shelf shelf = shelfRepository.GetById(id);
                FloorTextBox.Text = shelf.Floor;
                TitleTextBox.Text = shelf.Title;
                selectedShelf = shelf;


            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (selectedShelf is null)
            {
                MessageBox.Show("Please Select An Item");
                return;
            }
            ShelfRepository shelfRepository = new ShelfRepository();
            selectedShelf.Floor = FloorTextBox.Text;
            selectedShelf.Title = TitleTextBox.Text;
            shelfRepository.UpdateItem(selectedShelf);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }
    }
}
