using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitnessClubManagement.Entities
{
    public class MemberShipPlan
    {
        [Key]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string PlanId { get; set; }
        public string PlanName { get; set; }
        public string PlanDetails { get; set; }
        public float PlanAmount { get; set; }
        public string ValidFor { get; set; }
        public DateTime PlanStartDate { get; set; }
        public string Remark { get; set; }
    }
}
