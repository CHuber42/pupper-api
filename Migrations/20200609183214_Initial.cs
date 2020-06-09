using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pupper.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doggos",
                columns: table => new
                {
                    DoggoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Breed = table.Column<string>(maxLength: 20, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    PicUrl = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doggos", x => x.DoggoId);
                });

            migrationBuilder.InsertData(
                table: "Doggos",
                columns: new[] { "DoggoId", "Age", "Breed", "Gender", "Name", "PicUrl" },
                values: new object[] { 1, 7, "Mutt", "Female", "Matilda", "https://t1.ea.ltmcdn.com/en/images/4/0/0/small_white_dog_breeds_3004_600.jpg" });

            migrationBuilder.InsertData(
                table: "Doggos",
                columns: new[] { "DoggoId", "Age", "Breed", "Gender", "Name", "PicUrl" },
                values: new object[] { 2, 11, "Dachshund", "Male", "Bagera", "https://i.pinimg.com/originals/0c/dc/6b/0cdc6b9ea47cdee8ff88c1d6c9e02ca7.jpg" });

            migrationBuilder.InsertData(
                table: "Doggos",
                columns: new[] { "DoggoId", "Age", "Breed", "Gender", "Name", "PicUrl" },
                values: new object[] { 3, 2, "Mutt", "Male", "Flash", "https://www.sciencesource.com/Doc/TR1_WATERMARKED/0/f/c/f/SS2695389.jpg?d63644087851" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doggos");
        }
    }
}
