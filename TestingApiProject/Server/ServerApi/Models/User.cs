using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ServerApi.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }

        public string Username { get; set; }
    }
}