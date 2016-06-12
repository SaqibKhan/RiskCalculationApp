using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskCalculator.Common
{
    public class Winner
    {
        public int Customer { get; set; }
        public int TotalStack { get; set; }
        public int TotalWin { get; set; }

        public decimal Percentage { get; set; }
    }
}
