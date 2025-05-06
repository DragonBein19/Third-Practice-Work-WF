namespace ThirdProgramingPractice
{
    partial class TransactionForm
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
            TransactionNameLabel = new Label();
            TransactionNameTextBox = new TextBox();
            CategoryLabel = new Label();
            DescriptionLabel = new Label();
            DescriptonTextBox = new TextBox();
            CreateTransactionButton = new Button();
            AmountLabel = new Label();
            AmountTextBox = new TextBox();
            ExpensesRadioButton = new RadioButton();
            IncomeRadioButton = new RadioButton();
            ExpIncGroupBox = new GroupBox();
            ExpIncGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TransactionNameLabel
            // 
            TransactionNameLabel.AutoSize = true;
            TransactionNameLabel.Location = new Point(10, 17);
            TransactionNameLabel.Name = "TransactionNameLabel";
            TransactionNameLabel.Size = new Size(103, 15);
            TransactionNameLabel.TabIndex = 0;
            TransactionNameLabel.Text = "Transaction name:";
            TransactionNameLabel.UseWaitCursor = true;
            // 
            // TransactionNameTextBox
            // 
            TransactionNameTextBox.Location = new Point(128, 15);
            TransactionNameTextBox.Margin = new Padding(3, 2, 3, 2);
            TransactionNameTextBox.Name = "TransactionNameTextBox";
            TransactionNameTextBox.Size = new Size(110, 23);
            TransactionNameTextBox.TabIndex = 1;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(66, 48);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(92, 15);
            CategoryLabel.TabIndex = 2;
            CategoryLabel.Text = "Catecory (Soon)";
            CategoryLabel.UseWaitCursor = true;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(10, 136);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(70, 15);
            DescriptionLabel.TabIndex = 3;
            DescriptionLabel.Text = "Description:";
            DescriptionLabel.UseWaitCursor = true;
            // 
            // DescriptonTextBox
            // 
            DescriptonTextBox.Location = new Point(10, 154);
            DescriptonTextBox.Margin = new Padding(3, 2, 3, 2);
            DescriptonTextBox.Multiline = true;
            DescriptonTextBox.Name = "DescriptonTextBox";
            DescriptonTextBox.Size = new Size(227, 84);
            DescriptonTextBox.TabIndex = 4;
            // 
            // CreateTransactionButton
            // 
            CreateTransactionButton.Location = new Point(66, 242);
            CreateTransactionButton.Margin = new Padding(3, 2, 3, 2);
            CreateTransactionButton.Name = "CreateTransactionButton";
            CreateTransactionButton.Size = new Size(123, 22);
            CreateTransactionButton.TabIndex = 5;
            CreateTransactionButton.Text = "Create transaction";
            CreateTransactionButton.UseVisualStyleBackColor = true;
            CreateTransactionButton.Click += CreateTransactionButton_Click;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(10, 79);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(57, 15);
            AmountLabel.TabIndex = 6;
            AmountLabel.Text = "Amount: ";
            AmountLabel.UseWaitCursor = true;
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(76, 76);
            AmountTextBox.Margin = new Padding(3, 2, 3, 2);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(110, 23);
            AmountTextBox.TabIndex = 7;
            // 
            // ExpensesRadioButton
            // 
            ExpensesRadioButton.AutoSize = true;
            ExpensesRadioButton.Location = new Point(12, 1);
            ExpensesRadioButton.Margin = new Padding(3, 2, 3, 2);
            ExpensesRadioButton.Name = "ExpensesRadioButton";
            ExpensesRadioButton.Size = new Size(68, 19);
            ExpensesRadioButton.TabIndex = 8;
            ExpensesRadioButton.TabStop = true;
            ExpensesRadioButton.Text = "Expense";
            ExpensesRadioButton.UseVisualStyleBackColor = true;
            // 
            // IncomeRadioButton
            // 
            IncomeRadioButton.AutoSize = true;
            IncomeRadioButton.Location = new Point(92, 1);
            IncomeRadioButton.Margin = new Padding(3, 2, 3, 2);
            IncomeRadioButton.Name = "IncomeRadioButton";
            IncomeRadioButton.Size = new Size(65, 19);
            IncomeRadioButton.TabIndex = 9;
            IncomeRadioButton.TabStop = true;
            IncomeRadioButton.Text = "Income";
            IncomeRadioButton.UseVisualStyleBackColor = true;
            // 
            // ExpIncGroupBox
            // 
            ExpIncGroupBox.Controls.Add(IncomeRadioButton);
            ExpIncGroupBox.Controls.Add(ExpensesRadioButton);
            ExpIncGroupBox.Location = new Point(44, 112);
            ExpIncGroupBox.Name = "ExpIncGroupBox";
            ExpIncGroupBox.Size = new Size(172, 21);
            ExpIncGroupBox.TabIndex = 10;
            ExpIncGroupBox.TabStop = false;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 271);
            Controls.Add(ExpIncGroupBox);
            Controls.Add(AmountTextBox);
            Controls.Add(AmountLabel);
            Controls.Add(CreateTransactionButton);
            Controls.Add(DescriptonTextBox);
            Controls.Add(DescriptionLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(TransactionNameTextBox);
            Controls.Add(TransactionNameLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TransactionForm";
            Text = "TransactionCreationForm";
            ExpIncGroupBox.ResumeLayout(false);
            ExpIncGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TransactionNameLabel;
        private TextBox TransactionNameTextBox;
        private Label CategoryLabel;
        private Label DescriptionLabel;
        private TextBox DescriptonTextBox;
        private Button CreateTransactionButton;
        private Label AmountLabel;
        private TextBox AmountTextBox;
        private RadioButton ExpensesRadioButton;
        private RadioButton IncomeRadioButton;
        private GroupBox ExpIncGroupBox;
    }
}