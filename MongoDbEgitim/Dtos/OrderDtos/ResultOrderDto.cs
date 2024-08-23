using MongoDbEgitim.Entities;

namespace MongoDbEgitim.Dtos.OrderDtos
{
    public class ResultOrderDto
    {
        public string OrderId { get; set; }
        public int OrderProductStock { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Status { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
