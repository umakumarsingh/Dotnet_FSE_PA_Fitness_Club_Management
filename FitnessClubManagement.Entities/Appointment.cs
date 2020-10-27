using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace FitnessClubManagement.Entities
{
    public class Appointment
    {
        [Key]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string AppointmentId { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Current Weight")]
        public int CurrentWeight { get; set; }
        public float Height { get; set; }
        public int Age { get; set; }
        [Display(Name = "Goal Weight")]
        public int GoalWeight { get; set; }
        public string Address { get; set; }
        [Display(Name = "Phone")]
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Remark { get; set; }
    }
}
