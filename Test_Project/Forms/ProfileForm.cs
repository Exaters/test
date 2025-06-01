using System;
using System.Windows.Forms;
using Test_Project.Models;
using Test_Project.Services;

namespace Test_Project.Forms
{
    public partial class ProfileForm : Form
    {
        private readonly User _currentUser;

        public ProfileForm(User user)
        {
            _currentUser = user;
            InitializeComponent();
            InitializeForm();
            LoadUserData();
        }

        private void InitializeForm()
        {
            // Настройка валидации
            nameTextBox.Validating += ValidateRequiredField;
            newPasswordTextBox.Validating += ValidatePassword;
            confirmPasswordTextBox.Validating += ValidatePasswordMatch;

            // Скрываем пароли по умолчанию
            newPasswordTextBox.UseSystemPasswordChar = true;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
        }

        private void ValidateRequiredField(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "This field is required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBox, "");
            }
        }

        private void ValidatePassword(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(newPasswordTextBox.Text) && newPasswordTextBox.Text.Length < 6)
            {
                errorProvider.SetError(newPasswordTextBox, "Password must be at least 6 characters");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(newPasswordTextBox, "");
            }
        }

        private void ValidatePasswordMatch(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (newPasswordTextBox.Text != confirmPasswordTextBox.Text)
            {
                errorProvider.SetError(confirmPasswordTextBox, "Passwords do not match");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(confirmPasswordTextBox, "");
            }
        }

        private void LoadUserData()
        {
            usernameLabel.Text = _currentUser.Username;
            nameTextBox.Text = _currentUser.Name;
            accountCreatedLabel.Text = $"Account created: {_currentUser.CreatedDate.ToShortDateString()}";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            try
            {
                _currentUser.Name = nameTextBox.Text;

                if (!string.IsNullOrEmpty(newPasswordTextBox.Text))
                {
                    _currentUser.Password = newPasswordTextBox.Text;
                }

                AuthService.UpdateUser(_currentUser);
                MessageBox.Show("Profile updated successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating profile: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            newPasswordTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
            confirmPasswordTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
        }
    }
}