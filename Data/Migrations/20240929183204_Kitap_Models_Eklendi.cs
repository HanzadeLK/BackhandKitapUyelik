using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BHPKitapUyelik.Data.Migrations
{
    /// <inheritdoc />
    public partial class Kitap_Models_Eklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    KitapId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Yazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SayfaSayisi = table.Column<int>(type: "int", nullable: false),
                    YayinEvi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasimYili = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.KitapId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kitaplar");
        }
    }
}
