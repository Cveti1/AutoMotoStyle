using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoMotoStyle.Infrastructure.Migrations
{
    public partial class AdminMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-2-1234-47c0-a9ba-38b9a5ddb123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd3bbaff-bc28-4b4c-bc41-6c32fe2b1a4a", "AQAAAAEAACcQAAAAECw5PGLLx4KE48MNZTzMzG8teY8KyDak4MpIC6KllkRTADbEdsH7FK4+4+ykTY+KAg==", "dd8983c4-1b69-4885-8261-2c1da2e3720e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-7-4421-47c0-a9ba-38b9a5ddb357",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e49258a-911c-48bc-9e5e-db3f94bcf490", "AQAAAAEAACcQAAAAEC4gkLOqyRecG4Qx4Z9nzRDHyZNo2yy71oflUOXAZCEC2e7YABysGviLUjDBykS6NA==", "b7448dde-e4b7-421b-9f97-d3627de09ed1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ea60f4a-f8cf-4e73-b861-7b94b934e8d3", "AQAAAAEAACcQAAAAEH1Mbif/F/elcWo3o+L5N9lbioyMnFqUflPVfd3Z2dnX8E7dasHiDonGBFZgGfDQNQ==", "b750d46e-0d99-40c7-b367-46906da62bfd" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "admin-a5-7a9a-4ba7-8768-66ba10cd0123", 0, "4f00db2e-a291-427e-973f-4e5ee472cc4d", "admin@automotostyle.com", false, false, null, "admin@automotostyle.com", "admin@automotostyle.com", "AQAAAAEAACcQAAAAENJeLIl9Mi+gCiUQTRQZRG+Gz2j1umoqVOubkuA0HWjT42pGjlnowJaKCUfr41qHlw==", null, false, "a6e25f0b-c9a0-40f9-9d81-ae05e4000fe0", false, "admin@automotostyle.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-a5-7a9a-4ba7-8768-66ba10cd0123");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-2-1234-47c0-a9ba-38b9a5ddb123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa3c9bcb-8547-44a5-81e3-982171511425", "AQAAAAEAACcQAAAAENkPaVUU+ond2bhtcJP3642R/QO9HwHH7M2lpRrJzrP/PUhNW99IlAHFwf9FFPmU2A==", "f1cd077b-e268-4846-8f3a-877389e6656c" });

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
        }
    }
}
