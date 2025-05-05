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
            SuspendLayout();
            // 
            // NewBudgetTextBox
            // 
            NewBudgetTextBox.Location = new Point(36, 45);
            NewBudgetTextBox.Name = "NewBudgetTextBox";
            NewBudgetTextBox.Size = new Size(107, 23);
            NewBudgetTextBox.TabIndex = 0;
            // 
            // BudgetLabel
            // 
            BudgetLabel.AutoSize = true;
            BudgetLabel.Location = new Point(36, 27);
            BudgetLabel.Name = "BudgetLabel";
            BudgetLabel.Size = new Size(105, 15);
            BudgetLabel.TabIndex = 1;
            BudgetLabel.Text = "New budget name";
            // 
            // NewBudgetBotton
            // 
            NewBudgetBotton.Location = new Point(22, 74);
            NewBudgetBotton.Name = "NewBudgetBotton";
            NewBudgetBotton.Size = new Size(138, 23);
            NewBudgetBotton.TabIndex = 2;
            NewBudgetBotton.Text = "Create new budget";
            NewBudgetBotton.UseVisualStyleBackColor = true;
            NewBudgetBotton.Click += NewBudgetBotton_Click;
            // 
            // NewBudgetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(188, 130);
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
    }
}