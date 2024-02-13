using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMotoStyle.Infrastructure.Data.Models
{
    public class Transmission
    {
        public Transmission()
        {
            Cars = new List<Car>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public List<Car> Cars { get; set; }

    }
}
