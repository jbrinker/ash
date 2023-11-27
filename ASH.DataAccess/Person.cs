using System.ComponentModel.DataAnnotations;

namespace ASH.DataAccess
{
    public class Person
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty; 

        public string Address1 { get; set; } = string.Empty;

        public ExemptPay? ExemptPay { get; set; }

        public NonExemptPay? NonExemptPay { get; set; }

        public Expenses? Expenses { get; set; }
    }
}
