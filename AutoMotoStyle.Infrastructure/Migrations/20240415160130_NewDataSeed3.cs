using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoMotoStyle.Infrastructure.Migrations
{
    public partial class NewDataSeed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-7-4421-47c0-a9ba-38b9a5ddb357",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81d0fee4-dcdd-4b9c-b98c-d2124af46162", "AQAAAAEAACcQAAAAEFa2p+hnflJqn8A3oqvrlQbBRu2uP01pSnSsnTGANHCd6ED23hm8cu9aNw9xycGycA==", "38ce188e-7138-4f72-abae-df591af42a3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15e166a3-3bab-4a41-8df8-f09c2259b4bc", "AQAAAAEAACcQAAAAEHgKb43L4MQ4L2S2ZGJgqqiOXIeM68l4t/9kmSx2kJOQwP6BTkqbJojmOApDGiUd+g==", "e6a89581-ef0c-4f43-84bd-fa469acb2f80" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dealer-2-1234-47c0-a9ba-38b9a5ddb123", 0, "aa3c9bcb-8547-44a5-81e3-982171511425", "dealer_2@mail.com", false, false, null, "dealer_2@mail.com", "dealer_2@mail.com", "AQAAAAEAACcQAAAAENkPaVUU+ond2bhtcJP3642R/QO9HwHH7M2lpRrJzrP/PUhNW99IlAHFwf9FFPmU2A==", null, false, "f1cd077b-e268-4846-8f3a-877389e6656c", false, "dealer_2@mail.com" });

            migrationBuilder.InsertData(
                table: "Dealers",
                columns: new[] { "Id", "DealerName", "PhoneNumber", "UserId" },
                values: new object[] { 2, "dealer2", "+359987654321", "dealer-2-1234-47c0-a9ba-38b9a5ddb123" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "DealerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DealerId", "RenterId" },
                values: new object[] { 2, "guest-a5-7a9a-4ba7-8768-66ba10cd0979" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DealerId", "RenterId" },
                values: new object[] { 2, "guest-a5-7a9a-4ba7-8768-66ba10cd0979" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dealers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-2-1234-47c0-a9ba-38b9a5ddb123");

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
                keyValue: 3,
                column: "DealerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DealerId", "RenterId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DealerId", "RenterId" },
                values: new object[] { 1, null });
        }
    }
}
