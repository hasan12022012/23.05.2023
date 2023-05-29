﻿using System.ComponentModel.DataAnnotations;

namespace P138Allup.Models
{
    public class Slider : BaseEntity
    {
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(255)]
        public string SubTitle { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [StringLength(255)]
        public string Link { get; set; }
    }
}
