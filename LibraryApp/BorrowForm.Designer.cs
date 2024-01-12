namespace LibraryApp
{
    partial class BorrowForm
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
            BorrowedBookNameLable = new Label();
            BorrowingDateLable = new Label();
            ReturnDateLable = new Label();
            borrowedBookNameTextBox = new TextBox();
            BorrowDataGridView = new DataGridView();
            CancelButton = new Button();
            ReturnDateDataTimePicker = new DateTimePicker();
            BorrowingDateDataTimePicker = new DateTimePicker();
            Deletebutton = new Button();
            Updatebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)BorrowDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(680, 140);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(87, 41);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // BorrowedBookNameLable
            // 
            BorrowedBookNameLable.AutoSize = true;
            BorrowedBookNameLable.Location = new Point(23, 21);
            BorrowedBookNameLable.Name = "BorrowedBookNameLable";
            BorrowedBookNameLable.Size = new Size(156, 20);
            BorrowedBookNameLable.TabIndex = 2;
            BorrowedBookNameLable.Text = "Borrowed Book Name";
            // 
            // BorrowingDateLable
            // 
            BorrowingDateLable.AutoSize = true;
            BorrowingDateLable.Location = new Point(23, 57);
            BorrowingDateLable.Name = "BorrowingDateLable";
            BorrowingDateLable.Size = new Size(114, 20);
            BorrowingDateLable.TabIndex = 3;
            BorrowingDateLable.Text = "Borrowing Date";
            // 
            // ReturnDateLable
            // 
            ReturnDateLable.AutoSize = true;
            ReturnDateLable.Location = new Point(23, 90);
            ReturnDateLable.Name = "ReturnDateLable";
            ReturnDateLable.Size = new Size(88, 20);
            ReturnDateLable.TabIndex = 4;
            ReturnDateLable.Text = "Return Date";
            // 
            // borrowedBookNameTextBox
            // 
            borrowedBookNameTextBox.Location = new Point(181, 21);
            borrowedBookNameTextBox.Name = "borrowedBookNameTextBox";
            borrowedBookNameTextBox.Size = new Size(162, 27);
            borrowedBookNameTextBox.TabIndex = 2;
            // 
            // BorrowDataGridView
            // 
            BorrowDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BorrowDataGridView.Location = new Point(12, 187);
            BorrowDataGridView.Name = "BorrowDataGridView";
            BorrowDataGridView.RowHeadersWidth = 51;
            BorrowDataGridView.RowTemplate.Height = 29;
            BorrowDataGridView.Size = new Size(758, 277);
            BorrowDataGridView.TabIndex = 9;
            BorrowDataGridView.CellClick += BorrowDataGridView_CellClick;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(585, 140);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(89, 41);
            CancelButton.TabIndex = 6;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ReturnDateDataTimePicker
            // 
            ReturnDateDataTimePicker.Location = new Point(181, 90);
            ReturnDateDataTimePicker.Name = "ReturnDateDataTimePicker";
            ReturnDateDataTimePicker.Size = new Size(250, 27);
            ReturnDateDataTimePicker.TabIndex = 4;
            // 
            // BorrowingDateDataTimePicker
            // 
            BorrowingDateDataTimePicker.Location = new Point(181, 57);
            BorrowingDateDataTimePicker.Name = "BorrowingDateDataTimePicker";
            BorrowingDateDataTimePicker.Size = new Size(250, 27);
            BorrowingDateDataTimePicker.TabIndex = 3;
            // 
            // Deletebutton
            // 
            Deletebutton.Location = new Point(385, 140);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(94, 41);
            Deletebutton.TabIndex = 10;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = true;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // Updatebutton
            // 
            Updatebutton.Location = new Point(485, 140);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(94, 41);
            Updatebutton.TabIndex = 11;
            Updatebutton.Text = "Update";
            Updatebutton.UseVisualStyleBackColor = true;
            Updatebutton.Click += Updatebutton_Click;
            // 
            // BorrowForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(779, 466);
            Controls.Add(Updatebutton);
            Controls.Add(Deletebutton);
            Controls.Add(BorrowingDateDataTimePicker);
            Controls.Add(ReturnDateDataTimePicker);
            Controls.Add(CancelButton);
            Controls.Add(BorrowDataGridView);
            Controls.Add(borrowedBookNameTextBox);
            Controls.Add(ReturnDateLable);
            Controls.Add(BorrowingDateLable);
            Controls.Add(BorrowedBookNameLable);
            Controls.Add(SaveButton);
            Name = "BorrowForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Borrow";
            ((System.ComponentModel.ISupportInitialize)BorrowDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Label BorrowedBookNameLable;
        private Label BorrowingDateLable;
        private Label ReturnDateLable;
        private TextBox borrowedBookNameTextBox;
        private DataGridView BorrowDataGridView;
        private Button CancelButton;
        private DateTimePicker ReturnDateDataTimePicker;
        private DateTimePicker BorrowingDateDataTimePicker;
        private Button Deletebutton;
        private Button Updatebutton;
    }
}