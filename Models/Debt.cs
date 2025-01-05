using System;
using System.Collections.Generic;
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
        public string Description { get; set; }
        public string Tag { get; set; }


    }
}
