using System;
using Microsoft.EntityFrameworkCore;
using fms.Models;

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
        public DbSet<mtUser> mtUser { get; set; }
        public DbSet<mtUserRole> mtUserRole { get; set; }

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

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
            
            InitialData initialData = new InitialData(this);
        }
    }
}
