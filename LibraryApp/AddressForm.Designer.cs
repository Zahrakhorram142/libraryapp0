namespace LibraryApp
{
    partial class AddressForm
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
            SaveButten = new Button();
            CancelButton = new Button();
            PelakLable = new Label();
            CityLable = new Label();
            StreetLable = new Label();
            FullAddressLable = new Label();
            PostalCodeLable = new Label();
            PostalCodeTextBox = new TextBox();
            FullAddressTextBox = new TextBox();
            StreetTextBox = new TextBox();
            CityTextBox = new TextBox();
            PelakTextBox = new TextBox();
            AddressDataGridView = new DataGridView();
            CreationDateLable = new Label();
            CreationDateDataTimePicker = new DateTimePicker();
            IsActiveCheckBox = new CheckBox();
            Deletebutton = new Button();
            UpdateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AddressDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SaveButten
            // 
            SaveButten.Location = new Point(972, 261);
            SaveButten.Name = "SaveButten";
            SaveButten.Size = new Size(94, 41);
            SaveButten.TabIndex = 7;
            SaveButten.Text = "Save";
            SaveButten.UseVisualStyleBackColor = true;
            SaveButten.Click += SaveButten_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(872, 261);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 41);
            CancelButton.TabIndex = 8;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += button2_Click;
            // 
            // PelakLable
            // 
            PelakLable.AutoSize = true;
            PelakLable.Location = new Point(21, 15);
            PelakLable.Name = "PelakLable";
            PelakLable.Size = new Size(43, 20);
            PelakLable.TabIndex = 3;
            PelakLable.Text = "Pelak";
            // 
            // CityLable
            // 
            CityLable.AutoSize = true;
            CityLable.Location = new Point(21, 51);
            CityLable.Name = "CityLable";
            CityLable.Size = new Size(34, 20);
            CityLable.TabIndex = 4;
            CityLable.Text = "City";
            // 
            // StreetLable
            // 
            StreetLable.AutoSize = true;
            StreetLable.Location = new Point(21, 84);
            StreetLable.Name = "StreetLable";
            StreetLable.Size = new Size(48, 20);
            StreetLable.TabIndex = 5;
            StreetLable.Text = "Street";
            // 
            // FullAddressLable
            // 
            FullAddressLable.AutoSize = true;
            FullAddressLable.Location = new Point(21, 114);
            FullAddressLable.Name = "FullAddressLable";
            FullAddressLable.Size = new Size(89, 20);
            FullAddressLable.TabIndex = 6;
            FullAddressLable.Text = "Full Address";
            // 
            // PostalCodeLable
            // 
            PostalCodeLable.AutoSize = true;
            PostalCodeLable.Location = new Point(23, 147);
            PostalCodeLable.Name = "PostalCodeLable";
            PostalCodeLable.Size = new Size(87, 20);
            PostalCodeLable.TabIndex = 7;
            PostalCodeLable.Text = "Postal Code";
            // 
            // PostalCodeTextBox
            // 
            PostalCodeTextBox.Location = new Point(126, 150);
            PostalCodeTextBox.Name = "PostalCodeTextBox";
            PostalCodeTextBox.Size = new Size(161, 27);
            PostalCodeTextBox.TabIndex = 6;
            // 
            // FullAddressTextBox
            // 
            FullAddressTextBox.Location = new Point(126, 117);
            FullAddressTextBox.Name = "FullAddressTextBox";
            FullAddressTextBox.Size = new Size(161, 27);
            FullAddressTextBox.TabIndex = 5;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(126, 84);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(161, 27);
            StreetTextBox.TabIndex = 4;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(126, 51);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(161, 27);
            CityTextBox.TabIndex = 3;
            // 
            // PelakTextBox
            // 
            PelakTextBox.Location = new Point(126, 18);
            PelakTextBox.Name = "PelakTextBox";
            PelakTextBox.Size = new Size(161, 27);
            PelakTextBox.TabIndex = 2;
            // 
            // AddressDataGridView
            // 
            AddressDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AddressDataGridView.Location = new Point(4, 308);
            AddressDataGridView.Name = "AddressDataGridView";
            AddressDataGridView.RowHeadersWidth = 51;
            AddressDataGridView.RowTemplate.Height = 29;
            AddressDataGridView.Size = new Size(1069, 279);
            AddressDataGridView.TabIndex = 14;
            AddressDataGridView.CellClick += AddressDataGridView_CellClick;
            // 
            // CreationDateLable
            // 
            CreationDateLable.AutoSize = true;
            CreationDateLable.Location = new Point(23, 180);
            CreationDateLable.Name = "CreationDateLable";
            CreationDateLable.Size = new Size(101, 20);
            CreationDateLable.TabIndex = 15;
            CreationDateLable.Text = "Creation Date";
            // 
            // CreationDateDataTimePicker
            // 
            CreationDateDataTimePicker.Location = new Point(126, 180);
            CreationDateDataTimePicker.Name = "CreationDateDataTimePicker";
            CreationDateDataTimePicker.Size = new Size(250, 27);
            CreationDateDataTimePicker.TabIndex = 16;
            // 
            // IsActiveCheckBox
            // 
            IsActiveCheckBox.AutoSize = true;
            IsActiveCheckBox.Location = new Point(126, 228);
            IsActiveCheckBox.Name = "IsActiveCheckBox";
            IsActiveCheckBox.Size = new Size(82, 24);
            IsActiveCheckBox.TabIndex = 17;
            IsActiveCheckBox.Text = "IsActive";
            IsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // Deletebutton
            // 
            Deletebutton.Location = new Point(672, 261);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(94, 41);
            Deletebutton.TabIndex = 18;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = true;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(772, 261);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(94, 41);
            UpdateButton.TabIndex = 19;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // AddressForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1078, 599);
            Controls.Add(UpdateButton);
            Controls.Add(Deletebutton);
            Controls.Add(IsActiveCheckBox);
            Controls.Add(CreationDateDataTimePicker);
            Controls.Add(CreationDateLable);
            Controls.Add(AddressDataGridView);
            Controls.Add(PelakTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(StreetTextBox);
            Controls.Add(FullAddressTextBox);
            Controls.Add(PostalCodeTextBox);
            Controls.Add(PostalCodeLable);
            Controls.Add(FullAddressLable);
            Controls.Add(StreetLable);
            Controls.Add(CityLable);
            Controls.Add(PelakLable);
            Controls.Add(CancelButton);
            Controls.Add(SaveButten);
            Name = "AddressForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Address";
            ((System.ComponentModel.ISupportInitialize)AddressDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButten;
        private Button CancelButton;
        private Label PelakLable;
        private Label CityLable;
        private Label StreetLable;
        private Label FullAddressLable;
        private Label PostalCodeLable;
        private TextBox PostalCodeTextBox;
        private TextBox FullAddressTextBox;
        private TextBox StreetTextBox;
        private TextBox CityTextBox;
        private TextBox PelakTextBox;
        private DataGridView AddressDataGridView;
        private Label CreationDateLable;
        private DateTimePicker CreationDateDataTimePicker;
        private CheckBox IsActiveCheckBox;
        private Button Deletebutton;
        private Button UpdateButton;
    }
}