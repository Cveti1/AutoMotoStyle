using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoMotoStyle.Infrastructure.Data
{
    public class DataConstants
    {
        //Type
        public const int MaxType = 35;

        //Fuel
        public const int MaxFuel = 15;

        // Car
        public const int MaxBrand = 50;
        public const int MinBrand= 4;

        public const int MaxModel = 50;
        public const int MinModel = 4;

        public const int MaxDescription = 500;
        public const int MinDescription = 50;

        public const int MaxImageUrl = 1000;


        // Service
        public const int MaxServiceName = 50;

        public const int MaxServiceDescription = 500;
        public const int MaxServiceImageUrl = 1000;


        // User
		public const int MaxUserFirstName = 15;
        public const int MinUserFirstName = 3;

        public const int MaxUserLastName = 15;
        public const int MinUserLastName = 3;
        

        // Dealer
        public const int MaxDealerName = 20;
        public const int MinDealerName = 3;

        public const int MaxPhone = 15;
        public const int MinPhone = 8;


       
    }
}
