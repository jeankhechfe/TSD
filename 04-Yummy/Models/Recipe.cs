using System;
using System.ComponentModel.DataAnnotations;

namespace Yummy.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Time { get; set; }

        [Range(1, 5)]
        public int Difficulty { get; set; }
        public int Number_of_likes { get; set; }

        [Required]
        public string Ingredients { get; set; }
        public string Process { get; set; }
        public string Tips_and_tricks{ get; set; }
    }
}