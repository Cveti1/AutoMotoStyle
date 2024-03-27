using AutoMotoStyle.Core.Models.Car;
using System;
using System.Collections.Generic;

using AutoMotoStyle.Core.Models.Service;

namespace AutoMotoStyle.Core.Contracts
{
	public interface IServiceModel
	{
		Task<IEnumerable<ServiceFormModel>>All();
		
	}

	
}
