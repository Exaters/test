using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Project.Models;
using Test_Project.Services;
using System.Windows.Forms;
using System.Xml.Linq;

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
                var user = AuthService.Login(txtUsername.Text, txtPassword.Text);
                if (user != null)
                {
                    new MainForm(user).Show();
                    this.Hide();
                }
                else MessageBox.Show("Invalid credentials");
            }
            else
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Please enter your name");
                    return;
                }

                var newUser = new User
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Name = txtName.Text
                };

                if (AuthService.Register(newUser))
                {
                    isLoginMode = true;
                    UpdateFormState();
                    MessageBox.Show("Registration successful!");
                }
                else MessageBox.Show("Username already exists");
            }
        }
    }
}
