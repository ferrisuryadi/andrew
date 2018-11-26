using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fms.Migrations
{
    public partial class InitialCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mtBank",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(maxLength: 10, nullable: false),
                    description = table.Column<string>(maxLength: 50, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtBank", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mtContainer",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    typeofContainer = table.Column<string>(maxLength: 50, nullable: false),
                    interiorDimension = table.Column<string>(maxLength: 50, nullable: false),
                    doorOpening = table.Column<string>(maxLength: 50, nullable: false),
                    tareWeight = table.Column<string>(maxLength: 50, nullable: false),
                    cubicCapacity = table.Column<string>(maxLength: 50, nullable: false),
                    payload = table.Column<string>(maxLength: 50, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtContainer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mtCountry",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(maxLength: 10, nullable: false),
                    description = table.Column<string>(maxLength: 50, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtCountry", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mtCurrency",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(maxLength: 10, nullable: false),
                    description = table.Column<string>(maxLength: 50, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtCurrency", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mtDepoContainer",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(maxLength: 50, nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    address = table.Column<string>(maxLength: 500, nullable: false),
                    email = table.Column<string>(maxLength: 250, nullable: false),
                    website = table.Column<string>(maxLength: 50, nullable: false),
                    telepon = table.Column<string>(maxLength: 50, nullable: false),
                    fax = table.Column<string>(maxLength: 50, nullable: false),
                    remark = table.Column<string>(maxLength: 500, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtDepoContainer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mtEmployee",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(maxLength: 50, nullable: false),
                    name = table.Column<string>(maxLength: 250, nullable: false),
                    initial = table.Column<string>(maxLength: 50, nullable: false),
                    address = table.Column<string>(maxLength: 500, nullable: false),
                    joinDate = table.Column<DateTime>(nullable: false),
                    email = table.Column<string>(maxLength: 250, nullable: false),
                    handphone = table.Column<string>(maxLength: 50, nullable: false),
                    phone = table.Column<string>(maxLength: 50, nullable: false),
                    idCard = table.Column<string>(maxLength: 50, nullable: false),
                    pictureUrl = table.Column<string>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtEmployee", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mtGroups",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(maxLength: 10, nullable: false),
                    description = table.Column<string>(maxLength: 50, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtGroups", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mtLocation",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    location = table.Column<string>(maxLength: 500, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtLocation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mtOrders",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtOrders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mtTax",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(maxLength: 10, nullable: false),
                    amount = table.Column<decimal>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtTax", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mtType",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(maxLength: 50, nullable: false),
                    description = table.Column<string>(maxLength: 50, nullable: false),
                    category = table.Column<int>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sysDocNo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    module = table.Column<string>(maxLength: 100, nullable: false),
                    documentType = table.Column<string>(maxLength: 20, nullable: false),
                    numberFormat = table.Column<string>(maxLength: 50, nullable: false),
                    prefix = table.Column<string>(maxLength: 20, nullable: false),
                    nextDocNo = table.Column<int>(nullable: false),
                    suffix = table.Column<string>(maxLength: 20, nullable: false),
                    lastYear = table.Column<int>(nullable: false),
                    lastMonth = table.Column<int>(nullable: false),
                    lastDay = table.Column<int>(nullable: false),
                    resetLevel = table.Column<int>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sysDocNo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sysModule",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(maxLength: 50, nullable: false),
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    parentId = table.Column<int>(nullable: true),
                    controller = table.Column<string>(maxLength: 50, nullable: false),
                    view = table.Column<string>(maxLength: 50, nullable: false),
                    level = table.Column<int>(nullable: false),
                    orderModule = table.Column<int>(nullable: false),
                    hasChild = table.Column<bool>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sysModule", x => x.id);
                    table.ForeignKey(
                        name: "FK_sysModule_sysModule_parentId",
                        column: x => x.parentId,
                        principalTable: "sysModule",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sysUserRole",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    description = table.Column<string>(maxLength: 50, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sysUserRole", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mtConsignee",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(maxLength: 50, nullable: false),
                    referenceNo = table.Column<string>(maxLength: 50, nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    address = table.Column<string>(maxLength: 500, nullable: false),
                    dog = table.Column<string>(maxLength: 50, nullable: false),
                    countryId = table.Column<int>(nullable: true),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtConsignee", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtConsignee_mtCountry_countryId",
                        column: x => x.countryId,
                        principalTable: "mtCountry",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mtPortOfDestination",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    location = table.Column<string>(maxLength: 150, nullable: false),
                    countryId = table.Column<int>(nullable: false),
                    countryIdTransit = table.Column<int>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtPortOfDestination", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtPortOfDestination_mtCountry_countryId",
                        column: x => x.countryId,
                        principalTable: "mtCountry",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_mtPortOfDestination_mtCountry_countryIdTransit",
                        column: x => x.countryIdTransit,
                        principalTable: "mtCountry",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mtPortOfLoading",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    port = table.Column<string>(maxLength: 50, nullable: false),
                    countryId = table.Column<int>(nullable: false),
                    remark = table.Column<string>(maxLength: 500, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtPortOfLoading", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtPortOfLoading_mtCountry_countryId",
                        column: x => x.countryId,
                        principalTable: "mtCountry",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mtChartOfAccount",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(maxLength: 50, nullable: false),
                    description = table.Column<string>(maxLength: 50, nullable: false),
                    parentId = table.Column<int>(nullable: true),
                    currencyId = table.Column<int>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtChartOfAccount", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtChartOfAccount_mtCurrency_currencyId",
                        column: x => x.currencyId,
                        principalTable: "mtCurrency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_mtChartOfAccount_mtChartOfAccount_parentId",
                        column: x => x.parentId,
                        principalTable: "mtChartOfAccount",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mtCurrencyRate",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    currencyIdFrom = table.Column<int>(nullable: true),
                    currencyIdTo = table.Column<int>(nullable: true),
                    rate = table.Column<double>(nullable: false),
                    validFrom = table.Column<DateTime>(nullable: false),
                    validTo = table.Column<DateTime>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtCurrencyRate", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtCurrencyRate_mtCurrency_currencyIdFrom",
                        column: x => x.currencyIdFrom,
                        principalTable: "mtCurrency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mtCurrencyRate_mtCurrency_currencyIdTo",
                        column: x => x.currencyIdTo,
                        principalTable: "mtCurrency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mtDepoContainerDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    depoContainerId = table.Column<int>(nullable: false),
                    contactPerson = table.Column<string>(maxLength: 50, nullable: false),
                    telepon = table.Column<string>(maxLength: 50, nullable: false),
                    position = table.Column<string>(maxLength: 50, nullable: false),
                    address = table.Column<string>(maxLength: 500, nullable: false),
                    handphone = table.Column<string>(maxLength: 50, nullable: false),
                    email = table.Column<string>(maxLength: 250, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtDepoContainerDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtDepoContainerDetails_mtDepoContainer_depoContainerId",
                        column: x => x.depoContainerId,
                        principalTable: "mtDepoContainer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sysModuleRole",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    userRoleId = table.Column<int>(nullable: false),
                    moduleId = table.Column<int>(nullable: false),
                    isDefault = table.Column<bool>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sysModuleRole", x => x.id);
                    table.ForeignKey(
                        name: "FK_sysModuleRole_sysModule_moduleId",
                        column: x => x.moduleId,
                        principalTable: "sysModule",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sysModuleRole_sysUserRole_userRoleId",
                        column: x => x.userRoleId,
                        principalTable: "sysUserRole",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sysUser",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(maxLength: 50, nullable: false),
                    password = table.Column<string>(maxLength: 50, nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    email = table.Column<string>(maxLength: 50, nullable: false),
                    roleId = table.Column<int>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sysUser", x => x.id);
                    table.ForeignKey(
                        name: "FK_sysUser_sysUserRole_roleId",
                        column: x => x.roleId,
                        principalTable: "sysUserRole",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mtPortTerminal",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    portOfLoadingId = table.Column<int>(nullable: false),
                    terminalPort = table.Column<string>(maxLength: 50, nullable: false),
                    address = table.Column<string>(maxLength: 500, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtPortTerminal", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtPortTerminal_mtPortOfLoading_portOfLoadingId",
                        column: x => x.portOfLoadingId,
                        principalTable: "mtPortOfLoading",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mtCompany",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    company = table.Column<string>(maxLength: 50, nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    address = table.Column<string>(maxLength: 500, nullable: false),
                    email = table.Column<string>(maxLength: 250, nullable: false),
                    website = table.Column<string>(maxLength: 50, nullable: false),
                    telepon = table.Column<string>(maxLength: 50, nullable: false),
                    fax = table.Column<string>(maxLength: 50, nullable: false),
                    taxNo = table.Column<string>(maxLength: 50, nullable: false),
                    typeId = table.Column<int>(nullable: true),
                    coaIdUsd = table.Column<int>(nullable: true),
                    coaIdIdr = table.Column<int>(nullable: true),
                    remark = table.Column<string>(maxLength: 500, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtCompany", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtCompany_mtChartOfAccount_coaIdIdr",
                        column: x => x.coaIdIdr,
                        principalTable: "mtChartOfAccount",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mtCompany_mtChartOfAccount_coaIdUsd",
                        column: x => x.coaIdUsd,
                        principalTable: "mtChartOfAccount",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mtCompany_mtType_typeId",
                        column: x => x.typeId,
                        principalTable: "mtType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mtServices",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(maxLength: 50, nullable: false),
                    description = table.Column<string>(maxLength: 50, nullable: false),
                    coaIdUsd = table.Column<int>(nullable: true),
                    coaIdIdr = table.Column<int>(nullable: true),
                    groupId = table.Column<int>(nullable: true),
                    hargaPerCon = table.Column<bool>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtServices", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtServices_mtChartOfAccount_coaIdIdr",
                        column: x => x.coaIdIdr,
                        principalTable: "mtChartOfAccount",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mtServices_mtChartOfAccount_coaIdUsd",
                        column: x => x.coaIdUsd,
                        principalTable: "mtChartOfAccount",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mtServices_mtGroups_groupId",
                        column: x => x.groupId,
                        principalTable: "mtGroups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mtShipper",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(maxLength: 50, nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    qq = table.Column<string>(maxLength: 50, nullable: false),
                    attention = table.Column<string>(maxLength: 50, nullable: false),
                    email = table.Column<string>(maxLength: 250, nullable: false),
                    website = table.Column<string>(maxLength: 50, nullable: false),
                    phone = table.Column<string>(maxLength: 50, nullable: false),
                    fax = table.Column<string>(maxLength: 50, nullable: false),
                    taxNo = table.Column<string>(maxLength: 50, nullable: false),
                    province = table.Column<string>(maxLength: 50, nullable: false),
                    city = table.Column<string>(maxLength: 50, nullable: false),
                    district = table.Column<string>(maxLength: 50, nullable: false),
                    subDistrict = table.Column<string>(maxLength: 50, nullable: false),
                    village = table.Column<string>(maxLength: 50, nullable: false),
                    subVillage = table.Column<string>(maxLength: 50, nullable: false),
                    block = table.Column<string>(maxLength: 50, nullable: false),
                    postalCode = table.Column<string>(maxLength: 50, nullable: false),
                    remark = table.Column<string>(maxLength: 500, nullable: false),
                    employeeId = table.Column<int>(nullable: true),
                    coaIdUsd = table.Column<int>(nullable: true),
                    coaIdIdr = table.Column<int>(nullable: true),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtShipper", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtShipper_mtChartOfAccount_coaIdIdr",
                        column: x => x.coaIdIdr,
                        principalTable: "mtChartOfAccount",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mtShipper_mtChartOfAccount_coaIdUsd",
                        column: x => x.coaIdUsd,
                        principalTable: "mtChartOfAccount",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mtShipper_mtEmployee_employeeId",
                        column: x => x.employeeId,
                        principalTable: "mtEmployee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mtVendor",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(maxLength: 50, nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    attention = table.Column<string>(maxLength: 50, nullable: false),
                    email = table.Column<string>(maxLength: 250, nullable: false),
                    website = table.Column<string>(maxLength: 50, nullable: false),
                    phone = table.Column<string>(maxLength: 50, nullable: false),
                    fax = table.Column<string>(maxLength: 50, nullable: false),
                    province = table.Column<string>(maxLength: 50, nullable: false),
                    city = table.Column<string>(maxLength: 50, nullable: false),
                    district = table.Column<string>(maxLength: 50, nullable: false),
                    subDistrict = table.Column<string>(maxLength: 50, nullable: false),
                    village = table.Column<string>(maxLength: 50, nullable: false),
                    subVillage = table.Column<string>(maxLength: 50, nullable: false),
                    block = table.Column<string>(maxLength: 50, nullable: false),
                    postalCode = table.Column<string>(maxLength: 50, nullable: false),
                    remark = table.Column<string>(maxLength: 500, nullable: false),
                    coaIdUsd = table.Column<int>(nullable: true),
                    coaIdIdr = table.Column<int>(nullable: true),
                    typeId = table.Column<int>(nullable: true),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtVendor", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtVendor_mtChartOfAccount_coaIdIdr",
                        column: x => x.coaIdIdr,
                        principalTable: "mtChartOfAccount",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mtVendor_mtChartOfAccount_coaIdUsd",
                        column: x => x.coaIdUsd,
                        principalTable: "mtChartOfAccount",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mtVendor_mtType_typeId",
                        column: x => x.typeId,
                        principalTable: "mtType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mtWarehouse",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(maxLength: 50, nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    address = table.Column<string>(maxLength: 500, nullable: false),
                    email = table.Column<string>(maxLength: 250, nullable: false),
                    website = table.Column<string>(maxLength: 50, nullable: false),
                    phone = table.Column<string>(maxLength: 50, nullable: false),
                    fax = table.Column<string>(maxLength: 50, nullable: false),
                    taxNo = table.Column<string>(maxLength: 50, nullable: false),
                    province = table.Column<string>(maxLength: 50, nullable: false),
                    city = table.Column<string>(maxLength: 50, nullable: false),
                    district = table.Column<string>(maxLength: 50, nullable: false),
                    subDistrict = table.Column<string>(maxLength: 50, nullable: false),
                    village = table.Column<string>(maxLength: 50, nullable: false),
                    subVillage = table.Column<string>(maxLength: 50, nullable: false),
                    block = table.Column<string>(maxLength: 50, nullable: false),
                    postalCode = table.Column<string>(maxLength: 50, nullable: false),
                    remark = table.Column<string>(maxLength: 500, nullable: false),
                    coaIdUsd = table.Column<int>(nullable: true),
                    coaIdIdr = table.Column<int>(nullable: true),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtWarehouse", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtWarehouse_mtChartOfAccount_coaIdIdr",
                        column: x => x.coaIdIdr,
                        principalTable: "mtChartOfAccount",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mtWarehouse_mtChartOfAccount_coaIdUsd",
                        column: x => x.coaIdUsd,
                        principalTable: "mtChartOfAccount",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mtCompanyDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    companyId = table.Column<int>(nullable: false),
                    contactPerson = table.Column<string>(maxLength: 50, nullable: false),
                    telepon = table.Column<string>(maxLength: 50, nullable: false),
                    position = table.Column<string>(maxLength: 50, nullable: false),
                    address = table.Column<string>(maxLength: 500, nullable: false),
                    handphone = table.Column<string>(maxLength: 50, nullable: false),
                    email = table.Column<string>(maxLength: 250, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtCompanyDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtCompanyDetails_mtCompany_companyId",
                        column: x => x.companyId,
                        principalTable: "mtCompany",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mtAgent",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(maxLength: 50, nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    address = table.Column<string>(maxLength: 500, nullable: false),
                    email = table.Column<string>(maxLength: 250, nullable: false),
                    website = table.Column<string>(maxLength: 50, nullable: false),
                    postalCode = table.Column<string>(maxLength: 50, nullable: false),
                    portOfDestinationId = table.Column<int>(nullable: true),
                    typeId = table.Column<int>(nullable: true),
                    shipperId = table.Column<int>(nullable: true),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtAgent", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtAgent_mtPortOfDestination_portOfDestinationId",
                        column: x => x.portOfDestinationId,
                        principalTable: "mtPortOfDestination",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mtAgent_mtShipper_shipperId",
                        column: x => x.shipperId,
                        principalTable: "mtShipper",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mtAgent_mtType_typeId",
                        column: x => x.typeId,
                        principalTable: "mtType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mtShipperDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    shipperId = table.Column<int>(nullable: false),
                    contactPerson = table.Column<string>(maxLength: 50, nullable: false),
                    telepon = table.Column<string>(maxLength: 50, nullable: false),
                    position = table.Column<string>(maxLength: 50, nullable: false),
                    address = table.Column<string>(maxLength: 500, nullable: false),
                    handphone = table.Column<string>(maxLength: 50, nullable: false),
                    email = table.Column<string>(maxLength: 250, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtShipperDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtShipperDetails_mtShipper_shipperId",
                        column: x => x.shipperId,
                        principalTable: "mtShipper",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trSellingShipper",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    referenceNo = table.Column<string>(maxLength: 50, nullable: false),
                    txDate = table.Column<DateTime>(nullable: false),
                    txValidDate = table.Column<DateTime>(nullable: false),
                    shipperId = table.Column<int>(nullable: false),
                    shipperAttention = table.Column<string>(maxLength: 50, nullable: false),
                    shipperCc = table.Column<string>(maxLength: 50, nullable: false),
                    employeeId = table.Column<int>(nullable: false),
                    employeeCc = table.Column<string>(maxLength: 50, nullable: false),
                    termOfPayment = table.Column<int>(nullable: false),
                    portOfLoadingId = table.Column<int>(nullable: false),
                    remarkQuo = table.Column<string>(maxLength: 500, nullable: true),
                    remarkEmkl = table.Column<string>(maxLength: 500, nullable: true),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trSellingShipper", x => x.id);
                    table.ForeignKey(
                        name: "FK_trSellingShipper_mtEmployee_employeeId",
                        column: x => x.employeeId,
                        principalTable: "mtEmployee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipper_mtPortOfLoading_portOfLoadingId",
                        column: x => x.portOfLoadingId,
                        principalTable: "mtPortOfLoading",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipper_mtShipper_shipperId",
                        column: x => x.shipperId,
                        principalTable: "mtShipper",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mtVendorDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    vendorId = table.Column<int>(nullable: false),
                    contactPerson = table.Column<string>(maxLength: 50, nullable: false),
                    telepon = table.Column<string>(maxLength: 50, nullable: false),
                    position = table.Column<string>(maxLength: 50, nullable: false),
                    address = table.Column<string>(maxLength: 500, nullable: false),
                    handphone = table.Column<string>(maxLength: 50, nullable: false),
                    email = table.Column<string>(maxLength: 250, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtVendorDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtVendorDetails_mtVendor_vendorId",
                        column: x => x.vendorId,
                        principalTable: "mtVendor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trCostShipping",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    referenceNo = table.Column<string>(maxLength: 50, nullable: false),
                    txDate = table.Column<DateTime>(nullable: false),
                    txValidDate = table.Column<DateTime>(nullable: false),
                    portOfLoadingId = table.Column<int>(nullable: false),
                    sales = table.Column<string>(maxLength: 200, nullable: false),
                    shippingReferenceNo = table.Column<string>(maxLength: 50, nullable: false),
                    vendorId = table.Column<int>(nullable: false),
                    remark = table.Column<string>(maxLength: 500, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trCostShipping", x => x.id);
                    table.ForeignKey(
                        name: "FK_trCostShipping_mtPortOfLoading_portOfLoadingId",
                        column: x => x.portOfLoadingId,
                        principalTable: "mtPortOfLoading",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trCostShipping_mtVendor_vendorId",
                        column: x => x.vendorId,
                        principalTable: "mtVendor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mtWarehouseDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    warehouseId = table.Column<int>(nullable: false),
                    contactPerson = table.Column<string>(maxLength: 50, nullable: false),
                    telepon = table.Column<string>(maxLength: 50, nullable: false),
                    position = table.Column<string>(maxLength: 50, nullable: false),
                    address = table.Column<string>(maxLength: 500, nullable: false),
                    handphone = table.Column<string>(maxLength: 50, nullable: false),
                    email = table.Column<string>(maxLength: 250, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtWarehouseDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtWarehouseDetails_mtWarehouse_warehouseId",
                        column: x => x.warehouseId,
                        principalTable: "mtWarehouse",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mtAgentDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    agentId = table.Column<int>(nullable: false),
                    contactPerson = table.Column<string>(maxLength: 50, nullable: false),
                    telepon = table.Column<string>(maxLength: 50, nullable: false),
                    position = table.Column<string>(maxLength: 50, nullable: false),
                    address = table.Column<string>(maxLength: 500, nullable: false),
                    handphone = table.Column<string>(maxLength: 50, nullable: false),
                    email = table.Column<string>(maxLength: 250, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtAgentDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtAgentDetails_mtAgent_agentId",
                        column: x => x.agentId,
                        principalTable: "mtAgent",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mtAgentProfitShared",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    agentId = table.Column<int>(nullable: true),
                    containerId = table.Column<int>(nullable: true),
                    shipperId = table.Column<int>(nullable: true),
                    periodStart = table.Column<DateTime>(nullable: false),
                    periodEnd = table.Column<DateTime>(nullable: false),
                    profitShared = table.Column<int>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtAgentProfitShared", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtAgentProfitShared_mtAgent_agentId",
                        column: x => x.agentId,
                        principalTable: "mtAgent",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mtAgentProfitShared_mtContainer_containerId",
                        column: x => x.containerId,
                        principalTable: "mtContainer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mtAgentProfitShared_mtShipper_shipperId",
                        column: x => x.shipperId,
                        principalTable: "mtShipper",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mtProfitShared",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    agentId = table.Column<int>(nullable: true),
                    countryId = table.Column<int>(nullable: true),
                    refNo = table.Column<string>(maxLength: 50, nullable: false),
                    txDate = table.Column<DateTime>(nullable: false),
                    txValidDate = table.Column<DateTime>(nullable: false),
                    psCondition = table.Column<int>(nullable: false),
                    psForAgent = table.Column<double>(nullable: false),
                    rebateForTsk = table.Column<double>(nullable: false),
                    inputBy = table.Column<string>(maxLength: 50, nullable: false),
                    remark = table.Column<string>(maxLength: 500, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false),
                    mtContainerid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtProfitShared", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtProfitShared_mtAgent_agentId",
                        column: x => x.agentId,
                        principalTable: "mtAgent",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mtProfitShared_mtCountry_countryId",
                        column: x => x.countryId,
                        principalTable: "mtCountry",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mtProfitShared_mtContainer_mtContainerid",
                        column: x => x.mtContainerid,
                        principalTable: "mtContainer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "trSellingShipperDetail",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    sellingShipperId = table.Column<int>(nullable: false),
                    serviceId = table.Column<int>(nullable: false),
                    portOfDestinationId = table.Column<int>(nullable: false),
                    ofEmkl = table.Column<int>(nullable: false),
                    locationId = table.Column<int>(nullable: false),
                    consigneeId = table.Column<int>(nullable: false),
                    containerId = table.Column<int>(nullable: false),
                    currencyId = table.Column<int>(nullable: false),
                    truckingCondition = table.Column<int>(nullable: false),
                    taxId23 = table.Column<int>(nullable: false),
                    taxIdvat = table.Column<int>(nullable: false),
                    price = table.Column<decimal>(nullable: false),
                    remark = table.Column<string>(maxLength: 500, nullable: true),
                    orderId = table.Column<int>(nullable: false),
                    allIn = table.Column<bool>(nullable: false),
                    refund = table.Column<decimal>(nullable: false),
                    refundType = table.Column<int>(nullable: false),
                    payable = table.Column<string>(nullable: false),
                    vendorId = table.Column<int>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trSellingShipperDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_trSellingShipperDetail_mtConsignee_consigneeId",
                        column: x => x.consigneeId,
                        principalTable: "mtConsignee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipperDetail_mtContainer_containerId",
                        column: x => x.containerId,
                        principalTable: "mtContainer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipperDetail_mtCurrency_currencyId",
                        column: x => x.currencyId,
                        principalTable: "mtCurrency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipperDetail_mtLocation_locationId",
                        column: x => x.locationId,
                        principalTable: "mtLocation",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipperDetail_mtOrders_orderId",
                        column: x => x.orderId,
                        principalTable: "mtOrders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipperDetail_mtPortOfDestination_portOfDestination~",
                        column: x => x.portOfDestinationId,
                        principalTable: "mtPortOfDestination",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipperDetail_trSellingShipper_sellingShipperId",
                        column: x => x.sellingShipperId,
                        principalTable: "trSellingShipper",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipperDetail_mtServices_serviceId",
                        column: x => x.serviceId,
                        principalTable: "mtServices",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipperDetail_mtTax_taxId23",
                        column: x => x.taxId23,
                        principalTable: "mtTax",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipperDetail_mtTax_taxIdvat",
                        column: x => x.taxIdvat,
                        principalTable: "mtTax",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipperDetail_mtVendor_vendorId",
                        column: x => x.vendorId,
                        principalTable: "mtVendor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trSellingShipperService",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    sellingShipperId = table.Column<int>(nullable: false),
                    serviceId = table.Column<int>(nullable: false),
                    portOfDestinationId = table.Column<int>(nullable: false),
                    ofEmkl = table.Column<int>(nullable: false),
                    pcPay = table.Column<int>(nullable: false),
                    containerId = table.Column<int>(nullable: false),
                    taxId23 = table.Column<int>(nullable: false),
                    taxIdvat = table.Column<int>(nullable: false),
                    remark = table.Column<string>(maxLength: 500, nullable: true),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trSellingShipperService", x => x.id);
                    table.ForeignKey(
                        name: "FK_trSellingShipperService_mtContainer_containerId",
                        column: x => x.containerId,
                        principalTable: "mtContainer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipperService_mtPortOfDestination_portOfDestinatio~",
                        column: x => x.portOfDestinationId,
                        principalTable: "mtPortOfDestination",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipperService_trSellingShipper_sellingShipperId",
                        column: x => x.sellingShipperId,
                        principalTable: "trSellingShipper",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipperService_mtServices_serviceId",
                        column: x => x.serviceId,
                        principalTable: "mtServices",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipperService_mtTax_taxId23",
                        column: x => x.taxId23,
                        principalTable: "mtTax",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipperService_mtTax_taxIdvat",
                        column: x => x.taxIdvat,
                        principalTable: "mtTax",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trCostShippingDetail",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    costShippingId = table.Column<int>(nullable: false),
                    serviceId = table.Column<int>(nullable: false),
                    portOfDestinationId = table.Column<int>(nullable: false),
                    portTerminalId = table.Column<int>(nullable: false),
                    pcPay = table.Column<int>(nullable: false),
                    containerId = table.Column<int>(nullable: false),
                    currencyId = table.Column<int>(nullable: false),
                    taxId23 = table.Column<int>(nullable: false),
                    taxIdvat = table.Column<int>(nullable: false),
                    price = table.Column<decimal>(nullable: false),
                    remark = table.Column<string>(maxLength: 500, nullable: true),
                    allIn = table.Column<bool>(nullable: false),
                    refund = table.Column<decimal>(nullable: false),
                    refundType = table.Column<int>(nullable: false),
                    payable = table.Column<string>(nullable: false),
                    vendorId = table.Column<int>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trCostShippingDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_trCostShippingDetail_mtContainer_containerId",
                        column: x => x.containerId,
                        principalTable: "mtContainer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trCostShippingDetail_trCostShipping_costShippingId",
                        column: x => x.costShippingId,
                        principalTable: "trCostShipping",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trCostShippingDetail_mtCurrency_currencyId",
                        column: x => x.currencyId,
                        principalTable: "mtCurrency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trCostShippingDetail_mtPortOfDestination_portOfDestinationId",
                        column: x => x.portOfDestinationId,
                        principalTable: "mtPortOfDestination",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trCostShippingDetail_mtPortTerminal_portTerminalId",
                        column: x => x.portTerminalId,
                        principalTable: "mtPortTerminal",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trCostShippingDetail_mtServices_serviceId",
                        column: x => x.serviceId,
                        principalTable: "mtServices",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trCostShippingDetail_mtTax_taxId23",
                        column: x => x.taxId23,
                        principalTable: "mtTax",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trCostShippingDetail_mtTax_taxIdvat",
                        column: x => x.taxIdvat,
                        principalTable: "mtTax",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trCostShippingDetail_mtVendor_vendorId",
                        column: x => x.vendorId,
                        principalTable: "mtVendor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trCostShippingService",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    costShippingId = table.Column<int>(nullable: false),
                    serviceId = table.Column<int>(nullable: false),
                    portOfDestinationId = table.Column<int>(nullable: false),
                    ofEmkl = table.Column<int>(nullable: false),
                    pcPay = table.Column<int>(nullable: false),
                    containerId = table.Column<int>(nullable: false),
                    taxId23 = table.Column<int>(nullable: false),
                    taxIdvat = table.Column<int>(nullable: false),
                    remark = table.Column<string>(maxLength: 500, nullable: true),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trCostShippingService", x => x.id);
                    table.ForeignKey(
                        name: "FK_trCostShippingService_mtContainer_containerId",
                        column: x => x.containerId,
                        principalTable: "mtContainer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trCostShippingService_trCostShipping_costShippingId",
                        column: x => x.costShippingId,
                        principalTable: "trCostShipping",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trCostShippingService_mtPortOfDestination_portOfDestinationId",
                        column: x => x.portOfDestinationId,
                        principalTable: "mtPortOfDestination",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trCostShippingService_mtServices_serviceId",
                        column: x => x.serviceId,
                        principalTable: "mtServices",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trCostShippingService_mtTax_taxId23",
                        column: x => x.taxId23,
                        principalTable: "mtTax",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trCostShippingService_mtTax_taxIdvat",
                        column: x => x.taxIdvat,
                        principalTable: "mtTax",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mtProfitSharedDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    profitSharedId = table.Column<int>(nullable: false),
                    containerId = table.Column<int>(nullable: true),
                    refNo = table.Column<string>(maxLength: 50, nullable: false),
                    psForAgent = table.Column<double>(nullable: false),
                    psForTsk = table.Column<double>(nullable: false),
                    psDueForAgent = table.Column<double>(nullable: false),
                    psDueForTsk = table.Column<double>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtProfitSharedDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_mtProfitSharedDetails_mtContainer_containerId",
                        column: x => x.containerId,
                        principalTable: "mtContainer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mtProfitSharedDetails_mtProfitShared_profitSharedId",
                        column: x => x.profitSharedId,
                        principalTable: "mtProfitShared",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trSellingShipperDetailVendor",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    sellingShipperId = table.Column<int>(nullable: false),
                    sellingShipperDetailId = table.Column<int>(nullable: false),
                    vendorId = table.Column<int>(nullable: false),
                    vendorCode = table.Column<string>(maxLength: 50, nullable: false),
                    vendorName = table.Column<string>(maxLength: 50, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trSellingShipperDetailVendor", x => x.id);
                    table.ForeignKey(
                        name: "FK_trSellingShipperDetailVendor_trSellingShipperDetail_sellingS~",
                        column: x => x.sellingShipperDetailId,
                        principalTable: "trSellingShipperDetail",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipperDetailVendor_trSellingShipper_sellingShipper~",
                        column: x => x.sellingShipperId,
                        principalTable: "trSellingShipper",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trSellingShipperDetailVendor_mtVendor_vendorId",
                        column: x => x.vendorId,
                        principalTable: "mtVendor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trCostShippingDetailShipper",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    costShippingId = table.Column<int>(nullable: false),
                    costShippingDetailId = table.Column<int>(nullable: false),
                    shipperId = table.Column<int>(nullable: false),
                    shipperCode = table.Column<string>(maxLength: 50, nullable: false),
                    shipperName = table.Column<string>(maxLength: 50, nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    createdBy = table.Column<string>(maxLength: 100, nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    updatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trCostShippingDetailShipper", x => x.id);
                    table.ForeignKey(
                        name: "FK_trCostShippingDetailShipper_trCostShippingDetail_costShippin~",
                        column: x => x.costShippingDetailId,
                        principalTable: "trCostShippingDetail",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trCostShippingDetailShipper_trCostShipping_costShippingId",
                        column: x => x.costShippingId,
                        principalTable: "trCostShipping",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trCostShippingDetailShipper_mtShipper_shipperId",
                        column: x => x.shipperId,
                        principalTable: "mtShipper",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "mtBank",
                columns: new[] { "id", "code", "createdBy", "createdOn", "description", "isActive", "updatedBy", "updatedOn" },
                values: new object[,]
                {
                    { 1, "BCA", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local), "PT. Bank Central Asia Tbk", true, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local) },
                    { 2, "MANDIRI", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local), "PT. Bank Mandiri Tbk", true, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "mtCountry",
                columns: new[] { "id", "code", "createdBy", "createdOn", "description", "isActive", "updatedBy", "updatedOn" },
                values: new object[,]
                {
                    { 1, "INA", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 414, DateTimeKind.Local), "Indonesia", true, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 421, DateTimeKind.Local) },
                    { 2, "USA", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local), "United State of America", true, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "mtCurrency",
                columns: new[] { "id", "code", "createdBy", "createdOn", "description", "isActive", "updatedBy", "updatedOn" },
                values: new object[,]
                {
                    { 1, "IDR", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local), "Indonesian Rupiah", true, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local) },
                    { 2, "USD", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local), "US Dollar", true, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 422, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "mtType",
                columns: new[] { "id", "category", "code", "createdBy", "createdOn", "description", "isActive", "updatedBy", "updatedOn" },
                values: new object[,]
                {
                    { 12, 3, "CO LOADER", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), "CO LOADER", true, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) },
                    { 11, 3, "SHIPPING LINE AGENT", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), "SHIPPING LINE AGENT", true, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) },
                    { 10, 3, "AGENT TSK", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), "AGENT TSK", true, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) },
                    { 9, 2, "UNDERNAME", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), "UNDERNAME", true, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) },
                    { 8, 2, "FUMIGASI", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), "FUMIGASI", true, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) },
                    { 7, 2, "INSURANCE", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), "INSURANCE", true, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) },
                    { 5, 2, "COLOADER", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), "COLOADER", true, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) },
                    { 4, 2, "SHIPPING", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), "SHIPPING", true, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) },
                    { 3, 2, "TRUCKING", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), "TRUCKING", true, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) },
                    { 2, 1, "INS", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), "INSURANCE", true, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) },
                    { 1, 1, "FMG", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), "FUMIGASI", true, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) },
                    { 6, 2, "WAREHOUSE", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), "WAREHOUSE", true, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "sysDocNo",
                columns: new[] { "id", "createdBy", "createdOn", "documentType", "isActive", "lastDay", "lastMonth", "lastYear", "module", "nextDocNo", "numberFormat", "prefix", "resetLevel", "suffix", "updatedBy", "updatedOn" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 424, DateTimeKind.Local), "RefNo", true, 1, 1, 2018, "SellingShipper", 1, "0000", "SQXP-%YYYY%%mm%", 2, "", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 424, DateTimeKind.Local) },
                    { 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 424, DateTimeKind.Local), "RefNo", true, 1, 1, 2018, "CostShipping", 1, "0000", "QSLXP-%YYYY%%mm%", 2, "", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 424, DateTimeKind.Local) },
                    { 3, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 424, DateTimeKind.Local), "Image", true, 1, 1, 2018, "Employee", 1, "0000", "%YYYY%%mm%%dd%", 1, "", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 424, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "sysModule",
                columns: new[] { "id", "code", "controller", "createdBy", "createdOn", "hasChild", "isActive", "level", "name", "orderModule", "parentId", "updatedBy", "updatedOn", "view" },
                values: new object[,]
                {
                    { 3, "Transaction", "", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), true, true, 1, "Transaction", 3, null, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "" },
                    { 1, "Dashboard", "Dashboard", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 1, "Dashboard", 1, null, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "" },
                    { 2, "Master", "", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), true, true, 1, "Master", 2, null, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "" }
                });

            migrationBuilder.InsertData(
                table: "sysUserRole",
                columns: new[] { "id", "createdBy", "createdOn", "description", "isActive", "name", "updatedBy", "updatedOn" },
                values: new object[] { 1, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Super Administrator", true, "Super Admin", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "mtChartOfAccount",
                columns: new[] { "id", "code", "createdBy", "createdOn", "currencyId", "description", "isActive", "parentId", "updatedBy", "updatedOn" },
                values: new object[,]
                {
                    { 1, "1-10001", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), 1, "Cash", true, null, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) },
                    { 2, "6-60100", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), 1, "General & Administrative Expenses", true, null, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "sysModule",
                columns: new[] { "id", "code", "controller", "createdBy", "createdOn", "hasChild", "isActive", "level", "name", "orderModule", "parentId", "updatedBy", "updatedOn", "view" },
                values: new object[,]
                {
                    { 30, "SellingShipper", "SellingShipper", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Selling Shipper", 2, 3, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Create" },
                    { 29, "CostShipping", "CostShipping", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Cost Shipping", 1, 3, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 28, "Warehouse", "Warehouse", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Warehouse", 28, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 27, "Vendor", "Vendor", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Vendor", 27, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 26, "Type", "Type", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Type", 26, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 25, "Tax", "Tax", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Tax", 25, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 24, "Shipper", "Shipper", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Shipper", 24, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 23, "Service", "Services", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Service", 23, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 22, "ProfitShared", "ProfitShared", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Profit Shared", 22, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 21, "PortTerminal", "PortTerminal", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Port Terminal", 21, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 20, "PortOfLoading", "PortOfLoading", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Port Of Loading", 19, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 19, "PortOfDestination", "PortOfDestination", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Port Of Destination", 18, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 17, "Orders", "Orders", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Orders", 16, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 18, "Location", "Location", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Location", 17, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 8, "Company", "Company", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Fumigasi & Insurance", 5, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 15, "Employee", "Employee", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Employee", 12, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 14, "DepoContainer", "DepoContainer", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Depo Container", 11, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 13, "CurrencyRate", "CurrencyRate", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Currency Rate", 10, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 12, "Currency", "Currency", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Currency", 9, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 11, "Country", "Country", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Country", 8, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 10, "Container", "Container", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Container", 7, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 9, "Consignee", "Consignee", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Consignee", 6, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 16, "Groups", "Groups", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Groups", 13, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 7, "ChartOfAccount", "ChartOfAccount", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Chart Of Account", 4, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 6, "Bank", "Bank", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Bank", 3, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 5, "AgentProfitShared", "AgentProfitShared", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Agent Profit Shared", 2, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" },
                    { 4, "Agent", "Agent", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), false, true, 2, "Agent", 1, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 425, DateTimeKind.Local), "Index" }
                });

            migrationBuilder.InsertData(
                table: "sysModuleRole",
                columns: new[] { "id", "createdBy", "createdOn", "isActive", "isDefault", "moduleId", "updatedBy", "updatedOn", "userRoleId" },
                values: new object[,]
                {
                    { 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 3, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 3, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 1, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, true, 1, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 }
                });

            migrationBuilder.InsertData(
                table: "sysUser",
                columns: new[] { "id", "createdBy", "createdOn", "email", "isActive", "name", "password", "roleId", "updatedBy", "updatedOn", "username" },
                values: new object[] { 1, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 447, DateTimeKind.Local), "", true, "Administrator", "XMj64dzz0qOMj2sA6LHbJ6E4aGxNP7gRRN9SYi48OA7E+iL3", 1, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 447, DateTimeKind.Local), "admin" });

            migrationBuilder.InsertData(
                table: "mtChartOfAccount",
                columns: new[] { "id", "code", "createdBy", "createdOn", "currencyId", "description", "isActive", "parentId", "updatedBy", "updatedOn" },
                values: new object[] { 3, "6-60101", "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local), 1, "Salaries", true, 2, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 423, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "sysModuleRole",
                columns: new[] { "id", "createdBy", "createdOn", "isActive", "isDefault", "moduleId", "updatedBy", "updatedOn", "userRoleId" },
                values: new object[,]
                {
                    { 28, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 28, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 27, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 27, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 26, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 26, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 25, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 25, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 24, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 24, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 23, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 23, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 22, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 22, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 21, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 21, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 20, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 20, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 19, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 19, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 18, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 18, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 17, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 17, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 16, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 16, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 15, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 15, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 14, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 14, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 13, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 13, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 12, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 12, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 11, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 11, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 10, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 10, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 9, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 9, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 8, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 8, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 7, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 7, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 6, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 6, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 5, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 5, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 4, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 4, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 29, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 29, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 },
                    { 30, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), true, false, 30, "admin", new DateTime(2018, 11, 26, 19, 14, 38, 448, DateTimeKind.Local), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_mtAgent_portOfDestinationId",
                table: "mtAgent",
                column: "portOfDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_mtAgent_shipperId",
                table: "mtAgent",
                column: "shipperId");

            migrationBuilder.CreateIndex(
                name: "IX_mtAgent_typeId",
                table: "mtAgent",
                column: "typeId");

            migrationBuilder.CreateIndex(
                name: "IX_mtAgentDetails_agentId",
                table: "mtAgentDetails",
                column: "agentId");

            migrationBuilder.CreateIndex(
                name: "IX_mtAgentProfitShared_agentId",
                table: "mtAgentProfitShared",
                column: "agentId");

            migrationBuilder.CreateIndex(
                name: "IX_mtAgentProfitShared_containerId",
                table: "mtAgentProfitShared",
                column: "containerId");

            migrationBuilder.CreateIndex(
                name: "IX_mtAgentProfitShared_shipperId",
                table: "mtAgentProfitShared",
                column: "shipperId");

            migrationBuilder.CreateIndex(
                name: "IX_mtChartOfAccount_currencyId",
                table: "mtChartOfAccount",
                column: "currencyId");

            migrationBuilder.CreateIndex(
                name: "IX_mtChartOfAccount_parentId",
                table: "mtChartOfAccount",
                column: "parentId");

            migrationBuilder.CreateIndex(
                name: "IX_mtCompany_coaIdIdr",
                table: "mtCompany",
                column: "coaIdIdr");

            migrationBuilder.CreateIndex(
                name: "IX_mtCompany_coaIdUsd",
                table: "mtCompany",
                column: "coaIdUsd");

            migrationBuilder.CreateIndex(
                name: "IX_mtCompany_typeId",
                table: "mtCompany",
                column: "typeId");

            migrationBuilder.CreateIndex(
                name: "IX_mtCompanyDetails_companyId",
                table: "mtCompanyDetails",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_mtConsignee_countryId",
                table: "mtConsignee",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_mtCurrencyRate_currencyIdFrom",
                table: "mtCurrencyRate",
                column: "currencyIdFrom");

            migrationBuilder.CreateIndex(
                name: "IX_mtCurrencyRate_currencyIdTo",
                table: "mtCurrencyRate",
                column: "currencyIdTo");

            migrationBuilder.CreateIndex(
                name: "IX_mtDepoContainerDetails_depoContainerId",
                table: "mtDepoContainerDetails",
                column: "depoContainerId");

            migrationBuilder.CreateIndex(
                name: "IX_mtPortOfDestination_countryId",
                table: "mtPortOfDestination",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_mtPortOfDestination_countryIdTransit",
                table: "mtPortOfDestination",
                column: "countryIdTransit");

            migrationBuilder.CreateIndex(
                name: "IX_mtPortOfLoading_countryId",
                table: "mtPortOfLoading",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_mtPortTerminal_portOfLoadingId",
                table: "mtPortTerminal",
                column: "portOfLoadingId");

            migrationBuilder.CreateIndex(
                name: "IX_mtProfitShared_agentId",
                table: "mtProfitShared",
                column: "agentId");

            migrationBuilder.CreateIndex(
                name: "IX_mtProfitShared_countryId",
                table: "mtProfitShared",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_mtProfitShared_mtContainerid",
                table: "mtProfitShared",
                column: "mtContainerid");

            migrationBuilder.CreateIndex(
                name: "IX_mtProfitSharedDetails_containerId",
                table: "mtProfitSharedDetails",
                column: "containerId");

            migrationBuilder.CreateIndex(
                name: "IX_mtProfitSharedDetails_profitSharedId",
                table: "mtProfitSharedDetails",
                column: "profitSharedId");

            migrationBuilder.CreateIndex(
                name: "IX_mtServices_coaIdIdr",
                table: "mtServices",
                column: "coaIdIdr");

            migrationBuilder.CreateIndex(
                name: "IX_mtServices_coaIdUsd",
                table: "mtServices",
                column: "coaIdUsd");

            migrationBuilder.CreateIndex(
                name: "IX_mtServices_groupId",
                table: "mtServices",
                column: "groupId");

            migrationBuilder.CreateIndex(
                name: "IX_mtShipper_coaIdIdr",
                table: "mtShipper",
                column: "coaIdIdr");

            migrationBuilder.CreateIndex(
                name: "IX_mtShipper_coaIdUsd",
                table: "mtShipper",
                column: "coaIdUsd");

            migrationBuilder.CreateIndex(
                name: "IX_mtShipper_employeeId",
                table: "mtShipper",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_mtShipperDetails_shipperId",
                table: "mtShipperDetails",
                column: "shipperId");

            migrationBuilder.CreateIndex(
                name: "IX_mtVendor_coaIdIdr",
                table: "mtVendor",
                column: "coaIdIdr");

            migrationBuilder.CreateIndex(
                name: "IX_mtVendor_coaIdUsd",
                table: "mtVendor",
                column: "coaIdUsd");

            migrationBuilder.CreateIndex(
                name: "IX_mtVendor_typeId",
                table: "mtVendor",
                column: "typeId");

            migrationBuilder.CreateIndex(
                name: "IX_mtVendorDetails_vendorId",
                table: "mtVendorDetails",
                column: "vendorId");

            migrationBuilder.CreateIndex(
                name: "IX_mtWarehouse_coaIdIdr",
                table: "mtWarehouse",
                column: "coaIdIdr");

            migrationBuilder.CreateIndex(
                name: "IX_mtWarehouse_coaIdUsd",
                table: "mtWarehouse",
                column: "coaIdUsd");

            migrationBuilder.CreateIndex(
                name: "IX_mtWarehouseDetails_warehouseId",
                table: "mtWarehouseDetails",
                column: "warehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_sysModule_parentId",
                table: "sysModule",
                column: "parentId");

            migrationBuilder.CreateIndex(
                name: "IX_sysModuleRole_moduleId",
                table: "sysModuleRole",
                column: "moduleId");

            migrationBuilder.CreateIndex(
                name: "IX_sysModuleRole_userRoleId",
                table: "sysModuleRole",
                column: "userRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_sysUser_roleId",
                table: "sysUser",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShipping_portOfLoadingId",
                table: "trCostShipping",
                column: "portOfLoadingId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShipping_vendorId",
                table: "trCostShipping",
                column: "vendorId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingDetail_containerId",
                table: "trCostShippingDetail",
                column: "containerId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingDetail_costShippingId",
                table: "trCostShippingDetail",
                column: "costShippingId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingDetail_currencyId",
                table: "trCostShippingDetail",
                column: "currencyId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingDetail_portOfDestinationId",
                table: "trCostShippingDetail",
                column: "portOfDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingDetail_portTerminalId",
                table: "trCostShippingDetail",
                column: "portTerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingDetail_serviceId",
                table: "trCostShippingDetail",
                column: "serviceId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingDetail_taxId23",
                table: "trCostShippingDetail",
                column: "taxId23");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingDetail_taxIdvat",
                table: "trCostShippingDetail",
                column: "taxIdvat");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingDetail_vendorId",
                table: "trCostShippingDetail",
                column: "vendorId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingDetailShipper_costShippingDetailId",
                table: "trCostShippingDetailShipper",
                column: "costShippingDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingDetailShipper_costShippingId",
                table: "trCostShippingDetailShipper",
                column: "costShippingId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingDetailShipper_shipperId",
                table: "trCostShippingDetailShipper",
                column: "shipperId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingService_containerId",
                table: "trCostShippingService",
                column: "containerId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingService_costShippingId",
                table: "trCostShippingService",
                column: "costShippingId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingService_portOfDestinationId",
                table: "trCostShippingService",
                column: "portOfDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingService_serviceId",
                table: "trCostShippingService",
                column: "serviceId");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingService_taxId23",
                table: "trCostShippingService",
                column: "taxId23");

            migrationBuilder.CreateIndex(
                name: "IX_trCostShippingService_taxIdvat",
                table: "trCostShippingService",
                column: "taxIdvat");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipper_employeeId",
                table: "trSellingShipper",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipper_portOfLoadingId",
                table: "trSellingShipper",
                column: "portOfLoadingId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipper_shipperId",
                table: "trSellingShipper",
                column: "shipperId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperDetail_consigneeId",
                table: "trSellingShipperDetail",
                column: "consigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperDetail_containerId",
                table: "trSellingShipperDetail",
                column: "containerId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperDetail_currencyId",
                table: "trSellingShipperDetail",
                column: "currencyId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperDetail_locationId",
                table: "trSellingShipperDetail",
                column: "locationId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperDetail_orderId",
                table: "trSellingShipperDetail",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperDetail_portOfDestinationId",
                table: "trSellingShipperDetail",
                column: "portOfDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperDetail_sellingShipperId",
                table: "trSellingShipperDetail",
                column: "sellingShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperDetail_serviceId",
                table: "trSellingShipperDetail",
                column: "serviceId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperDetail_taxId23",
                table: "trSellingShipperDetail",
                column: "taxId23");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperDetail_taxIdvat",
                table: "trSellingShipperDetail",
                column: "taxIdvat");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperDetail_vendorId",
                table: "trSellingShipperDetail",
                column: "vendorId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperDetailVendor_sellingShipperDetailId",
                table: "trSellingShipperDetailVendor",
                column: "sellingShipperDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperDetailVendor_sellingShipperId",
                table: "trSellingShipperDetailVendor",
                column: "sellingShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperDetailVendor_vendorId",
                table: "trSellingShipperDetailVendor",
                column: "vendorId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperService_containerId",
                table: "trSellingShipperService",
                column: "containerId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperService_portOfDestinationId",
                table: "trSellingShipperService",
                column: "portOfDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperService_sellingShipperId",
                table: "trSellingShipperService",
                column: "sellingShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperService_serviceId",
                table: "trSellingShipperService",
                column: "serviceId");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperService_taxId23",
                table: "trSellingShipperService",
                column: "taxId23");

            migrationBuilder.CreateIndex(
                name: "IX_trSellingShipperService_taxIdvat",
                table: "trSellingShipperService",
                column: "taxIdvat");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mtAgentDetails");

            migrationBuilder.DropTable(
                name: "mtAgentProfitShared");

            migrationBuilder.DropTable(
                name: "mtBank");

            migrationBuilder.DropTable(
                name: "mtCompanyDetails");

            migrationBuilder.DropTable(
                name: "mtCurrencyRate");

            migrationBuilder.DropTable(
                name: "mtDepoContainerDetails");

            migrationBuilder.DropTable(
                name: "mtProfitSharedDetails");

            migrationBuilder.DropTable(
                name: "mtShipperDetails");

            migrationBuilder.DropTable(
                name: "mtVendorDetails");

            migrationBuilder.DropTable(
                name: "mtWarehouseDetails");

            migrationBuilder.DropTable(
                name: "sysDocNo");

            migrationBuilder.DropTable(
                name: "sysModuleRole");

            migrationBuilder.DropTable(
                name: "sysUser");

            migrationBuilder.DropTable(
                name: "trCostShippingDetailShipper");

            migrationBuilder.DropTable(
                name: "trCostShippingService");

            migrationBuilder.DropTable(
                name: "trSellingShipperDetailVendor");

            migrationBuilder.DropTable(
                name: "trSellingShipperService");

            migrationBuilder.DropTable(
                name: "mtCompany");

            migrationBuilder.DropTable(
                name: "mtDepoContainer");

            migrationBuilder.DropTable(
                name: "mtProfitShared");

            migrationBuilder.DropTable(
                name: "mtWarehouse");

            migrationBuilder.DropTable(
                name: "sysModule");

            migrationBuilder.DropTable(
                name: "sysUserRole");

            migrationBuilder.DropTable(
                name: "trCostShippingDetail");

            migrationBuilder.DropTable(
                name: "trSellingShipperDetail");

            migrationBuilder.DropTable(
                name: "mtAgent");

            migrationBuilder.DropTable(
                name: "trCostShipping");

            migrationBuilder.DropTable(
                name: "mtPortTerminal");

            migrationBuilder.DropTable(
                name: "mtConsignee");

            migrationBuilder.DropTable(
                name: "mtContainer");

            migrationBuilder.DropTable(
                name: "mtLocation");

            migrationBuilder.DropTable(
                name: "mtOrders");

            migrationBuilder.DropTable(
                name: "trSellingShipper");

            migrationBuilder.DropTable(
                name: "mtServices");

            migrationBuilder.DropTable(
                name: "mtTax");

            migrationBuilder.DropTable(
                name: "mtPortOfDestination");

            migrationBuilder.DropTable(
                name: "mtVendor");

            migrationBuilder.DropTable(
                name: "mtPortOfLoading");

            migrationBuilder.DropTable(
                name: "mtShipper");

            migrationBuilder.DropTable(
                name: "mtGroups");

            migrationBuilder.DropTable(
                name: "mtType");

            migrationBuilder.DropTable(
                name: "mtCountry");

            migrationBuilder.DropTable(
                name: "mtChartOfAccount");

            migrationBuilder.DropTable(
                name: "mtEmployee");

            migrationBuilder.DropTable(
                name: "mtCurrency");
        }
    }
}
