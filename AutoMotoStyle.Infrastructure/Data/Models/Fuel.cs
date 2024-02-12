using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutoMotoStyle.Infrastructure.Data.DataConstants;

namespace AutoMotoStyle.Infrastructure.Data.Models
{
    public class Fuel
    {

        public Fuel()
        {
            Cars = new List<Car>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(MaxFuel)]
        public string FuelName { get; set; } = null!;

        public List<Car> Cars { get; set; }

    }
}
