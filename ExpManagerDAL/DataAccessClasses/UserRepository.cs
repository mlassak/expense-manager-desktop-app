using System.Threading.Tasks;
using ExpManagerDAL.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpManagerDAL.DataAccessClasses
{
    public class UserRepository
    {
        public async Task<User> GetUserAsync(string uname)
        {
            using (var dbc = new ExpManagerDbContext())
            {
                return await dbc.Users.FirstOrDefaultAsync(u => u.Username == uname);       
            }
        }

        public async Task CreateUserAsync(User newUser)
        {
            using (var dbc = new ExpManagerDbContext())
            {
                dbc.Users.Add(newUser);       
                await dbc.SaveChangesAsync();
            }
        }

        public async Task RemoveUserAsync(User userToRemove)
        {
            using (var dbc = new ExpManagerDbContext())
            {
                dbc.Users.Remove(userToRemove);   
                await dbc.SaveChangesAsync();
            }
        }

        public async Task UpdateUserAsync(User editedUser)      
        {
            using (var dbc = new ExpManagerDbContext())
            {
                var foundUser = await dbc.Users.FirstAsync(u => u.Id == editedUser.Id);   
                foundUser.Username = editedUser.Username;
                foundUser.Password = editedUser.Password;
                foundUser.Balance = editedUser.Balance;

                await dbc.SaveChangesAsync();
            }
        }
    }
}
