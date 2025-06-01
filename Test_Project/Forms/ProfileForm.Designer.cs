namespace Test_Project.Forms
{
    partial class ProfileForm
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
            this.components = new System.ComponentModel.Container();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.accountCreatedLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(20, 20);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 17);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(20, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(20, 100);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '*';
            this.newPasswordTextBox.Size = new System.Drawing.Size(200, 23);
            this.newPasswordTextBox.TabIndex = 2;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(20, 140);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(200, 23);
            this.confirmPasswordTextBox.TabIndex = 3;
            // 
            // accountCreatedLabel
            // 
            this.accountCreatedLabel.AutoSize = true;
            this.accountCreatedLabel.Location = new System.Drawing.Point(20, 220);
            this.accountCreatedLabel.Name = "accountCreatedLabel";
            this.accountCreatedLabel.Size = new System.Drawing.Size(100, 15);
            this.accountCreatedLabel.TabIndex = 4;
            this.accountCreatedLabel.Text = "Account created:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(20, 180);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 30);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(130, 180);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 30);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(20, 170);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(108, 19);
            this.showPasswordCheckBox.TabIndex = 7;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 260);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.accountCreatedLabel);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Profile";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label usernameLabel;
        private TextBox nameTextBox;
        private TextBox newPasswordTextBox;
        private TextBox confirmPasswordTextBox;
        private Label accountCreatedLabel;
        private Button saveButton;
        private Button cancelButton;
        private ErrorProvider errorProvider;
        private CheckBox showPasswordCheckBox;
    }
}