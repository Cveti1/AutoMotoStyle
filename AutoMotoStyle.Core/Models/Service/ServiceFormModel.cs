using System.ComponentModel.DataAnnotations;
using static AutoMotoStyle.Infrastructure.Data.DataConstants;

namespace AutoMotoStyle.Core.Models.Service
{
	public class ServiceFormModel 
	{
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		public string Description { get; set; } = null!;

		public string ImageUrl { get; set; } = null!;




		

	
		
	}
}
