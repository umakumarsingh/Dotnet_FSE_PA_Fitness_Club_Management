using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitnessClubManagement.BusinessLayer.ViewModels
{
    public class ToolsViewModel
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
