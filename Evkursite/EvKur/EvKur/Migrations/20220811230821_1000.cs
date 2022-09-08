using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvKur.Migrations
{
    public partial class _1000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminAdi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    AdminSoyad = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bayiis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BayiAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BayiKazanc = table.Column<int>(type: "int", nullable: true),
                    BayiSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BayiAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BayiMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BayiTelefon = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bayiis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "carts",
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
                    table.PrimaryKey("PK_carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriIsmi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SirketIsmi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SirketSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "customerComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriYorumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerilenPuan = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerComments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriAdi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MusteriSoyad = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "logins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Benihatirla = table.Column<bool>(type: "bit", nullable: false),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "registers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciSifreTekrar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "shippings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shippings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tedarikcis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TedarikciIsmi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TedarikciSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tedarikcis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "addProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrunFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UrunAdet = table.Column<int>(type: "int", nullable: false),
                    TedarikciId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_addProducts_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_addProducts_tedarikcis_TedarikciId",
                        column: x => x.TedarikciId,
                        principalTable: "tedarikcis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bayiSiparis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiparisAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiparisMiktari = table.Column<int>(type: "int", nullable: false),
                    SiparisDurumu = table.Column<bool>(type: "bit", nullable: false),
                    tedarikciId = table.Column<int>(type: "int", nullable: true),
                    BayiId = table.Column<int>(type: "int", nullable: true),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bayiSiparis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bayiSiparis_bayiis_BayiId",
                        column: x => x.BayiId,
                        principalTable: "bayiis",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_bayiSiparis_tedarikcis_tedarikciId",
                        column: x => x.tedarikciId,
                        principalTable: "tedarikcis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "productOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiparisUrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiparisUrunAdet = table.Column<int>(type: "int", nullable: false),
                    BayiId = table.Column<int>(type: "int", nullable: true),
                    tedarikciId = table.Column<int>(type: "int", nullable: true),
                    UrunDurumu = table.Column<bool>(type: "bit", nullable: false),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productOrders_bayiis_BayiId",
                        column: x => x.BayiId,
                        principalTable: "bayiis",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_productOrders_tedarikcis_tedarikciId",
                        column: x => x.tedarikciId,
                        principalTable: "tedarikcis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrunFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UrunAdet = table.Column<int>(type: "int", nullable: false),
                    TedarikciId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_tedarikcis_TedarikciId",
                        column: x => x.TedarikciId,
                        principalTable: "tedarikcis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bayiProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BayiUrunIsim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BayiUrunFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    productId = table.Column<int>(type: "int", nullable: true),
                    BayiUrunAdet = table.Column<int>(type: "int", nullable: false),
                    BayiId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bayiProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bayiProducts_bayiis_BayiId",
                        column: x => x.BayiId,
                        principalTable: "bayiis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bayiProducts_products_productId",
                        column: x => x.productId,
                        principalTable: "products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cartline",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UrunAdet = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: true),
                    GuncelleyenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    aktifMi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cartline", x => x.Id);
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
                });

            migrationBuilder.CreateIndex(
                name: "IX_addProducts_CategoryId",
                table: "addProducts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_addProducts_TedarikciId",
                table: "addProducts",
                column: "TedarikciId");

            migrationBuilder.CreateIndex(
                name: "IX_bayiProducts_BayiId",
                table: "bayiProducts",
                column: "BayiId");

            migrationBuilder.CreateIndex(
                name: "IX_bayiProducts_productId",
                table: "bayiProducts",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_bayiSiparis_BayiId",
                table: "bayiSiparis",
                column: "BayiId");

            migrationBuilder.CreateIndex(
                name: "IX_bayiSiparis_tedarikciId",
                table: "bayiSiparis",
                column: "tedarikciId");

            migrationBuilder.CreateIndex(
                name: "IX_Cartline_CartId",
                table: "Cartline",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Cartline_ProductId",
                table: "Cartline",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_productOrders_BayiId",
                table: "productOrders",
                column: "BayiId");

            migrationBuilder.CreateIndex(
                name: "IX_productOrders_tedarikciId",
                table: "productOrders",
                column: "tedarikciId");

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoryId",
                table: "products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_products_TedarikciId",
                table: "products",
                column: "TedarikciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addProducts");

            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "bayiProducts");

            migrationBuilder.DropTable(
                name: "bayiSiparis");

            migrationBuilder.DropTable(
                name: "Cartline");

            migrationBuilder.DropTable(
                name: "companies");

            migrationBuilder.DropTable(
                name: "customerComments");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "logins");

            migrationBuilder.DropTable(
                name: "productOrders");

            migrationBuilder.DropTable(
                name: "registers");

            migrationBuilder.DropTable(
                name: "shippings");

            migrationBuilder.DropTable(
                name: "carts");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "bayiis");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "tedarikcis");
        }
    }
}
