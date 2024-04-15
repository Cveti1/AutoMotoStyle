using AutoMotoStyle.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AutoMotoStyle.Infrastructure.Data.Configuration
{
   public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<IdentityUser> CreateUsers()
        {

            //Seed Dealer
            var users = new List<IdentityUser>();

            var hasher = new PasswordHasher<IdentityUser>();

            var user = new IdentityUser()
            {
                Id = "dealer-7-4421-47c0-a9ba-38b9a5ddb357",
                UserName = "dealer@mail.com",
                NormalizedUserName = "dealer@mail.com",
                Email = "dealer@mail.com",
                NormalizedEmail = "dealer@mail.com"
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "dealer123");

            users.Add(user);
            

            //Seed Dealer2

            user = new IdentityUser()
            {
                Id = "dealer-2-1234-47c0-a9ba-38b9a5ddb123",
                UserName = "dealer_2@mail.com",
                NormalizedUserName = "dealer_2@mail.com",
                Email = "dealer_2@mail.com",
                NormalizedEmail = "dealer_2@mail.com"
            };

            user.PasswordHash =
                hasher.HashPassword(user, "dealer456");

            users.Add(user);

            //Seed Guest

            
            user = new IdentityUser()
            {
                Id = "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };

            user.PasswordHash =
            hasher.HashPassword(user, "guest123");

            users.Add(user);

            return users;
        }

    }
}
