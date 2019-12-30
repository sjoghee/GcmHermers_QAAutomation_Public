using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

using System.Threading;

using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Hermes_Automation
{
    [TestClass]
  public  class QAReportsManagerFund
    {
        IWebDriver QAReportsDriver;
        HermesBase objbase = new HermesBase();

        [TestMethod]
        public void Validatate_ManagerFund_InvestmentsMonitor_Report()
        {
            try
            {

                QAReportsDriver = objbase.Initializedriver();
                QAReportsDriver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                QAReportsDriver.Manage().Window.Maximize();
                objbase.WaitforPageload();

                IWebElement elelnkreport = QAReportsDriver.FindElement(By.Id("btnReports"));
                IJavaScriptExecutor QAReportexecutor = (IJavaScriptExecutor)QAReportsDriver;
                QAReportexecutor.ExecuteScript("arguments[0].click();", elelnkreport);
                objbase.WaitforPageload();

                IWebElement tableqareportsmenu = QAReportsDriver.FindElement(By.Id("reportsMenu"));
                objbase.WaitforPageload();
                
                IWebElement lnkqareports = QAReportsDriver.FindElement(By.LinkText("Hermes QA Reports"));
                QAReportexecutor.ExecuteScript("arguments[0].click();", lnkqareports);
                objbase.WaitforPageload();
              

                QAReportsDriver.SwitchTo().Window(QAReportsDriver.WindowHandles.Last());
                objbase.WaitforPageload();

               // QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                IWebElement eletabedindex = QAReportsDriver.FindElement(By.Name("tabedindex"));
                objbase.WaitForFrameload();
                var wdwaittabedindex = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(30));
                wdwaittabedindex.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("tabedindex"));
                objbase.WaitForFrameload();


               // QAReportsDriver.SwitchTo().Frame("tabedindex");
               // QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                //objbase.WaitforPageload();

                IWebElement eleInvestorFund = QAReportsDriver.FindElement(By.Id("tabid8"));
                objbase.WaitforPageRefresh();
                QAReportexecutor.ExecuteScript("arguments[0].click();", eleInvestorFund);
                objbase.WaitforPortfolioload();
                QAReportsDriver.SwitchTo().DefaultContent();

                
                IWebElement frmtabview = QAReportsDriver.FindElement(By.Name("tabview"));
                var framewaittabview = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(30));
                framewaittabview.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("tabview"));
                objbase.WaitforPageload();

               // QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

              
              //  QAReportsDriver.SwitchTo().Frame(frmtabview).SwitchTo().Frame("frametree1");
              //  QAReportsDriver.SwitchTo().Frame("tabview");

                QAReportsDriver.FindElement(By.Name("frametree1"));
                objbase.WaitforPageload();
                var wdwaitfrmframetree1 = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(30));
                wdwaitfrmframetree1.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("frametree1"));
                objbase.WaitforPageload();

             //   QAReportsDriver.SwitchTo().Frame("frametree1");

                /* break into two switch statements*/

                IWebElement eleporfolio = QAReportsDriver.FindElement(By.LinkText(ConfigurationSettings.AppSettings["selectfund"]));
                QAReportexecutor.ExecuteScript("arguments[0].click();", eleporfolio);
                objbase.WaitforPageload();
                QAReportsDriver.SwitchTo().DefaultContent();

                IWebElement frmtabview1 = QAReportsDriver.FindElement(By.Name("tabview"));
                var waitfortabview1 = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(30));
                waitfortabview1.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("tabview"));
                objbase.WaitforPageload();


                IWebElement frmFrametree4 = QAReportsDriver.FindElement(By.Id("frametree4"));
                var  wdwaitframetree4 = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(30));
                wdwaitframetree4.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("frametree4"));
                objbase.WaitforPageload();

                /****/


            //    QAReportsDriver.SwitchTo().Frame(frmtabview1).SwitchTo().Frame("frametree4");
                IWebElement treetable = QAReportsDriver.FindElement(By.Id("tree1table"));
                objbase.WaitforPageRefresh();

                IWebElement eleaccfeereport = treetable.FindElement(By.Id("i04"));
                eleaccfeereport.Click();
                objbase.WaitforAlert();

                try
                {
                    var potfolioloadwait = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(60));
                    potfolioloadwait.Until(ExpectedConditions.AlertIsPresent());
                    QAReportsDriver.SwitchTo().Alert().Accept();
                    objbase.WaitforPageRefresh();
                }
                catch(Exception ex)
                {}
               // QAReportsDriver.SwitchTo().DefaultContent();

                QAReportsDriver.SwitchTo().Window(QAReportsDriver.WindowHandles.Last());
                QAReportsDriver.Manage().Window.Maximize();
                objbase.WaitforPageRefresh();

               // QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
         
                QAReportsDriver.FindElement(By.Name("frametree1"));
                objbase.WaitforPageload();
                var waitforframetree1 = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(30));
                waitforframetree1.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("frametree1"));
                objbase.WaitforPageload();
           
                IWebElement tbltreet = QAReportsDriver.FindElement(By.Id("tree1table"));
                IWebElement eleportfolioid = tbltreet.FindElement(By.Id("portfolioid"));
                QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //objbase.WaitforPageRefresh();

                SelectElement seleportfolioid = new SelectElement(eleportfolioid);
                seleportfolioid.SelectByValue(ConfigurationSettings.AppSettings["ManagerPortfolioid"]);
                objbase.WaitforReportPage();
              //  Assert.IsTrue(QAReportsDriver.PageSource.Contains("GROSVENOR"));
                QAReportsDriver.Quit();

        

            }
            catch (Exception exInvestor)
            {
                Console.WriteLine(" QA Manager Fund Exception :" + exInvestor.Message.ToString());
                QAReportsDriver.Quit();
            }
        }

    }
}
