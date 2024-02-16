using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Tournament
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string id { get; set; }
    public string name { get; set; }
}
