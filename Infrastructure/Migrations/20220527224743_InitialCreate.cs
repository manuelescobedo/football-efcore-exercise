using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Ground = table.Column<string>(type: "TEXT", nullable: false),
                    Visitor = table.Column<string>(type: "TEXT", nullable: false),
                    Local = table.Column<string>(type: "TEXT", nullable: false),
                    VisitorScore = table.Column<int>(type: "INTEGER", nullable: false),
                    LocalScore = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 1, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canada", "Canada", 2, "Mexico", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 2, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canada", "Canada", 2, "United States", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 3, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canada", "Canada", 1, "Costa Rica", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 4, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canada", "Canada", 4, "Panama", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 5, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canada", "Canada", 4, "Jamaica", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 6, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canada", "Canada", 3, "El Salvador", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 7, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canada", "Canada", 1, "Honduras", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 8, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexico", "Mexico", 1, "Canada", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 9, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexico", "Mexico", 0, "United States", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 10, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexico", "Mexico", 0, "Costa Rica", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 11, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexico", "Mexico", 1, "Panama", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 12, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexico", "Mexico", 2, "Jamaica", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 13, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexico", "Mexico", 2, "El Salvador", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 14, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexico", "Mexico", 3, "Honduras", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 15, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States", "United States", 1, "Canada", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 16, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States", "United States", 2, "Mexico", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 17, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States", "United States", 2, "Costa Rica", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 18, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States", "United States", 5, "Panama", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 19, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States", "United States", 2, "Jamaica", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 20, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States", "United States", 1, "El Salvador", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 21, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "United States", "United States", 3, "Honduras", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 22, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Costa Rica", "Costa Rica", 1, "Canada", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 23, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Costa Rica", "Costa Rica", 0, "Mexico", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 24, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Costa Rica", "Costa Rica", 2, "United States", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 25, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Costa Rica", "Costa Rica", 1, "Panama", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 26, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Costa Rica", "Costa Rica", 1, "Jamaica", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 27, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Costa Rica", "Costa Rica", 2, "El Salvador", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 28, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Costa Rica", "Costa Rica", 2, "Honduras", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 29, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panama", "Panama", 1, "Canada", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 30, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panama", "Panama", 1, "Mexico", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 31, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panama", "Panama", 1, "United States", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 32, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panama", "Panama", 0, "Costa Rica", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 33, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panama", "Panama", 3, "Jamaica", 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 34, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panama", "Panama", 2, "El Salvador", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 35, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panama", "Panama", 1, "Honduras", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 36, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jamaica", "Jamaica", 0, "Canada", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 37, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jamaica", "Jamaica", 1, "Mexico", 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 38, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jamaica", "Jamaica", 1, "United States", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 39, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jamaica", "Jamaica", 0, "Costa Rica", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 40, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jamaica", "Jamaica", 0, "Panama", 3 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 41, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jamaica", "Jamaica", 1, "El Salvador", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 42, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jamaica", "Jamaica", 2, "Honduras", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 43, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "El Salvador", "El Salvador", 0, "Canada", 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 44, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "El Salvador", "El Salvador", 0, "Mexico", 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 45, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "El Salvador", "El Salvador", 0, "United States", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 46, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "El Salvador", "El Salvador", 1, "Costa Rica", 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 47, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "El Salvador", "El Salvador", 1, "Panama", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 48, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "El Salvador", "El Salvador", 1, "Jamaica", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 49, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "El Salvador", "El Salvador", 0, "Honduras", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 50, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honduras", "Honduras", 0, "Canada", 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 51, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honduras", "Honduras", 0, "Mexico", 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 52, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honduras", "Honduras", 1, "United States", 4 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 53, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honduras", "Honduras", 0, "Costa Rica", 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 54, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honduras", "Honduras", 2, "Panama", 3 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 55, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honduras", "Honduras", 0, "Jamaica", 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "ID", "Date", "Ground", "Local", "LocalScore", "Visitor", "VisitorScore" },
                values: new object[] { 56, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honduras", "Honduras", 0, "El Salvador", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
