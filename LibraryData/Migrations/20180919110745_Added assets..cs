using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class Addedassets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Branches_BranchId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Statuses_StatusId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistories_Asset_AssetId",
                table: "CheckoutHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_Asset_AssetId",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Holds_Asset_AssetId",
                table: "Holds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Asset",
                table: "Asset");

            migrationBuilder.RenameTable(
                name: "Asset",
                newName: "Assets");

            migrationBuilder.RenameIndex(
                name: "IX_Asset_StatusId",
                table: "Assets",
                newName: "IX_Assets_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Asset_BranchId",
                table: "Assets",
                newName: "IX_Assets_BranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assets",
                table: "Assets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Branches_BranchId",
                table: "Assets",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Statuses_StatusId",
                table: "Assets",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistories_Assets_AssetId",
                table: "CheckoutHistories",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_Assets_AssetId",
                table: "Checkouts",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Holds_Assets_AssetId",
                table: "Holds",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Branches_BranchId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Statuses_StatusId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistories_Assets_AssetId",
                table: "CheckoutHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_Assets_AssetId",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Holds_Assets_AssetId",
                table: "Holds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assets",
                table: "Assets");

            migrationBuilder.RenameTable(
                name: "Assets",
                newName: "Asset");

            migrationBuilder.RenameIndex(
                name: "IX_Assets_StatusId",
                table: "Asset",
                newName: "IX_Asset_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Assets_BranchId",
                table: "Asset",
                newName: "IX_Asset_BranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Asset",
                table: "Asset",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Branches_BranchId",
                table: "Asset",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Statuses_StatusId",
                table: "Asset",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistories_Asset_AssetId",
                table: "CheckoutHistories",
                column: "AssetId",
                principalTable: "Asset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_Asset_AssetId",
                table: "Checkouts",
                column: "AssetId",
                principalTable: "Asset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Holds_Asset_AssetId",
                table: "Holds",
                column: "AssetId",
                principalTable: "Asset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
