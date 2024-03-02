using AutoMotoStyle.Core.Models.Car;

namespace AutoMotoStyle.Models
{
    public class AllCarsQueryModel
    {
        public const int CarsPerPage = 3;

        public string? Type { get; set; }

        public string? SearchTerm { get; set; }

        public Sorting Sorting { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int TotalCarCount { get; set; }

        public IEnumerable<string> Types { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<CarServiceModel> Cars { get; set; } = Enumerable.Empty<CarServiceModel>();
    }
}
