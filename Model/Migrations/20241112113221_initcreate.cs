using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    /// <inheritdoc />
    public partial class initcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BOOKDETAILS",
                columns: table => new
                {
                    BOOKID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TOTALCOPIES = table.Column<int>(type: "int", nullable: false),
                    BORROWEDCOPIES = table.Column<int>(type: "int", nullable: false),
                    AVAILABLECOPIES = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOOKDETAILS", x => x.BOOKID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PERSONS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FIRSTNAME = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LASTNAME = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATEOFBIRTH = table.Column<DateTime>(type: "datetime(6)", rowVersion: true, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSONS", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AUTHORS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    BIOGRAPHY = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUTHORS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AUTHORS_PERSONS_ID",
                        column: x => x.ID,
                        principalTable: "PERSONS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CUSTOMERS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    MEMBERSHIPDATE = table.Column<DateTime>(type: "datetime(6)", rowVersion: true, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMERS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CUSTOMERS_PERSONS_ID",
                        column: x => x.ID,
                        principalTable: "PERSONS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LIBRARIANS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    EMPLOYEEID = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIBRARIANS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LIBRARIANS_PERSONS_ID",
                        column: x => x.ID,
                        principalTable: "PERSONS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BOOKS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TITLE = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AUTHOR = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PUBLISHEDDATE = table.Column<DateTime>(type: "datetime(6)", rowVersion: true, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    ISBN = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BOOKDETAILSID = table.Column<int>(type: "int", nullable: false),
                    AUTHORID = table.Column<int>(type: "int", nullable: false),
                    ItemType = table.Column<string>(type: "varchar(21)", maxLength: 21, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOOKS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BOOKS_AUTHORS_AUTHORID",
                        column: x => x.AUTHORID,
                        principalTable: "AUTHORS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOOKS_BOOKDETAILS_BOOKDETAILSID",
                        column: x => x.BOOKDETAILSID,
                        principalTable: "BOOKDETAILS",
                        principalColumn: "BOOKID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BOOKLOANS",
                columns: table => new
                {
                    BOOKID = table.Column<int>(type: "int", nullable: false),
                    CUSTOMERID = table.Column<int>(type: "int", nullable: false),
                    LOANDATE = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LIBRARIANID = table.Column<int>(type: "int", nullable: false),
                    DUEDATE = table.Column<DateTime>(type: "datetime(6)", rowVersion: true, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    RETURNLIBRARIANID = table.Column<int>(type: "int", nullable: true),
                    RETURNDATE = table.Column<DateTime>(type: "datetime(6)", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOOKLOANS", x => new { x.BOOKID, x.CUSTOMERID, x.LIBRARIANID, x.LOANDATE });
                    table.ForeignKey(
                        name: "FK_BOOKLOANS_BOOKS_BOOKID",
                        column: x => x.BOOKID,
                        principalTable: "BOOKS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOOKLOANS_CUSTOMERS_CUSTOMERID",
                        column: x => x.CUSTOMERID,
                        principalTable: "CUSTOMERS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOOKLOANS_LIBRARIANS_LIBRARIANID",
                        column: x => x.LIBRARIANID,
                        principalTable: "LIBRARIANS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOOKLOANS_LIBRARIANS_RETURNLIBRARIANID",
                        column: x => x.RETURNLIBRARIANID,
                        principalTable: "LIBRARIANS",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_BOOKLOANS_CUSTOMERID",
                table: "BOOKLOANS",
                column: "CUSTOMERID");

            migrationBuilder.CreateIndex(
                name: "IX_BOOKLOANS_LIBRARIANID",
                table: "BOOKLOANS",
                column: "LIBRARIANID");

            migrationBuilder.CreateIndex(
                name: "IX_BOOKLOANS_RETURNLIBRARIANID",
                table: "BOOKLOANS",
                column: "RETURNLIBRARIANID");

            migrationBuilder.CreateIndex(
                name: "IX_BOOKS_AUTHORID",
                table: "BOOKS",
                column: "AUTHORID");

            migrationBuilder.CreateIndex(
                name: "IX_BOOKS_BOOKDETAILSID",
                table: "BOOKS",
                column: "BOOKDETAILSID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BOOKLOANS");

            migrationBuilder.DropTable(
                name: "BOOKS");

            migrationBuilder.DropTable(
                name: "CUSTOMERS");

            migrationBuilder.DropTable(
                name: "LIBRARIANS");

            migrationBuilder.DropTable(
                name: "AUTHORS");

            migrationBuilder.DropTable(
                name: "BOOKDETAILS");

            migrationBuilder.DropTable(
                name: "PERSONS");
        }
    }
}
