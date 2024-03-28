namespace ExpenseTracker.Models
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public string Title { get; set; }
        public string Type { get; set; } = "Expense";
    }
}
