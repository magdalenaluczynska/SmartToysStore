using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartToysStore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductsTableAndSeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 7, 7, "Movers" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Description", "Image", "Link", "ModelCode", "Name", "Price", "Price100", "Price50" },
                values: new object[] { 1, "Pink", "This interactive dog puzzle toy provides an entertaining brain game for puppies and cats. It encourages and trains your pets to seek food by sliding the parts, helping them increase their IQ through learning sequential steps and engaging in challenging play.", "https://m.media-amazon.com/images/I/71XFp-kRtGL._AC_SL1500_.jpg", "https://www.amazon.com/SYNATANA-Enrichment-Stimulation-Training-Dispense/dp/B0DCYYX4LR/ref=sr_1_1_sspa?crid=2R31LDUSIGVE6&dib=eyJ2IjoiMSJ9.27vy3bjlY6X8DSfw2qzdQ6IqxI8zm5keAnRoAwpuDcDwwMbGxlTe_WGX7Tfc7CnMECjp4JtxnnmE304bJJ97tWOAg7Gr5v9XBiRyK97zTEPBNctjbyuISDXCg0CpBvqb6jrGTKmCPypFnHk9_h9yTurRDC7bbaoJ4ejKyt9XI5njVtzqlIo9D-lTgI134LxnPJNKfEjTorKbzH5bgHiEAcFYGsd1gE41ZMPtqYfGwO3p-UhYjK-c4tbrCg99EOj9IxQ1zjyKVAj76WmabSNGrOa3Vc3Bkv3Xij_o9uFHIvg.jw4pl-sO9G1ILQzGEcYLfbQBiYMKiElc3Z_5Oqs3OV0&dib_tag=se&keywords=dogs%2Btoys%2Bsmart&qid=1732174403&sprefix=dogs%2Btoys%2Bsmar%2Caps%2C176&sr=8-1-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&th=1", "B0DCYYX4LR", "Dog Puzzle Toy", 10.0, 9.5, 9.8000000000000007 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
