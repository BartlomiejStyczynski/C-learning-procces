namespace PomodoroTimer
{
    partial class EnterNewUserWindow
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
            this.AcceptNewData = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.NewUserTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AcceptNewData
            // 
            this.AcceptNewData.Location = new System.Drawing.Point(15, 92);
            this.AcceptNewData.Name = "AcceptNewData";
            this.AcceptNewData.Size = new System.Drawing.Size(75, 23);
            this.AcceptNewData.TabIndex = 0;
            this.AcceptNewData.Text = "OK";
            this.AcceptNewData.UseVisualStyleBackColor = true;
            this.AcceptNewData.Click += new System.EventHandler(this.AcceptNewData_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(133, 92);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NewUserTextBox
            // 
            this.NewUserTextBox.Location = new System.Drawing.Point(15, 66);
            this.NewUserTextBox.Name = "NewUserTextBox";
            this.NewUserTextBox.Size = new System.Drawing.Size(193, 20);
            this.NewUserTextBox.TabIndex = 2;
            this.NewUserTextBox.TextChanged += new System.EventHandler(this.NewUserTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter a new use name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EnterNewUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 139);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewUserTextBox);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AcceptNewData);
            this.Name = "EnterNewUserWindow";
            this.Text = "Please enter new user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcceptNewData;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox NewUserTextBox;
        private System.Windows.Forms.Label label1;
    }
}