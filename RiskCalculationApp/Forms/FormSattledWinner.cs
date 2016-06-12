using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RiskCalculator.Common;

namespace RiskCalculationApp.Forms
{
    public partial class FormSattledWinner : Form
    {
        List<SettledBit> _sattledCustomerList = null;

        public List<SettledBit> SattledCustomerList
        {
            get { return _sattledCustomerList; }
            set { _sattledCustomerList = value; }
        }

        public FormSattledWinner()
        {
            InitializeComponent();
        }
        public FormSattledWinner(List<SettledBit> sattledCustomerList)
        {
            InitializeComponent();
            _sattledCustomerList = sattledCustomerList;
        }

        private void FormSattledWinner_Load(object sender, EventArgs e)
        {
             GvsattledWinners.DataSource = _sattledCustomerList;
        
        }

       
          
          

    }
}
