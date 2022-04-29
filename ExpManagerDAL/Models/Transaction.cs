using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpManagerDAL.Models
{
    public class Transaction
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public DateTime Date { get; set; }


        [ForeignKey("UserId")]
        public long UserId { get; set; }
        public virtual User User { get; set; }
    }
}
