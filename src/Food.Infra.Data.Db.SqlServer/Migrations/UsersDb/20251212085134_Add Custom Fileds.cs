using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food.Infra.Data.Db.SqlServer.Migrations.UsersDb
{
    /// <inheritdoc />
    public partial class AddCustomFileds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                schema: "Users",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NationalCode",
                schema: "Users",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityId",
                schema: "Users",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NationalCode",
                schema: "Users",
                table: "AspNetUsers");
        }
    }
}
