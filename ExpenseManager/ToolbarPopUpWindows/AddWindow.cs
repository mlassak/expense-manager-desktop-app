using ExpManagerDAL.DataAccessClasses;
using ExpManagerDAL.Models;
using System;
using System.Windows.Forms;

namespace ExpenseManager.AddWindow
{
    public partial class AddWindow : Form
    {
        public User CurrentUser { get; init; }

        public AddWindow(User currUser)
        {
            CurrentUser = currUser;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void createButton_Click(object sender, EventArgs e)
        {
            var transactionName = transNameTextBox.Text;
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

            decimal transactionAmount;
            if (!decimal.TryParse(amountText, out transactionAmount))
            {
                MessageBox.Show("Invalid amount value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                amountTextBox.Clear();
                return;
            }

            var transactionToAdd = new Transaction
            {
                UserId = CurrentUser.Id, 
                Name = transactionName,
                Amount = decimal.Round(transactionAmount, 2),
                Category = Enum.Parse<Category>(categoryComboBox.Text),
                Date = dateTimePicker.Value
            };

            CurrentUser.Balance += transactionAmount;

            var transactRepo = new TransactionRepository();       
            await transactRepo.CreateTransactionAsync(transactionToAdd);  

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
