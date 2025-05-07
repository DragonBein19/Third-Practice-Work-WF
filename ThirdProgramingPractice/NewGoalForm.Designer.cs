namespace ThirdProgramingPractice
{
    partial class NewGoalForm
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
            NameTextBox = new TextBox();
            GoalNameLabel = new Label();
            GoalTaskLabel = new Label();
            GoalTextBox = new TextBox();
            CreateGoalButton = new Button();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(10, 33);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(172, 23);
            NameTextBox.TabIndex = 12;
            // 
            // GoalNameLabel
            // 
            GoalNameLabel.AutoSize = true;
            GoalNameLabel.Location = new Point(60, 15);
            GoalNameLabel.Name = "GoalNameLabel";
            GoalNameLabel.Size = new Size(64, 15);
            GoalNameLabel.TabIndex = 13;
            GoalNameLabel.Text = "Goal name";
            // 
            // GoalTaskLabel
            // 
            GoalTaskLabel.AutoSize = true;
            GoalTaskLabel.Location = new Point(64, 56);
            GoalTaskLabel.Name = "GoalTaskLabel";
            GoalTaskLabel.Size = new Size(55, 15);
            GoalTaskLabel.TabIndex = 14;
            GoalTaskLabel.Text = "Goal task";
            GoalTaskLabel.Click += GoalTaskLabel_Click;
            // 
            // GoalTextBox
            // 
            GoalTextBox.Location = new Point(10, 74);
            GoalTextBox.Name = "GoalTextBox";
            GoalTextBox.Size = new Size(172, 23);
            GoalTextBox.TabIndex = 15;
            // 
            // CreateGoalButton
            // 
            CreateGoalButton.Location = new Point(24, 100);
            CreateGoalButton.Name = "CreateGoalButton";
            CreateGoalButton.Size = new Size(140, 28);
            CreateGoalButton.TabIndex = 17;
            CreateGoalButton.Text = "Create goal";
            CreateGoalButton.UseVisualStyleBackColor = true;
            CreateGoalButton.Click += CreateGoalButton_Click;
            // 
            // NewGoalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(192, 138);
            Controls.Add(CreateGoalButton);
            Controls.Add(GoalTextBox);
            Controls.Add(GoalTaskLabel);
            Controls.Add(GoalNameLabel);
            Controls.Add(NameTextBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NewGoalForm";
            Text = "NewGoalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTextBox;
        private Label GoalNameLabel;
        private Label GoalTaskLabel;
        private TextBox GoalTextBox;
        private Button CreateGoalButton;
    }
}