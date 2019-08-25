using MongoDB.Driver;
using ServerApi.Models;

namespace ServerApi.Services
{
    public interface IAccountService
    {
        User GetUser(string username);
    }
    public class AccountService : IAccountService
    {
        private IMongoCollection<User> _Users;
        public AccountService(IRecordDatabaseSettings settings) 
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _Users = database.GetCollection<User>(settings.UsersCollectionName);
        }

        public User GetUser(string username) 
        {
            return _Users.Find<User>(x => x.Username.Equals(username)).FirstOrDefault();
        }
    }
    
}