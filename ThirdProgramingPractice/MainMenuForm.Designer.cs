namespace ThirdProgramingPractice
{
    partial class MainMenuForm
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
            NewBudgetButton = new Button();
            BudgetsListBox = new ListBox();
            AmountTextBox = new TextBox();
            IncomeTextBox = new TextBox();
            ExpensesTextBox = new TextBox();
            IncomeListBox = new ListBox();
            ExpensesListBox = new ListBox();
            BudgetNameLabel = new Label();
            CreateTransactionButton = new Button();
            GoalsLabel = new Label();
            GoalsList = new ListBox();
            SuspendLayout();
            // 
            // NewBudgetButton
            // 
            NewBudgetButton.Location = new Point(12, 12);
            NewBudgetButton.Name = "NewBudgetButton";
            NewBudgetButton.Size = new Size(95, 23);
            NewBudgetButton.TabIndex = 0;
            NewBudgetButton.Text = "New budget";
            NewBudgetButton.UseVisualStyleBackColor = true;
            NewBudgetButton.Click += NewBudgetButton_Click;
            // 
            // BudgetsListBox
            // 
            BudgetsListBox.FormattingEnabled = true;
            BudgetsListBox.ItemHeight = 15;
            BudgetsListBox.Location = new Point(12, 41);
            BudgetsListBox.Name = "BudgetsListBox";
            BudgetsListBox.Size = new Size(94, 604);
            BudgetsListBox.TabIndex = 1;
            BudgetsListBox.SelectedIndexChanged += BudgetsListBox_SelectedIndexChanged;
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(126, 41);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(100, 23);
            AmountTextBox.TabIndex = 2;
            AmountTextBox.Text = "Amount:";
            // 
            // IncomeTextBox
            // 
            IncomeTextBox.Location = new Point(126, 70);
            IncomeTextBox.Name = "IncomeTextBox";
            IncomeTextBox.Size = new Size(100, 23);
            IncomeTextBox.TabIndex = 3;
            IncomeTextBox.Text = "Income:";
            // 
            // ExpensesTextBox
            // 
            ExpensesTextBox.Location = new Point(252, 70);
            ExpensesTextBox.Name = "ExpensesTextBox";
            ExpensesTextBox.Size = new Size(100, 23);
            ExpensesTextBox.TabIndex = 4;
            ExpensesTextBox.Text = "Expneses:";
            // 
            // IncomeListBox
            // 
            IncomeListBox.FormattingEnabled = true;
            IncomeListBox.ItemHeight = 15;
            IncomeListBox.Location = new Point(126, 97);
            IncomeListBox.Name = "IncomeListBox";
            IncomeListBox.Size = new Size(100, 514);
            IncomeListBox.TabIndex = 5;
            // 
            // ExpensesListBox
            // 
            ExpensesListBox.FormattingEnabled = true;
            ExpensesListBox.ItemHeight = 15;
            ExpensesListBox.Location = new Point(252, 97);
            ExpensesListBox.Name = "ExpensesListBox";
            ExpensesListBox.Size = new Size(100, 514);
            ExpensesListBox.TabIndex = 6;
            // 
            // BudgetNameLabel
            // 
            BudgetNameLabel.AutoSize = true;
            BudgetNameLabel.Location = new Point(126, 16);
            BudgetNameLabel.Name = "BudgetNameLabel";
            BudgetNameLabel.Size = new Size(127, 15);
            BudgetNameLabel.TabIndex = 7;
            BudgetNameLabel.Text = "Selected Budget Name";
            // 
            // CreateTransactionButton
            // 
            CreateTransactionButton.Location = new Point(160, 622);
            CreateTransactionButton.Name = "CreateTransactionButton";
            CreateTransactionButton.Size = new Size(145, 23);
            CreateTransactionButton.TabIndex = 8;
            CreateTransactionButton.Text = "Create new transaction";
            CreateTransactionButton.UseVisualStyleBackColor = true;
            CreateTransactionButton.Click += CreateTransactionButton_Click;
            // 
            // GoalsLabel
            // 
            GoalsLabel.AutoSize = true;
            GoalsLabel.Location = new Point(1210, 49);
            GoalsLabel.Name = "GoalsLabel";
            GoalsLabel.Size = new Size(36, 15);
            GoalsLabel.TabIndex = 9;
            GoalsLabel.Text = "Goals";
            // 
            // GoalsList
            // 
            GoalsList.FormattingEnabled = true;
            GoalsList.ItemHeight = 15;
            GoalsList.Location = new Point(1210, 70);
            GoalsList.Name = "GoalsList";
            GoalsList.Size = new Size(100, 514);
            GoalsList.TabIndex = 10;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 660);
            Controls.Add(GoalsList);
            Controls.Add(GoalsLabel);
            Controls.Add(CreateTransactionButton);
            Controls.Add(BudgetNameLabel);
            Controls.Add(ExpensesListBox);
            Controls.Add(IncomeListBox);
            Controls.Add(ExpensesTextBox);
            Controls.Add(IncomeTextBox);
            Controls.Add(AmountTextBox);
            Controls.Add(BudgetsListBox);
            Controls.Add(NewBudgetButton);
            Name = "MainMenuForm";
            Text = " ,¿";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NewBudgetButton;
        private ListBox BudgetsListBox;
        private TextBox AmountTextBox;
        private TextBox IncomeTextBox;
        private TextBox ExpensesTextBox;
        private ListBox IncomeListBox;
        private ListBox ExpensesListBox;
        private Label BudgetNameLabel;
        private Button CreateTransactionButton;
        private Label GoalsLabel;
        private ListBox GoalsList;
    }
}