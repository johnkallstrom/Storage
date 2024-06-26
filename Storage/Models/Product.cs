﻿namespace Storagge.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string? Name { get; set; }

        [Range(0, double.MaxValue)]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public Category Category { get; set; }

        [StringLength(5)]
        [Required]
        public string? Shelf { get; set; }

        [Range(0, double.MaxValue)]
        public int Count { get; set; }

        [StringLength(300)]
        [Required]
        public string? Description { get; set; }
    }
}
