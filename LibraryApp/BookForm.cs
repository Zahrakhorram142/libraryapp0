using BaseBackend.Enums;
using BaseBakend.Models;
using BaseBakend.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class BookForm : Form
    {
        Book selectedBook = null;
        public delegate void RefreshDataDelegate();
        public event RefreshDataDelegate RefreshDataEvent;
        public BookForm()
        {
            InitializeComponent();
            RefreshDataEvent += LoadFormdata;
            RefreshDataEvent?.Invoke();

        }
        private void LoadFormdata()
        {
            BookRepository bookRepository = new BookRepository();
            List<Book> books = bookRepository.GetAll();
            BookDataGridView.DataSource = null;
            BookDataGridView.DataSource = books;
            BookDataGridView.Refresh();

        }

        public void SaveButton_Click(object sender, EventArgs e)
        {

            Book book = new();
            try
            {
                book.Name = Person.IsValidInput(NameTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                book.Writer = Person.IsValidInput(WriterTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                book.Subject = Person.IsValidInput(SubjectTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                book.Publishers = Person.IsValidInput(PublishersTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                book.YearOfPublication = int.Parse(Person.IsValidNumber(YearOfPublicationTextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                book.Edition = Person.IsValidInput(EditionTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            book.CreationDate = CreationDateDataTimePicker.Value;
            book.IsActive = IsActiveCheckBox.Checked;
            BookRepository bookRepository = new BookRepository();
            bookRepository.AddItem(book);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }

        private void ClearForm()
        {
            NameTextBox.Text = default;
            WriterTextBox.Text = default;
            SubjectTextBox.Text = default;
            PublishersTextBox.Text = default;
            YearOfPublicationTextBox.Text = default;
            EditionTextBox.Text = default;

        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (selectedBook is null)
            {
                MessageBox.Show("Please Select An Item");
                return;
            }
            BookRepository bookRepository = new BookRepository();
            bookRepository.DeleteItem(id: selectedBook.Id);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }
        private void BookDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (BookDataGridView.SelectedCells.Count > 0)
            {
                var selectedRowindex = BookDataGridView.SelectedCells[0].RowIndex;
                var row = BookDataGridView.Rows[selectedRowindex];
                int id = int.Parse(row.Cells["Id"].Value.ToString());
                BookRepository bookRepository = new BookRepository();
                Book book = bookRepository.GetById(id);
                NameTextBox.Text = book.Name;
                WriterTextBox.Text = book.Writer;
                SubjectTextBox.Text = book.Subject;
                PublishersTextBox.Text = book.Publishers;
                YearOfPublicationTextBox.Text = book.IsActive.ToString();
                EditionTextBox.Text = book.Edition;
                IsActiveCheckBox.Checked = book.IsActive;
                selectedBook = book;


            }
        }


        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (selectedBook is null)
            {
                MessageBox.Show("Please Select An Item");
                return;
            }
            BookRepository bookRepository = new BookRepository();
            selectedBook.Name = NameTextBox.Text;
            selectedBook.Writer = WriterTextBox.Text;
            selectedBook.Subject = SubjectTextBox.Text;
            selectedBook.Publishers = PublishersTextBox.Text;
            //selectedBook.YearOfPublication = int.Parse(Person.IsValidNumber(YearOfPublicationTextBox.Text));
            selectedBook.Edition = EditionTextBox.Text;
            selectedBook.CreationDate = CreationDateDataTimePicker.Value;
            bookRepository.UpdateItem(selectedBook);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }


    }


}
