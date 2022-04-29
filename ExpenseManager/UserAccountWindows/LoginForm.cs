using ExpManagerDAL.DataAccessClasses;
using System;
using System.Windows.Forms;
using ExpManagerDAL.Models;

namespace ExpenseManager
{
    public partial class LoginForm : Form
    {
        public User CurrentUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)   
        {
            if (unameTextBox.Text == "")
            {
                MessageBox.Show("Empty username field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (passwdTextBox.Text == "")
            {
                MessageBox.Show("Empty password field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var userRepo = new UserRepository();
            var foundUser = await userRepo.GetUserAsync(unameTextBox.Text);
            if (foundUser is null || foundUser.Password != passwdTextBox.Text)
            {
                MessageBox.Show("Invalid credentials", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            CurrentUser = foundUser;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void passwdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                loginButton_Click(this, null);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            unameTextBox.Clear();
            passwdTextBox.Clear();

            var regForm = new RegisterForm(); 
            regForm.ShowDialog();
        }
    }
}
