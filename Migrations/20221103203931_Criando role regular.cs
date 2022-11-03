using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9999,
                column: "ConcurrencyStamp",
                value: "147c1a1f-d055-44eb-bc9b-a9fb917c2374");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 999997, "471f3306-a9c6-43b5-88b3-370cb939c2e0", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9855ec8e-3a2e-4d6a-b767-f3a8977fbeaa", "AQAAAAEAACcQAAAAEG8ZsJfZm4J5IqVclZj5VRuELz/DsAs11Xvh0QHwhlvB5WnqdmuaApBWgPnITsVLtw==", "94c997f4-73bf-48f6-a8c8-84a4ca0c1b80" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 999997);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 9999,
                column: "ConcurrencyStamp",
                value: "b3664201-7b17-4965-87d7-da4852ddf2fa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22c14f11-eec6-4747-9411-9d93f51af0f1", "AQAAAAEAACcQAAAAEGvSuOgFsBm8CMsuesb0Gg+oS3wpMOV1Xeh/rbR9/7OdEjzU7lSBNgzTrI9T7x9A4Q==", "880f07a5-b65e-443f-bc8d-db1f26c7d9a2" });
        }
    }
}
