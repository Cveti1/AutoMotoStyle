using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoMotoStyle.Infrastructure.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-7-4421-47c0-a9ba-38b9a5ddb357",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2abaf438-4f29-4bc7-a263-5d168ea331fc", "AQAAAAEAACcQAAAAEN2m0rVMvU4xTFwi0IscS++Y2vuhe9fP6d1ZW4CU6rO/iDtRrvl++J+N5EMV6f/PKw==", "06d6577b-b125-469a-8d63-aee56dbb06d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d81b786-2aac-415c-ac80-381961fee382", "AQAAAAEAACcQAAAAEHCyCyeHEIaX7uhT4uURKDvWROlZIbpeSO7jy/xq0vnRNBeY2329npp36iPMpffHmg==", "e6b47f70-0034-4c81-ba05-7c251d631fd7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-7-4421-47c0-a9ba-38b9a5ddb357");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest-a5-7a9a-4ba7-8768-66ba10cd0979");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dealer-7-4421-47c0-a9ba-38b9a5ddb357", 0, "a408b7a1-0f8e-4bd0-892c-b6eb0fa38890", "IdentityUser", "dealer@mail.com", false, false, null, "dealer@mail.com", "dealer@mail.com", "AQAAAAEAACcQAAAAEBqBAM8qmVn7gRLXxs/hQGtnH1Jlh2UppIym90sbeDIERRsg/CxiFlS8VoRqcGLo7g==", null, false, "086c788e-9b92-4f57-97c3-55a74c3e1162", false, "dealer@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "guest-a5-7a9a-4ba7-8768-66ba10cd0979", 0, "534c06ed-98a7-4cc9-a23f-87bfc0116b25", "IdentityUser", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEL8sIzyEWXwFCjkKR1SkkySlRx8Urdd6tGaJq4Gl8kwUMHVNLmtMYsj8Gc7dWKdofA==", null, false, "ba898c61-fbe1-431f-9ffb-a5ec8e1b30f4", false, "guest@mail.com" });
        }
    }
}
