using MongoDB.Driver;

namespace StrikeBuilderMVC.Data
{
    public class MongoDbContext
    {
        private readonly IMongoClient _mongoClient;
        

        public MongoDbContext(IMongoClient MongoClient) 
        {
            _mongoClient = MongoClient;
        }

        //public IMonogoCollection<T> MyEntities => 
    }
}
