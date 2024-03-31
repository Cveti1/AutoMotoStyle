using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoMotoStyle.Infrastructure.Migrations
{
    public partial class DatabaseUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-7-4421-47c0-a9ba-38b9a5ddb357",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1aedb3ce-0bfd-4cc6-8973-0901c7d76bd3", "AQAAAAEAACcQAAAAEEMvM49jq8K6TLlY5ambHhLrrv3x1Lma4aXmq/f8pYJ7+1LuHD28mXCgVWiHSGRSww==", "d5d6c8a0-3b0d-41d9-ac9c-7195cf0ff25d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dab7e93-1e27-4c63-bb3f-7b31bb434214", "AQAAAAEAACcQAAAAENsaLYDZlO9QAPdghDKIuHq582skqCrV98VKc6BFMwDaQzM2q/I3q38I67zILHOong==", "ee9f8d84-709b-45bd-bc0e-5fe5952d57a5" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Engine 2.0L TFSI with a power of 223 hp, 4x4 drive. Equipment:Brown leather interior, Navigation system, Climatronic. Front seat adjustment, Front seat heating, Steering wheel adjustment, Heated mirrors, Stability control.");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "7.0L V8 E-Force Supercharged engine with 730 hp, tire size P275/35ZR18; P325/30ZR19, alloy wheels  Edelbrok - screw compressor, installed in a tuning studio in Germany, chassis number: 1G1YY26E075126150.");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Engine 2.0L TDI with a power of 190 hp. with. , aluminum rims.Chassis number: TMB1JCNP2H7544236, with registration. Equipment:Leather interior, Navigation system, Front and rear parking sensors, Heated mirrors, LED brake lights.");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "DealerId", "Description", "FuelId", "ImageUrl", "IsActive", "Model", "Price", "RenterId", "TransmissionId", "TypeId", "Year" },
                values: new object[,]
                {
                    { 4, "FIAT", 1, "It is characterized by strength and low consumption. It is articulated around a 2.3 engine\nWith a new variable geometry turbocharger, among other things, the access mechanic increases its power and torque by 10% compared to the previous 2.0. Probably the most sought after is the 140 HP...or 160, which boasts a specific engine shaft with large bearings, special pistons and a specific turbocharger.", 3, "https://www.fiatprofessional.com/content/dam/fiatprofessional/cross/news/details/Ducato-MY2020/fiatprofessional-ducato-grey-commercial-vehicle-mobile-626x386.jpg", true, "DUCATO", 2400.00m, null, 2, 2, 2020 },
                    { 5, "HONDA", 1, "Punchy maximum torque of 43.3Nm torque @ 6,000rpm combines with peak power of 34kW @ 8,500rpm. It's a power unit that strikes a great balance between physical size and flexible output. Bore and stroke is set at 67mm x 66.8mm with compression ratio of 10.7:1.", 1, "https://silesmotos.com/img/cms/Motos/HONDA/500-cmx-2023/c4%20(2).png", true, "REBEL", 1900.00m, null, 3, 4, 2023 },
                    { 6, "TOYOTA", 1, "The Toyota Land Cruiser SUV is a high-performance vehicle. It comes with a turbocharged 2.4-liter four-cylinder engine. The powerplant makes 326 horsepower and 465 pound-feet of torque compared to the 381 hp and 401 lb-ft from the old V8. And it can tow up to 6,000 pounds.", 4, "https://carnovo.com/wp-content/uploads/2023/12/toyota-land-cruiser-2024-1200x900.jpg", true, "LAND CRUISER", 2000.00m, null, 1, 3, 2024 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-7-4421-47c0-a9ba-38b9a5ddb357",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "156a1cfd-3c6e-4eb3-b6a4-c8e54f313611", "AQAAAAEAACcQAAAAEKYlIChKGhJnici1LJhvJb6CqRY3VIf8Mqckw/zlFMnA7ppJW9Gqmuj5ocGLWYi2Jw==", "9e38104c-e0b7-4d43-8d72-6b91e9233cdd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3331fead-8a73-4d38-8c37-c93a9c9de2c7", "AQAAAAEAACcQAAAAEJQylNrOeeAw7h7iGf+V1XxWCSt9qV2B3OLzKWDN+AMDxGIdTucnKTwOdhlcV9+hsQ==", "b42aff74-fa77-495d-8e08-b6cf288fa879" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Engine 2.0L TFSI with a power of 223 hp, 4x4 drive. Equipment:Brown leather interior, Navigation system, Climatronic. Front seat adjustment, Front seat heating, Steering wheel adjustment, Heated mirrors, Stability control");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "7.0L V8 E-Force Supercharged engine with 730 hp, tire size P275/35ZR18; P325/30ZR19, alloy wheels. Edelbrok - screw compressor, installed in a tuning studio in Germany, chassis number: 1G1YY26E075126150.");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Engine 2.0L TDI with a power of 190 hp. with. , aluminum rims.Chassis number: TMB1JCNP2H7544236, with registration. Equipment:Leather interior, Navigation system, Front and rear parking sensors, Heated mirrors, LED brake lights");
        }
    }
}
