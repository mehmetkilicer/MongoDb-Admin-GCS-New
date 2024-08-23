using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDbEgitim.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? ProductId { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? SavedUrl { get; set; }
        public string? SavedFileName { get; set; }
        public bool Status { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
