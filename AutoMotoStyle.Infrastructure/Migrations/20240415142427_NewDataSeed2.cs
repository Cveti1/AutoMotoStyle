using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoMotoStyle.Infrastructure.Migrations
{
    public partial class NewDataSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-7-4421-47c0-a9ba-38b9a5ddb357",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42250d4a-eab8-44c9-a3b1-ef86ffa15cf6", "AQAAAAEAACcQAAAAEEnvNPqB8PsZTCDHX0UmsnxN+jg6Sq5v65haN9KVHsl7DDxVQ9iHDJAAXIY0ZPaEGA==", "979e480f-9d0c-4836-aec8-c4ef365c9b42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3d5fdb2-6357-44b7-9af3-8acfd5d3115e", "AQAAAAEAACcQAAAAEIgFt5RIrHkoYugtQqpVT6yoxIVZmoruVmSxgtwDhHveXcbrj6mNYquYs4DUL2YR1g==", "711ee94a-bbf4-4b34-ae5e-8726753d860e" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "The Toyota Land Cruiser SUV is a high-performance vehicle. It comes with a turbocharged 2.4-liter four-cylinder engine. The power plant makes 326 horsepower and 465 pound-feet of torque compared to the 381 hp and 401 lb-ft from the old V8. And it can tow up to 6,000 pounds.");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "DealerId", "Description", "FuelId", "ImageUrl", "IsActive", "Model", "Price", "RenterId", "TransmissionId", "TypeId", "Year" },
                values: new object[,]
                {
                    { 7, "KAWASAKI", 1, "Futuristic appearance, excellent optics, digital instrument panel, adjustable suspension, sliding clutch - all this works as a single organism, at the heart of which is a 1043-cc engine with an impeccable reputation. 142 horsepower and a maximum speed of 249 km/h.", 3, "https://synergosmoto.com/uploaded/KWkFm67eFd.jpg", true, "Z1000", 1700.00m, null, 3, 4, 2021 },
                    { 8, "HYUNDAI", 1, "The 2023 Tucson Plug-in Hybrid is a powerful, efficient, and practical crossover. The 261-hp Plug-in's extra power—74 horsepower suits its personality well. It behaves well in the curves, and the electric torque provides plenty of oomph off the line.", 3, "https://www.motortrend.com/uploads/2022/08/2023-Hyundai-Tucson-PHEV-Front-Three-Quarter.jpg", true, "TUCSON", 2700.00m, null, 1, 3, 2023 },
                    { 9, "VOLKSWAGEN", 1, "Gasoline engine of the TSI series with a volume of 2.0 liters, power of 150 and 204 hp. It combines two technologies: direct injection and turbocharging. Fuel consumption is about 15 liters per 100 km. Length - 4904 mm, height - 1990 mm. The total number of seats when transporting people is 5 or 6 passengers.", 1, "https://parkers-images.bauersecure.com/wp-images/19429/12-vw-transporter-2003.jpg", true, "TRANSPORTER", 1600.00m, null, 1, 2, 2010 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-7-4421-47c0-a9ba-38b9a5ddb357",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebae6780-e527-46ec-a8ae-e6de9e72f7ea", "AQAAAAEAACcQAAAAECFW/CwtRc0lKZXfwasuXIlS+1P+VqB9FNtAmfkine1uvRn5uOxzfpsQmp2DofycsA==", "f355f6b6-57ed-4a76-a6b2-e82fb8faf729" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "272a4dc9-a2b8-4511-b1ab-add782a43cc4", "AQAAAAEAACcQAAAAELUoFOZzRc/c/iMrw89QOmdklC7hC4jwW6CEdqC40qAcv7dd4w1DLvNqwLGuTI74bQ==", "04ae1a9f-369a-499a-b981-246b2f24f38e" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "The Toyota Land Cruiser SUV is a high-performance vehicle. It comes with a turbocharged 2.4-liter four-cylinder engine. The powerplant makes 326 horsepower and 465 pound-feet of torque compared to the 381 hp and 401 lb-ft from the old V8. And it can tow up to 6,000 pounds.");
        }
    }
}
