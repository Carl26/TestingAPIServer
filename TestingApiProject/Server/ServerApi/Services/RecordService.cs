using System;
using System.Collections.Generic;
using System.Globalization;
using MongoDB.Driver;
using ServerApi.Models;

namespace ServerApi.Services
{
    public class RecordService
    {
        private readonly IMongoCollection<Detail> _Records;

        public RecordService(IRecordDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _Records = database.GetCollection<Detail>(settings.DetailsCollectionName);
        }

        public IList<Detail> GetRecordsByUserId(int userId) {
            return _Records.Find<Detail>(x => x.UserId == userId).ToList();
        }

        public IList<Detail> GetRecordsByTime(DateTime time, int userId) {
            return _Records.Find<Detail>(x => (x.UserId == userId 
                    && DateTime.Parse(x.Time, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal) <= time)).ToList();
        }
    }
}