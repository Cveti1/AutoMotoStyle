using AutoMotoStyle.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static AutoMotoStyle.Infrastructure.Data.DataConstants;


namespace AutoMotoStyle.Core.Models.Car
{
    public class CarModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(MaxBrand, MinimumLength = MinBrand)]
        public string Brand { get; set; } = null!;

        [Required]
        [StringLength(MaxModel, MinimumLength = MinModel)]
        public string Model { get; set; } = null!;

        [Required]
        public int Year { get; set; }

        [Required]
        [StringLength(MaxDescription, MinimumLength = MinDescription)]
        public string Description { get; set; } = null!;


        [Display(Name ="Fuel")]
        public int FuelId { get; set; }

        [Display(Name = "Type")]
        public int TypeId { get; set; }


        [Display(Name = "Transmission")]
        public int TransmissionId { get; set; }

        [Required]
        [StringLength(MaxImageUrl)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Display(Name = "Price")]
       // [Range(0.00, 100000.00, ErrorMessage = "The price must be a positive number and less than {2} euro")]
        public decimal Price { get; set; }

        public IEnumerable<CarTypeModel> CarTypes { get; set; } = new List<CarTypeModel>();
        public IEnumerable<CarTransmissionModel> CarTransmissions { get; set; } = new List<CarTransmissionModel>();
        public IEnumerable<CarFuelModel> CarFuels { get; set; } = new List<CarFuelModel>();

    }
}
