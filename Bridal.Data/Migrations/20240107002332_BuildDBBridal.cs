using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bridal.Data.Migrations
{
    public partial class BuildDBBridal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dressmaker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    experience = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dressmaker", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bridal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateWedding = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dressmakerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bridal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bridal_Dressmaker_dressmakerId",
                        column: x => x.dressmakerId,
                        principalTable: "Dressmaker",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QueueBridal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bridalId = table.Column<int>(type: "int", nullable: false),
                    DateQueue = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueueBridal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QueueBridal_Bridal_bridalId",
                        column: x => x.bridalId,
                        principalTable: "Bridal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bridal_dressmakerId",
                table: "Bridal",
                column: "dressmakerId");

            migrationBuilder.CreateIndex(
                name: "IX_QueueBridal_bridalId",
                table: "QueueBridal",
                column: "bridalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QueueBridal");

            migrationBuilder.DropTable(
                name: "Bridal");

            migrationBuilder.DropTable(
                name: "Dressmaker");
        }
    }
}
