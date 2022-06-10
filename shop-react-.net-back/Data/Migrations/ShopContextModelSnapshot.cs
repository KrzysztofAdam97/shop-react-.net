﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using shop_react_.net_back.Data;

namespace shop_react_.net_back.Data.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentityRole");

                    b.HasData(
                        new
                        {
                            Id = "731ed5ed-6047-4e80-8699-1f35bbeb0fec",
                            ConcurrencyStamp = "4750c834-724f-4ea6-8298-7ba2a2dbca75",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "a14761df-d6f6-4794-bbe7-ba4a2c5b8d1b",
                            ConcurrencyStamp = "1fd2d3b7-92ee-4e4a-bc96-04e7df545c31",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("shop_react_.net_back.Entities.basket", b =>
                {
                    b.Property<int>("id_basket")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("id_client")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_basket");

                    b.ToTable("baskets");
                });

            modelBuilder.Entity("shop_react_.net_back.Entities.basket_item", b =>
                {
                    b.Property<int>("id_basket_item")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("basketid_basket")
                        .HasColumnType("int");

                    b.Property<int>("id_basket")
                        .HasColumnType("int");

                    b.Property<int>("id_product")
                        .HasColumnType("int");

                    b.Property<int?>("productid_product")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("id_basket_item");

                    b.HasIndex("basketid_basket");

                    b.HasIndex("productid_product");

                    b.ToTable("basket_items");
                });

            modelBuilder.Entity("shop_react_.net_back.Entities.product", b =>
                {
                    b.Property<int>("id_product")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description_product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_category")
                        .HasColumnType("int");

                    b.Property<int>("in_stock")
                        .HasColumnType("int");

                    b.Property<string>("name_product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id_product");

                    b.ToTable("products");
                });

            modelBuilder.Entity("shop_react_.net_back.Entities.basket_item", b =>
                {
                    b.HasOne("shop_react_.net_back.Entities.basket", "basket")
                        .WithMany("Items")
                        .HasForeignKey("basketid_basket");

                    b.HasOne("shop_react_.net_back.Entities.product", "product")
                        .WithMany()
                        .HasForeignKey("productid_product");

                    b.Navigation("basket");

                    b.Navigation("product");
                });

            modelBuilder.Entity("shop_react_.net_back.Entities.basket", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
