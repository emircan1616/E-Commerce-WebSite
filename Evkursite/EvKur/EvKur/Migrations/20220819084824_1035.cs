using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvKur.Migrations
{
    public partial class _1035 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "bayiProductId",
                table: "Cartline",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cartline_bayiProductId",
                table: "Cartline",
                column: "bayiProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cartline_bayiProducts_bayiProductId",
                table: "Cartline",
                column: "bayiProductId",
                principalTable: "bayiProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cartline_bayiProducts_bayiProductId",
                table: "Cartline");

            migrationBuilder.DropIndex(
                name: "IX_Cartline_bayiProductId",
                table: "Cartline");

            migrationBuilder.DropColumn(
                name: "bayiProductId",
                table: "Cartline");
        }
    }
}
