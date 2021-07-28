using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiabetesControl.Data.Migrations
{
    public partial class diabetesInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NutritionalMeasures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MeasureAverage = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Quantity = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionalMeasures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NutritiveValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CarbohdrateValue = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ProteinValue = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    FatValue = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritiveValue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    NutritiveGroup = table.Column<int>(type: "int", nullable: false),
                    NutritiveValueId = table.Column<int>(type: "int", nullable: false),
                    NutritionalMeasureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_NutritionalMeasures_NutritionalMeasureId",
                        column: x => x.NutritionalMeasureId,
                        principalTable: "NutritionalMeasures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Foods_NutritiveValue_NutritiveValueId",
                        column: x => x.NutritiveValueId,
                        principalTable: "NutritiveValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_NutritionalMeasureId",
                table: "Foods",
                column: "NutritionalMeasureId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_NutritiveValueId",
                table: "Foods",
                column: "NutritiveValueId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "NutritionalMeasures");

            migrationBuilder.DropTable(
                name: "NutritiveValue");
        }
    }
}
