using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoMotoStyle.Infrastructure.Migrations
{
    public partial class newDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-7-4421-47c0-a9ba-38b9a5ddb357",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "584943d8-0ae3-4116-88bf-3c750196cb26", "AQAAAAEAACcQAAAAEBPiyQm8BqPW611e4Hp3shUpdwoWq43OQbNeP8SZfeVBGc5TfvAMqa5GY1XzMgeAlw==", "a5757806-f298-4a2f-8fb6-e256e17025c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb7cd6de-d131-47ba-99ab-2672e1eeb476", "AQAAAAEAACcQAAAAENWKgmG0krDzt8B5jhk2r4uItwZcEowj8o5ujxkk869Wc+6p6EnVjjDlGyGVtfBgiw==", "dcb47954-a74a-4496-a329-254cc81dcea0" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-7-4421-47c0-a9ba-38b9a5ddb357",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e47d991-08f8-4d75-94f2-fe0977ea087d", "AQAAAAEAACcQAAAAEN2j9/p+LMqCfHaYCRlzILHVa/vM+LL5u4CUUY6kQ0m6+w3RZRpMkM5Vdl9Rs8usSg==", "06d2d153-84ff-4269-9902-23d9f2e281a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1538e08d-2883-48ea-b5c5-6b3ac5ccc356", "AQAAAAEAACcQAAAAEAeDhIKmNZApdk8s2VwCuuqqLAt6gMml6O8Yp0NU1/btPfhpJZ2wgm3q82943Ch/LA==", "03623bad-0e78-48ca-9a4d-93709135636e" });
        }
    }
}
