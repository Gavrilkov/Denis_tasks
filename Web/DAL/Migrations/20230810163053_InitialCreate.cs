using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LibraryMember",
                columns: table => new
                {
                    MemberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryMember", x => x.MemberID);
                });

            migrationBuilder.CreateTable(
                name: "LibraryTransaction",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DueDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    MemberID1 = table.Column<int>(type: "int", nullable: false),
                    BookIDId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryTransaction", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_LibraryTransaction_Book_BookIDId",
                        column: x => x.BookIDId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibraryTransaction_LibraryMember_MemberID1",
                        column: x => x.MemberID1,
                        principalTable: "LibraryMember",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LibraryTransaction_BookIDId",
                table: "LibraryTransaction",
                column: "BookIDId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryTransaction_MemberID1",
                table: "LibraryTransaction",
                column: "MemberID1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibraryTransaction");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "LibraryMember");
        }
    }
}
