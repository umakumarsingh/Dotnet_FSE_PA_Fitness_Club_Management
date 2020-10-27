using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitnessClubManagement.BusinessLayer.ViewModels
{
    public class InstructorViewModel
    {
        [Required]
        public string Profession { get; set; }
        public string Competition { get; set; }
        [Display(Name = "Top Placing")]
        public string TopPlacing { get; set; }
        public string About { get; set; }
        [Display(Name = "Suggested WorkOut")]
        public string SuggestedWorkOut { get; set; }
    }
}
