using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoMotoStyle.Infrastructure.Migrations
{
    public partial class Lrio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-a5-7a9a-4ba7-8768-66ba10cd0123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "034a1a1c-278b-4006-b20d-81321196b913", "AQAAAAEAACcQAAAAEAEm6ONM2vVLeKe+1ZBVi45oOcFGIByEVtKIx1M9S3MfD9Sp6S7vPlkDatCjASex9g==", "8ac4b13a-5535-4be4-a2e1-f9b188cd6e10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-2-1234-47c0-a9ba-38b9a5ddb123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "163c282a-53db-4573-b4ea-79bd380e84d6", "AQAAAAEAACcQAAAAEDayEfUFnl4v7T/OXuCSllrzAnxIyG7OkZ31Bk2DzB0WlbmZWvpgYegSWif2XfQOMQ==", "44d4750b-3114-4547-93e4-2db935df57c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-7-4421-47c0-a9ba-38b9a5ddb357",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4c7808e-d998-46f3-acec-10693061d51f", "AQAAAAEAACcQAAAAEK+xAODw7u1Qehzywb6AjAC441LV+RqL3e1LUOyMFu2XeeVJLPugPoqgZsrCOH+ePQ==", "3cfc6c28-a3d5-4edf-b21a-6887a5276722" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3e36840-6dcf-4bfe-9d08-da4f234342df", "AQAAAAEAACcQAAAAEPLWJfLRA80khxB262MqgE/Qp6fixy/UCadwetn9aFIDct1I0PPdSWa30qKHG64nJg==", "0621ed0d-624e-4db5-a966-bb3654eb9fe0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
