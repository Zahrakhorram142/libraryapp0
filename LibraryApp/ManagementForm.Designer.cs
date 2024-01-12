namespace LibraryApp
{
    partial class ManagementForm
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
            BorrowButton = new Button();
            ShelfsButton = new Button();
            EmployeesButton = new Button();
            MembersButton = new Button();
            BooksButton = new Button();
            CancelButton = new Button();
            AddressesButton = new Button();
            SuspendLayout();
            // 
            // BorrowButton
            // 
            BorrowButton.Location = new Point(224, 121);
            BorrowButton.Name = "BorrowButton";
            BorrowButton.Size = new Size(94, 53);
            BorrowButton.TabIndex = 0;
            BorrowButton.Text = "Borrow";
            BorrowButton.UseVisualStyleBackColor = true;
            BorrowButton.Click += BorrowButton_Click;
            // 
            // ShelfsButton
            // 
            ShelfsButton.Location = new Point(224, 46);
            ShelfsButton.Name = "ShelfsButton";
            ShelfsButton.Size = new Size(94, 45);
            ShelfsButton.TabIndex = 1;
            ShelfsButton.Text = "Shelfs";
            ShelfsButton.UseVisualStyleBackColor = true;
            ShelfsButton.Click += ShelfsButton_Click;
            // 
            // EmployeesButton
            // 
            EmployeesButton.Location = new Point(24, 46);
            EmployeesButton.Name = "EmployeesButton";
            EmployeesButton.Size = new Size(94, 45);
            EmployeesButton.TabIndex = 2;
            EmployeesButton.Text = "Employees";
            EmployeesButton.UseVisualStyleBackColor = true;
            EmployeesButton.Click += EmployeesButton_Click;
            // 
            // MembersButton
            // 
            MembersButton.Location = new Point(24, 121);
            MembersButton.Name = "MembersButton";
            MembersButton.Size = new Size(94, 53);
            MembersButton.TabIndex = 3;
            MembersButton.Text = "Members";
            MembersButton.UseVisualStyleBackColor = true;
            MembersButton.Click += MembersButton_Click;
            // 
            // BooksButton
            // 
            BooksButton.Location = new Point(24, 205);
            BooksButton.Name = "BooksButton";
            BooksButton.Size = new Size(94, 52);
            BooksButton.TabIndex = 4;
            BooksButton.Text = "Books";
            BooksButton.UseVisualStyleBackColor = true;
            BooksButton.Click += BookButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(117, 290);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 52);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddressesButton
            // 
            AddressesButton.Location = new Point(224, 205);
            AddressesButton.Name = "AddressesButton";
            AddressesButton.Size = new Size(94, 52);
            AddressesButton.TabIndex = 6;
            AddressesButton.Text = "Addresses";
            AddressesButton.UseVisualStyleBackColor = true;
            AddressesButton.Click += AddressesButton_Click;
            // 
            // ManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(348, 354);
            Controls.Add(AddressesButton);
            Controls.Add(CancelButton);
            Controls.Add(BooksButton);
            Controls.Add(MembersButton);
            Controls.Add(EmployeesButton);
            Controls.Add(ShelfsButton);
            Controls.Add(BorrowButton);
            Name = "ManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Management";
            ResumeLayout(false);
        }

        #endregion

        private Button BorrowButton;
        private Button ShelfsButton;
        private Button EmployeesButton;
        private Button MembersButton;
        private Button BooksButton;
        private Button CancelButton;
        private Button AddressesButton;
    }
}