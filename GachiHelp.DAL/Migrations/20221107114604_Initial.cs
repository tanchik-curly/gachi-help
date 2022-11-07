using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GachiHelp.WebApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<byte>(type: "tinyint", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Login", "PasswordHash", "Role" },
                values: new object[,]
                {
                    { 1, "admin", "jGl25bVBBBW96Qi9Te4V37Fnqchz/Eu4qB9vKrRIqRg=", (byte)2 },
                    { 2, "tetiana", "6CspveltJTmkFUyGQHoHoSqEUONXJxl9gfpqB0e3dRY=", (byte)1 },
                    { 3, "jamal", "V7RyvfLPlnqKm4YnF74M/M1SYBIYIwdsm803Yr8aAJY=", (byte)1 },
                    { 4, "mykola", "wc+AFYFvnpXjMPddFzv5dQFcttUDH8g7/RuSoVZrTVQ=", (byte)2 },
                    { 5, "ivan", "zQuUUvw3b8TDWmAIezZvcNiD/JAVJNrx8SL70xk4T2o=", (byte)2 },
                    { 6, "olexandr", "aTT/kX//SexsFTyQKnOqTrvI9/0DR/Tw/KMJnwOkfok=", (byte)2 },
                    { 7, "vitaliy", "RGyTMh1A9dYEEPWj0vaLAitmPM5pmywYrJ7y7zoY6MY=", (byte)2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
