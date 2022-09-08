using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvKur.Migrations
{
    public partial class _1031 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cartline_bayiProducts_bayiProductId",
                table: "Cartline");

            migrationBuilder.AlterColumn<int>(
                name: "bayiProductId",
                table: "Cartline",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BayiUrunAdet",
                table: "Cartline",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Cartline_bayiProducts_bayiProductId",
                table: "Cartline",
                column: "bayiProductId",
                principalTable: "bayiProducts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cartline_bayiProducts_bayiProductId",
                table: "Cartline");

            migrationBuilder.DropColumn(
                name: "BayiUrunAdet",
                table: "Cartline");

            migrationBuilder.AlterColumn<int>(
                name: "bayiProductId",
                table: "Cartline",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cartline_bayiProducts_bayiProductId",
                table: "Cartline",
                column: "bayiProductId",
                principalTable: "bayiProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
