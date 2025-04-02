using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinShark.Migrations
{
    public partial class SeedRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "148c5d51-d2f6-416c-88fe-d97b1a7625a9", "28737a91-af06-4ad8-9e90-7314f87e66e0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3c00806d-f06c-4038-a7ac-b23dcc591d4b", "4e66729f-e5fd-4033-945b-4cc2ff2985d2", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "148c5d51-d2f6-416c-88fe-d97b1a7625a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c00806d-f06c-4038-a7ac-b23dcc591d4b");
        }
    }
}
