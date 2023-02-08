using Microsoft.EntityFrameworkCore.Migrations;

namespace e_movie.Migrations
{
    public partial class NameFixProducer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producerss_ProducerId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producerss",
                table: "Producerss");

            migrationBuilder.RenameTable(
                name: "Producerss",
                newName: "Producers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producers",
                table: "Producers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producers",
                table: "Producers");

            migrationBuilder.RenameTable(
                name: "Producers",
                newName: "Producerss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producerss",
                table: "Producerss",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producerss_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "Producerss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
