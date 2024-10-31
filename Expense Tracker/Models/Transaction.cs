using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TrabsactionId { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } 

        public int amount { get; set; }

        [Column(TypeName = "navrchar(75)")]
        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

    }
}
