using Microsoft.EntityFrameworkCore.Migrations;

namespace e_movie.Migrations
{
    public partial class newT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComedyId",
                table: "Movies",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Comedys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilePictureURL = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    Bio = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comedys", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ComedyId",
                table: "Movies",
                column: "ComedyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Comedys_ComedyId",
                table: "Movies",
                column: "ComedyId",
                principalTable: "Comedys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Comedys_ComedyId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Comedys");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ComedyId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ComedyId",
                table: "Movies");
        }
    }
}
