using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Match
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public int scoreHomeTeam { get; set; }

    public int scoreAwayTeam { get; set; }

    public string homeTeamId { get; set; }

    public string awayTeamId { get; set; }

    public string winnerId { get; set; }
}
