namespace PomodoroTimer
{
    partial class POMODORO
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
            this.startStop = new System.Windows.Forms.Button();
            this.activitiesList = new System.Windows.Forms.CheckedListBox();
            this.AddActivityButton = new System.Windows.Forms.Button();
            this.DeleteActivityButton = new System.Windows.Forms.Button();
            this.UsersList = new System.Windows.Forms.CheckedListBox();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.FirstPartDoneCheck = new System.Windows.Forms.CheckBox();
            this.SecondPartDoneCheck = new System.Windows.Forms.CheckBox();
            this.ThrirdPartDoneCheck = new System.Windows.Forms.CheckBox();
            this.ForthPartDoneCheck = new System.Windows.Forms.CheckBox();
            this.InfoButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startStop
            // 
            this.startStop.Location = new System.Drawing.Point(40, 255);
            this.startStop.Name = "startStop";
            this.startStop.Size = new System.Drawing.Size(244, 88);
            this.startStop.TabIndex = 0;
            this.startStop.Text = "START";
            this.startStop.UseVisualStyleBackColor = true;
            this.startStop.Click += new System.EventHandler(this.startStop_Click);
            // 
            // activitiesList
            // 
            this.activitiesList.FormattingEnabled = true;
            this.activitiesList.HorizontalScrollbar = true;
            this.activitiesList.Location = new System.Drawing.Point(398, 54);
            this.activitiesList.Name = "activitiesList";
            this.activitiesList.Size = new System.Drawing.Size(219, 289);
            this.activitiesList.TabIndex = 1;
            this.activitiesList.UseCompatibleTextRendering = true;
            this.activitiesList.SelectedIndexChanged += new System.EventHandler(this.activitiesList_SelectedIndexChanged);
            // 
            // AddActivityButton
            // 
            this.AddActivityButton.Location = new System.Drawing.Point(398, 350);
            this.AddActivityButton.Name = "AddActivityButton";
            this.AddActivityButton.Size = new System.Drawing.Size(102, 23);
            this.AddActivityButton.TabIndex = 2;
            this.AddActivityButton.Text = "Add Activity";
            this.AddActivityButton.UseVisualStyleBackColor = true;
            this.AddActivityButton.Click += new System.EventHandler(this.AddActivityButton_Click);
            // 
            // DeleteActivityButton
            // 
            this.DeleteActivityButton.Location = new System.Drawing.Point(506, 350);
            this.DeleteActivityButton.Name = "DeleteActivityButton";
            this.DeleteActivityButton.Size = new System.Drawing.Size(111, 22);
            this.DeleteActivityButton.TabIndex = 3;
            this.DeleteActivityButton.Text = "Delete Activity";
            this.DeleteActivityButton.UseVisualStyleBackColor = true;
            this.DeleteActivityButton.Click += new System.EventHandler(this.DeleteActivityButton_Click);
            // 
            // UsersList
            // 
            this.UsersList.FormattingEnabled = true;
            this.UsersList.Location = new System.Drawing.Point(39, 111);
            this.UsersList.Name = "UsersList";
            this.UsersList.Size = new System.Drawing.Size(244, 109);
            this.UsersList.TabIndex = 4;
            this.UsersList.SelectedIndexChanged += new System.EventHandler(this.UserList_SelectedIndexChanged);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(40, 226);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(116, 23);
            this.AddUserButton.TabIndex = 5;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(162, 226);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(121, 23);
            this.DeleteUserButton.TabIndex = 6;
            this.DeleteUserButton.Text = "Delete User";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // FirstPartDoneCheck
            // 
            this.FirstPartDoneCheck.AutoSize = true;
            this.FirstPartDoneCheck.Location = new System.Drawing.Point(312, 54);
            this.FirstPartDoneCheck.Name = "FirstPartDoneCheck";
            this.FirstPartDoneCheck.Size = new System.Drawing.Size(67, 17);
            this.FirstPartDoneCheck.TabIndex = 7;
            this.FirstPartDoneCheck.Text = "First Part";
            this.FirstPartDoneCheck.UseVisualStyleBackColor = true;
            this.FirstPartDoneCheck.CheckedChanged += new System.EventHandler(this.FirstPartDoneCheck_CheckedChanged);
            // 
            // SecondPartDoneCheck
            // 
            this.SecondPartDoneCheck.AutoSize = true;
            this.SecondPartDoneCheck.Location = new System.Drawing.Point(312, 78);
            this.SecondPartDoneCheck.Name = "SecondPartDoneCheck";
            this.SecondPartDoneCheck.Size = new System.Drawing.Size(85, 17);
            this.SecondPartDoneCheck.TabIndex = 8;
            this.SecondPartDoneCheck.Text = "Second Part";
            this.SecondPartDoneCheck.UseVisualStyleBackColor = true;
            // 
            // ThrirdPartDoneCheck
            // 
            this.ThrirdPartDoneCheck.AutoSize = true;
            this.ThrirdPartDoneCheck.Location = new System.Drawing.Point(312, 101);
            this.ThrirdPartDoneCheck.Name = "ThrirdPartDoneCheck";
            this.ThrirdPartDoneCheck.Size = new System.Drawing.Size(72, 17);
            this.ThrirdPartDoneCheck.TabIndex = 9;
            this.ThrirdPartDoneCheck.Text = "Third Part";
            this.ThrirdPartDoneCheck.UseVisualStyleBackColor = true;
            // 
            // ForthPartDoneCheck
            // 
            this.ForthPartDoneCheck.AutoSize = true;
            this.ForthPartDoneCheck.Location = new System.Drawing.Point(312, 125);
            this.ForthPartDoneCheck.Name = "ForthPartDoneCheck";
            this.ForthPartDoneCheck.Size = new System.Drawing.Size(72, 17);
            this.ForthPartDoneCheck.TabIndex = 10;
            this.ForthPartDoneCheck.Text = "Forth Part";
            this.ForthPartDoneCheck.UseVisualStyleBackColor = true;
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(461, 12);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(75, 23);
            this.InfoButton.TabIndex = 11;
            this.InfoButton.Text = "INFO";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(542, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // POMODORO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 427);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.ForthPartDoneCheck);
            this.Controls.Add(this.ThrirdPartDoneCheck);
            this.Controls.Add(this.SecondPartDoneCheck);
            this.Controls.Add(this.FirstPartDoneCheck);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.UsersList);
            this.Controls.Add(this.DeleteActivityButton);
            this.Controls.Add(this.AddActivityButton);
            this.Controls.Add(this.activitiesList);
            this.Controls.Add(this.startStop);
            this.Name = "POMODORO";
            this.Text = "POMODORO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startStop;
        private System.Windows.Forms.CheckedListBox activitiesList;
        private System.Windows.Forms.Button AddActivityButton;
        private System.Windows.Forms.Button DeleteActivityButton;
        private System.Windows.Forms.CheckedListBox UsersList;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.CheckBox FirstPartDoneCheck;
        private System.Windows.Forms.CheckBox SecondPartDoneCheck;
        private System.Windows.Forms.CheckBox ThrirdPartDoneCheck;
        private System.Windows.Forms.CheckBox ForthPartDoneCheck;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

