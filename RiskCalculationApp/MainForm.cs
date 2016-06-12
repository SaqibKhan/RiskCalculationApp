using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DAL.CSVReader;
using RiskCalculationApp.Forms;
using RiskCalculator.Common;

namespace RiskCalculationApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();

        }
        private void tabCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCustomers();
        }
        private void GvsattledCustomer_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var row = GvsattledCustomer.Rows[e.RowIndex];

            var obj = (Winner)row.DataBoundItem;

           
            foreach (DataGridViewCell cell in row.Cells)
            {
                cell.Style.BackColor = obj.Percentage > 60 ? Color.Tomato : Color.White;
               
            }

        }

        private void btnUnUsualWiners_Click(object sender, EventArgs e)
        {
            var selectedRow = GvsattledCustomer.SelectedRows;

            if (selectedRow.Count > 0)
            {
                var objCustomer = (Winner)selectedRow[0].DataBoundItem;
                ShowCustomerDetatils(objCustomer.Customer);
            }
            else
            {

                MessageBox.Show(@"Please select any record", @"Select Record");
            }
        }
        private void GvsattledCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = GvsattledCustomer.Rows[e.RowIndex];
            var obj = (Winner)row.DataBoundItem;
            ShowCustomerDetatils(obj.Customer);
        }
     /// <summary>
     /// this funcation is used to change the grid cell colors
     /// </summary>
        private void ChangeRowsStyle(){
            var lstUnSattledBids = (List<UnsettledBids>)gvUnsattledCustomers.DataSource;
            var unUsaulAmounttoWin = 1000;
            gvUnsattledCustomers.Columns[0].Visible = false;
            foreach (DataGridViewRow row in gvUnsattledCustomers.Rows)
            {
                var obj = (UnsettledBids) row.DataBoundItem;
                var customerlist = lstUnSattledBids.Where(item => item.Customer == obj.Customer 
                    && item.ID!=obj.ID).ToList();
                int total = customerlist.Sum(customer => customer.Stake);
                int avgBit = total/(customerlist.Count-1);
                
                if (obj.ToWin >= unUsaulAmounttoWin)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.LightSalmon;
                    }
                }
                if (obj.Stake > (avgBit*10))
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.Red;
                    }
                }
                if (obj.Stake > (avgBit*30))
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.DarkRed;
                    }
                }
            }
        }
        
        #endregion
        
        
        #region Private Funcations
      
        
        /// <summary>
        /// load Customer based on selected Tab
        /// </summary>
        private void LoadCustomers()
        {
            switch (tabCustomers.SelectedIndex)
            {
                case 0:
                    var lstSattledCustomer = GetSattledCustomerList();

                    var lstdistinctCustomer = lstSattledCustomer.GroupBy(customer => customer.Customer).ToList(); //  group the coustomer by their id
                    var lstCustomerWhoWins = lstSattledCustomer.Where(item => item.Win > 0).GroupBy(customer => customer.Customer).ToList(); //groupe the only winning customers by their customerId

                    var customerWinMoreThen60Percent = (from totalCustomer in lstdistinctCustomer
                                                        join winners in lstCustomerWhoWins on totalCustomer.Key equals winners.Key
                                                        // where ((Convert.ToDecimal(winners.ToList().Sum(customervalue => customervalue.Win) / totalCustomer.ToList().Sum(customervalue => customervalue.Stake)) * 100) > 60)
                                                        select new Winner()
                                                        {
                                                            Customer = winners.Key,
                                                            TotalStack = totalCustomer.ToList().Sum(customervalue => customervalue.Stake),
                                                            TotalWin = winners.ToList().Sum(customervalue => customervalue.Win),
                                                            Percentage = (Convert.ToDecimal(winners.ToList().Sum(customervalue => customervalue.Win) / totalCustomer.ToList().Sum(customervalue => customervalue.Stake)) * 100)

                                                        }).ToList();
                    GvsattledCustomer.DataSource = customerWinMoreThen60Percent;
                    break;
                case 1:
                   gvUnsattledCustomers.DataSource = GetUnSattledCustomerList();
                    ChangeRowsStyle();
                    break;
            }
        }

 /// <summary>
 /// Get the of list of Sattled bits form CSV file
 /// </summary>
 /// <returns></returns>
   
        private List<SettledBit> GetSattledCustomerList()
        {
            var lstSattledBits = SettledReader.GetAllSettledCustomers();

            return lstSattledBits;
        }
        /// <summary>
        /// Get the Unsattled Bits Customers
        /// </summary>
        /// <returns></returns>
        private List<UnsettledBids> GetUnSattledCustomerList()
        {
            return UnSettledReader.GetAllUnSettledCustomers();
        }
      /// <summary>
      /// load the sattled bit customers hisotry havint unsual wins
      /// </summary>
      /// <param name="customerid"></param>
        private void ShowCustomerDetatils(int customerid)
        {
            var lstSattledCustomers = GetSattledCustomerList();
            lstSattledCustomers = lstSattledCustomers.Where(customer => customer.Customer == customerid).ToList();
            var sattledWinner = new FormSattledWinner(lstSattledCustomers);
            sattledWinner.ShowDialog();


        }

        #endregion

     

        

       

    

      
    }
}
