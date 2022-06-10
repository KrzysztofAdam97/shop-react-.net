using Microsoft.EntityFrameworkCore.Migrations;

namespace shop_react_.net_back.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "baskets",
                columns: table => new
                {
                    id_basket = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_client = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_baskets", x => x.id_basket);
                });

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id_product = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description_product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    in_stock = table.Column<int>(type: "int", nullable: false),
                    id_category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.id_product);
                });

            migrationBuilder.CreateTable(
                name: "basket_items",
                columns: table => new
                {
                    id_basket_item = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    id_product = table.Column<int>(type: "int", nullable: false),
                    productid_product = table.Column<int>(type: "int", nullable: true),
                    id_basket = table.Column<int>(type: "int", nullable: false),
                    basketid_basket = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_basket_items", x => x.id_basket_item);
                    table.ForeignKey(
                        name: "FK_basket_items_baskets_basketid_basket",
                        column: x => x.basketid_basket,
                        principalTable: "baskets",
                        principalColumn: "id_basket",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_basket_items_products_productid_product",
                        column: x => x.productid_product,
                        principalTable: "products",
                        principalColumn: "id_product",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "731ed5ed-6047-4e80-8699-1f35bbeb0fec", "4750c834-724f-4ea6-8298-7ba2a2dbca75", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a14761df-d6f6-4794-bbe7-ba4a2c5b8d1b", "1fd2d3b7-92ee-4e4a-bc96-04e7df545c31", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_basket_items_basketid_basket",
                table: "basket_items",
                column: "basketid_basket");

            migrationBuilder.CreateIndex(
                name: "IX_basket_items_productid_product",
                table: "basket_items",
                column: "productid_product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "basket_items");

            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "baskets");

            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
