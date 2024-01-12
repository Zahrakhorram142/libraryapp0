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
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class MemberForm : Form
    {
        Member selectedMember = null;
        public delegate void RefreshDataDelegate();
        public event RefreshDataDelegate RefreshDataEvent;
        public MemberForm()
        {
            InitializeComponent();
            RefreshDataEvent += LoadFormData;
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));
            RefreshDataEvent?.Invoke();
        }

        private void LoadFormData()
        {
            MemberRepository memberRepository = new MemberRepository();
            List<Member> members = memberRepository.GetAll();
            MemberDataGridView.DataSource = null;
            MemberDataGridView.DataSource = members;
            MemberDataGridView.Refresh();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string phoneNumber;
            Member member = new();
            try
            {
                member.NationalCode = Person.IsValidCode(NationalCodeTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                member.FirstName = Person.IsValidInput(FirstNameTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                member.LastName = Person.IsValidInput(LastNameTextBox.Text);
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
            member.PhoneNumber = Person.ReplacePhone(phoneNumber);
            member.BirthDate = BirthDatedateTimePicker.Value;
            member.MembershipDate = MembershipDateDataTimePicker.Value;
            member.CreationDate = MemberDataTimePicker.Value;
            member.IsActive = IsActiveCheckBox.Checked;
            MemberRepository memberRepository = new MemberRepository();
            memberRepository.AddItem(member);
            RefreshDataEvent?.Invoke();
            ClearForm();

        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ClearForm()
        {
            NationalCodeTextBox.Text = default;
            FirstNameTextBox.Text = default;
            LastNameTextBox.Text = default;
            PhoneNumberTextBox.Text = default;
            IsActiveCheckBox.Checked = default;
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (selectedMember is null)
            {
                MessageBox.Show("Please Select An Item");
                return;
            }
            MemberRepository memberRepository = new MemberRepository();
            memberRepository.DeleteItem(id: selectedMember.Id);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }

        private void MemberDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MemberDataGridView.SelectedCells.Count > 0)
            {
                var selectedRowindex = MemberDataGridView.SelectedCells[0].RowIndex;
                var row = MemberDataGridView.Rows[selectedRowindex];
                int id = int.Parse(row.Cells["Id"].Value.ToString());
                MemberRepository memberRepository = new MemberRepository();
                Member member = memberRepository.GetById(id);
                NationalCodeTextBox.Text = member.NationalCode;
                FirstNameTextBox.Text = member.FirstName;
                LastNameTextBox.Text = member.LastName;
                PhoneNumberTextBox.Text = member.PhoneNumber;
                IsActiveCheckBox.Checked = member.IsActive;
                selectedMember = member;


            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (selectedMember is null)
            {
                MessageBox.Show("Please Select An Item");
                return;
            }
            MemberRepository memberRepository = new MemberRepository();
            selectedMember.NationalCode = NationalCodeTextBox.Text;
            selectedMember.FirstName = FirstNameTextBox.Text;
            selectedMember.LastName = LastNameTextBox.Text;
            selectedMember.PhoneNumber = PhoneNumberTextBox.Text;
            selectedMember.BirthDate = BirthDatedateTimePicker.Value;
            selectedMember.CreationDate = MemberDataTimePicker.Value;
            selectedMember.Gender = (Gender)genderComboBox.SelectedItem;
            memberRepository.UpdateItem(selectedMember);
            RefreshDataEvent?.Invoke();
            ClearForm();
        }
    }

}
