using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitnessClubManagement.BusinessLayer.ViewModels
{
    public class DietPlanViewModel
    {
        [Required]
        public string Name { get; set; }
        public string PlanOverview { get; set; }
        public string Description { get; set; }
        public string History { get; set; }
        [Display(Name = "Meal Timing / Frequency")]
        public string MealTimingFrequency { get; set; }
        [Display(Name = "Restrictions / Limitations")]
        public string RestrictionsLimitations { get; set; }
        public string Phases { get; set; }
        public string BestSuitedFor { get; set; }
        [Display(Name = "How Easy Is It to Follow")]
        public string HowToFollow { get; set; }
        public string Conclusion { get; set; }
    }
}
