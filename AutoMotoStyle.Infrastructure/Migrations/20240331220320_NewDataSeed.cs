using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoMotoStyle.Infrastructure.Migrations
{
    public partial class NewDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 1,
                columns: new[] { "Brand", "Description", "FuelId", "ImageUrl", "Model", "Price", "TransmissionId", "TypeId", "Year" },
                values: new object[] { "AUDI", "Engine 2.0L TFSI with a power of 223 hp, 4x4 drive. Equipment:Brown leather interior, Navigation system, Climatronic. Front seat adjustment, Front seat heating, Steering wheel adjustment, Heated mirrors, Stability control.", 1, "https://www.coches.com/fotos_historicas/audi/A3-Sedan-2.0-TDI-Quattro-S-Line-2016/audi_a3-sedan-2-0-tdi-quattro-s-line-2016_r14.jpg", "A3 QUATTRO", 1300.00m, 1, 1, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Price", "RenterId", "TypeId", "Year" },
                values: new object[] { "CHEVROLET", "7.0L V8 E-Force Supercharged engine with 730 hp, tire size P275/35ZR18; P325/30ZR19, alloy wheels  Edelbrok - screw compressor, installed in a tuning studio in Germany, chassis number: 1G1YY26E075126150.", "https://cdn.dealeraccelerate.com/pjs/1/456/13143/1920x1440/2007-chevrolet-corvette-z06-procharged.webp", "CORVETTE ZO6", 1500.00m, "guest-a5-7a9a-4ba7-8768-66ba10cd0979", 1, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "Description", "FuelId", "ImageUrl", "Model", "Price", "TransmissionId", "TypeId", "Year" },
                values: new object[] { "SKODA", "Engine 2.0L TDI with a power of 190 hp. with. , aluminum rims.Chassis number: TMB1JCNP2H7544236, with registration. Equipment:Leather interior, Navigation system, Front and rear parking sensors, Heated mirrors, LED brake lights.", 2, "https://img.indianautosblog.com/resize/750x-/2017/10/2018-Skoda-Superb-facelift-rendering-front-three-quarters.jpg", "SUPERB", 1400.00m, 2, 1, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "Description", "FuelId", "ImageUrl", "Model", "Price", "TransmissionId", "TypeId", "Year" },
                values: new object[] { "TOYOTA", "The Toyota Land Cruiser SUV is a high-performance vehicle. It comes with a turbocharged 2.4-liter four-cylinder engine. The powerplant makes 326 horsepower and 465 pound-feet of torque compared to the 381 hp and 401 lb-ft from the old V8. And it can tow up to 6,000 pounds.", 4, "https://carnovo.com/wp-content/uploads/2023/12/toyota-land-cruiser-2024-1200x900.jpg", "LAND CRUISER", 2000.00m, 1, 3, 2024 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Price", "RenterId", "TypeId", "Year" },
                values: new object[] { "HONDA", "Punchy maximum torque of 43.3Nm torque @ 6,000rpm combines with peak power of 34kW @ 8,500rpm. It's a power unit that strikes a great balance between physical size and flexible output. Bore and stroke is set at 67mm x 66.8mm with compression ratio of 10.7:1.", "https://silesmotos.com/img/cms/Motos/HONDA/500-cmx-2023/c4%20(2).png", "REBEL", 1900.00m, null, 4, 2023 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Brand", "Description", "FuelId", "ImageUrl", "Model", "Price", "TransmissionId", "TypeId", "Year" },
                values: new object[] { "FIAT", "It is characterized by strength and low consumption. It is articulated around a 2.3 engine\nWith a new variable geometry turbocharger, among other things, the access mechanic increases its power and torque by 10% compared to the previous 2.0. Probably the most sought after is the 140 HP...or 160, which boasts a specific engine shaft with large bearings, special pistons and a specific turbocharger.", 3, "https://www.fiatprofessional.com/content/dam/fiatprofessional/cross/news/details/Ducato-MY2020/fiatprofessional-ducato-grey-commercial-vehicle-mobile-626x386.jpg", "DUCATO", 2400.00m, 2, 2, 2020 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-7-4421-47c0-a9ba-38b9a5ddb357",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "899dca08-ac2d-4d6f-8c02-bc47e3d0d5a4", "AQAAAAEAACcQAAAAEGkukeNBELFbVQzjdt/TKkHCgPnd3+4i150oq8XTSMcAqqnuubbyZvyp8m2mNNvM4Q==", "3cb28a11-a9a9-417f-87e9-b5f89be41b6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a04c5c86-1151-4042-b69a-a39fc011b313", "AQAAAAEAACcQAAAAEISuv6GOOM/qg54V1Nif0eb+LIKSHiX5BjB8B/OTNlrcpqeVSQlBHn72mwtmazPJeQ==", "153a12c3-1181-40c3-b9ac-3f2eb2bc1724" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "Description", "FuelId", "ImageUrl", "Model", "Price", "TransmissionId", "TypeId", "Year" },
                values: new object[] { "FIAT", "It is characterized by strength and low consumption. It is articulated around a 2.3 engine\nWith a new variable geometry turbocharger, among other things, the access mechanic increases its power and torque by 10% compared to the previous 2.0. Probably the most sought after is the 140 HP...or 160, which boasts a specific engine shaft with large bearings, special pistons and a specific turbocharger.", 3, "https://www.fiatprofessional.com/content/dam/fiatprofessional/cross/news/details/Ducato-MY2020/fiatprofessional-ducato-grey-commercial-vehicle-mobile-626x386.jpg", "DUCATO", 2400.00m, 2, 2, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Price", "RenterId", "TypeId", "Year" },
                values: new object[] { "HONDA", "Punchy maximum torque of 43.3Nm torque @ 6,000rpm combines with peak power of 34kW @ 8,500rpm. It's a power unit that strikes a great balance between physical size and flexible output. Bore and stroke is set at 67mm x 66.8mm with compression ratio of 10.7:1.", "https://silesmotos.com/img/cms/Motos/HONDA/500-cmx-2023/c4%20(2).png", "REBEL", 1900.00m, null, 4, 2023 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "Description", "FuelId", "ImageUrl", "Model", "Price", "TransmissionId", "TypeId", "Year" },
                values: new object[] { "TOYOTA", "The Toyota Land Cruiser SUV is a high-performance vehicle. It comes with a turbocharged 2.4-liter four-cylinder engine. The powerplant makes 326 horsepower and 465 pound-feet of torque compared to the 381 hp and 401 lb-ft from the old V8. And it can tow up to 6,000 pounds.", 4, "https://carnovo.com/wp-content/uploads/2023/12/toyota-land-cruiser-2024-1200x900.jpg", "LAND CRUISER", 2000.00m, 1, 3, 2024 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "Description", "FuelId", "ImageUrl", "Model", "Price", "TransmissionId", "TypeId", "Year" },
                values: new object[] { "SKODA", "Engine 2.0L TDI with a power of 190 hp. with. , aluminum rims.Chassis number: TMB1JCNP2H7544236, with registration. Equipment:Leather interior, Navigation system, Front and rear parking sensors, Heated mirrors, LED brake lights.", 2, "https://img.indianautosblog.com/resize/750x-/2017/10/2018-Skoda-Superb-facelift-rendering-front-three-quarters.jpg", "SUPERB", 1400.00m, 2, 1, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "Description", "ImageUrl", "Model", "Price", "RenterId", "TypeId", "Year" },
                values: new object[] { "CHEVROLET", "7.0L V8 E-Force Supercharged engine with 730 hp, tire size P275/35ZR18; P325/30ZR19, alloy wheels  Edelbrok - screw compressor, installed in a tuning studio in Germany, chassis number: 1G1YY26E075126150.", "https://cdn.dealeraccelerate.com/pjs/1/456/13143/1920x1440/2007-chevrolet-corvette-z06-procharged.webp", "CORVETTE ZO6", 1500.00m, "guest-a5-7a9a-4ba7-8768-66ba10cd0979", 1, 2007 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Brand", "Description", "FuelId", "ImageUrl", "Model", "Price", "TransmissionId", "TypeId", "Year" },
                values: new object[] { "AUDI", "Engine 2.0L TFSI with a power of 223 hp, 4x4 drive. Equipment:Brown leather interior, Navigation system, Climatronic. Front seat adjustment, Front seat heating, Steering wheel adjustment, Heated mirrors, Stability control.", 1, "https://www.coches.com/fotos_historicas/audi/A3-Sedan-2.0-TDI-Quattro-S-Line-2016/audi_a3-sedan-2-0-tdi-quattro-s-line-2016_r14.jpg", "A3 QUATTRO", 1300.00m, 1, 1, 2016 });
        }
    }
}
