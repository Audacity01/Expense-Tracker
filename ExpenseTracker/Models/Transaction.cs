namespace ExpenseTracker.Models
{
    public class Transaction
    {
        public Guid TransactionId { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public int Amount { get; set; } 
        public string? Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
