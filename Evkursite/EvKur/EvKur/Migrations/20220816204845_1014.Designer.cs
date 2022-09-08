﻿// <auto-generated />
using System;
using EvKur.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EvKur.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220816204845_1014")]
    partial class _1014
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EvKur.Models.Comment.CustomerComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusteriYorumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OlusturanKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("VerilenPuan")
                        .HasColumnType("int");

                    b.Property<bool>("aktifMi")
                        .HasColumnType("bit");

                    b.Property<bool>("silindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("customerComments");
                });

            modelBuilder.Entity("EvKur.Models.Factory.Bayii", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BayiAciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BayiAdı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BayiKazanc")
                        .HasColumnType("int");

                    b.Property<string>("BayiMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BayiSifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BayiTelefon")
                        .HasColumnType("int");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OlusturanKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("aktifMi")
                        .HasColumnType("bit");

                    b.Property<bool>("silindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("bayiis");
                });

            modelBuilder.Entity("EvKur.Models.Factory.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OlusturanKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("SirketIsmi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SirketSifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("aktifMi")
                        .HasColumnType("bit");

                    b.Property<bool>("silindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("companies");
                });

            modelBuilder.Entity("EvKur.Models.Factory.Tedarikci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OlusturanKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("TedarikciIsmi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TedarikciSifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("aktifMi")
                        .HasColumnType("bit");

                    b.Property<bool>("silindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("tedarikcis");
                });

            modelBuilder.Entity("EvKur.Models.Shop.AddProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OlusturanKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("TedarikciId")
                        .HasColumnType("int");

                    b.Property<int>("UrunAdet")
                        .HasColumnType("int");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UrunFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("aktifMi")
                        .HasColumnType("bit");

                    b.Property<bool>("silindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TedarikciId");

                    b.ToTable("addProducts");
                });

            modelBuilder.Entity("EvKur.Models.Shop.BayiProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BayiId")
                        .HasColumnType("int");

                    b.Property<int>("BayiUrunAdet")
                        .HasColumnType("int");

                    b.Property<decimal?>("BayiUrunFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BayiUrunIsim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OlusturanKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("aktifMi")
                        .HasColumnType("bit");

                    b.Property<int?>("productId")
                        .HasColumnType("int");

                    b.Property<bool>("silindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BayiId");

                    b.HasIndex("productId");

                    b.ToTable("bayiProducts");
                });

            modelBuilder.Entity("EvKur.Models.Shop.BayiSiparis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BayiId")
                        .HasColumnType("int");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OlusturanKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("SiparisAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SiparisDurumu")
                        .HasColumnType("bit");

                    b.Property<int>("SiparisMiktari")
                        .HasColumnType("int");

                    b.Property<bool>("aktifMi")
                        .HasColumnType("bit");

                    b.Property<bool>("silindiMi")
                        .HasColumnType("bit");

                    b.Property<int?>("tedarikciId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BayiId");

                    b.HasIndex("tedarikciId");

                    b.ToTable("bayiSiparis");
                });

            modelBuilder.Entity("EvKur.Models.Shop.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KategoriIsmi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OlusturanKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("aktifMi")
                        .HasColumnType("bit");

                    b.Property<bool>("silindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("EvKur.Models.Shop.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OlusturanKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("TedarikciId")
                        .HasColumnType("int");

                    b.Property<int>("UrunAdet")
                        .HasColumnType("int");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UrunFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("aktifMi")
                        .HasColumnType("bit");

                    b.Property<bool>("silindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TedarikciId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("EvKur.Models.Shop.ProductOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BayiId")
                        .HasColumnType("int");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OlusturanKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("SiparisUrunAdet")
                        .HasColumnType("int");

                    b.Property<string>("SiparisUrunAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UrunDurumu")
                        .HasColumnType("bit");

                    b.Property<bool>("aktifMi")
                        .HasColumnType("bit");

                    b.Property<bool>("silindiMi")
                        .HasColumnType("bit");

                    b.Property<int?>("tedarikciId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BayiId");

                    b.HasIndex("tedarikciId");

                    b.ToTable("productOrders");
                });

            modelBuilder.Entity("EvKur.Models.Shop.Sepet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BayiId")
                        .HasColumnType("int");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OlusturanKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("SepetUrunAdet")
                        .HasColumnType("int");

                    b.Property<string>("SepetUrunAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("SepetUrunFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("aktifMi")
                        .HasColumnType("bit");

                    b.Property<int?>("bayiProductId")
                        .HasColumnType("int");

                    b.Property<int?>("productId")
                        .HasColumnType("int");

                    b.Property<bool>("silindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BayiId");

                    b.HasIndex("bayiProductId");

                    b.HasIndex("productId");

                    b.ToTable("sepet");
                });

            modelBuilder.Entity("EvKur.Models.ShopCart.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OlusturanKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("aktifMi")
                        .HasColumnType("bit");

                    b.Property<bool>("silindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("carts");
                });

            modelBuilder.Entity("EvKur.Models.ShopCart.Cartline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OlusturanKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UrunAdet")
                        .HasColumnType("int");

                    b.Property<bool>("aktifMi")
                        .HasColumnType("bit");

                    b.Property<bool>("silindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("Cartline");
                });

            modelBuilder.Entity("EvKur.Models.SignIn.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Benihatirla")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciSifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OlusturanKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("aktifMi")
                        .HasColumnType("bit");

                    b.Property<bool>("silindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("logins");
                });

            modelBuilder.Entity("EvKur.Models.SignIn.Register", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciSifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciSifreTekrar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailAdres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OlusturanKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("aktifMi")
                        .HasColumnType("bit");

                    b.Property<bool>("silindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("registers");
                });

            modelBuilder.Entity("EvKur.Models.User.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdminAdi")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("AdminSoyad")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OlusturanKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("aktifMi")
                        .HasColumnType("bit");

                    b.Property<bool>("silindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("admin");
                });

            modelBuilder.Entity("EvKur.Models.User.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MusteriAdi")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("MusteriSoyad")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("OlusturanKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("aktifMi")
                        .HasColumnType("bit");

                    b.Property<bool>("silindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("EvKur.Models.User.Shipping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OlusturanKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("aktifMi")
                        .HasColumnType("bit");

                    b.Property<bool>("silindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("shippings");
                });

            modelBuilder.Entity("EvKur.Models.Shop.AddProduct", b =>
                {
                    b.HasOne("EvKur.Models.Shop.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvKur.Models.Factory.Tedarikci", "Tedarikci")
                        .WithMany()
                        .HasForeignKey("TedarikciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Tedarikci");
                });

            modelBuilder.Entity("EvKur.Models.Shop.BayiProduct", b =>
                {
                    b.HasOne("EvKur.Models.Factory.Bayii", "Bayi")
                        .WithMany()
                        .HasForeignKey("BayiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvKur.Models.Shop.Product", "product")
                        .WithMany()
                        .HasForeignKey("productId");

                    b.Navigation("Bayi");

                    b.Navigation("product");
                });

            modelBuilder.Entity("EvKur.Models.Shop.BayiSiparis", b =>
                {
                    b.HasOne("EvKur.Models.Factory.Bayii", "Bayi")
                        .WithMany()
                        .HasForeignKey("BayiId");

                    b.HasOne("EvKur.Models.Factory.Tedarikci", "tedarikci")
                        .WithMany()
                        .HasForeignKey("tedarikciId");

                    b.Navigation("Bayi");

                    b.Navigation("tedarikci");
                });

            modelBuilder.Entity("EvKur.Models.Shop.Product", b =>
                {
                    b.HasOne("EvKur.Models.Shop.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvKur.Models.Factory.Tedarikci", "Tedarikci")
                        .WithMany("Products")
                        .HasForeignKey("TedarikciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Tedarikci");
                });

            modelBuilder.Entity("EvKur.Models.Shop.ProductOrder", b =>
                {
                    b.HasOne("EvKur.Models.Factory.Bayii", "Bayi")
                        .WithMany()
                        .HasForeignKey("BayiId");

                    b.HasOne("EvKur.Models.Factory.Tedarikci", "tedarikci")
                        .WithMany()
                        .HasForeignKey("tedarikciId");

                    b.Navigation("Bayi");

                    b.Navigation("tedarikci");
                });

            modelBuilder.Entity("EvKur.Models.Shop.Sepet", b =>
                {
                    b.HasOne("EvKur.Models.Factory.Bayii", "Bayi")
                        .WithMany()
                        .HasForeignKey("BayiId");

                    b.HasOne("EvKur.Models.Shop.BayiProduct", "bayiProduct")
                        .WithMany()
                        .HasForeignKey("bayiProductId");

                    b.HasOne("EvKur.Models.Shop.Product", "product")
                        .WithMany()
                        .HasForeignKey("productId");

                    b.Navigation("Bayi");

                    b.Navigation("bayiProduct");

                    b.Navigation("product");
                });

            modelBuilder.Entity("EvKur.Models.ShopCart.Cartline", b =>
                {
                    b.HasOne("EvKur.Models.ShopCart.Cart", null)
                        .WithMany("Cartlines")
                        .HasForeignKey("CartId");

                    b.HasOne("EvKur.Models.Shop.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EvKur.Models.Factory.Tedarikci", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EvKur.Models.Shop.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EvKur.Models.ShopCart.Cart", b =>
                {
                    b.Navigation("Cartlines");
                });
#pragma warning restore 612, 618
        }
    }
}
