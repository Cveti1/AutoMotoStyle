using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using static AutoMotoStyle.Infrastructure.Data.DataConstants;
using Microsoft.AspNetCore.Rewrite;

namespace AutoMotoStyle.Infrastructure.Data.Models
{
    public class Dealer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(MaxDealerName)]
        public string DealerName { get; set; } = null!;

        [Required]
        [StringLength(MaxPhone)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
    }
}
