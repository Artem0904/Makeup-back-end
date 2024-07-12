using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FillDbTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId1",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_OrderId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserTypes",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genders",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.OrdersId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_OrderProduct_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Chanel" },
                    { 2, "Dior" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Perfumes" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Female" },
                    { 2, "Male" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "Discount", "GenderId", "Image", "Name", "Price" },
                values: new object[] { 1, 1, 1, "", 0, 2, "data:image/webp;base64,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", "Chanel Bleu de Chanel Parfum", 12592 });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductsId",
                table: "OrderProduct",
                column: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId1",
                table: "Orders",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId1",
                table: "Orders",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
