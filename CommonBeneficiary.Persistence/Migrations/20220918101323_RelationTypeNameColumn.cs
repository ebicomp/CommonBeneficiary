using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommonBeneficiary.Persistence.Migrations
{
    public partial class RelationTypeNameColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RelationName",
                table: "RelationTypes",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "RelationTypes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "RelationTypes");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "RelationTypes",
                newName: "RelationName");
        }
    }
}
