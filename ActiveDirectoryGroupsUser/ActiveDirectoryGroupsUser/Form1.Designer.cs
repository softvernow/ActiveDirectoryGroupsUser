namespace ActiveDirectoryGroupsUser
{
    partial class Form1
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGroups = new System.Windows.Forms.RichTextBox();
            this.btnGetGroups = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(81, 19);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '*';
            this.txtUserName.Size = new System.Drawing.Size(191, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name:";
            // 
            // txtGroups
            // 
            this.txtGroups.Location = new System.Drawing.Point(15, 55);
            this.txtGroups.Name = "txtGroups";
            this.txtGroups.Size = new System.Drawing.Size(257, 150);
            this.txtGroups.TabIndex = 2;
            this.txtGroups.Text = "";
            // 
            // btnGetGroups
            // 
            this.btnGetGroups.Location = new System.Drawing.Point(13, 212);
            this.btnGetGroups.Name = "btnGetGroups";
            this.btnGetGroups.Size = new System.Drawing.Size(259, 23);
            this.btnGetGroups.TabIndex = 3;
            this.btnGetGroups.Text = "Get Groups";
            this.btnGetGroups.UseVisualStyleBackColor = true;
            this.btnGetGroups.Click += new System.EventHandler(this.btnGetGroups_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 245);
            this.Controls.Add(this.btnGetGroups);
            this.Controls.Add(this.txtGroups);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtGroups;
        private System.Windows.Forms.Button btnGetGroups;
    }
}

