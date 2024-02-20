using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoMotoStyle.Infrastructure.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dealer-7-4421-47c0-a9ba-38b9a5ddb357",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45f03ea1-6514-43b3-8278-03440688299c", "AQAAAAEAACcQAAAAED6JXgYO5Sr/kYKw2N/ayzoq/bnuztGawnZ5IoVDnmuTjs4G+Yre5Jvxv50YOTdiGg==", "3203d5c4-50b1-471d-bcbc-f24f27c2adfe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest-a5-7a9a-4ba7-8768-66ba10cd0979",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73e0c640-e4de-4968-8d5d-722e747052fa", "AQAAAAEAACcQAAAAEKcdf87jlXwBWHrx1DkEIO4j2utrX4t86ZomIhJ7eWGuCiTtYGL4vaChZAAStJ03qg==", "2614a5d4-17be-4a86-b5b5-b56813279d5f" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.autocasion.com%2Fmarcas%2Faudi%2Fa3-compactos%2Fa3-sedan-2-0tdi-design-edition-quattro-150-4-puertas-72727&psig=AOvVaw1XJMe-aG9baMYW6MAZt9Rw&ust=1708107620224000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCMiN9PH6rYQDFQAAAAAdAAAAABAE");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.pjsautoworld.com%2Fvehicles%2F487%2F2007-chevrolet-corvette-z06-procharged&psig=AOvVaw2IDhTWbbk8WPObH3y2r_Wi&ust=1708107533403000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCPD1vcj6rYQDFQAAAAAdAAAAABAE");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Findianautosblog.com%2F2018-skoda-superb-facelift-render-p286727&psig=AOvVaw17BfdprSt_Dry886ZJKR1u&ust=1708107574130000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCJC59tv6rYQDFQAAAAAdAAAAABAE");
        }
    }
}
