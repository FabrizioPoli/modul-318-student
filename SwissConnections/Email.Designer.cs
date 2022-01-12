namespace SwissConnections
{
    partial class Email
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
            this.tbxToEmail = new System.Windows.Forms.TextBox();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.tbxSubject = new System.Windows.Forms.TextBox();
            this.tbxGmailEmail = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lbGmailEmail = new System.Windows.Forms.Label();
            this.lbGamilPassword = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxBody = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxToEmail
            // 
            this.tbxToEmail.Location = new System.Drawing.Point(112, 18);
            this.tbxToEmail.Name = "tbxToEmail";
            this.tbxToEmail.Size = new System.Drawing.Size(165, 23);
            this.tbxToEmail.TabIndex = 0;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(12, 21);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(23, 15);
            this.lbTo.TabIndex = 1;
            this.lbTo.Text = "To:";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(12, 58);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(49, 15);
            this.lbSubject.TabIndex = 2;
            this.lbSubject.Text = "Subject:";
            // 
            // tbxSubject
            // 
            this.tbxSubject.Location = new System.Drawing.Point(112, 55);
            this.tbxSubject.Name = "tbxSubject";
            this.tbxSubject.Size = new System.Drawing.Size(165, 23);
            this.tbxSubject.TabIndex = 3;
            // 
            // tbxGmailEmail
            // 
            this.tbxGmailEmail.Location = new System.Drawing.Point(112, 150);
            this.tbxGmailEmail.Name = "tbxGmailEmail";
            this.tbxGmailEmail.Size = new System.Drawing.Size(165, 23);
            this.tbxGmailEmail.TabIndex = 4;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(112, 189);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(165, 23);
            this.tbxPassword.TabIndex = 5;
            // 
            // lbGmailEmail
            // 
            this.lbGmailEmail.AutoSize = true;
            this.lbGmailEmail.Location = new System.Drawing.Point(12, 153);
            this.lbGmailEmail.Name = "lbGmailEmail";
            this.lbGmailEmail.Size = new System.Drawing.Size(73, 15);
            this.lbGmailEmail.TabIndex = 6;
            this.lbGmailEmail.Text = "Gmail Email:";
            // 
            // lbGamilPassword
            // 
            this.lbGamilPassword.AutoSize = true;
            this.lbGamilPassword.Location = new System.Drawing.Point(12, 192);
            this.lbGamilPassword.Name = "lbGamilPassword";
            this.lbGamilPassword.Size = new System.Drawing.Size(94, 15);
            this.lbGamilPassword.TabIndex = 7;
            this.lbGamilPassword.Text = "Gmail Password:";
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Location = new System.Drawing.Point(112, 266);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Body:";
            // 
            // tbxBody
            // 
            this.tbxBody.Location = new System.Drawing.Point(112, 100);
            this.tbxBody.Name = "tbxBody";
            this.tbxBody.Size = new System.Drawing.Size(165, 23);
            this.tbxBody.TabIndex = 10;
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 313);
            this.Controls.Add(this.tbxBody);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbGamilPassword);
            this.Controls.Add(this.lbGmailEmail);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxGmailEmail);
            this.Controls.Add(this.tbxSubject);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.tbxToEmail);
            this.Name = "Email";
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbxToEmail;
        private Label lbTo;
        private Label lbSubject;
        private TextBox tbxSubject;
        private TextBox tbxGmailEmail;
        private TextBox tbxPassword;
        private Label lbGmailEmail;
        private Label lbGamilPassword;
        private Button btnSend;
        private Label label1;
        private TextBox tbxBody;
    }
}