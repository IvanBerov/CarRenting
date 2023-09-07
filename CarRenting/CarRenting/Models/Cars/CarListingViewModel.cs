﻿namespace CarRenting.Models.Cars
{
    public class CarListingViewModel
    {
        public int Id { get; set; }

        public string Brand { get; init; }

        
        public string Model { get; init; }

       
        public string ImageUrl { get; init; }

        public int Year { get; init; }

        public string Category { get; init; }
    }
}
