using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fms.Migrations
{
    public partial class updateselling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trSellingShipperDetail_mtVendor_vendorId",
                table: "trSellingShipperDetail");

            migrationBuilder.DropIndex(
                name: "IX_trSellingShipperDetail_vendorId",
                table: "trSellingShipperDetail");

            migrationBuilder.DropColumn(
                name: "payable",
                table: "trSellingShipperDetail");

            migrationBuilder.DropColumn(
                name: "refund",
                table: "trSellingShipperDetail");

            migrationBuilder.DropColumn(
                name: "refundType",
                table: "trSellingShipperDetail");

            migrationBuilder.DropColumn(
                name: "vendorId",
                table: "trSellingShipperDetail");

            migrationBuilder.AddColumn<int>(
                name: "containerId",
                table: "trSellingShipperDetailVendor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "currencyId",
                table: "trSellingShipperDetailVendor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "operationCost",
                table: "trSellingShipperDetailVendor",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "operationCostType",
                table: "trSellingShipperDetailVendor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "payable",
                table: "trSellingShipperDetailVendor",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "portOfDestinationId",
                table: "trSellingShipperDetailVendor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "category",
                table: "mtCurrencyRate",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "mtQuotation",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(maxLength: 50, nullable: false),
                    remark = table.Column<string>(maxLength: 500, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtQuotation", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "mtBank",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 93, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 93, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtBank",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 93, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 93, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtChartOfAccount",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtChartOfAccount",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtChartOfAccount",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtCountry",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 85, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 92, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtCountry",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 92, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 92, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtCurrency",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 93, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 93, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtCurrency",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 93, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 93, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 94, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysDocNo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 95, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 95, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysDocNo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 95, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 95, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysDocNo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 95, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 95, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 95, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 114, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysUser",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "password", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 113, DateTimeKind.Local), "cQeyR/6G59fwNXoKjkIPIkkXStwefY/E3yrAcfwA5IiqZCHj", new DateTime(2018, 12, 17, 19, 2, 10, 113, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysUserRole",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local), new DateTime(2018, 12, 17, 19, 2, 10, 96, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperDetailVendor_containerId",
                table: "trSellingShipperDetailVendor",
                column: "containerId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperDetailVendor_currencyId",
                table: "trSellingShipperDetailVendor",
                column: "currencyId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperDetailVendor_portOfDestinationId",
                table: "trSellingShipperDetailVendor",
                column: "portOfDestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_trSellingShipperDetailVendor_mtContainer_containerId",
                table: "trSellingShipperDetailVendor",
                column: "containerId",
                principalTable: "mtContainer",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trSellingShipperDetailVendor_mtCurrency_currencyId",
                table: "trSellingShipperDetailVendor",
                column: "currencyId",
                principalTable: "mtCurrency",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trSellingShipperDetailVendor_mtPortOfDestination_portOfDesti~",
                table: "trSellingShipperDetailVendor",
                column: "portOfDestinationId",
                principalTable: "mtPortOfDestination",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.InsertData(
               table: "sysModule",
               columns: new[] { "id", "code", "controller", "createdBy", "createdOn", "hasChild", "isActive", "level", "name", "orderModule", "parentId", "updatedBy", "updatedOn", "view" },
               values: new object[,]
               {
                    { 31, "Quotation", "Quotation", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Quotation", 29, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" }
               });

            migrationBuilder.InsertData(
               table: "sysModuleRole",
               columns: new[] { "id", "createdBy", "createdOn", "isActive", "isDefault", "moduleId", "updatedBy", "updatedOn", "userRoleId" },
               values: new object[,]
               {
                    { 31, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 31, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 }
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trSellingShipperDetailVendor_mtContainer_containerId",
                table: "trSellingShipperDetailVendor");

            migrationBuilder.DropForeignKey(
                name: "FK_trSellingShipperDetailVendor_mtCurrency_currencyId",
                table: "trSellingShipperDetailVendor");

            migrationBuilder.DropForeignKey(
                name: "FK_trSellingShipperDetailVendor_mtPortOfDestination_portOfDesti~",
                table: "trSellingShipperDetailVendor");

            migrationBuilder.DropTable(
                name: "mtQuotation");

            migrationBuilder.DropIndex(
                name: "IX_trSellingShipperDetailVendor_containerId",
                table: "trSellingShipperDetailVendor");

            migrationBuilder.DropIndex(
                name: "IX_trSellingShipperDetailVendor_currencyId",
                table: "trSellingShipperDetailVendor");

            migrationBuilder.DropIndex(
                name: "IX_trSellingShipperDetailVendor_portOfDestinationId",
                table: "trSellingShipperDetailVendor");

            migrationBuilder.DropColumn(
                name: "containerId",
                table: "trSellingShipperDetailVendor");

            migrationBuilder.DropColumn(
                name: "currencyId",
                table: "trSellingShipperDetailVendor");

            migrationBuilder.DropColumn(
                name: "operationCost",
                table: "trSellingShipperDetailVendor");

            migrationBuilder.DropColumn(
                name: "operationCostType",
                table: "trSellingShipperDetailVendor");

            migrationBuilder.DropColumn(
                name: "payable",
                table: "trSellingShipperDetailVendor");

            migrationBuilder.DropColumn(
                name: "portOfDestinationId",
                table: "trSellingShipperDetailVendor");

            migrationBuilder.DropColumn(
                name: "category",
                table: "mtCurrencyRate");

            migrationBuilder.AddColumn<string>(
                name: "payable",
                table: "trSellingShipperDetail",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "refund",
                table: "trSellingShipperDetail",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "refundType",
                table: "trSellingShipperDetail",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "vendorId",
                table: "trSellingShipperDetail",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "mtBank",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtBank",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtChartOfAccount",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtChartOfAccount",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtChartOfAccount",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtCountry",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 414, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 421, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtCountry",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtCurrency",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtCurrency",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysDocNo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 424, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 424, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysDocNo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 424, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 424, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysDocNo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 424, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 424, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysUser",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "password", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 447, DateTimeKind.Local), "XMj64dzz0qOMj2sA6LHbJ6E4aGxNP7gRRN9SYi48OA7E+iL3", new DateTime(2018, 11, 26, 19, 14, 38, 447, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysUserRole",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperDetail_vendorId",
                table: "trSellingShipperDetail",
                column: "vendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_trSellingShipperDetail_mtVendor_vendorId",
                table: "trSellingShipperDetail",
                column: "vendorId",
                principalTable: "mtVendor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
