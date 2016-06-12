using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using RiskCalculator.Common;

namespace DAL.CSVReader
{
    public static class SettledReader
    {
        public static List<SettledBit> GetAllSettledCustomers()
        {
            List<SettledBit> settledrecords = null;

            using (var sr = new StreamReader(Config.SattledFilePath))
            {
                var reader = new CsvReader(sr);
                settledrecords = reader.GetRecords<SettledBit>().ToList();
            }

            return settledrecords;
        }

    }
}
