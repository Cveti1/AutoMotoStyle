using AutoMotoStyle.Core.Models.Car;
using AutoMotoStyle.Core.Models.Service;

namespace AutoMotoStyle.Core.Contracts
{
	public interface IServiceModel
	{
		Task<IEnumerable<ServiceFormModel>>AllServices();

        Task<ServiceFormModel> ServiceDetailsById(int id);

    }

	
}
