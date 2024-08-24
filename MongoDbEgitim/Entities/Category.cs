using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbEgitim.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; }
    }
}
