using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMotoStyle.Core.Models.Car
{
    public class CarServiceModel
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
