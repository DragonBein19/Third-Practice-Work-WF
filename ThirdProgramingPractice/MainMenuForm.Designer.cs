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
            SuspendLayout();
            // 
            // NewBudgetButton
            // 
            NewBudgetButton.Location = new Point(161, 105);
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
            BudgetsListBox.Location = new Point(162, 134);
            BudgetsListBox.Name = "BudgetsListBox";
            BudgetsListBox.Size = new Size(94, 244);
            BudgetsListBox.TabIndex = 1;
            BudgetsListBox.SelectedIndexChanged += BudgetsListBox_SelectedIndexChanged;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 660);
            Controls.Add(BudgetsListBox);
            Controls.Add(NewBudgetButton);
            Name = "MainMenuForm";
            Text = "MainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button NewBudgetButton;
        private ListBox BudgetsListBox;
    }
}