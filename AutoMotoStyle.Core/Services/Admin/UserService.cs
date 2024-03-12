using AutoMotoStyle.Core.Contracts.Admin;
using AutoMotoStyle.Core.Models.Admin;
using AutoMotoStyle.Infrastructure.Data.Common;
using AutoMotoStyle.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AutoMotoStyle.Core.Services.Admin
{
    public class UserService : IUserService
    {
        private readonly IRepository repo;

        public UserService(IRepository _repo)
        {
            repo = _repo; 
        }
        public async Task<IEnumerable<UserServiceModel>> All()
        {
            List<UserServiceModel> result;

            result = await repo.AllReadonly<Dealer>()
               // .Where(a => a.User.IsActive)
                .Select(a => new UserServiceModel()
                {
                    UserId = a.UserId,
                    Email = a.User.Email,
                    FullName = a.DealerName,
                   // FullName = $"{a.User.FirstName} {a.User.LastName}",
                    PhoneNumber = a.PhoneNumber
                })
                .ToListAsync();

            string[] dealerIds = result.Select(a => a.UserId).ToArray();

            result.AddRange(await repo.AllReadonly<IdentityUser>()
                .Where(u => dealerIds.Contains(u.Id) == false)
                //.Where(u => u.IsActive)
                .Select(u => new UserServiceModel()
                {
                    UserId = u.Id,
                    Email = u.Email,
                    FullName = u.UserName
                }).ToListAsync());

            return result;
        }

      //  public async Task<string> UserFullName(string userId)
       // {
          //  var user = await repo.GetByIdAsync<ApplicationUser>(userId);

         //   return $"{user?.FirstName} {user?.LastName}".Trim();
       // }
    }
}
