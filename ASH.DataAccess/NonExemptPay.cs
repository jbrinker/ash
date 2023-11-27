namespace ASH.DataAccess
{
    public class NonExemptPay
    {
        public int NonExemptPayID { get; set; }
        public decimal PayPerHour { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
