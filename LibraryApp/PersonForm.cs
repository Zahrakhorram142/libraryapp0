using BaseBakend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;
using BaseBakend.Repository;
using System.Xml.Linq;
using BaseBackend.Enums;

namespace LibraryApp
{
    public partial class PersonForm : Form
    {
        Person selectedPerson = null;
        public delegate void RefreshDataDelegate();

        public event RefreshDataDelegate RefreshDataEvent;

        public PersonForm()
        {
            InitializeComponent();
            RefreshDataEvent += LoadFormData;
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));
            RefreshDataEvent?.Invoke();

        }
        private void LoadFormData()
        {
            PersonRepository personRepository = new PersonRepository();
            List<Person> persons = personRepository.GetAll();
            personDataGridView.DataSource = null;
            personDataGridView.DataSource = persons;
            personDataGridView.Refresh();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string phoneNumber;
            Person person = new Person();
            try
            {
                person.NationalCode = Person.IsValidCode(NationalCodeTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                person.FirstName = Person.IsValidInput(FirstNameTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                person.LastName = Person.IsValidInput(LastNameTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                phoneNumber = Person.IsValidPhoneNumber(PhoneNumberTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            person.PhoneNumber = Person.ReplacePhone(phoneNumber);
            person.IsAdmin = IsAdminCheckBox.Checked;
            person.BirthDate = birthDatedateTimePicker.Value;
            person.CreationDate = PersonDataTimePicker.Value;
            person.IsActive = IsActivecheckBox.Checked;
            person.Gender = (Gender)genderComboBox.SelectedItem;
            if (person.IsAdmin)
            {
                person.IsAdmin = true;
                AdminForm frm = new AdminForm();
                frm.ShowDialog();

            };

            PersonRepository personRepository = new PersonRepository();
            personRepository.AddItem(person);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }


        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void ClearForm()
        {
            NationalCodeTextBox.Text = default;
            FirstNameTextBox.Text = default;
            LastNameTextBox.Text = default;
            PhoneNumberTextBox.Text = default;
            IsActivecheckBox.Checked = default;
            IsAdminCheckBox.Checked = default;
            selectedPerson = null;
            genderComboBox.SelectedItem = default;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedPerson is null)
            {
                MessageBox.Show("Please Select An Item");
                return;
            }
            PersonRepository personRepository = new PersonRepository();
            personRepository.DeleteItem(id: selectedPerson.Id);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }

        private void personDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (personDataGridView.SelectedCells.Count > 0)
            {
                var selectedRowindex = personDataGridView.SelectedCells[0].RowIndex;
                var row = personDataGridView.Rows[selectedRowindex];
                int id = int.Parse(row.Cells["Id"].Value.ToString());
                PersonRepository personRepository = new PersonRepository();
                Person person = personRepository.GetById(id);
                NationalCodeTextBox.Text = person.NationalCode;
                FirstNameTextBox.Text = person.FirstName;
                LastNameTextBox.Text = person.LastName;
                PhoneNumberTextBox.Text = person.PhoneNumber;
                IsActivecheckBox.Checked = person.IsActive;
                IsAdminCheckBox.Checked = person.IsAdmin;
                genderComboBox.SelectedItem = person.Gender;
                selectedPerson = person;


            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPerson is null)
            {
                MessageBox.Show("Please Select An Item");
                return;
            }
            PersonRepository personRepository = new PersonRepository();
            selectedPerson.NationalCode = NationalCodeTextBox.Text;
            selectedPerson.FirstName = FirstNameTextBox.Text;
            selectedPerson.LastName = LastNameTextBox.Text;
            selectedPerson.PhoneNumber = PhoneNumberTextBox.Text;
            selectedPerson.BirthDate = birthDatedateTimePicker.Value;
            selectedPerson.CreationDate = PersonDataTimePicker.Value;
            selectedPerson.Gender = (Gender)genderComboBox.SelectedItem;
            personRepository.UpdateItem(selectedPerson);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }


    }
}
