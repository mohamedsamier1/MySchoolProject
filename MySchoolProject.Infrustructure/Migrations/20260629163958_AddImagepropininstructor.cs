using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySchoolProject.Infrustructure.Migrations
{
    /// <inheritdoc />
    public partial class AddImagepropininstructor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "instructors",
                type: "nvarchar(max)",
                nullable: true);


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.DropColumn(
                name: "Image",
                table: "instructors");
        }
    }
}
