using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiabetesControl.Data.Models
{
    public class NutritionalMeasure
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string MeasureAverage { get; set; }
        public string Quantity { get; set; }
        public Food Foods { get; set; }
    }
}
