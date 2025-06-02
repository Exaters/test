using Test_Project.Models;
using Test_Project.Services;

namespace Test_Project.Forms
{
    public partial class AuthForm : Form
    {
        private bool isLoginMode = true;

        public AuthForm()
        {
            InitializeComponent();
            UpdateFormState();
        }

        private void UpdateFormState()
        {
            lblTitle.Text = isLoginMode ? "Login" : "Register";
            btnSwitchMode.Text = isLoginMode ? "Create Account" : "Already have an account?";
            btnAction.Text = isLoginMode ? "Login" : "Register";
            lblName.Visible = !isLoginMode;
            txtName.Visible = !isLoginMode;
        }

        private void btnSwitchMode_Click(object sender, EventArgs e)
        {
            isLoginMode = !isLoginMode;
            UpdateFormState();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (isLoginMode)
            {
                string hashedPassword = HashService.ComputeSaltedHash(txtPassword.Text);
                var user = AuthService.Login(txtUsername.Text, hashedPassword);

                if (user != null)
                {
                    new MainForm(user).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Please enter your name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string hashedPassword = HashService.ComputeSaltedHash(txtPassword.Text);

                var newUser = new User
                {
                    Username = txtUsername.Text,
                    Password = hashedPassword,
                    Name = txtName.Text
                };

                if (AuthService.Register(newUser))
                {
                    isLoginMode = true;
                    UpdateFormState();
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}