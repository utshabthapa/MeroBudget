using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeroBudget.Models
{
    public class Debt
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Link debt to a user
        public decimal Amount { get; set; } // New Debt Amount (Total debt)
        public decimal PaidAmount { get; set; } // Debt Paid Amount
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Tags are required")]
        public string Tag { get; set; }

        public string Status { get; set; }



    }
}
