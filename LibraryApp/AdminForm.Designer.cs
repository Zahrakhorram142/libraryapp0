namespace LibraryApp
{
    partial class AdminForm
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
            CancelButton = new Button();
            SaveButton = new Button();
            UserNamelabel = new Label();
            Passwordlabel = new Label();
            PasswordtextBox = new TextBox();
            UserNametextBox = new TextBox();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(12, 111);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 45);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(172, 111);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(98, 45);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // UserNamelabel
            // 
            UserNamelabel.AutoSize = true;
            UserNamelabel.Location = new Point(33, 25);
            UserNamelabel.Name = "UserNamelabel";
            UserNamelabel.Size = new Size(78, 20);
            UserNamelabel.TabIndex = 6;
            UserNamelabel.Text = "UserName";
            // 
            // Passwordlabel
            // 
            Passwordlabel.AutoSize = true;
            Passwordlabel.Location = new Point(33, 59);
            Passwordlabel.Name = "Passwordlabel";
            Passwordlabel.Size = new Size(70, 20);
            Passwordlabel.TabIndex = 7;
            Passwordlabel.Text = "Password";
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Location = new Point(117, 59);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(153, 27);
            PasswordtextBox.TabIndex = 2;
            // 
            // UserNametextBox
            // 
            UserNametextBox.Location = new Point(117, 25);
            UserNametextBox.Name = "UserNametextBox";
            UserNametextBox.Size = new Size(153, 27);
            UserNametextBox.TabIndex = 1;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(282, 184);
            Controls.Add(UserNametextBox);
            Controls.Add(PasswordtextBox);
            Controls.Add(Passwordlabel);
            Controls.Add(UserNamelabel);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CancelButton;
        private Button SaveButton;
        private Label UserNamelabel;
        private Label Passwordlabel;
        private TextBox PasswordtextBox;
        private TextBox UserNametextBox;
    }
}