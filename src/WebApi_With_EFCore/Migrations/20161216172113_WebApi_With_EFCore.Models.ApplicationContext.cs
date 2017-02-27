using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_With_EFCore.Migrations
{
    public partial class WebApi_With_EFCoreModelsApplicationContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    AuthorName = table.Column<string>(maxLength: 100, nullable: false),
                    BookTitle = table.Column<string>(maxLength: 50, nullable: false),
                    Genre = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Publisher = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
