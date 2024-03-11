using AutoMotoStyle.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMotoStyle.Core.Models.Car
{
    public class CarHomePageModel : ICarModel
    {
        public int Id { get; set; }

        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int Year { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string Description { get; set; } = null!;

    }
}
