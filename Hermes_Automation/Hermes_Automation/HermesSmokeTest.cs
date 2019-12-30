using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hermes_Automation
{
    [TestClass]
   public class HermesSmokeTest
    {
      
        HermesBase objbase = new HermesBase();

           
        [TestMethod]
        public void Hermes_SmokeTest()
        {
            try
            {
                ManagerPricing objmp = new ManagerPricing();
                QAReportsManagerFund qamgrfund = new QAReportsManagerFund();
                QAReports QAPortfoliofund = new QAReports();
                QAInvestorFundReports qainvestor = new QAInvestorFundReports();
                QAReportsLogout qalogout = new QAReportsLogout();

                WebPortfolioreports webportfolioobj = new WebPortfolioreports();
                WebManagerFundReports webmgrobj = new WebManagerFundReports();
                WebInvestorReports webinvobj = new WebInvestorReports();
                WebReportLogout weblogobj = new WebReportLogout();

                objmp.Validate_Manager_Pricing();
                QAPortfoliofund.ValidateQAReport_PortfolioFund();
                qamgrfund.Validatate_ManagerFund_InvestmentsMonitor_Report();
                qainvestor.Validatate_InvestorFund_InvestmentsMonitor_Report();
                qalogout.Validatate_LogoutPage();

                webportfolioobj.Validate_Web_InvestmentsMonitor__Report();
                webmgrobj.Validate_WebManagerFund_InvestmentsMonitor__Report();
                webinvobj.Validate_WebInvestorFund_InvestmentsMonitor__Report();
                weblogobj.Validatate_WebreportLogoutPage();
                  
                 
                  

                  

            }
            catch (Exception exHermessmoke)
            {
                
                Console.WriteLine("Hermes smoke exception: " + exHermessmoke.Message.ToString());
            }

        }
    }
}
