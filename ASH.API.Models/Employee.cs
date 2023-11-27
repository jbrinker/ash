namespace ASH.API.Models
{
    public class Employee
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Address1 { get; set; } = string.Empty;

        public EmployeeTypes Role { get; set; }

        public decimal PaymentAmount { get; set; }

        public decimal? MaxExpenseAmount { get; set; }
    }
}
