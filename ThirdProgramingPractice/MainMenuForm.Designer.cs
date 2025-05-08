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
            GoalsListBox = new ListBox();
            NewGoalButton = new Button();
            button1 = new Button();
            label1 = new Label();
            TransactionNameTextBox = new TextBox();
            DescriptionLabel = new Label();
            DescriptionTextBox = new TextBox();
            TransactionDateLabel = new Label();
            AmountLabel = new Label();
            TransactionAmountTextBox = new TextBox();
            DeleteTransactionButton = new Button();
            DeleteGoalButton = new Button();
            GoalNameLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            GoalNameTextBox = new TextBox();
            GoalTaskTextBox = new TextBox();
            ProgressTextBox = new TextBox();
            VersionLabel = new Label();
            TransactionUpadateButton = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // NewBudgetButton
            // 
            NewBudgetButton.BackColor = SystemColors.AppWorkspace;
            NewBudgetButton.Location = new Point(14, 16);
            NewBudgetButton.Margin = new Padding(3, 4, 3, 4);
            NewBudgetButton.Name = "NewBudgetButton";
            NewBudgetButton.Size = new Size(145, 31);
            NewBudgetButton.TabIndex = 0;
            NewBudgetButton.Text = "New budget";
            NewBudgetButton.UseVisualStyleBackColor = false;
            NewBudgetButton.Click += NewBudgetButton_Click;
            // 
            // BudgetsListBox
            // 
            BudgetsListBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BudgetsListBox.FormattingEnabled = true;
            BudgetsListBox.ItemHeight = 21;
            BudgetsListBox.Location = new Point(14, 93);
            BudgetsListBox.Margin = new Padding(3, 4, 3, 4);
            BudgetsListBox.Name = "BudgetsListBox";
            BudgetsListBox.Size = new Size(145, 718);
            BudgetsListBox.TabIndex = 1;
            BudgetsListBox.SelectedIndexChanged += BudgetsListBox_SelectedIndexChanged;
            // 
            // AmountTextBox
            // 
            AmountTextBox.BorderStyle = BorderStyle.None;
            AmountTextBox.Location = new Point(166, 56);
            AmountTextBox.Margin = new Padding(3, 4, 3, 4);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(114, 20);
            AmountTextBox.TabIndex = 2;
            AmountTextBox.Text = "Amount:";
            // 
            // IncomeTextBox
            // 
            IncomeTextBox.BorderStyle = BorderStyle.None;
            IncomeTextBox.Location = new Point(166, 93);
            IncomeTextBox.Margin = new Padding(3, 4, 3, 4);
            IncomeTextBox.Name = "IncomeTextBox";
            IncomeTextBox.Size = new Size(114, 20);
            IncomeTextBox.TabIndex = 3;
            IncomeTextBox.Text = "Income:";
            // 
            // ExpensesTextBox
            // 
            ExpensesTextBox.BorderStyle = BorderStyle.None;
            ExpensesTextBox.Location = new Point(318, 93);
            ExpensesTextBox.Margin = new Padding(3, 4, 3, 4);
            ExpensesTextBox.Name = "ExpensesTextBox";
            ExpensesTextBox.Size = new Size(114, 20);
            ExpensesTextBox.TabIndex = 4;
            ExpensesTextBox.Text = "Expneses:";
            // 
            // IncomeListBox
            // 
            IncomeListBox.FormattingEnabled = true;
            IncomeListBox.Location = new Point(166, 132);
            IncomeListBox.Margin = new Padding(3, 4, 3, 4);
            IncomeListBox.Name = "IncomeListBox";
            IncomeListBox.Size = new Size(114, 684);
            IncomeListBox.TabIndex = 5;
            IncomeListBox.SelectedIndexChanged += IncomeListBox_SelectedIndexChanged;
            // 
            // ExpensesListBox
            // 
            ExpensesListBox.FormattingEnabled = true;
            ExpensesListBox.Location = new Point(318, 132);
            ExpensesListBox.Margin = new Padding(3, 4, 3, 4);
            ExpensesListBox.Name = "ExpensesListBox";
            ExpensesListBox.Size = new Size(114, 684);
            ExpensesListBox.TabIndex = 6;
            ExpensesListBox.SelectedIndexChanged += ExpensesListBox_SelectedIndexChanged;
            // 
            // BudgetNameLabel
            // 
            BudgetNameLabel.AutoSize = true;
            BudgetNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BudgetNameLabel.Location = new Point(166, 21);
            BudgetNameLabel.Name = "BudgetNameLabel";
            BudgetNameLabel.Size = new Size(228, 28);
            BudgetNameLabel.TabIndex = 7;
            BudgetNameLabel.Text = "Selected Budget Name";
            // 
            // CreateTransactionButton
            // 
            CreateTransactionButton.BackColor = SystemColors.AppWorkspace;
            CreateTransactionButton.Location = new Point(454, 16);
            CreateTransactionButton.Margin = new Padding(3, 4, 3, 4);
            CreateTransactionButton.Name = "CreateTransactionButton";
            CreateTransactionButton.Size = new Size(166, 31);
            CreateTransactionButton.TabIndex = 8;
            CreateTransactionButton.Text = "Create new transaction";
            CreateTransactionButton.UseVisualStyleBackColor = false;
            CreateTransactionButton.Click += CreateTransactionButton_Click;
            // 
            // GoalsLabel
            // 
            GoalsLabel.AutoSize = true;
            GoalsLabel.Location = new Point(717, 129);
            GoalsLabel.Name = "GoalsLabel";
            GoalsLabel.Size = new Size(49, 20);
            GoalsLabel.TabIndex = 9;
            GoalsLabel.Text = "Goals:";
            // 
            // GoalsListBox
            // 
            GoalsListBox.FormattingEnabled = true;
            GoalsListBox.Location = new Point(717, 152);
            GoalsListBox.Margin = new Padding(3, 4, 3, 4);
            GoalsListBox.Name = "GoalsListBox";
            GoalsListBox.Size = new Size(114, 664);
            GoalsListBox.TabIndex = 10;
            GoalsListBox.SelectedIndexChanged += GoalsListBox_SelectedIndexChanged;
            // 
            // NewGoalButton
            // 
            NewGoalButton.BackColor = SystemColors.AppWorkspace;
            NewGoalButton.Location = new Point(717, 16);
            NewGoalButton.Margin = new Padding(3, 4, 3, 4);
            NewGoalButton.Name = "NewGoalButton";
            NewGoalButton.Size = new Size(114, 31);
            NewGoalButton.TabIndex = 11;
            NewGoalButton.Text = "New goal";
            NewGoalButton.UseVisualStyleBackColor = false;
            NewGoalButton.Click += NewGoalButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(13, 55);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(146, 31);
            button1.TabIndex = 12;
            button1.Text = "Delete budget (soon)";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(447, 163);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 13;
            label1.Text = "Transaction name:";
            // 
            // TransactionNameTextBox
            // 
            TransactionNameTextBox.Location = new Point(561, 159);
            TransactionNameTextBox.Margin = new Padding(3, 4, 3, 4);
            TransactionNameTextBox.Name = "TransactionNameTextBox";
            TransactionNameTextBox.Size = new Size(122, 27);
            TransactionNameTextBox.TabIndex = 14;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(447, 244);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(88, 20);
            DescriptionLabel.TabIndex = 15;
            DescriptionLabel.Text = "Description:";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(447, 268);
            DescriptionTextBox.Margin = new Padding(3, 4, 3, 4);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(236, 137);
            DescriptionTextBox.TabIndex = 16;
            // 
            // TransactionDateLabel
            // 
            TransactionDateLabel.AutoSize = true;
            TransactionDateLabel.Location = new Point(454, 423);
            TransactionDateLabel.Name = "TransactionDateLabel";
            TransactionDateLabel.Size = new Size(123, 20);
            TransactionDateLabel.TabIndex = 17;
            TransactionDateLabel.Text = "Transaction Date:";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(503, 208);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(65, 20);
            AmountLabel.TabIndex = 18;
            AmountLabel.Text = "Amount:";
            // 
            // TransactionAmountTextBox
            // 
            TransactionAmountTextBox.Location = new Point(561, 204);
            TransactionAmountTextBox.Margin = new Padding(3, 4, 3, 4);
            TransactionAmountTextBox.Name = "TransactionAmountTextBox";
            TransactionAmountTextBox.Size = new Size(122, 27);
            TransactionAmountTextBox.TabIndex = 19;
            // 
            // DeleteTransactionButton
            // 
            DeleteTransactionButton.Location = new Point(454, 55);
            DeleteTransactionButton.Margin = new Padding(3, 4, 3, 4);
            DeleteTransactionButton.Name = "DeleteTransactionButton";
            DeleteTransactionButton.Size = new Size(187, 31);
            DeleteTransactionButton.TabIndex = 20;
            DeleteTransactionButton.Text = "Delete Transaction (soon)";
            DeleteTransactionButton.UseVisualStyleBackColor = true;
            // 
            // DeleteGoalButton
            // 
            DeleteGoalButton.Location = new Point(717, 55);
            DeleteGoalButton.Margin = new Padding(3, 4, 3, 4);
            DeleteGoalButton.Name = "DeleteGoalButton";
            DeleteGoalButton.Size = new Size(129, 31);
            DeleteGoalButton.TabIndex = 21;
            DeleteGoalButton.Text = "Delete goal (soon)";
            DeleteGoalButton.UseVisualStyleBackColor = true;
            // 
            // GoalNameLabel
            // 
            GoalNameLabel.AutoSize = true;
            GoalNameLabel.Location = new Point(848, 132);
            GoalNameLabel.Name = "GoalNameLabel";
            GoalNameLabel.Size = new Size(84, 20);
            GoalNameLabel.TabIndex = 22;
            GoalNameLabel.Text = "Goal name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(858, 177);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 23;
            label2.Text = "Goal task:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(862, 225);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 24;
            label3.Text = "Progress:";
            // 
            // GoalNameTextBox
            // 
            GoalNameTextBox.Location = new Point(921, 128);
            GoalNameTextBox.Margin = new Padding(3, 4, 3, 4);
            GoalNameTextBox.Name = "GoalNameTextBox";
            GoalNameTextBox.Size = new Size(122, 27);
            GoalNameTextBox.TabIndex = 25;
            // 
            // GoalTaskTextBox
            // 
            GoalTaskTextBox.Location = new Point(921, 173);
            GoalTaskTextBox.Margin = new Padding(3, 4, 3, 4);
            GoalTaskTextBox.Name = "GoalTaskTextBox";
            GoalTaskTextBox.Size = new Size(122, 27);
            GoalTaskTextBox.TabIndex = 26;
            // 
            // ProgressTextBox
            // 
            ProgressTextBox.Location = new Point(921, 221);
            ProgressTextBox.Margin = new Padding(3, 4, 3, 4);
            ProgressTextBox.Name = "ProgressTextBox";
            ProgressTextBox.Size = new Size(122, 27);
            ProgressTextBox.TabIndex = 27;
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.Location = new Point(447, 823);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(96, 20);
            VersionLabel.TabIndex = 28;
            VersionLabel.Text = "version V0.35";
            // 
            // TransactionUpadateButton
            // 
            TransactionUpadateButton.Location = new Point(454, 92);
            TransactionUpadateButton.Margin = new Padding(3, 4, 3, 4);
            TransactionUpadateButton.Name = "TransactionUpadateButton";
            TransactionUpadateButton.Size = new Size(187, 31);
            TransactionUpadateButton.TabIndex = 29;
            TransactionUpadateButton.Text = "Update transaction (soon)";
            TransactionUpadateButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(717, 93);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(143, 31);
            button2.TabIndex = 30;
            button2.Text = "Update goal (soon)";
            button2.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 855);
            Controls.Add(button2);
            Controls.Add(TransactionUpadateButton);
            Controls.Add(VersionLabel);
            Controls.Add(ProgressTextBox);
            Controls.Add(GoalTaskTextBox);
            Controls.Add(GoalNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(GoalNameLabel);
            Controls.Add(DeleteGoalButton);
            Controls.Add(DeleteTransactionButton);
            Controls.Add(TransactionAmountTextBox);
            Controls.Add(AmountLabel);
            Controls.Add(TransactionDateLabel);
            Controls.Add(DescriptionTextBox);
            Controls.Add(DescriptionLabel);
            Controls.Add(TransactionNameTextBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(NewGoalButton);
            Controls.Add(GoalsListBox);
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
            Text = "MainMenuForm";
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
        private ListBox GoalsListBox;
        private Button NewGoalButton;
        private Button button1;
        private Label label1;
        private TextBox TransactionNameTextBox;
        private Label DescriptionLabel;
        private TextBox DescriptionTextBox;
        private Label TransactionDateLabel;
        private Label AmountLabel;
        private TextBox TransactionAmountTextBox;
        private Button DeleteTransactionButton;
        private Button DeleteGoalButton;
        private Label GoalNameLabel;
        private Label label2;
        private Label label3;
        private TextBox GoalNameTextBox;
        private TextBox GoalTaskTextBox;
        private TextBox ProgressTextBox;
        private Label VersionLabel;
        private Button TransactionUpadateButton;
        private Button button2;
    }
}