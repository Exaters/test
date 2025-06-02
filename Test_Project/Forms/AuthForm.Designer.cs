using System.Xml.Linq;
using Test_Project.Services;

namespace Test_Project.Forms
{
    partial class AuthForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            btnSwitchMode = new Button();
            btnAction = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(156, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(78, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Login";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(57, 93);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(137, 89);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(205, 27);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(57, 147);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(137, 143);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(205, 27);
            txtPassword.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(57, 200);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            lblName.Visible = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(137, 196);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(205, 27);
            txtName.TabIndex = 6;
            txtName.Visible = false;
            // 
            // btnSwitchMode
            // 
            btnSwitchMode.Location = new Point(57, 267);
            btnSwitchMode.Margin = new Padding(3, 4, 3, 4);
            btnSwitchMode.Name = "btnSwitchMode";
            btnSwitchMode.Size = new Size(137, 40);
            btnSwitchMode.TabIndex = 7;
            btnSwitchMode.Text = "Create Account";
            btnSwitchMode.UseVisualStyleBackColor = true;
            btnSwitchMode.Click += btnSwitchMode_Click;
            // 
            // btnAction
            // 
            btnAction.Location = new Point(206, 267);
            btnAction.Margin = new Padding(3, 4, 3, 4);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(137, 40);
            btnAction.TabIndex = 8;
            btnAction.Text = "Login";
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += btnAction_Click;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 333);
            Controls.Add(btnAction);
            Controls.Add(btnSwitchMode);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authentication";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblName;
        private TextBox txtName;
        private Button btnSwitchMode;
        private Button btnAction;
    }
}