namespace MongoDbEgitim.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public IFormFile? ImageUrl { get; set; }
        public string? SavedUrl { get; set; }
        public string? SavedFileName { get; set; }
        public bool Status { get; set; }
        public string CategoryId { get; set; }
    }
}
