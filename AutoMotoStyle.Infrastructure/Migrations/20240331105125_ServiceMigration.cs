using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoMotoStyle.Infrastructure.Migrations
{
    public partial class ServiceMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Services",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

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
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "We offer a professional manual car wash service, often provided by someone in a mobile unit who can come to your home or workplace. They use professional products and can offer a high quality service.");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "General repair, engine rebuilding or reconditioning of motor vehicles collision service such as body, frame and fender straightening and repair and painting of motor vehicles and more... Just tell us what you need...!");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "All condition of the car or bus. Identification of the vehicle - registration numbers and documentation. Measurement of the braking system; status of brakes, parking brake and ABS. Condition of steering. Operation of all lights - lights, headlights, turn signals, gauges. Condition of electrical equipment - battery. Condition of tires, axles and suspension. Harmful effects - noise emissions exhaust. Car equipment - first aid kit, fire extinguisher, triangle, belts etc.", "Annual technical inspection" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Tuning of motorcycles, cars and other vehicles, means reworking and changing according to the owner's personal preferences. Mainly this can refer to optical and technical changes.\r\nTuning cars and other vehicles is fine-tuning the engine, aerodynamics or suspension to improve performance, exterior and interior aesthetics, and acoustics.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Services");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-7-4421-47c0-a9ba-38b9a5ddb357",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "032d6388-d18e-4085-8111-cd37c4cf5629", "AQAAAAEAACcQAAAAEP3Q3kK8WAEN0+XIWdcV/ei8j2CsXAnmJklyk3cmb8Oqqx2Y1dwyRmIhy8KNB6rQ+w==", "44f7f3b9-61b3-4f2b-85d6-fe83318928d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1033cb85-30ad-413f-a233-0b7f0534e465", "AQAAAAEAACcQAAAAEFf4TTz7DBYxuj7Shuc5haHcyImDq2XmEyHQDuZ3TOOlFmlotKBmBicnfd1XpEQKNw==", "46e16675-3cd0-4e17-a901-35ef12704d52" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Annual technical reviews");
        }
    }
}
