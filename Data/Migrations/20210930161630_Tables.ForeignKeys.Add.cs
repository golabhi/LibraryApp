using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryApp.Data.Migrations
{
    public partial class TablesForeignKeysAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DepatmentId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepatmentId",
                table: "Students",
                column: "DepatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_DepatmentId",
                table: "Books",
                column: "DepatmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Departments_DepatmentId",
                table: "Books",
                column: "DepatmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepatmentId",
                table: "Students",
                column: "DepatmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Departments_DepatmentId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepatmentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepatmentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Books_DepatmentId",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "DepatmentId",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
