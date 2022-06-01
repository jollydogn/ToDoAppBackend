using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoApp.DataAccess.Migrations
{
    public partial class initalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "toDos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    todo = table.Column<string>(maxLength: 200, nullable: true),
                    createAt = table.Column<DateTime>(nullable: false),
                    updateAt = table.Column<DateTime>(nullable: false),
                    category = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toDos", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "toDos");
        }
    }
}
