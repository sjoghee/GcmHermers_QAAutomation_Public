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
    public class QAInvestorFundReports
    {

        IWebDriver QAReportsDriver;
        HermesBase objbase = new HermesBase();

        [TestMethod]
        public void Validatate_InvestorFund_InvestmentsMonitor_Report()
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

             //   QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);


        //        objbase.WaitUntilFrameLoadedAndSwitchToIt(By.Name("tabedindex"));
        //        QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

                QAReportsDriver.FindElement(By.Name("tabedindex"));
                objbase.WaitForFrameload();
                var wdwaittabedindex = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(30));
                wdwaittabedindex.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("tabedindex"));
                objbase.WaitForFrameload();
         
                IWebElement eleInvestorFund = QAReportsDriver.FindElement(By.Id("tabid1"));
                objbase.WaitforPageRefresh();
                QAReportexecutor.ExecuteScript("arguments[0].click();", eleInvestorFund);
                objbase.WaitforPortfolioload();
                QAReportsDriver.SwitchTo().DefaultContent();


               // IWebElement frmtabview = QAReportsDriver.FindElement(By.Name("tabview"));
               // QAReportsDriver.SwitchTo().Frame(frmtabview).SwitchTo().Frame("frametree1");

                QAReportsDriver.FindElement(By.Name("tabview"));
                var wdwaittabview = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(30));
                wdwaittabview.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("tabview"));
                objbase.WaitforPageload();

                QAReportsDriver.FindElement(By.Name("frametree1"));
                objbase.WaitforPageload();
                var wdwaitfrmtree1 = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(30));
                wdwaitfrmtree1.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("frametree1"));
                objbase.WaitforPageload();
                
                IWebElement Investorfund = QAReportsDriver.FindElement(By.LinkText(ConfigurationSettings.AppSettings["InvestorSelectFund"]));
                QAReportexecutor.ExecuteScript("arguments[0].click();", Investorfund);
                objbase.WaitforPageload();
                QAReportsDriver.SwitchTo().DefaultContent();

               
              //  IWebElement frmtabview1 = QAReportsDriver.FindElement(By.Name("tabview"));

                QAReportsDriver.FindElement(By.Name("tabview"));
                var wdtabview1 = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(30));
                wdtabview1.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("tabview"));
                objbase.WaitforPageload();

                QAReportsDriver.FindElement(By.Name("frametree4"));
                var wdwaitframetree4 = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(30));
                wdwaitframetree4.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("frametree4"));
                objbase.WaitforPageload();

               // QAReportsDriver.SwitchTo().Frame(frmtabview1).SwitchTo().Frame("frametree4");

                IWebElement treetable = QAReportsDriver.FindElement(By.Id("tree1table"));
                objbase.WaitforPageRefresh();

                
                IWebElement eleaccfeereport = treetable.FindElement(By.Id("i04"));
                eleaccfeereport.Click();
                objbase.WaitforAlert();
               // QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                try
                {
                    var potfolioloadwait = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(60));
                    potfolioloadwait.Until(ExpectedConditions.AlertIsPresent());
                    QAReportsDriver.SwitchTo().Alert().Accept();
                    objbase.WaitforPageRefresh();
                }
                catch (Exception EX)
                { }

                // QAReportsDriver.SwitchTo().DefaultContent();

                QAReportsDriver.SwitchTo().Window(QAReportsDriver.WindowHandles.Last());
              //  objbase.WaitforPageRefresh();
                QAReportsDriver.Manage().Window.Maximize();
                objbase.WaitforPageRefresh();

              

                QAReportsDriver.FindElement(By.Name("frametree1"));
                objbase.WaitforPageload();
                var wdframetreeforreporrtpage = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(30));
                wdframetreeforreporrtpage.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("frametree1"));
                objbase.WaitforPageload();

                IWebElement tbltreet = QAReportsDriver.FindElement(By.Id("tree1table"));
                IWebElement eleportfolioid = tbltreet.FindElement(By.Id("portfolioid"));
                QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //objbase.WaitforPageRefresh();

                SelectElement seleportfolioid = new SelectElement(eleportfolioid);
                seleportfolioid.SelectByValue(ConfigurationSettings.AppSettings["InvestorPortfolioId"]);
                objbase.WaitforReportPage();

                QAReportsDriver.Quit();

               
              

            }
            catch (Exception exinvestorFundInvestmentsMonitor)
            {
                Console.WriteLine("QA Investestor Fund Exception :"+ exinvestorFundInvestmentsMonitor.Message.ToString());
                QAReportsDriver.Quit();
            }
        }

    }
}
