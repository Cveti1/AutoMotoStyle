using AutoMotoStyle.Core.Models.Dealer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMotoStyle.Core.Models.Car
{
    public class CarDetailsModel : CarServiceModel
    {
         public string Type { get; set; } = null!;
         public string Fuel { get; set; } = null!;
         public string Transmission { get; set; } = null!;

        public DealerServiceModel Dealer { get; set; }
    }
}
