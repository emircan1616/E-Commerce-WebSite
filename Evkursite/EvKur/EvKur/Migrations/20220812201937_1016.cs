using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvKur.Migrations
{
    public partial class _1016 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sepet_bayiis_BayiId",
                table: "sepet");

            migrationBuilder.DropForeignKey(
                name: "FK_sepet_products_productId",
                table: "sepet");

            migrationBuilder.AlterColumn<int>(
                name: "productId",
                table: "sepet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SepetUrunFiyat",
                table: "sepet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BayiId",
                table: "sepet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "bayiProductId",
                table: "sepet",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_sepet_bayiProductId",
                table: "sepet",
                column: "bayiProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_sepet_bayiis_BayiId",
                table: "sepet",
                column: "BayiId",
                principalTable: "bayiis",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_sepet_bayiProducts_bayiProductId",
                table: "sepet",
                column: "bayiProductId",
                principalTable: "bayiProducts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_sepet_products_productId",
                table: "sepet",
                column: "productId",
                principalTable: "products",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sepet_bayiis_BayiId",
                table: "sepet");

            migrationBuilder.DropForeignKey(
                name: "FK_sepet_bayiProducts_bayiProductId",
                table: "sepet");

            migrationBuilder.DropForeignKey(
                name: "FK_sepet_products_productId",
                table: "sepet");

            migrationBuilder.DropIndex(
                name: "IX_sepet_bayiProductId",
                table: "sepet");

            migrationBuilder.DropColumn(
                name: "bayiProductId",
                table: "sepet");

            migrationBuilder.AlterColumn<int>(
                name: "productId",
                table: "sepet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SepetUrunFiyat",
                table: "sepet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BayiId",
                table: "sepet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_sepet_bayiis_BayiId",
                table: "sepet",
                column: "BayiId",
                principalTable: "bayiis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sepet_products_productId",
                table: "sepet",
                column: "productId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
