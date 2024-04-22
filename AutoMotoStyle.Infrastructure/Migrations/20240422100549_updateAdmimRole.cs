using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoMotoStyle.Infrastructure.Migrations
{
    public partial class updateAdmimRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-a5-7a9a-4ba7-8768-66ba10cd0123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1d4fc98-66c3-483d-b651-5a67ea3081b8", "AQAAAAEAACcQAAAAEJ/edLw8g72VerK08dQ6T9m/UhgkqoaQX2UQeQOwZD0PcuPY2X736T7KU8FYHvgWCA==", "6ea4f423-0fa7-4e5a-98ef-52a0132b4ea5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-2-1234-47c0-a9ba-38b9a5ddb123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8451011-f5be-4c4d-8aaf-c30a359576e9", "AQAAAAEAACcQAAAAELnGelRMqEJROT0QVJNP4hAuD79W6sVtg9Jlu6ideG/VdKzztIFKZc+HuqdCkS36+A==", "54b3c3cb-5ebd-4696-9199-4bb9a0d1cf91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-7-4421-47c0-a9ba-38b9a5ddb357",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0859fa44-ce19-4f03-b2c7-e02385a9efa8", "AQAAAAEAACcQAAAAEJWR8XdRFa3U+hNw9bpT5BbpffJb+9rzfMAiQ0WAg50yA1ShZoS6LXe+iCSP2jRizg==", "49641629-d96a-4954-b164-f4382177f568" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b060454-7ce8-49a0-ae11-4718f4337da5", "AQAAAAEAACcQAAAAEDn15a0E1P/Znl/SQn6MDZuDmXlflZwMBWXOjAkF1VIEymMw7IfqjVm0ss3hdoesTA==", "44450fa8-35c6-4be7-a6a2-9c96446b4435" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
