using System;
using System.Windows.Forms;
using ExpenseManager.UserAccountWindows;
using ExpManagerDAL.DataAccessClasses;
using ExpManagerDAL.Models;

namespace ExpenseManager
{
    public partial class RegisterForm : Form
    {
        public User CreatedUser { get; private set; }

        public RegisterForm()
        {
            InitializeComponent();
        }


        private async void registerButton_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }

            var userRepo = new UserRepository();

            var foundUser = await userRepo.GetUserAsync(unameTextBox.Text);
            if (foundUser is not null)
            {
                MessageBox.Show("Username is already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                unameTextBox.Clear();
                return;
            }

            var newUser = new User
            {
                Username = unameTextBox.Text,
                Password = passwdTextBox.Text
            };
            CreatedUser = newUser;
            await userRepo.CreateUserAsync(newUser);
            
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool CheckInput()
        {
            if (unameTextBox.Text == "")
            {
                MessageBox.Show("Empty username field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (unameTextBox.Text.Length > LengthConstraints.UnameMaxLength)
            {
                MessageBox.Show($"Username is too long, maximum length is {LengthConstraints.UnameMaxLength} characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                unameTextBox.Clear();
                return false;
            }

            if (passwdTextBox.Text == "")
            {
                MessageBox.Show("Empty password field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (passwdTextBox.Text.Length > LengthConstraints.PasswdMaxLength)
            {
                MessageBox.Show($"Password is too long, maximum length is {LengthConstraints.PasswdMaxLength} characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                passwdTextBox.Clear();
                confirmPasswdTextBox.Clear();
                return false;
            }

            if (passwdTextBox.Text != confirmPasswdTextBox.Text)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                confirmPasswdTextBox.Clear();
                return false;
            }

            return true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void confirmPasswdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                registerButton_Click(this, null);
            }
        }
    }
}
