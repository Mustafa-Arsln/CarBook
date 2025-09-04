﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mid_add_comment_email : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EMail",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EMail",
                table: "Comments");
        }
    }
}
