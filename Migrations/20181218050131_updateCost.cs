using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fms.Migrations
{
    public partial class updateCost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trCostShippingDetail_mtPortTerminal_portTerminalId",
                table: "trCostShippingDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_trCostShippingDetail_mtVendor_vendorId",
                table: "trCostShippingDetail");

            migrationBuilder.DropIndex(
                name: "IX_trCostShippingDetail_portTerminalId",
                table: "trCostShippingDetail");

            migrationBuilder.DropIndex(
                name: "IX_trCostShippingDetail_vendorId",
                table: "trCostShippingDetail");

            migrationBuilder.DropColumn(
                name: "payable",
                table: "trCostShippingDetail");

            migrationBuilder.DropColumn(
                name: "refund",
                table: "trCostShippingDetail");

            migrationBuilder.DropColumn(
                name: "refundType",
                table: "trCostShippingDetail");

            migrationBuilder.RenameColumn(
                name: "vendorId",
                table: "trCostShippingDetail",
                newName: "portTerminalType");

            migrationBuilder.AlterColumn<string>(
                name: "payable",
                table: "trSellingShipperDetailVendor",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "containerId",
                table: "trCostShippingDetailShipper",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "currencyId",
                table: "trCostShippingDetailShipper",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "operationMonitoring",
                table: "trCostShippingDetailShipper",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "operationMonitoringType",
                table: "trCostShippingDetailShipper",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "payable",
                table: "trCostShippingDetailShipper",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "portOfDestinationId",
                table: "trCostShippingDetailShipper",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "mtBank",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 273, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 273, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtBank",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 273, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 273, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtChartOfAccount",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 274, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 274, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtChartOfAccount",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 274, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 274, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtChartOfAccount",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 274, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 274, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtCountry",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 265, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 273, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtCountry",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 273, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 273, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtCurrency",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 274, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 274, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtCurrency",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 274, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 274, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "mtType",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysDocNo",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysDocNo",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysDocNo",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 275, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModule",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysModuleRole",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysUser",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "password", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local), "C5DUlbPsfB/rBCwgC3DTPJpJK0xVqCMx9BYs3Sr+JpXTE9jC", new DateTime(2018, 12, 18, 12, 1, 30, 303, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "sysUserRole",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdOn", "updatedOn" },
                values: new object[] { new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local), new DateTime(2018, 12, 18, 12, 1, 30, 276, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingDetailShipper_containerId",
                table: "trCostShippingDetailShipper",
                column: "containerId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingDetailShipper_currencyId",
                table: "trCostShippingDetailShipper",
                column: "currencyId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingDetailShipper_portOfDestinationId",
                table: "trCostShippingDetailShipper",
                column: "portOfDestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_trCostShippingDetailShipper_mtContainer_containerId",
                table: "trCostShippingDetailShipper",
                column: "containerId",
                principalTable: "mtContainer",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trCostShippingDetailShipper_mtCurrency_currencyId",
                table: "trCostShippingDetailShipper",
                column: "currencyId",
                principalTable: "mtCurrency",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trCostShippingDetailShipper_mtPortOfDestination_portOfDestin~",
                table: "trCostShippingDetailShipper",
                column: "portOfDestinationId",
                principalTable: "mtPortOfDestination",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trCostShippingDetailShipper_mtContainer_containerId",
                table: "trCostShippingDetailShipper");

            migrationBuilder.DropForeignKey(
                name: "FK_trCostShippingDetailShipper_mtCurrency_currencyId",
                table: "trCostShippingDetailShipper");

            migrationBuilder.DropForeignKey(
                name: "FK_trCostShippingDetailShipper_mtPortOfDestination_portOfDestin~",
                table: "trCostShippingDetailShipper");

            migrationBuilder.DropIndex(
                name: "IX_trCostShippingDetailShipper_containerId",
                table: "trCostShippingDetailShipper");

            migrationBuilder.DropIndex(
                name: "IX_trCostShippingDetailShipper_currencyId",
                table: "trCostShippingDetailShipper");

            migrationBuilder.DropIndex(
                name: "IX_trCostShippingDetailShipper_portOfDestinationId",
                table: "trCostShippingDetailShipper");

            migrationBuilder.DropColumn(
                name: "containerId",
                table: "trCostShippingDetailShipper");

            migrationBuilder.DropColumn(
                name: "currencyId",
                table: "trCostShippingDetailShipper");

            migrationBuilder.DropColumn(
                name: "operationMonitoring",
                table: "trCostShippingDetailShipper");

            migrationBuilder.DropColumn(
                name: "operationMonitoringType",
                table: "trCostShippingDetailShipper");

            migrationBuilder.DropColumn(
                name: "payable",
                table: "trCostShippingDetailShipper");

            migrationBuilder.DropColumn(
                name: "portOfDestinationId",
                table: "trCostShippingDetailShipper");

            migrationBuilder.RenameColumn(
                name: "portTerminalType",
                table: "trCostShippingDetail",
                newName: "vendorId");

            migrationBuilder.AlterColumn<string>(
                name: "payable",
                table: "trSellingShipperDetailVendor",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "payable",
                table: "trCostShippingDetail",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "refund",
                table: "trCostShippingDetail",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "refundType",
                table: "trCostShippingDetail",
                nullable: false,
                defaultValue: 0);

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
                name: "IX_trCostShippingDetail_portTerminalId",
                table: "trCostShippingDetail",
                column: "portTerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingDetail_vendorId",
                table: "trCostShippingDetail",
                column: "vendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_trCostShippingDetail_mtPortTerminal_portTerminalId",
                table: "trCostShippingDetail",
                column: "portTerminalId",
                principalTable: "mtPortTerminal",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trCostShippingDetail_mtVendor_vendorId",
                table: "trCostShippingDetail",
                column: "vendorId",
                principalTable: "mtVendor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
