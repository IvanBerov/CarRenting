namespace CarRenting.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;

    public class Car
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(brandMaxlength)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(modelMaxlength)]
        public string Model { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public int Year { get; set; }

        public int CatrgoryId { get; set; }

        public Category Category { get; init; }
    }
}
