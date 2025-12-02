using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UI_MVC.Migrations
{
    /// <inheritdoc />
    public partial class AddAgeColumntoPersonEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "People");
        }
    }
}
