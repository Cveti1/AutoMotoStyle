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
       
        Task<IEnumerable<UserServiceModel>> All();

    }
}
