using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HPlusSport.Security.Web.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hash", "Password", "Salt" },
                values: new object[] { "WMut3QlwLJMXQC5ruk9dWpLhKts=", "", "qTTkQgS6ksz3D7P6qNjbGWJmDxMp53CzsM4FpZDExXg=" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hash", "Password", "Salt" },
                values: new object[] { "aPnpdCdqU/ugdsmajYsRsCYjyyo=", "", "8Oe0cd5GG5IznafXJrvvvhKmedFSW5w2YfOdNf3WKuc=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Hash", "Password", "Salt" },
                values: new object[] { "", "Adam's secret", "" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Hash", "Password", "Salt" },
                values: new object[] { "", "b@rb@r@", "" });
        }
    }
}
