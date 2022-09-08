using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvKur.Migrations
{
    public partial class _1065 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cartline");

            migrationBuilder.DropTable(
                name: "carts");

            migrationBuilder.AddColumn<int>(
                name: "ShoppingCartId",
                table: "sepet",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Shoppingcarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoppingcarts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sepet_ShoppingCartId",
                table: "sepet",
                column: "ShoppingCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_sepet_Shoppingcarts_ShoppingCartId",
                table: "sepet",
                column: "ShoppingCartId",
                principalTable: "Shoppingcarts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sepet_Shoppingcarts_ShoppingCartId",
                table: "sepet");

            migrationBuilder.DropTable(
                name: "Shoppingcarts");

            migrationBuilder.DropIndex(
                name: "IX_sepet_ShoppingCartId",
                table: "sepet");

            migrationBuilder.DropColumn(
                name: "ShoppingCartId",
                table: "sepet");

            migrationBuilder.CreateTable(
                name: "carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cartline",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bayiProductId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    sepetId = table.Column<int>(type: "int", nullable: false),
                    BayiUrunAdet = table.Column<int>(type: "int", nullable: true),
                    CartId = table.Column<int>(type: "int", nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UrunAdet = table.Column<int>(type: "int", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false),
                    sepetUrunAdet = table.Column<int>(type: "int", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cartline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cartline_bayiProducts_bayiProductId",
                        column: x => x.bayiProductId,
                        principalTable: "bayiProducts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cartline_carts_CartId",
                        column: x => x.CartId,
                        principalTable: "carts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cartline_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cartline_sepet_sepetId",
                        column: x => x.sepetId,
                        principalTable: "sepet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cartline_bayiProductId",
                table: "Cartline",
                column: "bayiProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Cartline_CartId",
                table: "Cartline",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Cartline_ProductId",
                table: "Cartline",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Cartline_sepetId",
                table: "Cartline",
                column: "sepetId");
        }
    }
}
