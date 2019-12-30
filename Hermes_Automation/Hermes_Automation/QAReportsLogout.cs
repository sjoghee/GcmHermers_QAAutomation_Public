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
    public class QAReportsLogout
    {
        IWebDriver QAReportsDriver;
        HermesBase objbase = new HermesBase();

        [TestMethod]
        public void Validatate_LogoutPage()
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
                //QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                objbase.WaitforPageRefresh();

               /* objbase.WaitUntilFrameLoadedAndSwitchToIt(By.Name("tabedindex"));
                QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

                QAReportsDriver.SwitchTo().Frame("tabedindex");*/

                QAReportsDriver.FindElement(By.Name("tabedindex"));
                objbase.WaitForFrameload();
                var wdwatfortabbedindex = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(30));
                wdwatfortabbedindex.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("tabedindex"));
                objbase.WaitForFrameload();

                //objbase.WaitforPageload();
                IWebElement eleInvestorFund = QAReportsDriver.FindElement(By.Id("tabid13"));
                objbase.WaitforPageRefresh();
                QAReportexecutor.ExecuteScript("arguments[0].click();", eleInvestorFund);
                objbase.WaitforPortfolioload();
                QAReportsDriver.SwitchTo().DefaultContent();
                QAReportsDriver.Quit();
            }
            catch (Exception exlogout)
            {
                Console.WriteLine(" QA Logout exception " + exlogout.Message.ToString());
                QAReportsDriver.Quit();
            }
        }
    }
}
