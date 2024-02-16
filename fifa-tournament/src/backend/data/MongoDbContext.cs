using MongoDB.Driver;

public class MongoDbContext
{
    private readonly IMongoDatabase _database;

    public MongoDbContext(IConfiguration configuration)
    {
        var connectionString = configuration.GetSection("MongoDB:ConnectionString").Value;
        var databaseName = configuration.GetSection("MongoDB:DatabaseName").Value;
        var client = new MongoClient(connectionString);
        _database = client.GetDatabase(databaseName);
    }

    public IMongoCollection<Player> Players => _database.GetCollection<Player>("player");
    public IMongoCollection<Match> Matches => _database.GetCollection<Match>("match");
    public IMongoCollection<Tournament> Tournament => _database.GetCollection<Tournament>("tournament");
}
