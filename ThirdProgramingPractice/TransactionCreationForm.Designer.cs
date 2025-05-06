namespace ThirdProgramingPractice
{
    partial class TransactionCreationForm
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
            SuspendLayout();
            // 
            // TransactionNameLabel
            // 
            TransactionNameLabel.AutoSize = true;
            TransactionNameLabel.Location = new Point(12, 23);
            TransactionNameLabel.Name = "TransactionNameLabel";
            TransactionNameLabel.Size = new Size(128, 20);
            TransactionNameLabel.TabIndex = 0;
            TransactionNameLabel.Text = "Transaction name:";
            TransactionNameLabel.UseWaitCursor = true;
            // 
            // TransactionNameTextBox
            // 
            TransactionNameTextBox.Location = new Point(146, 20);
            TransactionNameTextBox.Name = "TransactionNameTextBox";
            TransactionNameTextBox.Size = new Size(125, 27);
            TransactionNameTextBox.TabIndex = 1;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(75, 64);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(115, 20);
            CategoryLabel.TabIndex = 2;
            CategoryLabel.Text = "Catecory (Soon)";
            CategoryLabel.UseWaitCursor = true;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(12, 182);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(88, 20);
            DescriptionLabel.TabIndex = 3;
            DescriptionLabel.Text = "Description:";
            DescriptionLabel.UseWaitCursor = true;
            // 
            // DescriptonTextBox
            // 
            DescriptonTextBox.Location = new Point(12, 205);
            DescriptonTextBox.Multiline = true;
            DescriptonTextBox.Name = "DescriptonTextBox";
            DescriptonTextBox.Size = new Size(259, 111);
            DescriptonTextBox.TabIndex = 4;
            // 
            // CreateTransactionButton
            // 
            CreateTransactionButton.Location = new Point(75, 322);
            CreateTransactionButton.Name = "CreateTransactionButton";
            CreateTransactionButton.Size = new Size(141, 29);
            CreateTransactionButton.TabIndex = 5;
            CreateTransactionButton.Text = "Create transaction";
            CreateTransactionButton.UseVisualStyleBackColor = true;
            CreateTransactionButton.Click += CreateTransactionButton_Click;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(12, 105);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(69, 20);
            AmountLabel.TabIndex = 6;
            AmountLabel.Text = "Amount: ";
            AmountLabel.UseWaitCursor = true;
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(87, 102);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(125, 27);
            AmountTextBox.TabIndex = 7;
            // 
            // ExpensesRadioButton
            // 
            ExpensesRadioButton.AutoSize = true;
            ExpensesRadioButton.Location = new Point(57, 142);
            ExpensesRadioButton.Name = "ExpensesRadioButton";
            ExpensesRadioButton.Size = new Size(84, 24);
            ExpensesRadioButton.TabIndex = 8;
            ExpensesRadioButton.TabStop = true;
            ExpensesRadioButton.Text = "Expense";
            ExpensesRadioButton.UseVisualStyleBackColor = true;
            // 
            // IncomeRadioButton
            // 
            IncomeRadioButton.AutoSize = true;
            IncomeRadioButton.Location = new Point(149, 142);
            IncomeRadioButton.Name = "IncomeRadioButton";
            IncomeRadioButton.Size = new Size(79, 24);
            IncomeRadioButton.TabIndex = 9;
            IncomeRadioButton.TabStop = true;
            IncomeRadioButton.Text = "Income";
            IncomeRadioButton.UseVisualStyleBackColor = true;
            // 
            // TransactionCreationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 361);
            Controls.Add(IncomeRadioButton);
            Controls.Add(ExpensesRadioButton);
            Controls.Add(AmountTextBox);
            Controls.Add(AmountLabel);
            Controls.Add(CreateTransactionButton);
            Controls.Add(DescriptonTextBox);
            Controls.Add(DescriptionLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(TransactionNameTextBox);
            Controls.Add(TransactionNameLabel);
            Name = "TransactionCreationForm";
            Text = "TransactionCreationForm";
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
    }
}