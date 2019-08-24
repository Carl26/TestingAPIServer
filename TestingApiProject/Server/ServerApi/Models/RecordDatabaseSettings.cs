namespace ServerApi.Models
{
    public interface IRecordDatabaseSettings
    {
        string UsersCollectionName { get; set; }
        string DetailsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }

    public class RecordDatabaseSettings : IRecordDatabaseSettings
    {
        public string UsersCollectionName { get; set; }
        public string DetailsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}