using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;
using MongoDB.Bson;

namespace dotnetwithmongo.Entities
{
    [BsonIgnoreExtraElements]
    public class Payment
    {
#nullable disable
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("paymentMethodName")]
        public string PaymentMethodName { get; set; }

        [BsonElement("comment")]
        public string Comment { get; set; }
    }
}
