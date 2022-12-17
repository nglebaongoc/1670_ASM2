﻿using System.ComponentModel.DataAnnotations;

namespace Asm2.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Category { get; set; }
        [Required]
        public int? Quatity { get; set; }
        [Required]
        public DateTime Year { get; set; }
        [Required]
        public double Price { get; set; }

        public string? ImageUrl { get; set; }
    }
}
