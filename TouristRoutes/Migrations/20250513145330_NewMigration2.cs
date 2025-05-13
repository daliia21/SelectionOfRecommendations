using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TouristRoutes.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Routes_RouteId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_RouteId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "RouteId",
                table: "Tags");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RouteId",
                table: "Tags",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_RouteId",
                table: "Tags",
                column: "RouteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Routes_RouteId",
                table: "Tags",
                column: "RouteId",
                principalTable: "Routes",
                principalColumn: "Id");
        }
    }
}
