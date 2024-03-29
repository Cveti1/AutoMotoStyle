﻿using AutoMotoStyle.Core.Contracts;
using System.ComponentModel.DataAnnotations;

namespace AutoMotoStyle.Core.Models.Car
{
    public class CarServiceModel :ICarModel
    {
        public int Id { get; init; }

        public string Brand { get; init; } = null!;
        public string Model { get; init; } = null!;
        public string Description { get; init; } = null!;
        public int Year { get; init; }  

        [Display(Name = "Image URL")]
        public string ImageUrl { get; init; } = null!;

        [Display(Name = "Price")]
        public decimal Price { get; init; }

        [Display(Name = "Is Rented")]
        public bool IsRented { get; init; }
    }
}
