using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using RiskCalculator.Common;

namespace DAL.CSVReader
{
    public static class UnSettledReader
    {
        public static List<UnsettledBids> GetAllUnSettledCustomers()
        {
            List<UnsettledBids> unsettledrecords = null;

            using (var sr = new StreamReader(Config.UnSattledFilePath))
            {
                var reader = new CsvReader(sr);
                unsettledrecords = reader.GetRecords<UnsettledBids>().OrderBy(item=>item.Customer).ToList();
            }

            return unsettledrecords;
        }

    }
}
