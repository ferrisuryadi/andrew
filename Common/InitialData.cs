using System;
using System.Linq;
using fms.Models;

namespace fms
{
    public class InitialData
    {
        protected ApplicationDbContext Icontext;
        public InitialData(ApplicationDbContext context)
        {
            Icontext = context;
            mtBank();
            mtCurrency();
            mtChartOfAccount();
            mtType();
            sysDocNo();
        }

        private void mtBank(){
            if (!Icontext.mtBank.Any()){
                Icontext.mtBank.Add(new mtBank
                {
                    code = "BCA",
                    description = "PT. Bank Central Asia Tbk",
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });

                Icontext.mtBank.Add(new mtBank
                {
                    code = "MANDIRI",
                    description = "PT. Bank Mandiri Tbk",
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });

                Icontext.SaveChanges();
            }

        }

        private void mtChartOfAccount()
        {
            if (!Icontext.mtChartOfAccount.Any())
            {
                Icontext.mtChartOfAccount.Add(new mtChartOfAccount
                {
                    code = "1-10001",
                    description = "Cash",
                    parentId = null,
                    currency = Icontext.mtCurrency.Find(1),
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });

                Icontext.mtChartOfAccount.Add(new mtChartOfAccount
                {
                    code = "6-60100",
                    description = "General & Administrative Expenses",
                    parentId = null,
                    currency = Icontext.mtCurrency.Find(1),
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });

                Icontext.mtChartOfAccount.Add(new mtChartOfAccount
                {
                    code = "6-60101",
                    description = "Salaries",
                    parentId = 2,
                    currency = Icontext.mtCurrency.Find(1),
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });
                Icontext.SaveChanges();
            }
        }

        private void mtCurrency()
        {
            if (!Icontext.mtCurrency.Any())
            {
                Icontext.mtCurrency.Add(new mtCurrency
                {
                    code = "IDR",
                    description = "Indonesian Rupiah",
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });

                Icontext.mtCurrency.Add(new mtCurrency
                {
                    code = "USD",
                    description = "US Dollar",
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });

                Icontext.SaveChanges();
            }
        }

        private void mtType()
        {
            if (!Icontext.mtType.Any())
            {
                Icontext.mtType.Add(new mtType
                {
                    code = "FMG",
                    description = "FUMIGASI",
                    category = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });

                Icontext.mtType.Add(new mtType
                {
                    code = "INS",
                    description = "INSURANCE",
                    category = 1,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });

                Icontext.mtType.Add(new mtType
                {
                    code = "TRUCKING",
                    description = "TRUCKING",
                    category = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });

                Icontext.mtType.Add(new mtType
                {
                    code = "SHIPPING",
                    description = "SHIPPING",
                    category = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });

                Icontext.mtType.Add(new mtType
                {
                    code = "COLOADER",
                    description = "COLOADER",
                    category = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });

                Icontext.mtType.Add(new mtType
                {
                    code = "WAREHOUSE",
                    description = "WAREHOUSE",
                    category = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });

                Icontext.mtType.Add(new mtType
                {
                    code = "INSURANCE",
                    description = "INSURANCE",
                    category = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });

                Icontext.mtType.Add(new mtType
                {
                    code = "FUMIGASI",
                    description = "FUMIGASI",
                    category = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });

                Icontext.mtType.Add(new mtType
                {
                    code = "UNDERNAME",
                    description = "UNDERNAME",
                    category = 2,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });

                Icontext.mtType.Add(new mtType
                {
                    code = "AGENT TSK",
                    description = "AGENT TSK",
                    category = 3,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });

                Icontext.mtType.Add(new mtType
                {
                    code = "SHIPPING LINE AGENT",
                    description = "SHIPPING LINE AGENT",
                    category = 3,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });

                Icontext.mtType.Add(new mtType
                {
                    code = "CO LOADER",
                    description = "CO LOADER",
                    category = 3,
                    isActive = true,
                    createdBy = "admin",
                    createdOn = DateTime.Now,
                    updatedBy = "admin",
                    updatedOn = DateTime.Now
                });

                Icontext.SaveChanges();
            }
        }

        private void sysDocNo()
        {
            if (!Icontext.sysDocNo.Any())
            {
                Icontext.sysDocNo.Add(new sysDocNo
                {
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
                });

                Icontext.SaveChanges();
            }
        }
    }
}
