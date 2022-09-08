using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvKur.Migrations
{
    public partial class _1032 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BayiUrunAdet",
                table: "Cartline",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "sepetId",
                table: "Cartline",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sepetUrunAdet",
                table: "Cartline",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cartline_sepetId",
                table: "Cartline",
                column: "sepetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cartline_sepet_sepetId",
                table: "Cartline",
                column: "sepetId",
                principalTable: "sepet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cartline_sepet_sepetId",
                table: "Cartline");

            migrationBuilder.DropIndex(
                name: "IX_Cartline_sepetId",
                table: "Cartline");

            migrationBuilder.DropColumn(
                name: "sepetId",
                table: "Cartline");

            migrationBuilder.DropColumn(
                name: "sepetUrunAdet",
                table: "Cartline");

            migrationBuilder.AlterColumn<int>(
                name: "BayiUrunAdet",
                table: "Cartline",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
