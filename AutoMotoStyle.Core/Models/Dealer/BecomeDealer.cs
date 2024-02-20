using System.ComponentModel.DataAnnotations;
using static AutoMotoStyle.Infrastructure.Data.DataConstants;

namespace AutoMotoStyle.Core.Models.Dealer
{
    public class BecomeDealer
    {
        [Required]
        [StringLength(MaxDealerName, MinimumLength = MinDealerName)]
        [Display(Name = "Dealer Name")]
        public string DealerName { get; set; } = null!;


        [Required]
        [StringLength(MaxPhone, MinimumLength = MinPhone)]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; } = null!;



        

 
    }
}
