namespace ThirdProgramingPractice
{
    partial class RegistrationForm
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
            NameLabel = new Label();
            NameTextBox = new TextBox();
            SurnameLabel = new Label();
            SurnameTextBox = new TextBox();
            EmailLabel = new Label();
            EmailTextBox = new TextBox();
            PhoneNumberLabel = new Label();
            PhoneNumberTextBox = new TextBox();
            HomeAdressLabel = new Label();
            HomeAdressTextBox = new TextBox();
            LoginLabel = new Label();
            LoginTextBox = new TextBox();
            Password = new Label();
            PasswordTextBox = new TextBox();
            RepeatPasswordLabel = new Label();
            RepeadPaswordTextBox = new TextBox();
            RegisterButton = new Button();
            ErrorMassageLabel = new Label();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(21, 55);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(21, 73);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(172, 23);
            NameTextBox.TabIndex = 1;
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Location = new Point(21, 99);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(54, 15);
            SurnameLabel.TabIndex = 2;
            SurnameLabel.Text = "Surname";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(21, 117);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(172, 23);
            SurnameTextBox.TabIndex = 3;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(21, 143);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 4;
            EmailLabel.Text = "Email";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(21, 161);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(172, 23);
            EmailTextBox.TabIndex = 5;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(21, 187);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(86, 15);
            PhoneNumberLabel.TabIndex = 6;
            PhoneNumberLabel.Text = "Phone number";
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(21, 205);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(172, 23);
            PhoneNumberTextBox.TabIndex = 7;
            // 
            // HomeAdressLabel
            // 
            HomeAdressLabel.AutoSize = true;
            HomeAdressLabel.Location = new Point(21, 231);
            HomeAdressLabel.Name = "HomeAdressLabel";
            HomeAdressLabel.Size = new Size(76, 15);
            HomeAdressLabel.TabIndex = 8;
            HomeAdressLabel.Text = "Home adress";
            // 
            // HomeAdressTextBox
            // 
            HomeAdressTextBox.Location = new Point(21, 249);
            HomeAdressTextBox.Name = "HomeAdressTextBox";
            HomeAdressTextBox.Size = new Size(172, 23);
            HomeAdressTextBox.TabIndex = 9;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(199, 55);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(37, 15);
            LoginLabel.TabIndex = 10;
            LoginLabel.Text = "Login";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(199, 73);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(172, 23);
            LoginTextBox.TabIndex = 11;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(199, 99);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 12;
            Password.Text = "Password";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(199, 117);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(172, 23);
            PasswordTextBox.TabIndex = 13;
            // 
            // RepeatPasswordLabel
            // 
            RepeatPasswordLabel.AutoSize = true;
            RepeatPasswordLabel.Location = new Point(199, 143);
            RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            RepeatPasswordLabel.Size = new Size(96, 15);
            RepeatPasswordLabel.TabIndex = 14;
            RepeatPasswordLabel.Text = "Repeat password";
            // 
            // RepeadPaswordTextBox
            // 
            RepeadPaswordTextBox.Location = new Point(199, 161);
            RepeadPaswordTextBox.Name = "RepeadPaswordTextBox";
            RepeadPaswordTextBox.Size = new Size(172, 23);
            RepeadPaswordTextBox.TabIndex = 15;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(127, 307);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(140, 28);
            RegisterButton.TabIndex = 16;
            RegisterButton.Text = "Registration";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // ErrorMassageLabel
            // 
            ErrorMassageLabel.AutoSize = true;
            ErrorMassageLabel.Location = new Point(155, 20);
            ErrorMassageLabel.Name = "ErrorMassageLabel";
            ErrorMassageLabel.Size = new Size(81, 15);
            ErrorMassageLabel.TabIndex = 17;
            ErrorMassageLabel.Text = "Error massage";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 351);
            Controls.Add(ErrorMassageLabel);
            Controls.Add(RegisterButton);
            Controls.Add(RepeadPaswordTextBox);
            Controls.Add(RepeatPasswordLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(Password);
            Controls.Add(LoginTextBox);
            Controls.Add(LoginLabel);
            Controls.Add(HomeAdressTextBox);
            Controls.Add(HomeAdressLabel);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(SurnameTextBox);
            Controls.Add(SurnameLabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private TextBox NameTextBox;
        private Label SurnameLabel;
        private TextBox SurnameTextBox;
        private Label EmailLabel;
        private TextBox EmailTextBox;
        private Label PhoneNumberLabel;
        private TextBox PhoneNumberTextBox;
        private Label HomeAdressLabel;
        private TextBox HomeAdressTextBox;
        private Label LoginLabel;
        private TextBox LoginTextBox;
        private Label Password;
        private TextBox PasswordTextBox;
        private Label RepeatPasswordLabel;
        private TextBox RepeadPaswordTextBox;
        private Button RegisterButton;
        private Label ErrorMassageLabel;
    }
}