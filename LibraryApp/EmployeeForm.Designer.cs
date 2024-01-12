namespace LibraryApp
{
    partial class EmployeeForm
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
            NationalCodeLable = new Label();
            FirstNameLable = new Label();
            LastNameLable = new Label();
            PhoneNumberLable = new Label();
            EmployeementDateLable = new Label();
            PhoneNumberTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            NationalCodeTextBox = new TextBox();
            EmployeeDataGridView = new DataGridView();
            EmployeementDateDataTimePicker = new DateTimePicker();
            CreationDateLable = new Label();
            CreationDateDataTimePicker = new DateTimePicker();
            JobTitleLable = new Label();
            JobTItleTextBox = new TextBox();
            IsActiveCheckBox = new CheckBox();
            SaveButton = new Button();
            CancelButton = new Button();
            BirthDatelabel = new Label();
            BirthDatedateTimePicker = new DateTimePicker();
            Deletebutton = new Button();
            Updatebutton = new Button();
            Genderlabel = new Label();
            genderComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // NationalCodeLable
            // 
            NationalCodeLable.AutoSize = true;
            NationalCodeLable.Location = new Point(23, 28);
            NationalCodeLable.Name = "NationalCodeLable";
            NationalCodeLable.Size = new Size(105, 20);
            NationalCodeLable.TabIndex = 0;
            NationalCodeLable.Text = "National Code";
            // 
            // FirstNameLable
            // 
            FirstNameLable.AutoSize = true;
            FirstNameLable.Location = new Point(24, 61);
            FirstNameLable.Name = "FirstNameLable";
            FirstNameLable.Size = new Size(80, 20);
            FirstNameLable.TabIndex = 2;
            FirstNameLable.Text = "First Name";
            // 
            // LastNameLable
            // 
            LastNameLable.AutoSize = true;
            LastNameLable.Location = new Point(25, 94);
            LastNameLable.Name = "LastNameLable";
            LastNameLable.Size = new Size(79, 20);
            LastNameLable.TabIndex = 3;
            LastNameLable.Text = "Last Name";
            // 
            // PhoneNumberLable
            // 
            PhoneNumberLable.AutoSize = true;
            PhoneNumberLable.Location = new Point(23, 127);
            PhoneNumberLable.Name = "PhoneNumberLable";
            PhoneNumberLable.Size = new Size(108, 20);
            PhoneNumberLable.TabIndex = 4;
            PhoneNumberLable.Text = "Phone Number";
            // 
            // EmployeementDateLable
            // 
            EmployeementDateLable.AutoSize = true;
            EmployeementDateLable.Location = new Point(23, 226);
            EmployeementDateLable.Name = "EmployeementDateLable";
            EmployeementDateLable.Size = new Size(145, 20);
            EmployeementDateLable.TabIndex = 6;
            EmployeementDateLable.Text = "Employeement Date";
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(181, 127);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(171, 27);
            PhoneNumberTextBox.TabIndex = 4;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(181, 94);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(171, 27);
            LastNameTextBox.TabIndex = 3;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(181, 61);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(171, 27);
            FirstNameTextBox.TabIndex = 2;
            // 
            // NationalCodeTextBox
            // 
            NationalCodeTextBox.Location = new Point(181, 28);
            NationalCodeTextBox.Name = "NationalCodeTextBox";
            NationalCodeTextBox.Size = new Size(171, 27);
            NationalCodeTextBox.TabIndex = 1;
            // 
            // EmployeeDataGridView
            // 
            EmployeeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeDataGridView.Location = new Point(12, 335);
            EmployeeDataGridView.Name = "EmployeeDataGridView";
            EmployeeDataGridView.RowHeadersWidth = 51;
            EmployeeDataGridView.RowTemplate.Height = 29;
            EmployeeDataGridView.Size = new Size(1004, 250);
            EmployeeDataGridView.TabIndex = 15;
            EmployeeDataGridView.CellClick += EmployeeDataGridView_CellClick;
            // 
            // EmployeementDateDataTimePicker
            // 
            EmployeementDateDataTimePicker.Location = new Point(181, 226);
            EmployeementDateDataTimePicker.Name = "EmployeementDateDataTimePicker";
            EmployeementDateDataTimePicker.Size = new Size(250, 27);
            EmployeementDateDataTimePicker.TabIndex = 6;
            // 
            // CreationDateLable
            // 
            CreationDateLable.AutoSize = true;
            CreationDateLable.Location = new Point(23, 259);
            CreationDateLable.Name = "CreationDateLable";
            CreationDateLable.Size = new Size(101, 20);
            CreationDateLable.TabIndex = 16;
            CreationDateLable.Text = "Creation Date";
            // 
            // CreationDateDataTimePicker
            // 
            CreationDateDataTimePicker.Location = new Point(181, 259);
            CreationDateDataTimePicker.Name = "CreationDateDataTimePicker";
            CreationDateDataTimePicker.Size = new Size(250, 27);
            CreationDateDataTimePicker.TabIndex = 7;
            // 
            // JobTitleLable
            // 
            JobTitleLable.AutoSize = true;
            JobTitleLable.Location = new Point(25, 160);
            JobTitleLable.Name = "JobTitleLable";
            JobTitleLable.Size = new Size(65, 20);
            JobTitleLable.TabIndex = 18;
            JobTitleLable.Text = "Job Title";
            // 
            // JobTItleTextBox
            // 
            JobTItleTextBox.Location = new Point(181, 160);
            JobTItleTextBox.Name = "JobTItleTextBox";
            JobTItleTextBox.Size = new Size(171, 27);
            JobTItleTextBox.TabIndex = 5;
            // 
            // IsActiveCheckBox
            // 
            IsActiveCheckBox.AutoSize = true;
            IsActiveCheckBox.Location = new Point(181, 305);
            IsActiveCheckBox.Name = "IsActiveCheckBox";
            IsActiveCheckBox.Size = new Size(82, 24);
            IsActiveCheckBox.TabIndex = 8;
            IsActiveCheckBox.Text = "IsActive";
            IsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(912, 282);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 47);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click_1;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(812, 283);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 46);
            CancelButton.TabIndex = 19;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click_1;
            // 
            // BirthDatelabel
            // 
            BirthDatelabel.AutoSize = true;
            BirthDatelabel.Location = new Point(24, 193);
            BirthDatelabel.Name = "BirthDatelabel";
            BirthDatelabel.Size = new Size(76, 20);
            BirthDatelabel.TabIndex = 20;
            BirthDatelabel.Text = "Birth Date";
            // 
            // BirthDatedateTimePicker
            // 
            BirthDatedateTimePicker.Location = new Point(181, 193);
            BirthDatedateTimePicker.Name = "BirthDatedateTimePicker";
            BirthDatedateTimePicker.Size = new Size(250, 27);
            BirthDatedateTimePicker.TabIndex = 21;
            // 
            // Deletebutton
            // 
            Deletebutton.Location = new Point(612, 283);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(94, 46);
            Deletebutton.TabIndex = 22;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = true;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // Updatebutton
            // 
            Updatebutton.Location = new Point(712, 283);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(94, 46);
            Updatebutton.TabIndex = 23;
            Updatebutton.Text = "Update";
            Updatebutton.UseVisualStyleBackColor = true;
            Updatebutton.Click += Updatebutton_Click;
            // 
            // Genderlabel
            // 
            Genderlabel.AutoSize = true;
            Genderlabel.Location = new Point(563, 31);
            Genderlabel.Name = "Genderlabel";
            Genderlabel.Size = new Size(57, 20);
            Genderlabel.TabIndex = 24;
            Genderlabel.Text = "Gender";
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(626, 31);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(180, 28);
            genderComboBox.TabIndex = 25;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1018, 657);
            Controls.Add(genderComboBox);
            Controls.Add(Genderlabel);
            Controls.Add(Updatebutton);
            Controls.Add(Deletebutton);
            Controls.Add(BirthDatedateTimePicker);
            Controls.Add(BirthDatelabel);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(IsActiveCheckBox);
            Controls.Add(JobTItleTextBox);
            Controls.Add(JobTitleLable);
            Controls.Add(CreationDateDataTimePicker);
            Controls.Add(CreationDateLable);
            Controls.Add(EmployeementDateDataTimePicker);
            Controls.Add(EmployeeDataGridView);
            Controls.Add(NationalCodeTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(EmployeementDateLable);
            Controls.Add(PhoneNumberLable);
            Controls.Add(LastNameLable);
            Controls.Add(FirstNameLable);
            Controls.Add(NationalCodeLable);
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NationalCodeLable;
        private Label FirstNameLable;
        private Label LastNameLable;
        private Label PhoneNumberLable;
        private Label EmployeementDateLable;
        private TextBox PhoneNumberTextBox;
        private TextBox LastNameTextBox;
        private TextBox FirstNameTextBox;
        private TextBox NationalCodeTextBox;
        private DataGridView EmployeeDataGridView;
        private DateTimePicker EmployeementDateDataTimePicker;
        private Label CreationDateLable;
        private DateTimePicker CreationDateDataTimePicker;
        private Label JobTitleLable;
        private TextBox JobTItleTextBox;
        private CheckBox IsActiveCheckBox;
        private Button SaveButton;
        private Button CancelButton;
        private Label BirthDatelabel;
        private DateTimePicker BirthDatedateTimePicker;
        private Button Deletebutton;
        private Button Updatebutton;
        private Label Genderlabel;
        private ComboBox genderComboBox;
    }
}