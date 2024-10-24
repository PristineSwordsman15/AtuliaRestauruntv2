﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtuliaRestauruntv2.Migrations
{
    /// <inheritdoc />
    public partial class ProductNameCreateOrderForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductNames",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductNames",
                table: "Orders");
        }
    }
}