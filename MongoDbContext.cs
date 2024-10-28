using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using DietPlannerAPI.Recipes;

namespace DietPlannerAPI
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IConfiguration configuration)
        {
            var connectionString = configuration["MongoDB:ConnectionString"];
            var databaseName = configuration["MongoDB:DatabaseName"];
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<Recipe> Recipes => _database.GetCollection<Recipe>("Recipes");
        // Add more collections here as needed
    }
}
