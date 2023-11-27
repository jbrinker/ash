using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASH.DataAccess
{
    public class Expenses
    {
        public int ExpensesID { get; set; }

        public decimal MaxExpenseAmount { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
