using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoMotoStyle.Infrastructure.Data
{
    public class DataConstants
    {
        //Category
        public const int MaxType = 35;
        public const int MinType = 4;

        // Car
        public const int MaxBrand = 50;
        public const int MinBrand= 5;

        public const int MaxModel = 50;
        public const int MinModel = 5;

        public const int MaxDescription = 500;
        public const int MinDescription = 50;

        public const int MaxImageUrl = 200;


        // User
        public const int MaxUserFirstName = 15;
        public const int MinUserFirstName = 3;

        public const int MaxUserLastName = 15;
        public const int MinUserLastName = 3;
        

        // Dealer
        public const int MaxDealerName = 20;

        public const int MaxPhone = 15;


        //Fuel
        public const int MaxFuel = 15;
        public const int MinFuel = 3;
    }
}
