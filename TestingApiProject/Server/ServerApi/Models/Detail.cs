using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ServerApi.Models
{
    public class Detail
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        public int UserId { get; set; }

        [BsonElement("RecordTime")]
        public string Time { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        internal List<Detail> ToList()
        {
            var converted =  new List<Detail>();
            converted.Add(this);
            return converted;
        }
    }
}