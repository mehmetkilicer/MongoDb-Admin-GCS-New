using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDbEgitim.Entities
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CustomerId { get; set; }
        public string CustomerFullName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public List<Order> Orders { get; set; }
    }
}
