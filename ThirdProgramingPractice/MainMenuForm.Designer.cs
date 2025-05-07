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
            NewGoalButton = new Button();
            SuspendLayout();
            // 
            // NewBudgetButton
            // 
            NewBudgetButton.Location = new Point(14, 16);
            NewBudgetButton.Margin = new Padding(3, 4, 3, 4);
            NewBudgetButton.Name = "NewBudgetButton";
            NewBudgetButton.Size = new Size(109, 31);
            NewBudgetButton.TabIndex = 0;
            NewBudgetButton.Text = "New budget";
            NewBudgetButton.UseVisualStyleBackColor = true;
            NewBudgetButton.Click += NewBudgetButton_Click;
            // 
            // BudgetsListBox
            // 
            BudgetsListBox.FormattingEnabled = true;
            BudgetsListBox.Location = new Point(14, 55);
            BudgetsListBox.Margin = new Padding(3, 4, 3, 4);
            BudgetsListBox.Name = "BudgetsListBox";
            BudgetsListBox.Size = new Size(107, 804);
            BudgetsListBox.TabIndex = 1;
            BudgetsListBox.SelectedIndexChanged += BudgetsListBox_SelectedIndexChanged;
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(144, 55);
            AmountTextBox.Margin = new Padding(3, 4, 3, 4);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(114, 27);
            AmountTextBox.TabIndex = 2;
            AmountTextBox.Text = "Amount:";
            // 
            // IncomeTextBox
            // 
            IncomeTextBox.Location = new Point(144, 93);
            IncomeTextBox.Margin = new Padding(3, 4, 3, 4);
            IncomeTextBox.Name = "IncomeTextBox";
            IncomeTextBox.Size = new Size(114, 27);
            IncomeTextBox.TabIndex = 3;
            IncomeTextBox.Text = "Income:";
            // 
            // ExpensesTextBox
            // 
            ExpensesTextBox.Location = new Point(491, 93);
            ExpensesTextBox.Margin = new Padding(3, 4, 3, 4);
            ExpensesTextBox.Name = "ExpensesTextBox";
            ExpensesTextBox.Size = new Size(114, 27);
            ExpensesTextBox.TabIndex = 4;
            ExpensesTextBox.Text = "Expneses:";
            // 
            // IncomeListBox
            // 
            IncomeListBox.FormattingEnabled = true;
            IncomeListBox.Location = new Point(144, 129);
            IncomeListBox.Margin = new Padding(3, 4, 3, 4);
            IncomeListBox.Name = "IncomeListBox";
            IncomeListBox.Size = new Size(114, 684);
            IncomeListBox.TabIndex = 5;
            // 
            // ExpensesListBox
            // 
            ExpensesListBox.FormattingEnabled = true;
            ExpensesListBox.Location = new Point(491, 129);
            ExpensesListBox.Margin = new Padding(3, 4, 3, 4);
            ExpensesListBox.Name = "ExpensesListBox";
            ExpensesListBox.Size = new Size(114, 684);
            ExpensesListBox.TabIndex = 6;
            // 
            // BudgetNameLabel
            // 
            BudgetNameLabel.AutoSize = true;
            BudgetNameLabel.Location = new Point(144, 21);
            BudgetNameLabel.Name = "BudgetNameLabel";
            BudgetNameLabel.Size = new Size(162, 20);
            BudgetNameLabel.TabIndex = 7;
            BudgetNameLabel.Text = "Selected Budget Name";
            // 
            // CreateTransactionButton
            // 
            CreateTransactionButton.Location = new Point(183, 829);
            CreateTransactionButton.Margin = new Padding(3, 4, 3, 4);
            CreateTransactionButton.Name = "CreateTransactionButton";
            CreateTransactionButton.Size = new Size(166, 31);
            CreateTransactionButton.TabIndex = 8;
            CreateTransactionButton.Text = "Create new transaction";
            CreateTransactionButton.UseVisualStyleBackColor = true;
            CreateTransactionButton.Click += CreateTransactionButton_Click;
            // 
            // GoalsLabel
            // 
            GoalsLabel.AutoSize = true;
            GoalsLabel.Location = new Point(1383, 65);
            GoalsLabel.Name = "GoalsLabel";
            GoalsLabel.Size = new Size(46, 20);
            GoalsLabel.TabIndex = 9;
            GoalsLabel.Text = "Goals";
            // 
            // GoalsList
            // 
            GoalsList.FormattingEnabled = true;
            GoalsList.Location = new Point(1383, 93);
            GoalsList.Margin = new Padding(3, 4, 3, 4);
            GoalsList.Name = "GoalsList";
            GoalsList.Size = new Size(114, 684);
            GoalsList.TabIndex = 10;
            // 
            // NewGoalButton
            // 
            NewGoalButton.Location = new Point(1388, 836);
            NewGoalButton.Margin = new Padding(3, 4, 3, 4);
            NewGoalButton.Name = "NewGoalButton";
            NewGoalButton.Size = new Size(109, 31);
            NewGoalButton.TabIndex = 11;
            NewGoalButton.Text = "New goal";
            NewGoalButton.UseVisualStyleBackColor = true;
            NewGoalButton.Click += NewGoalButton_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1537, 880);
            Controls.Add(NewGoalButton);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Button NewGoalButton;
    }
}