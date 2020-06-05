using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema.De.Facturacion.Web.Migrations
{
    public partial class iniciadb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    ID_Doc = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Documento = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.ID_Doc);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Position_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Position_Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Position_Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Customer_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreC = table.Column<string>(maxLength: 30, nullable: false),
                    ApellidoC = table.Column<string>(maxLength: 30, nullable: false),
                    ID_Doc = table.Column<int>(nullable: false),
                    Document = table.Column<string>(maxLength: 50, nullable: false),
                    TelefonC = table.Column<string>(maxLength: 15, nullable: false),
                    Correo = table.Column<string>(nullable: false),
                    DireccionC = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Customer_Id);
                    table.ForeignKey(
                        name: "FK_Customer_Document_ID_Doc",
                        column: x => x.ID_Doc,
                        principalTable: "Document",
                        principalColumn: "ID_Doc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Employe_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo_Empleado = table.Column<int>(nullable: false),
                    Employee_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Employee_Lastname = table.Column<string>(maxLength: 50, nullable: false),
                    ID_Doc = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(maxLength: 20, nullable: true),
                    Cellphone = table.Column<string>(maxLength: 20, nullable: true),
                    Extension = table.Column<string>(maxLength: 6, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Position_Id = table.Column<int>(nullable: false),
                    Fecha_Ingreso = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Employe_Id);
                    table.ForeignKey(
                        name: "FK_Employee_Document_ID_Doc",
                        column: x => x.ID_Doc,
                        principalTable: "Document",
                        principalColumn: "ID_Doc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Position_Position_Id",
                        column: x => x.Position_Id,
                        principalTable: "Position",
                        principalColumn: "Position_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ID_Doc",
                table: "Customer",
                column: "ID_Doc");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ID_Doc",
                table: "Employee",
                column: "ID_Doc");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Position_Id",
                table: "Employee",
                column: "Position_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Position");
        }
    }
}
