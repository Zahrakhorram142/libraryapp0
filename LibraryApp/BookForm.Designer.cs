namespace LibraryApp
{
    partial class BookForm
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
            NameLable = new Label();
            SubjectLable = new Label();
            WriterLable = new Label();
            PublishersLable = new Label();
            YearOfPublicationLable = new Label();
            EditionLable = new Label();
            EditionTextBox = new TextBox();
            YearOfPublicationTextBox = new TextBox();
            PublishersTextBox = new TextBox();
            WriterTextBox = new TextBox();
            SubjectTextBox = new TextBox();
            NameTextBox = new TextBox();
            BookDataGridView = new DataGridView();
            CancelButton = new Button();
            CreationDateLable = new Label();
            CreationDateDataTimePicker = new DateTimePicker();
            IsActiveCheckBox = new CheckBox();
            Deletebutton = new Button();
            Updatebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)BookDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(952, 301);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(92, 45);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // NameLable
            // 
            NameLable.AutoSize = true;
            NameLable.Location = new Point(23, 20);
            NameLable.Name = "NameLable";
            NameLable.Size = new Size(49, 20);
            NameLable.TabIndex = 2;
            NameLable.Text = "Name";
            // 
            // SubjectLable
            // 
            SubjectLable.AutoSize = true;
            SubjectLable.Location = new Point(23, 55);
            SubjectLable.Name = "SubjectLable";
            SubjectLable.Size = new Size(58, 20);
            SubjectLable.TabIndex = 3;
            SubjectLable.Text = "Subject";
            // 
            // WriterLable
            // 
            WriterLable.AutoSize = true;
            WriterLable.Location = new Point(23, 87);
            WriterLable.Name = "WriterLable";
            WriterLable.Size = new Size(50, 20);
            WriterLable.TabIndex = 4;
            WriterLable.Text = "Writer";
            // 
            // PublishersLable
            // 
            PublishersLable.AutoSize = true;
            PublishersLable.Location = new Point(23, 121);
            PublishersLable.Name = "PublishersLable";
            PublishersLable.Size = new Size(75, 20);
            PublishersLable.TabIndex = 5;
            PublishersLable.Text = "Publishers";
            // 
            // YearOfPublicationLable
            // 
            YearOfPublicationLable.AutoSize = true;
            YearOfPublicationLable.Location = new Point(23, 157);
            YearOfPublicationLable.Name = "YearOfPublicationLable";
            YearOfPublicationLable.Size = new Size(135, 20);
            YearOfPublicationLable.TabIndex = 6;
            YearOfPublicationLable.Text = "Year Of Publication";
            // 
            // EditionLable
            // 
            EditionLable.AutoSize = true;
            EditionLable.Location = new Point(23, 190);
            EditionLable.Name = "EditionLable";
            EditionLable.Size = new Size(56, 20);
            EditionLable.TabIndex = 7;
            EditionLable.Text = "Edition";
            // 
            // EditionTextBox
            // 
            EditionTextBox.Location = new Point(164, 187);
            EditionTextBox.Name = "EditionTextBox";
            EditionTextBox.Size = new Size(172, 27);
            EditionTextBox.TabIndex = 7;
            // 
            // YearOfPublicationTextBox
            // 
            YearOfPublicationTextBox.Location = new Point(164, 154);
            YearOfPublicationTextBox.Name = "YearOfPublicationTextBox";
            YearOfPublicationTextBox.Size = new Size(172, 27);
            YearOfPublicationTextBox.TabIndex = 6;
            // 
            // PublishersTextBox
            // 
            PublishersTextBox.Location = new Point(164, 121);
            PublishersTextBox.Name = "PublishersTextBox";
            PublishersTextBox.Size = new Size(172, 27);
            PublishersTextBox.TabIndex = 5;
            // 
            // WriterTextBox
            // 
            WriterTextBox.Location = new Point(164, 88);
            WriterTextBox.Name = "WriterTextBox";
            WriterTextBox.Size = new Size(172, 27);
            WriterTextBox.TabIndex = 4;
            // 
            // SubjectTextBox
            // 
            SubjectTextBox.Location = new Point(164, 55);
            SubjectTextBox.Name = "SubjectTextBox";
            SubjectTextBox.Size = new Size(172, 27);
            SubjectTextBox.TabIndex = 3;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(164, 22);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(172, 27);
            NameTextBox.TabIndex = 2;
            // 
            // BookDataGridView
            // 
            BookDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookDataGridView.Location = new Point(6, 352);
            BookDataGridView.Name = "BookDataGridView";
            BookDataGridView.RowHeadersWidth = 51;
            BookDataGridView.RowTemplate.Height = 29;
            BookDataGridView.Size = new Size(1038, 230);
            BookDataGridView.TabIndex = 15;
            BookDataGridView.CellClick += BookDataGridView_CellClick;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(852, 301);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 45);
            CancelButton.TabIndex = 9;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // CreationDateLable
            // 
            CreationDateLable.AutoSize = true;
            CreationDateLable.Location = new Point(23, 220);
            CreationDateLable.Name = "CreationDateLable";
            CreationDateLable.Size = new Size(101, 20);
            CreationDateLable.TabIndex = 16;
            CreationDateLable.Text = "Creation Date";
            // 
            // CreationDateDataTimePicker
            // 
            CreationDateDataTimePicker.Location = new Point(164, 220);
            CreationDateDataTimePicker.Name = "CreationDateDataTimePicker";
            CreationDateDataTimePicker.Size = new Size(250, 27);
            CreationDateDataTimePicker.TabIndex = 17;
            // 
            // IsActiveCheckBox
            // 
            IsActiveCheckBox.AutoSize = true;
            IsActiveCheckBox.Location = new Point(164, 274);
            IsActiveCheckBox.Name = "IsActiveCheckBox";
            IsActiveCheckBox.Size = new Size(82, 24);
            IsActiveCheckBox.TabIndex = 18;
            IsActiveCheckBox.Text = "IsActive";
            IsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // Deletebutton
            // 
            Deletebutton.Location = new Point(652, 301);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(94, 45);
            Deletebutton.TabIndex = 19;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = true;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // Updatebutton
            // 
            Updatebutton.Location = new Point(752, 301);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(94, 45);
            Updatebutton.TabIndex = 20;
            Updatebutton.Text = "Update";
            Updatebutton.UseVisualStyleBackColor = true;
            Updatebutton.Click += Updatebutton_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1056, 607);
            Controls.Add(Updatebutton);
            Controls.Add(Deletebutton);
            Controls.Add(IsActiveCheckBox);
            Controls.Add(CreationDateDataTimePicker);
            Controls.Add(CreationDateLable);
            Controls.Add(CancelButton);
            Controls.Add(BookDataGridView);
            Controls.Add(NameTextBox);
            Controls.Add(SubjectTextBox);
            Controls.Add(WriterTextBox);
            Controls.Add(PublishersTextBox);
            Controls.Add(YearOfPublicationTextBox);
            Controls.Add(EditionTextBox);
            Controls.Add(EditionLable);
            Controls.Add(YearOfPublicationLable);
            Controls.Add(PublishersLable);
            Controls.Add(WriterLable);
            Controls.Add(SubjectLable);
            Controls.Add(NameLable);
            Controls.Add(SaveButton);
            Name = "BookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book";
            ((System.ComponentModel.ISupportInitialize)BookDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Label NameLable;
        private Label SubjectLable;
        private Label WriterLable;
        private Label PublishersLable;
        private Label YearOfPublicationLable;
        private Label EditionLable;
        private TextBox EditionTextBox;
        private TextBox YearOfPublicationTextBox;
        private TextBox PublishersTextBox;
        private TextBox WriterTextBox;
        private TextBox SubjectTextBox;
        private TextBox NameTextBox;
        private DataGridView BookDataGridView;
        private Button CancelButton;
        private Label CreationDateLable;
        private DateTimePicker CreationDateDataTimePicker;
        private CheckBox IsActiveCheckBox;
        private Button Deletebutton;
        private Button Updatebutton;
    }
}