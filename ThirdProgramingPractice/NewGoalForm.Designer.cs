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
            NameTextBox.Location = new Point(12, 44);
            NameTextBox.Margin = new Padding(3, 4, 3, 4);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(196, 27);
            NameTextBox.TabIndex = 12;
            // 
            // GoalNameLabel
            // 
            GoalNameLabel.AutoSize = true;
            GoalNameLabel.Location = new Point(69, 20);
            GoalNameLabel.Name = "GoalNameLabel";
            GoalNameLabel.Size = new Size(81, 20);
            GoalNameLabel.TabIndex = 13;
            GoalNameLabel.Text = "Goal name";
            // 
            // GoalTaskLabel
            // 
            GoalTaskLabel.AutoSize = true;
            GoalTaskLabel.Location = new Point(73, 75);
            GoalTaskLabel.Name = "GoalTaskLabel";
            GoalTaskLabel.Size = new Size(70, 20);
            GoalTaskLabel.TabIndex = 14;
            GoalTaskLabel.Text = "Goal task";
            GoalTaskLabel.Click += GoalTaskLabel_Click;
            // 
            // GoalTextBox
            // 
            GoalTextBox.Location = new Point(12, 99);
            GoalTextBox.Margin = new Padding(3, 4, 3, 4);
            GoalTextBox.Name = "GoalTextBox";
            GoalTextBox.Size = new Size(196, 27);
            GoalTextBox.TabIndex = 15;
            // 
            // CreateGoalButton
            // 
            CreateGoalButton.Location = new Point(28, 134);
            CreateGoalButton.Margin = new Padding(3, 4, 3, 4);
            CreateGoalButton.Name = "CreateGoalButton";
            CreateGoalButton.Size = new Size(160, 37);
            CreateGoalButton.TabIndex = 17;
            CreateGoalButton.Text = "Create goal";
            CreateGoalButton.UseVisualStyleBackColor = true;
            // 
            // NewGoalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 184);
            Controls.Add(CreateGoalButton);
            Controls.Add(GoalTextBox);
            Controls.Add(GoalTaskLabel);
            Controls.Add(GoalNameLabel);
            Controls.Add(NameTextBox);
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