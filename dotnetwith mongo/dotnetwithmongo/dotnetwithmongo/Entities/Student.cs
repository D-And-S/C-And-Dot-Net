using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dotnetwithmongo.Entities
{
    [BsonIgnoreExtraElements]
    public class Student
    {
#nullable disable
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("graduated")]
        public bool IsGraduated { get; set; }

#nullable enable
        [BsonElement("courses")]
        public string[]? Courses { get; set; }

#nullable disable
        [BsonElement("gender")]
        public string Gender { get; set; }

        [BsonElement("age")]
        public int Age { get; set; }

    }
}
