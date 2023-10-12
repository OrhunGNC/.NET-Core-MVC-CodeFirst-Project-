using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DOTNET_Core_Project.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hastanelers",
                columns: table => new
                {
                    HastaneNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HastaneAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HastaneTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CalisanSayisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SorumluKisi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hastanelers", x => x.HastaneNo);
                });

            migrationBuilder.CreateTable(
                name: "turlers",
                columns: table => new
                {
                    TurNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TurAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurSayisi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_turlers", x => x.TurNo);
                });

            migrationBuilder.CreateTable(
                name: "veterinerlers",
                columns: table => new
                {
                    VeterinerNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VeterinerAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maas = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VeterinerTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HastaneNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veterinerlers", x => x.VeterinerNo);
                    table.ForeignKey(
                        name: "FK_veterinerlers_hastanelers_HastaneNo",
                        column: x => x.HastaneNo,
                        principalTable: "hastanelers",
                        principalColumn: "HastaneNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "petss",
                columns: table => new
                {
                    PetNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PetHastalik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PetYas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_petss", x => x.PetNo);
                    table.ForeignKey(
                        name: "FK_petss_turlers_TurNo",
                        column: x => x.TurNo,
                        principalTable: "turlers",
                        principalColumn: "TurNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "musterilers",
                columns: table => new
                {
                    MusteriNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PetNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_musterilers", x => x.MusteriNo);
                    table.ForeignKey(
                        name: "FK_musterilers_petss_PetNo",
                        column: x => x.PetNo,
                        principalTable: "petss",
                        principalColumn: "PetNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "randevulars",
                columns: table => new
                {
                    RandevuNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RandevuSaati = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RandevuTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MusteriNo = table.Column<int>(type: "int", nullable: false),
                    VeterinerNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_randevulars", x => x.RandevuNo);
                    table.ForeignKey(
                        name: "FK_randevulars_musterilers_MusteriNo",
                        column: x => x.MusteriNo,
                        principalTable: "musterilers",
                        principalColumn: "MusteriNo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_randevulars_veterinerlers_VeterinerNo",
                        column: x => x.VeterinerNo,
                        principalTable: "veterinerlers",
                        principalColumn: "VeterinerNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_musterilers_PetNo",
                table: "musterilers",
                column: "PetNo");

            migrationBuilder.CreateIndex(
                name: "IX_petss_TurNo",
                table: "petss",
                column: "TurNo");

            migrationBuilder.CreateIndex(
                name: "IX_randevulars_MusteriNo",
                table: "randevulars",
                column: "MusteriNo");

            migrationBuilder.CreateIndex(
                name: "IX_randevulars_VeterinerNo",
                table: "randevulars",
                column: "VeterinerNo");

            migrationBuilder.CreateIndex(
                name: "IX_veterinerlers_HastaneNo",
                table: "veterinerlers",
                column: "HastaneNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "randevulars");

            migrationBuilder.DropTable(
                name: "musterilers");

            migrationBuilder.DropTable(
                name: "veterinerlers");

            migrationBuilder.DropTable(
                name: "petss");

            migrationBuilder.DropTable(
                name: "hastanelers");

            migrationBuilder.DropTable(
                name: "turlers");
        }
    }
}
