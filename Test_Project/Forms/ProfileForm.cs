using System.ComponentModel;
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

            txtName.Validating += ValidateRequiredField;
            txtNewPassword.Validating += ValidatePassword;
            txtConfirmPassword.Validating += ValidatePasswordMatch;

            UpdatePasswordVisibility();
        }

        private void UpdatePasswordVisibility()
        {
            bool showPassword = chkShowPassword.Checked;

            txtNewPassword.UseSystemPasswordChar = false;
            txtConfirmPassword.UseSystemPasswordChar = false;

            txtNewPassword.PasswordChar = showPassword ? '\0' : '*';
            txtConfirmPassword.PasswordChar = showPassword ? '\0' : '*';

            txtNewPassword.Refresh();
            txtConfirmPassword.Refresh();
        }

        private void ValidateRequiredField(object sender, CancelEventArgs e)
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

        private void ValidatePassword(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNewPassword.Text) && txtNewPassword.Text.Length < 6)
            {
                errorProvider.SetError(txtNewPassword, "Password must be at least 6 characters");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNewPassword, "");
            }
        }

        private void ValidatePasswordMatch(object sender, CancelEventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider.SetError(txtConfirmPassword, "Passwords do not match");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtConfirmPassword, "");
            }
        }

        private void LoadUserData()
        {
            lblUsername.Text = _currentUser.Username;
            txtName.Text = _currentUser.Name;
            lblAccountCreated.Text = $"Account created: {_currentUser.CreatedDate.ToShortDateString()}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            try
            {
                _currentUser.Name = txtName.Text;

                if (!string.IsNullOrEmpty(txtNewPassword.Text))
                {
                    _currentUser.Password = HashService.ComputeSaltedHash(txtNewPassword.Text);
                }

                AuthService.UpdateUser(_currentUser);
                _ = MessageBox.Show("Profile updated successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"Error updating profile: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePasswordVisibility();
        }
    }
}