using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MeroBudget.Models
{
    public class AppData
    {
        public List<User> Users { get; set; } = new();
        public List<Debt> Debt { get; set; } = new();
        public List<Transactions> Transactions { get; set; } = new();
    }

}
