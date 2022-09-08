using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvKur.Migrations
{
    public partial class _1081 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_sepet_bayiProductId",
                table: "sepet");

            migrationBuilder.CreateIndex(
                name: "IX_sepet_bayiProductId",
                table: "sepet",
                column: "bayiProductId",
                unique: true,
                filter: "[bayiProductId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_sepet_bayiProductId",
                table: "sepet");

            migrationBuilder.CreateIndex(
                name: "IX_sepet_bayiProductId",
                table: "sepet",
                column: "bayiProductId");
        }
    }
}
