using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace FifaTournament.Backend.Models;

public class Player
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string Name { get; set; }
}
