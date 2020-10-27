using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitnessClubManagement.Entities
{
    public class Tools
    {
        [Key]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ToolsId { get; set; }
        [Display(Name = "Tools Name")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
