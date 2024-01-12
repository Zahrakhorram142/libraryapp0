namespace LibraryApp
{
    partial class ShelfForm
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
            TitleLable = new Label();
            FloorLable = new Label();
            FloorTextBox = new TextBox();
            TitleTextBox = new TextBox();
            ShelfDataGridView = new DataGridView();
            CancelButton = new Button();
            Deletebutton = new Button();
            Updatebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)ShelfDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(477, 95);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(98, 46);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // TitleLable
            // 
            TitleLable.AutoSize = true;
            TitleLable.Location = new Point(27, 56);
            TitleLable.Name = "TitleLable";
            TitleLable.Size = new Size(38, 20);
            TitleLable.TabIndex = 1;
            TitleLable.Text = "Title";
            // 
            // FloorLable
            // 
            FloorLable.AutoSize = true;
            FloorLable.Location = new Point(27, 21);
            FloorLable.Name = "FloorLable";
            FloorLable.Size = new Size(43, 20);
            FloorLable.TabIndex = 2;
            FloorLable.Text = "Floor";
            // 
            // FloorTextBox
            // 
            FloorTextBox.Location = new Point(104, 18);
            FloorTextBox.Name = "FloorTextBox";
            FloorTextBox.Size = new Size(157, 27);
            FloorTextBox.TabIndex = 2;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(104, 51);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(157, 27);
            TitleTextBox.TabIndex = 3;
            // 
            // ShelfDataGridView
            // 
            ShelfDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShelfDataGridView.Location = new Point(12, 147);
            ShelfDataGridView.Name = "ShelfDataGridView";
            ShelfDataGridView.RowHeadersWidth = 51;
            ShelfDataGridView.RowTemplate.Height = 29;
            ShelfDataGridView.Size = new Size(563, 235);
            ShelfDataGridView.TabIndex = 7;
            ShelfDataGridView.CellClick += ShelfDataGridView_CellClick;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(377, 95);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 46);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // Deletebutton
            // 
            Deletebutton.Location = new Point(177, 95);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(94, 46);
            Deletebutton.TabIndex = 8;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = true;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // Updatebutton
            // 
            Updatebutton.Location = new Point(277, 95);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(94, 46);
            Updatebutton.TabIndex = 9;
            Updatebutton.Text = "Update";
            Updatebutton.UseVisualStyleBackColor = true;
            Updatebutton.Click += Updatebutton_Click;
            // 
            // ShelfForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(587, 385);
            Controls.Add(Updatebutton);
            Controls.Add(Deletebutton);
            Controls.Add(CancelButton);
            Controls.Add(ShelfDataGridView);
            Controls.Add(TitleTextBox);
            Controls.Add(FloorTextBox);
            Controls.Add(FloorLable);
            Controls.Add(TitleLable);
            Controls.Add(SaveButton);
            Name = "ShelfForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shelf";
            ((System.ComponentModel.ISupportInitialize)ShelfDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Label TitleLable;
        private Label FloorLable;
        private TextBox FloorTextBox;
        private TextBox TitleTextBox;
        private DataGridView ShelfDataGridView;
        private Button CancelButton;
        private Button Deletebutton;
        private Button Updatebutton;
    }
}