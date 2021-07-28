using DiabetesControl.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DiabetesControl.Data.Models
{
    public class Food
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public NutritiveGroupEnum NutritiveGroup { get; set; }
        [Required]
        [ForeignKey("NutritiveValueId")]
        public int NutritiveValueId { get; set; }
        [Required]
        [ForeignKey("NutritionalMeasureId")]
        public int NutritionalMeasureId { get; set; }
        public NutritionalMeasure NutritionalMeasure { get; set; }
        public NutritiveValue NutritiveValue { get; set; }
    }
}