namespace FBA_UserAPI.Models
{
    public class Transaction
    {
        public int id { get; set; }
        public User? User { get; set; }
        public DateTime? DateTime { get; set; }
        public decimal Amount { get; set; }
        public bool IsIncome { get; set; }

        public Transaction() { }
    }
}
