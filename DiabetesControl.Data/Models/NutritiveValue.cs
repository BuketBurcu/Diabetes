﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiabetesControl.Data.Models
{
    //Besin Değerleri
    public class NutritiveValue
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string CarbohdrateValue { get; set; }
        public string ProteinValue { get; set; }
        public string FatValue { get; set; }
        public Food Foods { get; set; }
    }
}