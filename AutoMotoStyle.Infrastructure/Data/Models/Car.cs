using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using static AutoMotoStyle.Infrastructure.Data.DataConstants;

namespace AutoMotoStyle.Infrastructure.Data.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(MaxBrand)]
        public string Brand { get; set; } = null!;

        [Required]
        [StringLength(MaxModel)]
        public string Model { get; set; } = null!;

        [Required]        
        public int Year { get; set; }

        [Required]
        public int FuelId { get; set; }


        [ForeignKey(nameof(FuelId))]
        [Required]
        public Fuel Fuel { get; set; } = null!;
        

        [Required]
        [StringLength(MaxDescription)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(MaxImageUrl)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        // [Column(TypeName = "money")]
        [Precision(18, 2)]
        public decimal Price { get; set; }

        [Required]
        public int TypeId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public Type Type { get; set; } = null!;

        [Required]
        public int DealerId { get; set; }

        [ForeignKey(nameof(DealerId))]
        public Dealer Dealer { get; set; } = null!;

        public string? RenterId { get; set; }

         [ForeignKey(nameof(RenterId))]
         public IdentityUser? Renter { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
