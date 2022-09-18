using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommonBeneficiary.Persistence.Migrations
{
    public partial class SeedDataForRelationType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RelationTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { 1L, "001", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "همسر" });

            migrationBuilder.InsertData(
                table: "RelationTypes",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[] { 2L, "002", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "فرزند" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RelationTypes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "RelationTypes",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
