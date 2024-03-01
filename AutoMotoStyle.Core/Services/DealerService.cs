using AutoMotoStyle.Core.Contracts;
using AutoMotoStyle.Infrastructure.Data.Common;
using AutoMotoStyle.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMotoStyle.Core.Services
{
    public class DealerService : IDealerService
    {
        private readonly IRepository repo;

        public DealerService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task Create(string userId, string dealerName, string phoneNumber)
        {
            var dealer = new Dealer()
            {
                UserId = userId,
                DealerName= dealerName,
                PhoneNumber = phoneNumber
            };

            await repo.AddAsync(dealer);
            await repo.SaveChangesAsync();
        }

        public async Task<bool> ExistsById(string userId)
        {
            return await repo.All<Dealer>()
               .AnyAsync(d => d.UserId == userId);
        }

        public async Task<int> GetDealerId(string userId)
        {
            return (await repo.AllReadonly<Dealer>()
               .FirstOrDefaultAsync(d => d.UserId == userId))?.Id ?? 0;
        }

        public async Task<bool> UserHasRents(string userId)
        {
            return await repo.All<Car>()
               .AnyAsync(c => c.RenterId == userId);
        }
    }
}
