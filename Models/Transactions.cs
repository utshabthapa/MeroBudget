using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeroBudget.Models
{
    public class Transactions
    {
        public int Id { get; set; }
        public int UserId { get; set; }

      
        public decimal Debit { get; set; }

     
        public decimal Credit { get; set; }

        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Source/purpose is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Tags are required")]
        public string Tags { get; set; }

        public string AdditionalNotes { get; set; }

       

    }
}
