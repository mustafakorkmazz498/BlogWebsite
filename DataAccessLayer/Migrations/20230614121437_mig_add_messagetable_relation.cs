﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class migaddmessagetablerelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages2",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<int>(type: "int", nullable: true),
                    ReceiverId = table.Column<int>(type: "int", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages2", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Messages2_Writers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Writers",
                        principalColumn: "WriterId");
                    table.ForeignKey(
                        name: "FK_Messages2_Writers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Writers",
                        principalColumn: "WriterId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages2_ReceiverId",
                table: "Messages2",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages2_SenderId",
                table: "Messages2",
                column: "SenderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages2");
        }
    }
}
