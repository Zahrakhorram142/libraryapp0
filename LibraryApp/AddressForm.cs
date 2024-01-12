using BaseBackend.Enums;
using BaseBakend.Models;
using BaseBakend.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryApp
{
    public partial class AddressForm : Form
    {
        Address selectedAddress = null;
        public delegate void RefreshDataDelegate();
        public event RefreshDataDelegate RefreshDataEvent;
        public AddressForm()
        {
            InitializeComponent();
            RefreshDataEvent += LoadFormdata;
            RefreshDataEvent?.Invoke();
        }
        private void LoadFormdata()
        {
            AddressRepository addressRepository = new AddressRepository();
            List<Address> addresses = addressRepository.GetAll();
            AddressDataGridView.DataSource = null;
            AddressDataGridView.DataSource = addresses;
            AddressDataGridView.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButten_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            try
            {
                address.City = Person.IsValidInput(CityTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            address.Street = StreetTextBox.Text;
            address.FullAddress = FullAddressTextBox.Text;
            try
            {
                address.Pelak = Person.IsValidInput(PelakTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                address.PostalCode = Person.IsValidCode(PostalCodeTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            address.CreationDate = CreationDateDataTimePicker.Value;
            address.IsActive = IsActiveCheckBox.Checked;
            AddressRepository addressRepository = new AddressRepository();
            addressRepository.AddItem(address);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }
        private void ClearForm()
        {
            PelakTextBox.Text = default;
            CityTextBox.Text = default;
            StreetTextBox.Text = default;
            FullAddressTextBox.Text = default;
            PostalCodeTextBox.Text = default;
            IsActiveCheckBox.Text = default;

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (selectedAddress is null)
            {
                MessageBox.Show("Please Select An Item");
                return;
            }
            AddressRepository addressRepository = new AddressRepository();
            addressRepository.DeleteItem(id: selectedAddress.Id);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }
        private void AddressDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AddressDataGridView.SelectedCells.Count > 0)
            {
                var selectedRowindex = AddressDataGridView.SelectedCells[0].RowIndex;
                var row = AddressDataGridView.Rows[selectedRowindex];
                int id = int.Parse(row.Cells["Id"].Value.ToString());
                AddressRepository addressRepository = new AddressRepository();
                Address address = addressRepository.GetById(id);
                CityTextBox.Text = address.City;
                StreetTextBox.Text = address.Street;
                FullAddressTextBox.Text = address.FullAddress;
                PelakTextBox.Text = address.Pelak;
                PostalCodeTextBox.Text = address.PostalCode;
                IsActiveCheckBox.Checked = address.IsActive;
                selectedAddress = address;


            }
        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (selectedAddress is null)
            {
                MessageBox.Show("Please Select An Item");
                return;
            }
            AddressRepository addressRepository = new AddressRepository();
            selectedAddress.City = CityTextBox.Text;
            selectedAddress.Street = StreetTextBox.Text;
            selectedAddress.FullAddress = FullAddressTextBox.Text;
            selectedAddress.Pelak = PelakTextBox.Text;
            selectedAddress.PostalCode = PostalCodeTextBox.Text;
            selectedAddress.CreationDate = CreationDateDataTimePicker.Value;
            addressRepository.UpdateItem(selectedAddress);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }

    }
}

