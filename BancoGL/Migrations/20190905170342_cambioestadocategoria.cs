using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoGL.Migrations
{
    public partial class cambioestadocategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Estado",
                table: "Producto",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Estado",
                table: "Producto",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
