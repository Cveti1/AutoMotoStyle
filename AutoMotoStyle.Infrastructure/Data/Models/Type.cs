using System.ComponentModel.DataAnnotations;
using static AutoMotoStyle.Infrastructure.Data.DataConstants;

namespace AutoMotoStyle.Infrastructure.Data.Models
{
    public class Type
    {
        public Type()
        {
            Cars = new List<Car>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(MaxType)]
        public string TypeName { get; set; } = null!;

        public List<Car> Cars { get; set; }
    }
}
