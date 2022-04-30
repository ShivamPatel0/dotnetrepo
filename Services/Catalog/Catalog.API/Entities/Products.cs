using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.API.Entities
{
    public class Products
    {
        [BsonId] 
        public string Id { get; set; }
    }
}
