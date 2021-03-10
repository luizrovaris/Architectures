using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerRelationship.Entity.Migrations
{
    public partial class FirstVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AddressLine1 = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: false),
                    AddressLine2 = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    PostalCode = table.Column<string>(type: "varchar(15) CHARACTER SET utf8mb4", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: false),
                    FederalIdentification = table.Column<string>(type: "varchar(25) CHARACTER SET utf8mb4", maxLength: 25, nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Billings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InvoiceNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    EmissionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Description = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    Value = table.Column<decimal>(type: "decimal(19,2)", nullable: false),
                    ReceiptValue = table.Column<decimal>(type: "decimal(19,2)", nullable: true),
                    IncreasedValue = table.Column<decimal>(type: "decimal(19,2)", nullable: true),
                    DiscountValue = table.Column<decimal>(type: "decimal(19,2)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Billings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(150) CHARACTER SET utf8mb4", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "varchar(150) CHARACTER SET utf8mb4", maxLength: 150, nullable: false),
                    Phone = table.Column<string>(type: "varchar(18) CHARACTER SET utf8mb4", maxLength: 18, nullable: true),
                    CellPhone = table.Column<string>(type: "varchar(18) CHARACTER SET utf8mb4", maxLength: 18, nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Billings_CustomerId",
                table: "Billings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CustomerId",
                table: "Contacts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddressId",
                table: "Customers",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Billings");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
