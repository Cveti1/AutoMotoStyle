using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMotoStyle.Core.Contracts
{
    public interface IDealerService
    {
        Task<bool> ExistsById(string userId);

      
        Task<bool> UserHasRents(string userId);

        Task Create(string userId, string dealerName, string phoneNumber);

        Task<int> GetDealerId(string userId);

    }
}
