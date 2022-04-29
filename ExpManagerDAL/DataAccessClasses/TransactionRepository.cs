using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpManagerDAL.Models;

namespace ExpManagerDAL.DataAccessClasses
{
    public class TransactionRepository
    {
        public async Task CreateTransactionAsync(Transaction transactionToAdd)
        {
            using (var dbc = new ExpManagerDbContext())
            {
                dbc.Transactions.Add(transactionToAdd);
                await dbc.SaveChangesAsync();
            }
        }

        public async Task RemoveTransactionAsync(Transaction transactionToRemove)
        {
            using (var dbc = new ExpManagerDbContext())
            {
                dbc.Transactions.Remove(transactionToRemove);     
                
                await dbc.SaveChangesAsync();
            }
        }

        public async Task RemoveTransactionsRangeAsync(List<Transaction> transactionsToRemove)
        {
            using (var dbc = new ExpManagerDbContext())
            {
                dbc.Transactions.RemoveRange(transactionsToRemove);   

                await dbc.SaveChangesAsync();
            }
        }

        public Transaction GetTransaction(long trId)
        {
            using (var dbc = new ExpManagerDbContext())
            {
                 return dbc.Transactions.FirstOrDefault(t => t.Id == trId);
            }
        }

        public List<Transaction> GetAllUserTransactions(long userId)
        {
            using (var dbc = new ExpManagerDbContext())
            {
                return dbc.Transactions
                    .Where(t => t.UserId == userId)
                    .OrderByDescending(t => t.Id)     
                    .ToList();
            }
        }

        public async Task UpdateTransactionAsync(Transaction updatedTransaction)
        {
            using (var dbc = new ExpManagerDbContext())
            {
                var transactionToUpdate = dbc.Transactions
                    .First(t => t.Id == updatedTransaction.Id);

                transactionToUpdate.Name = updatedTransaction.Name;                
                transactionToUpdate.Amount = updatedTransaction.Amount;
                transactionToUpdate.Category = updatedTransaction.Category;
                transactionToUpdate.Date = updatedTransaction.Date;

                await dbc.SaveChangesAsync();
            }
        }
    }
}
