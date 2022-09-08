using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvKur.Migrations
{
    public partial class _1033 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "customerId",
                table: "sepet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_sepet_customerId",
                table: "sepet",
                column: "customerId");

            migrationBuilder.AddForeignKey(
                name: "FK_sepet_customers_customerId",
                table: "sepet",
                column: "customerId",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sepet_customers_customerId",
                table: "sepet");

            migrationBuilder.DropIndex(
                name: "IX_sepet_customerId",
                table: "sepet");

            migrationBuilder.DropColumn(
                name: "customerId",
                table: "sepet");
        }
    }
}
