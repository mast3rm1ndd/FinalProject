using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class InitFinalProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblDersler",
                columns: table => new
                {
                    DersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersKod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DersAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDersler", x => x.DersID);
                });

            migrationBuilder.CreateTable(
                name: "tblSiniflar",
                columns: table => new
                {
                    SinifID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinifAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kontenjan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSiniflar", x => x.SinifID);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    OgrenciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numara = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SinifID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.OgrenciID);
                    table.ForeignKey(
                        name: "FK_Ogrenciler_tblSiniflar_SinifID",
                        column: x => x.SinifID,
                        principalTable: "tblSiniflar",
                        principalColumn: "SinifID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblOgrenciDers",
                columns: table => new
                {
                    DersID = table.Column<int>(type: "int", nullable: false),
                    OgrenciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOgrenciDers", x => new { x.OgrenciID, x.DersID });
                    table.ForeignKey(
                        name: "FK_tblOgrenciDers_Ogrenciler_OgrenciID",
                        column: x => x.OgrenciID,
                        principalTable: "Ogrenciler",
                        principalColumn: "OgrenciID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblOgrenciDers_tblDersler_DersID",
                        column: x => x.DersID,
                        principalTable: "tblDersler",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tblSiniflar",
                columns: new[] { "SinifID", "Kontenjan", "SinifAd" },
                values: new object[,]
                {
                    { 1, 20, "1.Sınıf" },
                    { 2, 20, "2.Sınıf" },
                    { 3, 20, "3.Sınıf" },
                    { 4, 20, "4.Sınıf" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_SinifID",
                table: "Ogrenciler",
                column: "SinifID");

            migrationBuilder.CreateIndex(
                name: "IX_tblOgrenciDers_DersID",
                table: "tblOgrenciDers",
                column: "DersID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblOgrenciDers");

            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "tblDersler");

            migrationBuilder.DropTable(
                name: "tblSiniflar");
        }
    }
}
