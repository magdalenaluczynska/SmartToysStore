using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartToysStore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "Image", "Link", "ModelCode", "Name", "Price", "Price100", "Price50" },
                values: new object[] { 5, "<p>This <strong>plush</strong> dog toy features a soft pink duck design with vibrant yellow beak and feet, making it an adorable and engaging playmate for your pet. <strong>Durable</strong> and <strong>lightweight</strong>, it&rsquo;s perfect for <strong>fetching</strong>, <strong>chewing</strong>, and <strong>cuddling</strong>, ensuring hours of fun for dogs of all sizes.</p>", "\\images\\product\\f8551ae3-8ccc-4f17-8b3f-8330ec9bda5e.jpg", "", "B09BBP8FP3", "Duck with Soft Squeaker", 45.0, 43.5, 44.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Description", "Image", "Link", "ModelCode", "Name", "Price", "Price100", "Price50" },
                values: new object[] { "Green", "<p>The dog toy <strong>opens</strong> in the middle and fill the dog <strong>treat</strong> tray with your dog's favorite foods or treats, pop it in the freezer, Pop the frozen treats in the toy for <strong>delicious</strong>, <strong>large </strong>capacity 6 cavities silicone dog treat tray can be used for l<strong>ong-lasting</strong> dog play.</p>", "\\images\\product\\6f8d1e45-0a58-46b5-9103-4a4cd8f333e4.jpg", "", "B0CQR9741Z", "Treat Dispensing Dog Toy", 80.0, 78.0, 79.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Color", "Description", "Image", "Link", "ModelCode", "Name", "Price", "Price100", "Price50" },
                values: new object[,]
                {
                    { 3, 1, "Multicolor", "<p style=\"list-style-type: disc;\">Interactive Dog Ball Toy is made of <strong>durable</strong>, <strong>non-toxic </strong>nylon and does not contain&nbsp;BPA. However, please note that it is not <strong>suitable </strong>for <strong>aggressive chewers</strong></p>  <p style=\"list-style-type: disc;\"><strong>Waterproof </strong>rating of IP54, suitable for both <strong>indoor </strong>and <strong>outdoor </strong>use and play</p>", "\\images\\product\\96564181-f9a3-484d-b11f-4ba4af827ac2.jpg", "", "B0CFXSQSKH", "Interactive Rolling Ball For Dogs", 75.0, 70.0, 72.0 },
                    { 4, 2, "Blue", "<p style=\"list-style-type: disc;\"><strong>Advanced</strong> dog puzzle &ndash; an interactive <strong>challenge </strong>for <strong>smart </strong>dogs, this treat game is great for pets who have mastered easier puzzles.</p>", "\\images\\product\\f5388d76-c917-47ea-abdb-02ccd5daabb7.jpg", "", "B0719Q89X8", "Interactive Treat Puzzle For Dog", 40.0, 36.0, 39.0 },
                    { 5, 4, "Black", "<p>The <strong>large </strong>water storage capacity allows owners to go out <strong>without worrying </strong>about their pets running out of water. <strong>Last </strong>about <strong>2-23 days </strong>for cat or dog use according to the pet's size.</p>", "\\images\\product\\df552834-a21f-4736-a3c6-f0caa3a48fd4.jpg", "", "B0CJR8KM2Y", "7L Dog and Cat Water Dispenser", 120.0, 110.0, 115.0 },
                    { 6, 5, "Multicolor", "<p>Fuufome plush dog toys features a reali<strong>stic cartoon design that will keep your dog interested and satisfies the dog&rsquo;s natural urge to chew.This large dog toys can accompany your dog for a fun tim</strong>e. Large dog plush toys length is 13.5 inch, perfect pet dog toys</p>", "\\images\\product\\c61e0a9c-9618-44c3-853f-91de4103932b.jpg", "", "B0B1LVKG8D", "Octopus Plush Toy For Dog", 30.0, 27.0, 28.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "Image", "Link", "ModelCode", "Name", "Price", "Price100", "Price50" },
                values: new object[] { 2, "This interactive dog puzzle toy provides an entertaining brain game for puppies and cats. It encourages and trains your pets to seek food by sliding the parts, helping them increase their IQ through learning sequential steps and engaging in challenging play.", "https://m.media-amazon.com/images/I/71XFp-kRtGL._AC_SL1500_.jpg", "https://www.amazon.com/SYNATANA-Enrichment-Stimulation-Training-Dispense/dp/B0DCYYX4LR/ref=sr_1_1_sspa?crid=2R31LDUSIGVE6&dib=eyJ2IjoiMSJ9.27vy3bjlY6X8DSfw2qzdQ6IqxI8zm5keAnRoAwpuDcDwwMbGxlTe_WGX7Tfc7CnMECjp4JtxnnmE304bJJ97tWOAg7Gr5v9XBiRyK97zTEPBNctjbyuISDXCg0CpBvqb6jrGTKmCPypFnHk9_h9yTurRDC7bbaoJ4ejKyt9XI5njVtzqlIo9D-lTgI134LxnPJNKfEjTorKbzH5bgHiEAcFYGsd1gE41ZMPtqYfGwO3p-UhYjK-c4tbrCg99EOj9IxQ1zjyKVAj76WmabSNGrOa3Vc3Bkv3Xij_o9uFHIvg.jw4pl-sO9G1ILQzGEcYLfbQBiYMKiElc3Z_5Oqs3OV0&dib_tag=se&keywords=dogs%2Btoys%2Bsmart&qid=1732174403&sprefix=dogs%2Btoys%2Bsmar%2Caps%2C176&sr=8-1-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&th=1", "B0DCYYX4LR", "Dog Puzzle Toy", 10.0, 9.5, 9.8000000000000007 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Description", "Image", "Link", "ModelCode", "Name", "Price", "Price100", "Price50" },
                values: new object[] { "Yellow", "Testestestestest", "testIMAGE", "testLINK", "Testcode", "TEST Toy", 111.5, 110.0, 110.8 });
        }
    }
}
