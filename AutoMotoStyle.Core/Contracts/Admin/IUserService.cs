using AutoMotoStyle.Core.Models.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMotoStyle.Core.Contracts.Admin
{
    public interface IUserService
    {
       // Task<string> UserFullName(string userId);

        Task<IEnumerable<UserServiceModel>> All();

       // Task<bool> Forget(string userId);
    }
}
