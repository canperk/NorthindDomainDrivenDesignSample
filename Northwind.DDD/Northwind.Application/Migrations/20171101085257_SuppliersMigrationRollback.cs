using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Northwind.Application.Migrations
{
    public partial class SuppliersMigrationRollback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupplierId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SupplierId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SupplierId1",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupplierId1",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId1",
                table: "Products",
                column: "SupplierId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupplierId1",
                table: "Products",
                column: "SupplierId1",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
