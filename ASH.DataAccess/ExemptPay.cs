namespace ASH.DataAccess
{
    public class ExemptPay
    {        
        public int ExemptPayID { get; set; }
        public decimal AnnualSalary { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }

    }
}
