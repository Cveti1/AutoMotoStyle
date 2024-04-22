using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoMotoStyle.Infrastructure.Migrations
{
    public partial class admin2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-a5-7a9a-4ba7-8768-66ba10cd0123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa024d47-3524-460c-bc01-92989e7a43a7", "AQAAAAEAACcQAAAAEDsCWaL+ciML6t+cUMO8laNgqxaDZNELDQmRlFTq4Pj2V/dnJK8+O1fieThrrAkPzw==", "9782f9d6-72ad-4d3a-80c5-be7f62b9f7d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-2-1234-47c0-a9ba-38b9a5ddb123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "158c66ca-7c1e-4602-ab3a-1d82520519d9", "AQAAAAEAACcQAAAAEHFCu9FOVKVX+C0KUelvwEwkhYquv/W1lWbNUKk7XAPz2/YH1grBtg/LHXIWYrcF4w==", "3b9d5034-134e-4f82-a7c7-30aaf4f15eac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-7-4421-47c0-a9ba-38b9a5ddb357",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28b41851-cc1b-4630-a6d0-3392147d8446", "AQAAAAEAACcQAAAAEFGhPaIIAZnIvBwG2jWPyZAC+6Cy0wFYhyZnTXuBKJMhJ1cKrMGj4mSPDYOzwexfQg==", "fe5260cd-ac3a-4aa2-9c7b-2da816333fc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23c18fa6-e811-4a3b-bdd5-1baf05991167", "AQAAAAEAACcQAAAAEG0c9S/zljSkvtjN/ks+m+8WKLbn1qNeyPu9W1KcmB9AHOC1w02J0WAqqdxe3yxO2g==", "0ec1ec87-014c-4c74-8a9c-e746e5973e79" });

            migrationBuilder.InsertData(
                table: "Dealers",
                columns: new[] { "Id", "DealerName", "PhoneNumber", "UserId" },
                values: new object[] { 3, "admin", "+359001100000", "admin-a5-7a9a-4ba7-8768-66ba10cd0123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dealers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-a5-7a9a-4ba7-8768-66ba10cd0123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f00db2e-a291-427e-973f-4e5ee472cc4d", "AQAAAAEAACcQAAAAENJeLIl9Mi+gCiUQTRQZRG+Gz2j1umoqVOubkuA0HWjT42pGjlnowJaKCUfr41qHlw==", "a6e25f0b-c9a0-40f9-9d81-ae05e4000fe0" });

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
        }
    }
}
