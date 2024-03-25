using AutoMotoStyle.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace AutoMotoStyle.Infrastructure.Data.Configuration
{
	internal class ServiceConfiguration :  IEntityTypeConfiguration<Service>
	{
		public void Configure(EntityTypeBuilder<Service> builder)
		{
			builder.HasData(CreateService());
		}

		private List<Service> CreateService()
		{
			var services = new List<Service>()
			{
				new Service()
				{
					Id = 1,
					Name = "Car washing",
					ImageUrl = "https://imgrabo.com/pics/deals/15898130566073.jpg"
				},
				new Service()
				{
					Id = 2,
					Name = "Car repair and service",
					ImageUrl = "https://www.totalcardiagnostics.com/learn/wp-content/uploads/2015/10/car-repair-770x269.jpg"
				},
				new Service()
				{
					Id = 3,
					Name = "Annual technical reviews",
					ImageUrl = "https://www.netsuite.com/portal/assets/img/business-articles/accounting-software/social-quarterly-annual-business-reviews.jpg"
				},
				new Service()
				{
					Id = 4,
					Name = "Тuning",
					ImageUrl = "https://www.gtplanet.net/wp-content/uploads/2022/10/image-6-11.jpg"
				}

			};

			return services;
		}
	}
}

