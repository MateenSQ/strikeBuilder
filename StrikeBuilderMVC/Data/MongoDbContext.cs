using MongoDB.Bson;
using MongoDB.Driver;
using StrikeBuilderMVC.Models;

namespace StrikeBuilderMVC.Data
{
    public class MongoDbContext
    {
        private readonly IMongoClient _mongoClient;
        private readonly IMongoDatabase _planetDatabase;
        

        public MongoDbContext(IMongoClient MongoClient) 
        {
            _mongoClient = MongoClient;
            _planetDatabase = _mongoClient.GetDatabase("sample_guides");
        }

        public IMongoCollection<Planets> PlanetsCollection => _planetDatabase.GetCollection<Planets>("planets");
    }
}
