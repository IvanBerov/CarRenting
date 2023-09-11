﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRenting.Models.Cars
{
    public class AllCarsQueryModel
    {
        public IEnumerable<string> Brands { get; init; }

        [Display(Name = "Search by text")]
        public string SearchTerm { get; init;}

        public CarSorting Sorting { get; init; }

        public IEnumerable<CarListingViewModel> Cars { get; init; }
    }
}
