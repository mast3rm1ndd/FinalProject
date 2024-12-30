using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tblDersler",
                columns: new[] { "DersID", "DersAd", "DersKod" },
                values: new object[,]
                {
                    { 1, "Nesne Tabanlı Programlama", "001" },
                    { 2, "Veritabanı", "002" },
                    { 3, "Görsel Programlama", "003" },
                    { 4, "Web Programlama", "004" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblDersler",
                keyColumn: "DersID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblDersler",
                keyColumn: "DersID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblDersler",
                keyColumn: "DersID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblDersler",
                keyColumn: "DersID",
                keyValue: 4);
        }
    }
}
