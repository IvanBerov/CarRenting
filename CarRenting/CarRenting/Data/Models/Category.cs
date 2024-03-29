﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRenting.Data.Models
{
    using static DataConstants.Category;
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public IEnumerable<Car> Cars { get; init; } = new List<Car>();
    }
}