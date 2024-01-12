namespace LibraryApp
{
    partial class PersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonForm));
            SaveButton = new Button();
            FirstNameLable = new Label();
            LastNameLable = new Label();
            PhoneNumberLable = new Label();
            PhoneNumberTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            IsAdminCheckBox = new CheckBox();
            NationalCodeLable = new Label();
            NationalCodeTextBox = new TextBox();
            PersonDataTimePicker = new DateTimePicker();
            CreationDateLable = new Label();
            personDataGridView = new DataGridView();
            IsActivecheckBox = new CheckBox();
            CancelButton = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            Genderlabel = new Label();
            genderComboBox = new ComboBox();
            birthDatelabel = new Label();
            birthDatedateTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)personDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(995, 336);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(100, 45);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // FirstNameLable
            // 
            FirstNameLable.AutoSize = true;
            FirstNameLable.Location = new Point(28, 53);
            FirstNameLable.Name = "FirstNameLable";
            FirstNameLable.Size = new Size(80, 20);
            FirstNameLable.TabIndex = 1;
            FirstNameLable.Text = "First Name";
            // 
            // LastNameLable
            // 
            LastNameLable.AutoSize = true;
            LastNameLable.Location = new Point(29, 86);
            LastNameLable.Name = "LastNameLable";
            LastNameLable.Size = new Size(79, 20);
            LastNameLable.TabIndex = 2;
            LastNameLable.Text = "Last Name";
            // 
            // PhoneNumberLable
            // 
            PhoneNumberLable.AutoSize = true;
            PhoneNumberLable.Location = new Point(28, 119);
            PhoneNumberLable.Name = "PhoneNumberLable";
            PhoneNumberLable.Size = new Size(108, 20);
            PhoneNumberLable.TabIndex = 3;
            PhoneNumberLable.Text = "Phone Number";
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(144, 116);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(166, 27);
            PhoneNumberTextBox.TabIndex = 5;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(144, 83);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(166, 27);
            LastNameTextBox.TabIndex = 4;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(144, 50);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(166, 27);
            FirstNameTextBox.TabIndex = 3;
            // 
            // IsAdminCheckBox
            // 
            IsAdminCheckBox.AutoSize = true;
            IsAdminCheckBox.Location = new Point(171, 232);
            IsAdminCheckBox.Name = "IsAdminCheckBox";
            IsAdminCheckBox.Size = new Size(85, 24);
            IsAdminCheckBox.TabIndex = 7;
            IsAdminCheckBox.Text = "IsAdmin";
            IsAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // NationalCodeLable
            // 
            NationalCodeLable.AutoSize = true;
            NationalCodeLable.Location = new Point(29, 20);
            NationalCodeLable.Name = "NationalCodeLable";
            NationalCodeLable.Size = new Size(105, 20);
            NationalCodeLable.TabIndex = 12;
            NationalCodeLable.Text = "National Code";
            // 
            // NationalCodeTextBox
            // 
            NationalCodeTextBox.Location = new Point(144, 17);
            NationalCodeTextBox.Name = "NationalCodeTextBox";
            NationalCodeTextBox.Size = new Size(166, 27);
            NationalCodeTextBox.TabIndex = 2;
            // 
            // PersonDataTimePicker
            // 
            PersonDataTimePicker.Location = new Point(144, 182);
            PersonDataTimePicker.Name = "PersonDataTimePicker";
            PersonDataTimePicker.Size = new Size(250, 27);
            PersonDataTimePicker.TabIndex = 6;
            // 
            // CreationDateLable
            // 
            CreationDateLable.AutoSize = true;
            CreationDateLable.Location = new Point(28, 182);
            CreationDateLable.Name = "CreationDateLable";
            CreationDateLable.Size = new Size(101, 20);
            CreationDateLable.TabIndex = 14;
            CreationDateLable.Text = "Creation Date";
            // 
            // personDataGridView
            // 
            personDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            personDataGridView.Location = new Point(-6, 387);
            personDataGridView.Name = "personDataGridView";
            personDataGridView.RowHeadersWidth = 51;
            personDataGridView.RowTemplate.Height = 29;
            personDataGridView.Size = new Size(1102, 351);
            personDataGridView.TabIndex = 16;
            personDataGridView.CellClick += personDataGridView_CellClick;
            // 
            // IsActivecheckBox
            // 
            IsActivecheckBox.AutoSize = true;
            IsActivecheckBox.Location = new Point(29, 232);
            IsActivecheckBox.Name = "IsActivecheckBox";
            IsActivecheckBox.Size = new Size(82, 24);
            IsActivecheckBox.TabIndex = 17;
            IsActivecheckBox.Text = "IsActive";
            IsActivecheckBox.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(895, 336);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 45);
            CancelButton.TabIndex = 18;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click_1;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(695, 336);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 45);
            buttonDelete.TabIndex = 19;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(795, 336);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 45);
            buttonUpdate.TabIndex = 20;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // Genderlabel
            // 
            Genderlabel.AutoSize = true;
            Genderlabel.Location = new Point(497, 20);
            Genderlabel.Name = "Genderlabel";
            Genderlabel.Size = new Size(57, 20);
            Genderlabel.TabIndex = 21;
            Genderlabel.Text = "Gender";
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(570, 20);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(194, 28);
            genderComboBox.TabIndex = 22;
            // 
            // birthDatelabel
            // 
            birthDatelabel.AutoSize = true;
            birthDatelabel.Location = new Point(29, 152);
            birthDatelabel.Name = "birthDatelabel";
            birthDatelabel.Size = new Size(76, 20);
            birthDatelabel.TabIndex = 23;
            birthDatelabel.Text = "Birth Date";
            // 
            // birthDatedateTimePicker
            // 
            birthDatedateTimePicker.Location = new Point(144, 149);
            birthDatedateTimePicker.Name = "birthDatedateTimePicker";
            birthDatedateTimePicker.Size = new Size(250, 27);
            birthDatedateTimePicker.TabIndex = 24;
            // 
            // PersonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1095, 750);
            Controls.Add(birthDatedateTimePicker);
            Controls.Add(birthDatelabel);
            Controls.Add(genderComboBox);
            Controls.Add(Genderlabel);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(CancelButton);
            Controls.Add(IsActivecheckBox);
            Controls.Add(personDataGridView);
            Controls.Add(CreationDateLable);
            Controls.Add(PersonDataTimePicker);
            Controls.Add(NationalCodeTextBox);
            Controls.Add(NationalCodeLable);
            Controls.Add(IsAdminCheckBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(PhoneNumberLable);
            Controls.Add(LastNameLable);
            Controls.Add(FirstNameLable);
            Controls.Add(SaveButton);
            Name = "PersonForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person";
            ((System.ComponentModel.ISupportInitialize)personDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Label FirstNameLable;
        private Label LastNameLable;
        private Label PhoneNumberLable;
        private TextBox PhoneNumberTextBox;
        private TextBox LastNameTextBox;
        private TextBox FirstNameTextBox;
        private CheckBox IsAdminCheckBox;
        private Label NationalCodeLable;
        private TextBox NationalCodeTextBox;
        private DateTimePicker PersonDataTimePicker;
        private Label CreationDateLable;
        private DataGridView personDataGridView;
        private CheckBox IsActivecheckBox;
        private Button CancelButton;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Label Genderlabel;
        private ComboBox genderComboBox;
        private Label birthDatelabel;
        private DateTimePicker birthDatedateTimePicker;
    }
}