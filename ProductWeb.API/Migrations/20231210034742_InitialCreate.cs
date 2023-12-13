using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductWeb.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "ID", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Introducing the only foundation a girl will ever need for a Matte Golden Complexion!", "/Images/TNK-foundation-3.jpg", "Thanakha Perfect Liquid to Powder Foundation", 11500m },
                    { 2, "Thanakha Loose Mineral Powder weightlessly locks in make-up for perfect long-lasting wear with a flawless, pore-less finish creating a modern, velvety matte look with a touch of sheer coverage, while Natural Thanakha essence absorbs excess oil allowing you to be Selfie Perfect and HD ready all day.", "/Images/Thanakha Powder Pact.png", "Thanakha Powder Pact", 8690m },
                    { 3, "our skin will look and feel radiant, refreshed, and soft - so you wake up with soft, glowing skin! ", "/Images/Thanakha Water Recharging Sleeping Mask - Night Cream - Old.jpg", "Thanakha Water Recharging Sleeping Mask - Night Cream - Old", 11500m },
                    { 4, "Makeup palette collaboration with Moguk Pauk Pauk, leading fashion designer and makeup artist.", "/Images/Perfect Look in a Palette.jpeg", "Perfect Look in a Palette", 6550m },
                    { 5, "Rejuvenate and refresh your spirit with a spritz of Bella Perfumes. Easy to carry, travel-friendly size.", "/Images/Perfume.jpeg", "Perfume", 5950m },
                    { 6, "Foundation fit for a Superstar – specially made for Superstars who need to look perfect all day and night.", "/Images/Superstar Perfect Matte Foundation.png", "Superstar Perfect Matte Foundation", 14500m },
                    { 7, "Suitable for All Skin Types.Alcohol-Free. Paraben-Free.", "/Images/Bella Serum Sheet Mask.jpeg", "Bella Serum Sheet Maskn", 2050m },
                    { 8, "Wake up to juicy skin: nourished, renewed, glowing.", "/Images/Watermelon Jelly Night Cream.jpeg", "Watermelon Jelly Night Cream", 11500m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
