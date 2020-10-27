using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitnessClubManagement.Entities
{
    public class ContactUs
    {
        [Key]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ContactId { get; set; }
        public string FullName { get; set; }
        public double Phone { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime DateofMessage { get; set; }
    }
}
