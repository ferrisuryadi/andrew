using System;
using System.Linq;
using fms.Models;
using Microsoft.EntityFrameworkCore;

namespace fms.Common
{
    public class SystemDocumentNo
    {
        protected ApplicationDbContext mContext;

        public SystemDocumentNo(ApplicationDbContext context)
        {
            mContext = context;
        }

        public string getDocNo(string module, string documentType, bool update)
        {
            string result = "";

            string user = "System";
            DateTime txDate = DateTime.Now;

            string numberFormat;
            string prefix;
            int nextDocNo;
            string suffix;
            int resetLevel;

            int lastYear;
            int lastMonth;
            int lastDay;

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;

            sysDocNo SysDocNo = mContext.sysDocNo.Where(
                x => x.isActive == true && 
                x.module == module && 
                x.documentType == documentType
            ).SingleOrDefault();

            if (SysDocNo != null)
            {
                numberFormat = SysDocNo.numberFormat;
                prefix = SysDocNo.prefix;
                nextDocNo = SysDocNo.nextDocNo;
                suffix = SysDocNo.suffix;
                resetLevel = SysDocNo.resetLevel;

                lastYear = SysDocNo.lastYear;
                lastMonth = SysDocNo.lastMonth;
                lastDay = SysDocNo.lastDay;

                result = prefix;

                switch (resetLevel){
                    case 1: //day
                        if ((lastYear != year) || (lastMonth != month) || (lastDay != day))
                        {
                            lastYear = year;
                            lastMonth = month;
                            lastDay = day;

                            nextDocNo = 1;
                        }
                        break;
                    case 2: //month
                        if ((lastYear != year) || (lastMonth != month) )
                        {
                            lastYear = year;
                            lastMonth = month;
                            lastDay = 1;

                            nextDocNo = 1;
                        }
                        break;

                    case 3: //year
                        if (lastYear != year) 
                        {
                            lastYear = year;
                            lastMonth = 1;
                            lastDay = 1;

                            nextDocNo = 1;
                        }
                        break;
                }

                //replace format %YYYY% with year
                result = result.Replace("%YYYY%", lastYear.ToString());
                //replace format %mm% with month
                result = result.Replace("%mm%", String.Format("{0:00}", lastMonth.ToString()));
                //replace format %dd% with day
                result = result.Replace("%dd%", String.Format("{0:00}", lastDay.ToString()));
                result = string.Concat(result, String.Format(string.Concat("{0:", numberFormat, "}"), nextDocNo), suffix);

                if(update){
                    //update data
                    SysDocNo.lastDay = lastDay;
                    SysDocNo.lastMonth = lastMonth;
                    SysDocNo.lastYear = lastYear;
                    SysDocNo.nextDocNo = (nextDocNo + 1);
                    SysDocNo.updatedBy = user;
                    SysDocNo.updatedOn = txDate;

                    mContext.Entry(SysDocNo).State = EntityState.Modified;
                    mContext.SaveChanges();
                }
            }

            return result;
        }
    }
}
