using Microsoft.EntityFrameworkCore.Migrations;

namespace TMS.PocoData.Migrations
{
    public partial class SeedRoleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Description", "IsClient", "IsManagement", "RoleCode" },
                values: new object[,]
                {
                    { 1, "Quality Assurance", false, false, "TMS-QA" },
                    { 2, "Manager", false, true, "TMS-MA" },
                    { 3, "Developer", false, false, "TMS-DEV" },
                    { 4, "Customer Service", false, false, "TMS-SERVICE" },
                    { 5, "Client", true, false, "TMS-CLIENT" },
                    { 6, "Adminstrator", false, true, "TMS-ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 6);
        }
    }
}
