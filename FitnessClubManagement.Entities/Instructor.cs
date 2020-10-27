using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitnessClubManagement.Entities
{
    public class Instructor
    {
        [Key]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string InstructorId { get; set; }
        public string Profession { get; set; }
        public string Competition { get; set; }
        [Display(Name = "Top Placing")]
        public string TopPlacing { get; set; }
        public string About { get; set; }
        [Display(Name = "Suggested WorkOut")]
        public string SuggestedWorkOut { get; set; }
    }
}
