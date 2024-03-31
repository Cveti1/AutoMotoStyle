using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static AutoMotoStyle.Infrastructure.Data.DataConstants;


namespace AutoMotoStyle.Infrastructure.Data.Models
{
	public class Service
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(MaxServiceName)]
		public string Name { get; set; } = null!;

        [Required]
        [StringLength(MaxServiceDescription)]
        public string Description { get; set; } = null!;

        [Required]
		[StringLength(MaxServiceImageUrl)]
		public string ImageUrl { get; set; } = null!;


	}
}
