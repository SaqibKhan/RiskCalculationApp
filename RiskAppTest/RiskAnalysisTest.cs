using DAL.CSVReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiskCalculationApp;

namespace RiskAppTest
{
    [TestClass]
    public class RiskAnalysisTest
    {
        [TestMethod]
        public void GetSattledBids()
        {
            var sattledBids = SettledReader.GetAllSettledCustomers();
            Assert.IsNotNull(sattledBids);
        }

        [TestMethod]
        public void GetUnSattledBids()
        {
            var uNsattledBids = UnSettledReader.GetAllUnSettledCustomers();
            Assert.IsNotNull(uNsattledBids);
        }

        [TestMethod]
        public void LoadForm()
        {
            var form = new MainForm();
            form.Show();
            Assert.IsNotNull(form);
        }
    }
}