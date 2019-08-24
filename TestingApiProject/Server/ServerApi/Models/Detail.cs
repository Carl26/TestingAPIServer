using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ServerApi.Models
{
    public class Detail
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int _id { get; set; }

        public int UserId { get; set; }

        [BsonElement("RecordTime")]
        public DateTime Time { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}