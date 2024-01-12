namespace LibraryApp
{
    partial class MemberForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SaveButton = new Button();
            FirstNameLable = new Label();
            LastNameLable = new Label();
            PhoneNumberLable = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            PhoneNumberTextBox = new TextBox();
            MemberDataGridView = new DataGridView();
            CancelButton = new Button();
            NationalCodeLable = new Label();
            NationalCodeTextBox = new TextBox();
            CreationDateLable = new Label();
            MemberDataTimePicker = new DateTimePicker();
            IsActiveCheckBox = new CheckBox();
            MembershipDateLable = new Label();
            MembershipDateDataTimePicker = new DateTimePicker();
            BirthDatelabel = new Label();
            BirthDatedateTimePicker = new DateTimePicker();
            Genderlabel = new Label();
            genderComboBox = new ComboBox();
            Deletebutton = new Button();
            Updatebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)MemberDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(830, 246);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(104, 45);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // FirstNameLable
            // 
            FirstNameLable.AutoSize = true;
            FirstNameLable.Location = new Point(24, 59);
            FirstNameLable.Name = "FirstNameLable";
            FirstNameLable.Size = new Size(80, 20);
            FirstNameLable.TabIndex = 2;
            FirstNameLable.Text = "First Name";
            // 
            // LastNameLable
            // 
            LastNameLable.AutoSize = true;
            LastNameLable.Location = new Point(24, 97);
            LastNameLable.Name = "LastNameLable";
            LastNameLable.Size = new Size(79, 20);
            LastNameLable.TabIndex = 3;
            LastNameLable.Text = "Last Name";
            // 
            // PhoneNumberLable
            // 
            PhoneNumberLable.AutoSize = true;
            PhoneNumberLable.Location = new Point(24, 131);
            PhoneNumberLable.Name = "PhoneNumberLable";
            PhoneNumberLable.Size = new Size(108, 20);
            PhoneNumberLable.TabIndex = 4;
            PhoneNumberLable.Text = "Phone Number";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(161, 55);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(149, 27);
            FirstNameTextBox.TabIndex = 3;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(161, 88);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(149, 27);
            LastNameTextBox.TabIndex = 4;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(161, 121);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(149, 27);
            PhoneNumberTextBox.TabIndex = 5;
            // 
            // MemberDataGridView
            // 
            MemberDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MemberDataGridView.Location = new Point(2, 297);
            MemberDataGridView.Name = "MemberDataGridView";
            MemberDataGridView.RowHeadersWidth = 51;
            MemberDataGridView.RowTemplate.Height = 29;
            MemberDataGridView.Size = new Size(943, 284);
            MemberDataGridView.TabIndex = 14;
            MemberDataGridView.CellClick += MemberDataGridView_CellClick;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(720, 246);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(104, 45);
            CancelButton.TabIndex = 7;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // NationalCodeLable
            // 
            NationalCodeLable.AutoSize = true;
            NationalCodeLable.Location = new Point(24, 22);
            NationalCodeLable.Name = "NationalCodeLable";
            NationalCodeLable.Size = new Size(105, 20);
            NationalCodeLable.TabIndex = 16;
            NationalCodeLable.Text = "National Code";
            // 
            // NationalCodeTextBox
            // 
            NationalCodeTextBox.Location = new Point(161, 22);
            NationalCodeTextBox.Name = "NationalCodeTextBox";
            NationalCodeTextBox.Size = new Size(149, 27);
            NationalCodeTextBox.TabIndex = 2;
            // 
            // CreationDateLable
            // 
            CreationDateLable.AutoSize = true;
            CreationDateLable.Location = new Point(24, 225);
            CreationDateLable.Name = "CreationDateLable";
            CreationDateLable.Size = new Size(101, 20);
            CreationDateLable.TabIndex = 17;
            CreationDateLable.Text = "Creation Date";
            // 
            // MemberDataTimePicker
            // 
            MemberDataTimePicker.Location = new Point(158, 220);
            MemberDataTimePicker.Name = "MemberDataTimePicker";
            MemberDataTimePicker.Size = new Size(250, 27);
            MemberDataTimePicker.TabIndex = 18;
            // 
            // IsActiveCheckBox
            // 
            IsActiveCheckBox.AutoSize = true;
            IsActiveCheckBox.Location = new Point(161, 267);
            IsActiveCheckBox.Name = "IsActiveCheckBox";
            IsActiveCheckBox.Size = new Size(82, 24);
            IsActiveCheckBox.TabIndex = 19;
            IsActiveCheckBox.Text = "IsActive";
            IsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // MembershipDateLable
            // 
            MembershipDateLable.AutoSize = true;
            MembershipDateLable.Location = new Point(24, 192);
            MembershipDateLable.Name = "MembershipDateLable";
            MembershipDateLable.Size = new Size(128, 20);
            MembershipDateLable.TabIndex = 20;
            MembershipDateLable.Text = "Membership Date";
            // 
            // MembershipDateDataTimePicker
            // 
            MembershipDateDataTimePicker.Location = new Point(158, 187);
            MembershipDateDataTimePicker.Name = "MembershipDateDataTimePicker";
            MembershipDateDataTimePicker.Size = new Size(250, 27);
            MembershipDateDataTimePicker.TabIndex = 21;
            // 
            // BirthDatelabel
            // 
            BirthDatelabel.AutoSize = true;
            BirthDatelabel.Location = new Point(24, 159);
            BirthDatelabel.Name = "BirthDatelabel";
            BirthDatelabel.Size = new Size(76, 20);
            BirthDatelabel.TabIndex = 22;
            BirthDatelabel.Text = "Birth Date";
            // 
            // BirthDatedateTimePicker
            // 
            BirthDatedateTimePicker.Location = new Point(158, 154);
            BirthDatedateTimePicker.Name = "BirthDatedateTimePicker";
            BirthDatedateTimePicker.Size = new Size(250, 27);
            BirthDatedateTimePicker.TabIndex = 23;
            // 
            // Genderlabel
            // 
            Genderlabel.AutoSize = true;
            Genderlabel.Location = new Point(480, 25);
            Genderlabel.Name = "Genderlabel";
            Genderlabel.Size = new Size(57, 20);
            Genderlabel.TabIndex = 24;
            Genderlabel.Text = "Gender";
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(543, 25);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(176, 28);
            genderComboBox.TabIndex = 25;
            // 
            // Deletebutton
            // 
            Deletebutton.Location = new Point(520, 246);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(94, 45);
            Deletebutton.TabIndex = 26;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = true;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // Updatebutton
            // 
            Updatebutton.Location = new Point(620, 246);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(94, 45);
            Updatebutton.TabIndex = 27;
            Updatebutton.Text = "Update";
            Updatebutton.UseVisualStyleBackColor = true;
            Updatebutton.Click += Updatebutton_Click;
            // 
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(957, 614);
            Controls.Add(Updatebutton);
            Controls.Add(Deletebutton);
            Controls.Add(genderComboBox);
            Controls.Add(Genderlabel);
            Controls.Add(BirthDatedateTimePicker);
            Controls.Add(BirthDatelabel);
            Controls.Add(MembershipDateDataTimePicker);
            Controls.Add(MembershipDateLable);
            Controls.Add(IsActiveCheckBox);
            Controls.Add(MemberDataTimePicker);
            Controls.Add(CreationDateLable);
            Controls.Add(NationalCodeTextBox);
            Controls.Add(NationalCodeLable);
            Controls.Add(CancelButton);
            Controls.Add(MemberDataGridView);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(PhoneNumberLable);
            Controls.Add(LastNameLable);
            Controls.Add(FirstNameLable);
            Controls.Add(SaveButton);
            Name = "MemberForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member";
            ((System.ComponentModel.ISupportInitialize)MemberDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Label FirstNameLable;
        private Label LastNameLable;
        private Label PhoneNumberLable;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox PhoneNumberTextBox;
        private DataGridView MemberDataGridView;
        private Button CancelButton;
        private Label NationalCodeLable;
        private TextBox NationalCodeTextBox;
        private Label CreationDateLable;
        private DateTimePicker MemberDataTimePicker;
        private CheckBox IsActiveCheckBox;
        private Label MembershipDateLable;
        private DateTimePicker MembershipDateDataTimePicker;
        private Label BirthDatelabel;
        private DateTimePicker BirthDatedateTimePicker;
        private Label Genderlabel;
        private ComboBox genderComboBox;
        private Button Deletebutton;
        private Button Updatebutton;
    }
}