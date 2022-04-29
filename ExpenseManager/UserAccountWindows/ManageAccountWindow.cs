using System;
using System.Windows.Forms;
using ExpManagerDAL.DataAccessClasses;
using ExpManagerDAL.Models;

namespace ExpenseManager.UserAccountWindows
{
    public partial class ManageAccountWindow : Form
    {
        public User CurrentUser { get; set; }

        public ManageAccountWindow(User user)
        {
            CurrentUser = user;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void deleteAccConfirmCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            deleteAccountButton.Enabled = !deleteAccountButton.Enabled;
        }

        private async void deleteAccountButton_Click(object sender, EventArgs e)
        {
            var trRepo = new TransactionRepository();
            var userTransactions = trRepo.GetAllUserTransactions(CurrentUser.Id);
            await trRepo.RemoveTransactionsRangeAsync(userTransactions);

            var userRepo = new UserRepository();
            var user = await userRepo.GetUserAsync(CurrentUser.Username);
            await userRepo.RemoveUserAsync(user);

            DialogResult = DialogResult.Abort;
            Close();
        }

        private async void changePasswdButton_Click(object sender, EventArgs e)
        {
            if (passwdTextBox.Text == "")
            {
                MessageBox.Show("Password field cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (passwdTextBox.Text.Length > LengthConstraints.PasswdMaxLength)
            {
                MessageBox.Show($"Password is too long, maximum length is {LengthConstraints.PasswdMaxLength} characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                passwdTextBox.Clear();
                confirmPasswdTextBox.Clear();
                return;
            }

            if (passwdTextBox.Text != confirmPasswdTextBox.Text)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                confirmPasswdTextBox.Clear();
                return;
            }

            CurrentUser.Password = passwdTextBox.Text;
            var userRepo = new UserRepository();
            await userRepo.UpdateUserAsync(CurrentUser);

            passwdTextBox.Clear();
            confirmPasswdTextBox.Clear();

            MessageBox.Show("Password has been successfully changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void changeUnameButton_Click(object sender, EventArgs e)
        {
            if (newUnameTextBox.Text == "")
            {
                MessageBox.Show("Username field cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (newUnameTextBox.Text.Length > LengthConstraints.UnameMaxLength)
            {
                MessageBox.Show($"Username is too long, maximum length is {LengthConstraints.UnameMaxLength} characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                newUnameTextBox.Clear();
                return;
            }

            var newUsername = newUnameTextBox.Text;  

            var userRepo = new UserRepository();
            var foundUser = await userRepo.GetUserAsync(newUsername);
            if (foundUser != null)
            {
                MessageBox.Show("Username is already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                newUnameTextBox.Clear();
                return;
            }

            CurrentUser.Username = newUsername;        
            await userRepo.UpdateUserAsync(CurrentUser);

            newUnameTextBox.Clear();

            MessageBox.Show("Username changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.Yes;   
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
