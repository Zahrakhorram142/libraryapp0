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
    public partial class EmployeeForm : Form
    {

        Employee selectedEmployee = null;
        public delegate void RefreshDataDelegate();

        public event RefreshDataDelegate RefreshDataEvent;

        public EmployeeForm()
        {
            InitializeComponent();
            RefreshDataEvent += LoadFormData;
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));
            RefreshDataEvent?.Invoke();

        }
        private void LoadFormData()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            List<Employee> employees = employeeRepository.GetAll();
            EmployeeDataGridView.DataSource = null;
            EmployeeDataGridView.DataSource = employees;
            EmployeeDataGridView.Refresh();
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            Employee employee = new();
            string phoneNumber;
            try
            {
                employee.NationalCode = Person.IsValidCode(NationalCodeTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                employee.FirstName = Person.IsValidInput(FirstNameTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                employee.LastName = Person.IsValidInput(LastNameTextBox.Text);
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
            try
            {
                employee.JobTitle = Person.IsValidInput(JobTItleTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            employee.PhoneNumber = Person.ReplacePhone(phoneNumber);
            employee.EmployeementDate = EmployeementDateDataTimePicker.Value;
            employee.CreationDate = CreationDateDataTimePicker.Value;
            employee.BirthDate = BirthDatedateTimePicker.Value;
            employee.IsActive = IsActiveCheckBox.Checked;

            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.AddItem(employee);
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
            JobTItleTextBox.Text = default;
            selectedEmployee = null;
            genderComboBox.SelectedItem = default;
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {

            if (selectedEmployee is null)
            {
                MessageBox.Show("Please Select An Item");
                return;
            }
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.DeleteItem(id: selectedEmployee.Id);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }

        private void EmployeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (EmployeeDataGridView.SelectedCells.Count > 0)
            {
                var selectedRowindex = EmployeeDataGridView.SelectedCells[0].RowIndex;
                var row = EmployeeDataGridView.Rows[selectedRowindex];
                int id = int.Parse(row.Cells["Id"].Value.ToString());
                EmployeeRepository employeeRepository = new EmployeeRepository();
                Employee employee = employeeRepository.GetById(id);
                NationalCodeTextBox.Text = employee.NationalCode;
                FirstNameTextBox.Text = employee.FirstName;
                LastNameTextBox.Text = employee.LastName;
                PhoneNumberTextBox.Text = employee.PhoneNumber;
                JobTItleTextBox.Text = employee.JobTitle;
                IsActiveCheckBox.Checked = employee.IsActive;
                selectedEmployee = employee;


            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (selectedEmployee is null)
            {
                MessageBox.Show("Please Select An Item");
                return;
            }
            EmployeeRepository employeeRepository = new EmployeeRepository();
            selectedEmployee.NationalCode = NationalCodeTextBox.Text;
            selectedEmployee.FirstName = FirstNameTextBox.Text;
            selectedEmployee.LastName = LastNameTextBox.Text;
            selectedEmployee.PhoneNumber = PhoneNumberTextBox.Text;
            selectedEmployee.BirthDate = BirthDatedateTimePicker.Value;
            selectedEmployee.JobTitle = JobTItleTextBox.Text;
            selectedEmployee.EmployeementDate = EmployeementDateDataTimePicker.Value;
            selectedEmployee.CreationDate = CreationDateDataTimePicker.Value;
            selectedEmployee.Gender = (Gender)genderComboBox.SelectedItem;
            employeeRepository.UpdateItem(selectedEmployee);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }
    }
}
