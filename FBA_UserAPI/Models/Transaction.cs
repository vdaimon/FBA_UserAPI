namespace FBA_UserAPI.Models
{
    public class Transaction
    {
        public int id { get; set; }
        public DateTime? DateTime { get; set; }
        public decimal Amount { get; set; }
        public bool IsIncome { get; set; }
        public int UserId { get; set; }

    }
}
