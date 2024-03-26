using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CamposDealerMVC.Migrations
{
    public partial class CriandoTabelasDoSistema1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLIENTE",
                columns: table => new
                {
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CIDADE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTE", x => x.ID_CLIENTE);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTO",
                columns: table => new
                {
                    ID_PRODUTO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRICAO_PRODUTO = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    VALOR_UNITARIO = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTO", x => x.ID_PRODUTO);
                });

            migrationBuilder.CreateTable(
                name: "VENDA",
                columns: table => new
                {
                    ID_VENDA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_PRODUTO = table.Column<int>(type: "int", nullable: false),
                    QTD_VENDA = table.Column<long>(type: "bigint", nullable: false),
                    VLR_UNITARIO_VENDA = table.Column<long>(type: "bigint", nullable: false),
                    DATA_VENDA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VLR_TOTAL_VENDA = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VENDA", x => x.ID_VENDA);
                    table.ForeignKey(
                        name: "FK_VENDA_CLIENTE_ID_CLIENTE",
                        column: x => x.ID_CLIENTE,
                        principalTable: "CLIENTE",
                        principalColumn: "ID_CLIENTE",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VENDA_PRODUTO_ID_PRODUTO",
                        column: x => x.ID_PRODUTO,
                        principalTable: "PRODUTO",
                        principalColumn: "ID_PRODUTO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VENDA_ID_CLIENTE",
                table: "VENDA",
                column: "ID_CLIENTE");

            migrationBuilder.CreateIndex(
                name: "IX_VENDA_ID_PRODUTO",
                table: "VENDA",
                column: "ID_PRODUTO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VENDA");

            migrationBuilder.DropTable(
                name: "CLIENTE");

            migrationBuilder.DropTable(
                name: "PRODUTO");
        }
    }
}
