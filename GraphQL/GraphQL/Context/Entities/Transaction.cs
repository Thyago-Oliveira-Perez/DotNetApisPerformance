namespace GraphQL.Context.Entities
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public int ProductId { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
