using System;
using System.Windows.Forms;
using ExpManagerDAL.DataAccessClasses;
using ExpManagerDAL.Models;

namespace ExpenseManager.ToolbarPopUpWindows
{
    public partial class EditWindow : Form
    {
        public User CurrUser { get; set; }

        private long editedTransactionId { get; set; }

        public EditWindow(User user)
        {
            CurrUser = user;
            InitializeComponent();
        }

        public EditWindow(User user, long trId)
        {
            CurrUser = user;
            editedTransactionId = trId;
            InitializeComponent();
            loadIdTextBox.Text = trId.ToString();
            loadButton_Click(this, null);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            SwitchFocus();
            loadIdTextBox.Clear();
        }

        private void SwitchFocus()
        {
            loadButton.Enabled = !loadButton.Enabled;
            loadIdTextBox.Enabled = !loadIdTextBox.Enabled;

            nameTextBox.Enabled = !nameTextBox.Enabled;
            amountTextBox.Enabled = !amountTextBox.Enabled;
            categoryComboBox.Enabled = !categoryComboBox.Enabled;
            datePicker.Enabled = !datePicker.Enabled;

            resetButton.Enabled = !resetButton.Enabled;
            editButton.Enabled = !editButton.Enabled;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (loadIdTextBox.Text == "")
            {
                MessageBox.Show("Empty id box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            long transactionId;
            if (!long.TryParse(loadIdTextBox.Text, out transactionId))
            {
                MessageBox.Show("Invalid ID value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var trRepo = new TransactionRepository();
            var foundTransaction = trRepo.GetTransaction(transactionId);
            if (foundTransaction is null || foundTransaction.UserId != CurrUser.Id)   
            {
                MessageBox.Show("No owned transaction found with given ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            nameTextBox.Text = foundTransaction.Name;
            amountTextBox.Text = foundTransaction.Amount.ToString();
            categoryComboBox.SelectedItem = foundTransaction.Category;    
            datePicker.Value = foundTransaction.Date;

            editedTransactionId = transactionId;

            SwitchFocus();
        }

        private async void editButton_Click(object sender, EventArgs e)
        {
            var transactionName = nameTextBox.Text;
            if (transactionName == "")
            {
                MessageBox.Show("Empty transaction name box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var amountText = amountTextBox.Text;
            if (amountText == "")
            {
                MessageBox.Show("Empty amount box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal newTransactionAmount;
            if (!decimal.TryParse(amountText, out newTransactionAmount))
            {
                MessageBox.Show("Invalid amount value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                amountTextBox.Clear();
                return;
            }

            var updatedTransaction = new Transaction
            {
                Id = editedTransactionId,
                UserId = CurrUser.Id,
                Name = transactionName,
                Amount = decimal.Round(newTransactionAmount, 2),
                Category = Enum.Parse<Category>(categoryComboBox.Text),
                Date = datePicker.Value
            };

            var transactRepo = new TransactionRepository();
            CurrUser.Balance -= transactRepo.GetTransaction(long.Parse(loadIdTextBox.Text)).Amount;    
            CurrUser.Balance += newTransactionAmount;
            await transactRepo.UpdateTransactionAsync(updatedTransaction);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
