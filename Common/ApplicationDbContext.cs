using System;
using Microsoft.EntityFrameworkCore;
using fms.Models;
using fms.Common;

namespace fms
{
    public class ApplicationDbContext : DbContext
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");

        public DbSet<mtAgent> mtAgent { get; set; }
        public DbSet<mtAgentDetails> mtAgentDetails { get; set; }
        public DbSet<mtAgentProfitShared> mtAgentProfitShared { get; set; }
        public DbSet<mtBank> mtBank { get; set; }
        public DbSet<mtChartOfAccount> mtChartOfAccount { get; set; }

        public DbSet<mtCompany> mtCompany { get; set; }
        public DbSet<mtCompanyDetails> mtCompanyDetails { get; set; }
        public DbSet<mtConsignee> mtConsignee { get; set; }
        public DbSet<mtContainer> mtContainer { get; set; }
        public DbSet<mtCountry> mtCountry { get; set; }

        public DbSet<mtCurrency> mtCurrency { get; set; }
        public DbSet<mtCurrencyRate> mtCurrencyRate { get; set; }
        public DbSet<mtDepoContainer> mtDepoContainer { get; set; }
        public DbSet<mtDepoContainerDetails> mtDepoContainerDetails { get; set; }
        public DbSet<mtEmployee> mtEmployee { get; set; }

        public DbSet<mtGroups> mtGroups { get; set; }
        public DbSet<mtLocation> mtLocation { get; set; }
        public DbSet<mtOrders> mtOrders { get; set; }
        public DbSet<mtPortOfDestination> mtPortOfDestination { get; set; }
        public DbSet<mtPortOfLoading> mtPortOfLoading { get; set; }

        public DbSet<mtPortTerminal> mtPortTerminal { get; set; }
        public DbSet<mtProfitShared> mtProfitShared { get; set; }
        public DbSet<mtProfitSharedDetails> mtProfitSharedDetails { get; set; }
        public DbSet<mtServices> mtServices { get; set; }
        public DbSet<mtShipper> mtShipper { get; set; }

        public DbSet<mtShipperDetails> mtShipperDetails { get; set; }
        public DbSet<mtTax> mtTax { get; set; }
        public DbSet<mtType> mtType { get; set; }
        public DbSet<mtVendor> mtVendor { get; set; }
        public DbSet<mtVendorDetails> mtVendorDetails { get; set; }

        public DbSet<mtWarehouse> mtWarehouse { get; set; }
        public DbSet<mtWarehouseDetails> mtWarehouseDetails { get; set; }

        public DbSet<trCostShipping> trCostShipping { get; set; }
        public DbSet<trCostShippingService> trCostShippingService { get; set; }
        public DbSet<trCostShippingDetail> trCostShippingDetail { get; set; }
        public DbSet<trCostShippingDetailShipper> trCostShippingDetailShipper { get; set; }

        public DbSet<trSellingShipper> trSellingShipper { get; set; }
        public DbSet<trSellingShipperService> trSellingShipperService { get; set; }
        public DbSet<trSellingShipperDetail> trSellingShipperDetail { get; set; }
        public DbSet<trSellingShipperDetailVendor> trSellingShipperDetailVendor { get; set; }

        public DbSet<sysDocNo> sysDocNo { get; set; }
        public DbSet<sysModule> sysModule { get; set; }
        public DbSet<sysModuleRole> sysModuleRole { get; set; }
        public DbSet<sysUser> sysUser { get; set; }
        public DbSet<sysUserRole> sysUserRole { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //mtBank
            modelBuilder.Entity<mtCountry>().HasData(
                new mtCountry
                {
                    id = 1,
                    code = "INA",
                    description = "Indonesia",
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new mtBank
                {
                    id = 2,
                    code = "USA",
                    description = "United State of America",
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                }
            );

            //mtBank
            modelBuilder.Entity<mtBank>().HasData(
                new mtBank
                {
                    id = 1,
                    code = "BCA",
                    description = "PT. Bank Central Asia Tbk",
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new mtBank
                {
                    id = 2,
                    code = "MANDIRI",
                    description = "PT. Bank Mandiri Tbk",
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                }
            );

            //mtCurrency
            modelBuilder.Entity<mtCurrency>().HasData(
                new mtCurrency
                {
                    id = 1,
                    code = "IDR",
                    description = "Indonesian Rupiah",
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new mtCurrency
                {
                    id = 2,
                    code = "USD",
                    description = "US Dollar",
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                }
            );

            //mtBank
            modelBuilder.Entity<mtChartOfAccount>().HasData(
                new mtChartOfAccount
                {
                    id = 1,
                    code = "1-10001",
                    description = "Cash",
                    parentId = null,
                    currencyId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new mtChartOfAccount
                {
                    id = 2,
                    code = "6-60100",
                    description = "General & Administrative Expenses",
                    parentId = null,
                    currencyId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new mtChartOfAccount
                {
                    id = 3,
                    code = "6-60101",
                    description = "Salaries",
                    parentId = 2,
                    currencyId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                }
            );

            //mtType
            modelBuilder.Entity<mtType>().HasData(
                new mtType
                {
                    id = 1,
                    code = "FMG",
                    description = "FUMIGASI",
                    category = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new mtType
                {
                    id = 2,
                    code = "INS",
                    description = "INSURANCE",
                    category = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new mtType
                {
                    id = 3,
                    code = "TRUCKING",
                    description = "TRUCKING",
                    category = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new mtType
                {
                    id = 4,
                    code = "SHIPPING",
                    description = "SHIPPING",
                    category = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new mtType
                {
                    id = 5,
                    code = "COLOADER",
                    description = "COLOADER",
                    category = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new mtType
                {
                    id = 6,
                    code = "WAREHOUSE",
                    description = "WAREHOUSE",
                    category = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new mtType
                {
                    id = 7,
                    code = "INSURANCE",
                    description = "INSURANCE",
                    category = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new mtType
                {
                    id = 8,
                    code = "FUMIGASI",
                    description = "FUMIGASI",
                    category = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new mtType
                {
                    id = 9,
                    code = "UNDERNAME",
                    description = "UNDERNAME",
                    category = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new mtType
                {
                    id = 10,
                    code = "AGENT TSK",
                    description = "AGENT TSK",
                    category = 3,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new mtType
                {
                    id = 11,
                    code = "SHIPPING LINE AGENT",
                    description = "SHIPPING LINE AGENT",
                    category = 3,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new mtType
                {
                    id = 12,
                    code = "CO LOADER",
                    description = "CO LOADER",
                    category = 3,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                }
            );

            //sysDocNo
            modelBuilder.Entity<sysDocNo>().HasData(
                new sysDocNo
                {
                    id = 1,
                    module = "SellingShipper",
                    documentType = "RefNo",
                    numberFormat = "0000",
                    prefix = "SQXP-%YYYY%%mm%",
                    nextDocNo = 1,
                    suffix = "",
                    lastYear = 2018,
                    lastMonth = 1,
                    lastDay = 1,
                    resetLevel = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysDocNo
                {
                    id = 2,
                    module = "CostShipping",
                    documentType = "RefNo",
                    numberFormat = "0000",
                    prefix = "QSLXP-%YYYY%%mm%",
                    nextDocNo = 1,
                    suffix = "",
                    lastYear = 2018,
                    lastMonth = 1,
                    lastDay = 1,
                    resetLevel = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysDocNo
                {
                    id = 3,
                    module = "Employee",
                    documentType = "Image",
                    numberFormat = "0000",
                    prefix = "%YYYY%%mm%%dd%",
                    nextDocNo = 1,
                    suffix = "",
                    lastYear = 2018,
                    lastMonth = 1,
                    lastDay = 1,
                    resetLevel = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                }
            );

            //sysModule
            modelBuilder.Entity<sysModule>().HasData(
                new sysModule
                {
                    id = 1,
                    code = "Dashboard",
                    name = "Dashboard",
                    parentId = null,
                    controller = "Dashboard",
                    view = "",
                    level = 1,
                    hasChild = false,
                    orderModule = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 2,
                    code = "Master",
                    name = "Master",
                    parentId = null,
                    controller = "",
                    view = "",
                    level = 1,
                    hasChild = true,
                    orderModule = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 3,
                    code = "Transaction",
                    name = "Transaction",
                    parentId = null,
                    controller = "",
                    view = "",
                    level = 1,
                    hasChild = true,
                    orderModule = 3,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 4,
                    code = "Agent",
                    name = "Agent",
                    parentId = 2,
                    controller = "Agent",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 5,
                    code = "AgentProfitShared",
                    name = "Agent Profit Shared",
                    parentId = 2,
                    controller = "AgentProfitShared",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 6,
                    code = "Bank",
                    name = "Bank",
                    parentId = 2,
                    controller = "Bank",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 3,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 7,
                    code = "ChartOfAccount",
                    name = "Chart Of Account",
                    parentId = 2,
                    controller = "ChartOfAccount",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 4,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 8,
                    code = "Company",
                    name = "Fumigasi & Insurance",
                    parentId = 2,
                    controller = "Company",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 5,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 9,
                    code = "Consignee",
                    name = "Consignee",
                    parentId = 2,
                    controller = "Consignee",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 6,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 10,
                    code = "Container",
                    name = "Container",
                    parentId = 2,
                    controller = "Container",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 7,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 11,
                    code = "Country",
                    name = "Country",
                    parentId = 2,
                    controller = "Country",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 8,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 12,
                    code = "Currency",
                    name = "Currency",
                    parentId = 2,
                    controller = "Currency",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 9,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 13,
                    code = "CurrencyRate",
                    name = "Currency Rate",
                    parentId = 2,
                    controller = "CurrencyRate",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 10,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 14,
                    code = "DepoContainer",
                    name = "Depo Container",
                    parentId = 2,
                    controller = "DepoContainer",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 11,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 15,
                    code = "Employee",
                    name = "Employee",
                    parentId = 2,
                    controller = "Employee",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 12,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 16,
                    code = "Groups",
                    name = "Groups",
                    parentId = 2,
                    controller = "Groups",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 13,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 17,
                    code = "Orders",
                    name = "Orders",
                    parentId = 2,
                    controller = "Orders",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 16,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 18,
                    code = "Location",
                    name = "Location",
                    parentId = 2,
                    controller = "Location",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 17,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 19,
                    code = "PortOfDestination",
                    name = "Port Of Destination",
                    parentId = 2,
                    controller = "PortOfDestination",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 18,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 20,
                    code = "PortOfLoading",
                    name = "Port Of Loading",
                    parentId = 2,
                    controller = "PortOfLoading",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 19,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 21,
                    code = "PortTerminal",
                    name = "Port Terminal",
                    parentId = 2,
                    controller = "PortTerminal",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 21,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 22,
                    code = "ProfitShared",
                    name = "Profit Shared",
                    parentId = 2,
                    controller = "ProfitShared",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 22,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 23,
                    code = "Service",
                    name = "Service",
                    parentId = 2,
                    controller = "Services",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 23,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 24,
                    code = "Shipper",
                    name = "Shipper",
                    parentId = 2,
                    controller = "Shipper",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 24,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 25,
                    code = "Tax",
                    name = "Tax",
                    parentId = 2,
                    controller = "Tax",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 25,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 26,
                    code = "Type",
                    name = "Type",
                    parentId = 2,
                    controller = "Type",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 26,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 27,
                    code = "Vendor",
                    name = "Vendor",
                    parentId = 2,
                    controller = "Vendor",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 27,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 28,
                    code = "Warehouse",
                    name = "Warehouse",
                    parentId = 2,
                    controller = "Warehouse",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 28,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 29,
                    code = "CostShipping",
                    name = "Cost Shipping",
                    parentId = 3,
                    controller = "CostShipping",
                    view = "Index",
                    level = 2,
                    hasChild = false,
                    orderModule = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModule
                {
                    id = 30,
                    code = "SellingShipper",
                    name = "Selling Shipper",
                    parentId = 3,
                    controller = "SellingShipper",
                    view = "Create",
                    level = 2,
                    hasChild = false,
                    orderModule = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                }
            );

            //sysUserRole
            modelBuilder.Entity<sysUserRole>().HasData(
                new sysUserRole
                {
                    id = 1,
                    name = "Super Admin",
                    description = "Super Administrator",
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                }
            );

            //sysUser
            modelBuilder.Entity<sysUser>().HasData(
                new sysUser
                {
                    id = 1,
                    username = "admin",
                    password = new Authorize().generateHashPassword("admin"),
                    name = "Administrator",
                    email = "",
                    roleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                }
            );

            //sysModuleRole
            modelBuilder.Entity<sysModuleRole>().HasData(
                new sysModuleRole
                {
                    id = 1,
                    moduleId = 1,
                    userRoleId = 1,
                    isDefault = true,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 2,
                    moduleId = 2,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 3,
                    moduleId = 3,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 4,
                    moduleId = 4,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 5,
                    moduleId = 5,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 6,
                    moduleId = 6,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 7,
                    moduleId = 7,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 8,
                    moduleId = 8,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 9,
                    moduleId = 9,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 10,
                    moduleId = 10,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 11,
                    moduleId = 11,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 12,
                    moduleId = 12,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 13,
                    moduleId = 13,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 14,
                    moduleId = 14,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 15,
                    moduleId = 15,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 16,
                    moduleId = 16,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 17,
                    moduleId = 17,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 18,
                    moduleId = 18,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 19,
                    moduleId = 19,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 20,
                    moduleId = 20,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 21,
                    moduleId = 21,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 22,
                    moduleId = 22,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 23,
                    moduleId = 23,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 24,
                    moduleId = 24,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 25,
                    moduleId = 25,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 26,
                    moduleId = 26,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 27,
                    moduleId = 27,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 28,
                    moduleId = 28,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 29,
                    moduleId = 29,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                },
                new sysModuleRole
                {
                    id = 30,
                    moduleId = 30,
                    userRoleId = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                }
            );
        }
    }
}
