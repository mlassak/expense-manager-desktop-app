using ExpManagerDAL.Models;
using ExpManagerDAL.DataAccessClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ExpenseManager.ToolbarPopUpWindows;
using System.Threading.Tasks;
using ExpenseManager.UserAccountWindows;

namespace ExpenseManager
{
    public partial class MainWindow : Form
    {
        protected User CurrentUser { get; set; }
        protected List<Transaction> CurrentTransactions { get; set; }

        public MainWindow(User currUser)
        {
            CurrentUser = currUser;
            InitializeComponent();
            UpdateBalanceTextBox();
            usernameTextBox.Text = CurrentUser.Username;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            var addWindow = new AddWindow.AddWindow(CurrentUser);
            addWindow.ShowDialog();
            
            UpdateBalanceTextBox();
            await UpdateUserRecordAsync();

            loadButton_Click(this, null);   

            DialogResult = DialogResult.OK;
        }

        private void UpdateBalanceTextBox()
        {
            balanceTextBox.Text = decimal.Round(CurrentUser.Balance, 2).ToString();
        }

        private async Task UpdateUserRecordAsync()                
        {
            var userRepo = new UserRepository();
            await userRepo.UpdateUserAsync(CurrentUser);
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataTable.SelectedRows.Count > 0)
            {
                var trRepo = new TransactionRepository();

                foreach (DataGridViewRow row in dataTable.SelectedRows)
                {
                    long trId = long.Parse(row.Cells[0].Value.ToString());

                    var trToDelete = trRepo.GetTransaction(trId);

                    CurrentUser.Balance -= trToDelete.Amount;
                    await trRepo.RemoveTransactionAsync(trToDelete);
                }
            }
            else
            {
                var deleteWindow = new DeleteWindow(CurrentUser);
                deleteWindow.ShowDialog();
            }

            UpdateBalanceTextBox();
            await UpdateUserRecordAsync();

            loadButton_Click(this, null);   

            DialogResult = DialogResult.OK;
        }

        private async void editButton_Click(object sender, EventArgs e)
        {
            var editWindow = new EditWindow(CurrentUser);

            if (dataTable.SelectedRows.Count == 1)
            {
                var selectedTrId = long.Parse(dataTable.SelectedRows[0].Cells[0].Value.ToString());
                editWindow = new EditWindow(CurrentUser, selectedTrId);
            }

            editWindow.ShowDialog();

            UpdateBalanceTextBox();
            await UpdateUserRecordAsync();

            loadButton_Click(this, null);  

            DialogResult = DialogResult.OK;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Clear(); 

            var trRepo = new TransactionRepository();
            CurrentTransactions = trRepo.GetAllUserTransactions(CurrentUser.Id);   

            foreach (var transaction in CurrentTransactions)
            {
                var rowToAdd = new DataGridViewRow();

                for (int i = 0; i < 5; ++i)
                {
                    rowToAdd.Cells.Add(new DataGridViewTextBoxCell());
                }

                rowToAdd.Cells[0].Value = transaction.Id;
                rowToAdd.Cells[1].Value = transaction.Name;
                rowToAdd.Cells[2].Value = decimal.Round(transaction.Amount, 2);
                rowToAdd.Cells[3].Value = transaction.Category.ToString();
                rowToAdd.Cells[4].Value = transaction.Date.ToString();          

                dataTable.Rows.Add(rowToAdd);
            }
            
            addButton.Enabled = true;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
            exportButton.Enabled = true;
        }

        private async void exportButton_Click(object sender, EventArgs e)   
        {
            try
            {
                string outFilePath = "";

                var fileDialog = new SaveFileDialog();
                fileDialog.FileName = $"{CurrentUser.Username}_output.txt";
                fileDialog.Filter = "Text File | *.txt";

                if (fileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                outFilePath = fileDialog.FileName;

                var trRepo = new TransactionRepository();
                var transactions = trRepo.GetAllUserTransactions(CurrentUser.Id);

                using (var output = new FileStream(
                    outFilePath,
                    FileMode.Append,
                    FileAccess.Write,
                    FileShare.None,
                    4096,
                    true))
                {
                    foreach (var tr in transactions)
                    {
                        var outStr = $"{tr.Name};{tr.Amount};{tr.Category.ToString()};{tr.Date.ToString()}\n";
                        byte[] byteOutput = Encoding.UTF8.GetBytes(outStr);
                        await output.WriteAsync(byteOutput);
                    }
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() => throw ex));
            }
        }

        private async void importButton_Click(object sender, EventArgs e)
        {
            try
            {
                string inputFilePath = "";

                var fileDialog = new OpenFileDialog();

                if (fileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                inputFilePath = fileDialog.FileName;

                if (!File.Exists(inputFilePath))
                {
                    return;
                }

                var lines = new List<string>();

                using (var inputFile = new StreamReader(inputFilePath, Encoding.UTF8))
                {
                    string line;

                    while ((line = inputFile.ReadLineAsync().Result) != null)
                    {
                        lines.Add(line);
                    }
                }

                if (!ValidateFileContent(lines))
                {
                    MessageBox.Show("Input file does not conform to the expected format",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }

                await SaveLinesDataAsync(lines);

                UpdateBalanceTextBox();
                await UpdateUserRecordAsync();
                loadButton_Click(this, null);
            }
            catch (Exception ex)
            {
                Invoke(new Action(() => throw ex));
            }
        }


        private static bool ValidateFileContent(List<string> lines)       
        {
            bool result = true;

            Parallel.ForEach(lines, line =>
            {
                var split = line.Split(';');

                if (split.Length != 4
                    || !decimal.TryParse(split[1], out _)
                    || !Enum.TryParse<Category>(split[2], out _)
                    || !DateTime.TryParse(split[3], out _))
                {
                    result = false;
                };
            });

            return result;
        }

        private async Task SaveLinesDataAsync(List<string> lines)
        {
            var trRepo = new TransactionRepository();

            foreach (var line in lines)
            {
                var split = line.Split(';');

                var amount = decimal.Parse(split[1]);
                CurrentUser.Balance += amount;

                var transactionToAdd = new Transaction
                {
                    Name = split[0],
                    Amount = amount,
                    Category = Enum.Parse<Category>(split[2]),
                    Date = DateTime.Parse(split[3]),
                    UserId = CurrentUser.Id              
                };

                await trRepo.CreateTransactionAsync(transactionToAdd);
            }
        }

        private void manageAccountButton_Click(object sender, EventArgs e)
        {
            var manageWindow = new ManageAccountWindow(CurrentUser);
            manageWindow.ShowDialog();

            if (manageWindow.DialogResult == DialogResult.Abort)
            {
                logoutButton_Click(this, null);
                return;
            }

            if (manageWindow.DialogResult == DialogResult.Yes)
            {
                usernameTextBox.Text = CurrentUser.Username;
                manageAccountButton_Click(this, null); 
            }
        }
    }
}
