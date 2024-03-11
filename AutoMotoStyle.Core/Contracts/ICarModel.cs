using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMotoStyle.Core.Contracts
{
    public interface ICarModel
    {
        public string Brand { get; }

        public string Model { get; }
    }
}
