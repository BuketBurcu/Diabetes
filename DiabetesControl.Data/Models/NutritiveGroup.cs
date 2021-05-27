using DiabetesControl.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiabetesControl.Data.Models
{
    public class NutritiveGroup
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public NutritiveGroupEnum NutritiveGroupName { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
