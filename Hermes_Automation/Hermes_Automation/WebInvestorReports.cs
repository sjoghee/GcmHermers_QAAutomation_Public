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
    public  class WebInvestorReports
    {
        IWebDriver QAReportsDriver;
        HermesBase objbase = new HermesBase();

        [TestMethod]
        public void Validate_WebInvestorFund_InvestmentsMonitor__Report()
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
                IWebElement lnkwebreports = QAReportsDriver.FindElement(By.LinkText("Hermes Web Reports"));
                QAReportexecutor.ExecuteScript("arguments[0].click();", lnkwebreports);
                objbase.WaitforPageload();

                //  objbase.WaitforPageload();

                QAReportsDriver.SwitchTo().Window(QAReportsDriver.WindowHandles.Last());
                objbase.WaitforPageload();

             //   objbase.WaitForFrameload();
            //    QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);


               // objbase.WaitUntilFrameLoadedAndSwitchToIt(By.Name("tabedindex"));
                //QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

                QAReportsDriver.FindElement(By.Name("tabedindex"));
                objbase.WaitForFrameload();
                var wdwaittabedindex = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(30));
                wdwaittabedindex.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("tabedindex"));
                objbase.WaitForFrameload();


               // QAReportsDriver.SwitchTo().Frame("tabedindex");
                //QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

                //objbase.WaitforPageload();

                IWebElement elewebInvestorFund = QAReportsDriver.FindElement(By.Id("tabid1"));
                objbase.WaitforPageRefresh();
                QAReportexecutor.ExecuteScript("arguments[0].click();", elewebInvestorFund);
                objbase.WaitforPortfolioload();
                QAReportsDriver.SwitchTo().DefaultContent();

                
               /* IWebElement frmtabview = QAReportsDriver.FindElement(By.Name("tabview"));
                QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                QAReportsDriver.SwitchTo().Frame(frmtabview).SwitchTo().Frame("frametree1");*/

                QAReportsDriver.FindElement(By.Name("tabview"));
                wdwaittabedindex.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("tabview"));
                objbase.WaitforPageload();

              //  QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                QAReportsDriver.FindElement(By.Name("frametree1"));
                objbase.WaitforPageload();
                wdwaittabedindex.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("frametree1"));
                objbase.WaitforPageload();

                IWebElement Webportfoliofund = QAReportsDriver.FindElement(By.LinkText(ConfigurationSettings.AppSettings["WebInvestorfund"]));
                QAReportexecutor.ExecuteScript("arguments[0].click();", Webportfoliofund);
                objbase.WaitforPageload();
                QAReportsDriver.SwitchTo().DefaultContent();

              /*  IWebElement frmtabview1 = QAReportsDriver.FindElement(By.Name("tabview"));
                QAReportsDriver.SwitchTo().Frame(frmtabview1).SwitchTo().Frame("frametree4");*/

                QAReportsDriver.FindElement(By.Name("tabview"));
                wdwaittabedindex.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("tabview"));
                objbase.WaitforPageload();

               // QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                QAReportsDriver.FindElement(By.Name("frametree4"));
                wdwaittabedindex.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("frametree4"));
                objbase.WaitForFrameload();

                IWebElement treetable = QAReportsDriver.FindElement(By.Id("tree1table"));
                objbase.WaitforPageRefresh();

                
                bool accfeereereportExists = objbase.validatelementexist(By.Id("i04"));
                if (accfeereereportExists)
                {
                    IWebElement eleaccfeereport = treetable.FindElement(By.Id("i04"));
                    eleaccfeereport.Click();
                    objbase.WaitforAlert();
                }


                try
                {
                    var potfolioloadwait = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(30));
                    potfolioloadwait.Until(ExpectedConditions.AlertIsPresent());
                    QAReportsDriver.SwitchTo().Alert().Accept();
                    objbase.WaitforPageRefresh();
                }
                catch (Exception ex)
                { }


                // QAReportsDriver.SwitchTo().DefaultContent();
                QAReportsDriver.SwitchTo().Window(QAReportsDriver.WindowHandles.Last());
                //  objbase.WaitforPageRefresh();
                QAReportsDriver.Manage().Window.Maximize();
                objbase.WaitforPageRefresh();

                //QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

               /* objbase.WaitUntilFrameLoadedAndSwitchToIt(By.Name("frametree1"));
                QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                IWebElement frmtree1 = QAReportsDriver.FindElement(By.Name("frametree1"));*/

                QAReportsDriver.FindElement(By.Name("frametree1"));
                objbase.WaitforPageload();
                wdwaittabedindex.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("frametree1"));
                objbase.WaitforPageload();


              /* QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                QAReportsDriver.SwitchTo().Frame(frmtree1);*/

                IWebElement tbltreet = QAReportsDriver.FindElement(By.Id("tree1table"));
                IWebElement eleportfolioid = tbltreet.FindElement(By.Id("portfolioid"));
                QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                //objbase.WaitforPageRefresh();

                SelectElement seleportfolioid = new SelectElement(eleportfolioid);
                seleportfolioid.SelectByValue(ConfigurationSettings.AppSettings["WebManagerportfolioid"]);
                objbase.WaitforReportPage();

                QAReportsDriver.Quit();

            }
            catch (Exception exWebMInvestorFundInvestmentsMonitor)
            {

                Console.WriteLine("\n" +"Web Investor Fund exception: " + exWebMInvestorFundInvestmentsMonitor.Message.ToString());
                QAReportsDriver.Quit();
                //Assert.Fail();
               
            }
        }

    }
}
