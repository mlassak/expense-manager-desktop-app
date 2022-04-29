using System;
using System.Windows.Forms;
using ExpManagerDAL.DataAccessClasses;
using ExpManagerDAL.Models;

namespace ExpenseManager.ToolbarPopUpWindows
{
    public partial class DeleteWindow : Form
    {
        public User CurrUser { get; set; }

        public DeleteWindow(User user)
        {
            CurrUser = user;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            long trId;
            if (idTextBox.Text == "")
            {
                MessageBox.Show("Empty ID field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!long.TryParse(idTextBox.Text, out trId))
            {
                MessageBox.Show("Invalid ID value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var transactionRepo = new TransactionRepository();
            var transactionToDelete = transactionRepo.GetTransaction(trId);
            if (transactionToDelete is null || transactionToDelete.UserId != CurrUser.Id)
            {
                MessageBox.Show("Cannot delete transaction, ID does not correspond to any owned transaction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            

            CurrUser.Balance -= transactionToDelete.Amount;
            await transactionRepo.RemoveTransactionAsync(transactionToDelete);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
