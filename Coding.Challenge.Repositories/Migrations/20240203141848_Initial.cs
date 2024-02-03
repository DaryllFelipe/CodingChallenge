using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Coding.Challenge.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PublishDateUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CategoryId", "Description", "PublishDateUtc", "Title" },
                values: new object[,]
                {
                    { 1L, 1L, "First Book", new DateTimeOffset(new DateTime(2024, 2, 3, 14, 18, 48, 261, DateTimeKind.Unspecified).AddTicks(6090), new TimeSpan(0, 0, 0, 0, 0)), "Book #1" },
                    { 2L, 1L, "Second Book", new DateTimeOffset(new DateTime(2024, 2, 3, 14, 18, 48, 261, DateTimeKind.Unspecified).AddTicks(6093), new TimeSpan(0, 0, 0, 0, 0)), "Book #2" },
                    { 3L, 2L, "Third Book", new DateTimeOffset(new DateTime(2024, 2, 3, 14, 18, 48, 261, DateTimeKind.Unspecified).AddTicks(6094), new TimeSpan(0, 0, 0, 0, 0)), "Book #3" },
                    { 4L, 2L, "Fourth Book", new DateTimeOffset(new DateTime(2024, 2, 3, 14, 18, 48, 261, DateTimeKind.Unspecified).AddTicks(6095), new TimeSpan(0, 0, 0, 0, 0)), "Book #4" },
                    { 5L, 3L, "Fifth Book", new DateTimeOffset(new DateTime(2024, 2, 3, 14, 18, 48, 261, DateTimeKind.Unspecified).AddTicks(6096), new TimeSpan(0, 0, 0, 0, 0)), "Book #5" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "First Category" },
                    { 2L, "Second Category" },
                    { 3L, "Third Category" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
