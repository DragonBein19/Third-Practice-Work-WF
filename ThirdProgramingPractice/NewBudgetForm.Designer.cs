namespace ThirdProgramingPractice
{
    partial class NewBudgetForm
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
            NewBudgetTextBox = new TextBox();
            BudgetLabel = new Label();
            NewBudgetBotton = new Button();
            BudgetDescriptionTextBox = new TextBox();
            DescriptionLabel = new Label();
            SuspendLayout();
            // 
            // NewBudgetTextBox
            // 
            NewBudgetTextBox.Location = new Point(34, 38);
            NewBudgetTextBox.Name = "NewBudgetTextBox";
            NewBudgetTextBox.Size = new Size(107, 23);
            NewBudgetTextBox.TabIndex = 0;
            // 
            // BudgetLabel
            // 
            BudgetLabel.AutoSize = true;
            BudgetLabel.Location = new Point(34, 20);
            BudgetLabel.Name = "BudgetLabel";
            BudgetLabel.Size = new Size(81, 15);
            BudgetLabel.TabIndex = 1;
            BudgetLabel.Text = "Budget name:";
            // 
            // NewBudgetBotton
            // 
            NewBudgetBotton.Location = new Point(86, 199);
            NewBudgetBotton.Name = "NewBudgetBotton";
            NewBudgetBotton.Size = new Size(138, 23);
            NewBudgetBotton.TabIndex = 2;
            NewBudgetBotton.Text = "Create new budget";
            NewBudgetBotton.UseVisualStyleBackColor = true;
            NewBudgetBotton.Click += NewBudgetBotton_Click;
            // 
            // BudgetDescriptionTextBox
            // 
            BudgetDescriptionTextBox.Location = new Point(34, 82);
            BudgetDescriptionTextBox.Multiline = true;
            BudgetDescriptionTextBox.Name = "BudgetDescriptionTextBox";
            BudgetDescriptionTextBox.Size = new Size(243, 111);
            BudgetDescriptionTextBox.TabIndex = 3;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(34, 64);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(70, 15);
            DescriptionLabel.TabIndex = 4;
            DescriptionLabel.Text = "Description:";
            // 
            // NewBudgetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 248);
            Controls.Add(DescriptionLabel);
            Controls.Add(BudgetDescriptionTextBox);
            Controls.Add(NewBudgetBotton);
            Controls.Add(BudgetLabel);
            Controls.Add(NewBudgetTextBox);
            Name = "NewBudgetForm";
            Text = "NewBudgetForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewBudgetTextBox;
        private Label BudgetLabel;
        private Button NewBudgetBotton;
        private TextBox BudgetDescriptionTextBox;
        private Label DescriptionLabel;
    }
}