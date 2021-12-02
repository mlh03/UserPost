using System;
using System.ComponentModel.DataAnnotations;

namespace UserPost.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
