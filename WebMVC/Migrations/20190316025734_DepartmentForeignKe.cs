using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMVC.Migrations
{
    public partial class DepartmentForeignKe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departments_Departmentsid",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "Departmentsid",
                table: "Seller",
                newName: "DepartmentsId");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_Departmentsid",
                table: "Seller",
                newName: "IX_Seller_DepartmentsId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentsId",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departments_DepartmentsId",
                table: "Seller",
                column: "DepartmentsId",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departments_DepartmentsId",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "DepartmentsId",
                table: "Seller",
                newName: "Departmentsid");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DepartmentsId",
                table: "Seller",
                newName: "IX_Seller_Departmentsid");

            migrationBuilder.AlterColumn<int>(
                name: "Departmentsid",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Seller",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departments_Departmentsid",
                table: "Seller",
                column: "Departmentsid",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
