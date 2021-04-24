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
        public string MilkGroup { get; set; }
        public string MeatGroup { get; set; }
        public string BreadGroup { get; set; }
        public string FatGroup { get; set; }
        public string FruitGroup { get; set; }
        public string EatGroup { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
