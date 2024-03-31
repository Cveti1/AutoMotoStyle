using AutoMotoStyle.Core.Contracts;
using AutoMotoStyle.Core.Models.Car;
using AutoMotoStyle.Core.Models.Dealer;
using AutoMotoStyle.Core.Models.Service;
using AutoMotoStyle.Infrastructure.Data.Common;
using AutoMotoStyle.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AutoMotoStyle.Core.Services
{
	public class ServiceModel : IServiceModel
	{

        private readonly IRepository repo;

        public ServiceModel(IRepository _repo)
        {
            repo = _repo;
        }
        public async  Task<IEnumerable<ServiceFormModel>> AllServices()
		{
            return await repo.AllReadonly<Service>()
                .OrderByDescending(s => s.Id)
                .Select(s => new ServiceFormModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    ImageUrl = s.ImageUrl
                })
                .ToListAsync();
        }

        public async Task<ServiceFormModel> ServiceDetailsById(int id)
        {
            
            return await repo.AllReadonly<Service>()
                .Where(s => s.Id == id)
                .Select(s => new ServiceFormModel()
                {
                    Id = id,
                    Name = s.Name,
                    Description = s.Description,
                    ImageUrl = s.ImageUrl
                })
                .FirstAsync();

        }

      }
}



