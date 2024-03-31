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
					Description = "We offer a professional manual car wash service, often provided by someone in a mobile unit who can come to your home or workplace. They use professional products and can offer a high quality service.",
					ImageUrl = "https://imgrabo.com/pics/deals/15898130566073.jpg"
				},
				new Service()
				{
					Id = 2,
					Name = "Car repair and service",
                    Description = "General repair, engine rebuilding or reconditioning of motor vehicles collision service such as body, frame and fender straightening and repair and painting of motor vehicles and more... Just tell us what you need...!",
                    ImageUrl = "https://www.totalcardiagnostics.com/learn/wp-content/uploads/2015/10/car-repair-770x269.jpg"
				},
				new Service()
				{
					Id = 3,
					Name = "Annual technical inspection",
                    Description = "All condition of the car or bus. Identification of the vehicle - registration numbers and documentation. Measurement of the braking system; status of brakes, parking brake and ABS. Condition of steering. Operation of all lights - lights, headlights, turn signals, gauges. Condition of electrical equipment - battery. Condition of tires, axles and suspension. Harmful effects - noise emissions exhaust. Car equipment - first aid kit, fire extinguisher, triangle, belts etc.",
                    ImageUrl = "https://www.netsuite.com/portal/assets/img/business-articles/accounting-software/social-quarterly-annual-business-reviews.jpg"
				},
				new Service()
				{
					Id = 4,
					Name = "Тuning",
                    Description = "Tuning of motorcycles, cars and other vehicles, means reworking and changing according to the owner's personal preferences. Mainly this can refer to optical and technical changes.\r\nTuning cars and other vehicles is fine-tuning the engine, aerodynamics or suspension to improve performance, exterior and interior aesthetics, and acoustics.",
                    ImageUrl = "https://www.gtplanet.net/wp-content/uploads/2022/10/image-6-11.jpg"
				}
            };

			return services;
		}
	}
}

