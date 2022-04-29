using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ExpManagerDAL.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }

            
        [Required]
        [StringLength(100)]
        public string Username { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        public decimal Balance { get; set; }

        public virtual ObservableCollection<Transaction> Transactions { get; set; }
    }
}
