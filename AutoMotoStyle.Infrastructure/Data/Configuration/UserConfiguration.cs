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

            
            var users = new List<IdentityUser>();
            var hasher = new PasswordHasher<IdentityUser>();


            //Create Dealer1 as user
            var dealer1 = new IdentityUser()
            {
                Id = "dealer-7-4421-47c0-a9ba-38b9a5ddb357",
                UserName = "dealer@mail.com",
                NormalizedUserName = "dealer@mail.com",
                Email = "dealer@mail.com",
                NormalizedEmail = "dealer@mail.com"
            };

            dealer1.PasswordHash =
                 hasher.HashPassword(dealer1, "dealer123");

            users.Add(dealer1);
            


            //Create Dealer2 as user
           var dealer2 = new IdentityUser()
            {
                Id = "dealer-2-1234-47c0-a9ba-38b9a5ddb123",
                UserName = "dealer_2@mail.com",
                NormalizedUserName = "dealer_2@mail.com",
                Email = "dealer_2@mail.com",
                NormalizedEmail = "dealer_2@mail.com"
            };

            dealer2.PasswordHash =
                hasher.HashPassword(dealer2, "dealer456");

            users.Add(dealer2);



            //Create Guest as user     
            var dealer3 = new IdentityUser()
            {
                Id = "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };

            dealer3.PasswordHash =
            hasher.HashPassword(dealer3, "guest123");

            users.Add(dealer3);



            //Create Administrator as user
            var admin = new IdentityUser()
            {
                Id = "admin-a5-7a9a-4ba7-8768-66ba10cd0123",
                UserName = "admin@automotostyle.com",
                NormalizedUserName = "admin@automotostyle.com",
                Email = "admin@automotostyle.com",
                NormalizedEmail = "admin@automotostyle.com"
            };

            admin.PasswordHash =
            hasher.HashPassword(admin, "admin123");

            users.Add(admin);




            return users;
        }

    }
}
