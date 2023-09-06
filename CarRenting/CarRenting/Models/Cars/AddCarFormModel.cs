using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static CarRenting.Data.Models.DataConstants;

namespace CarRenting.Models.Cars
{
    public class AddCarFormModel
    {
        [Required]
        [StringLength(brandMaxlength, MinimumLength = brandMinlength)]
        public string Brand { get; init; }

        [Required]
        [StringLength(modelMaxlength, MinimumLength = modelMinlength)]
        public string Model { get; init; }

        [Required]
        [StringLength(
            int.MaxValue,
            MinimumLength = descriptionMinlength,
            ErrorMessage ="The field Description must be a string with a minimum length of {2}")]
        public string Description { get; init; }

        [Display(Name = "Image URL")]
        [Url]
        public string ImageUrl { get; init; }

        [Range(yearMinValue, yearMaxValue)]
        public int Year { get; init; }

        [Display(Name = "Category")]
        public int CategoryId { get; init; }

        public IEnumerable<CarCategoryViewModel> Categoris { get; set; }
    }
}
