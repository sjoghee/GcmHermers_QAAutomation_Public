using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

//using System.Collections.Generic;
//using System.Collections;
using System.Threading;

using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;


namespace Hermes_Automation
{
    [TestClass]
    public class QAReports
    {
        IWebDriver QAReportsDriver;
        HermesBase objbase = new HermesBase();

       

       

        [TestMethod]
        public void ValidateQAReport_PortfolioFund()
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
               // QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                objbase.WaitforPageload();

                QAReportsDriver.FindElement(By.Name("tabedindex"));
                objbase.WaitForFrameload();
                var wdwaittabbedindex = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(30));
                wdwaittabbedindex.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("tabedindex"));
                objbase.WaitForFrameload();
                           
               
                IWebElement elePortfolioFund = QAReportsDriver.FindElement(By.Id("tabid9"));
                objbase.WaitforPageRefresh();
                QAReportexecutor.ExecuteScript("arguments[0].click();", elePortfolioFund);
                objbase.WaitforPortfolioload();
                QAReportsDriver.SwitchTo().DefaultContent();
                //objbase.WaitforPortfolioload();
                                                                
             
                QAReportsDriver.FindElement(By.Name("tabview"));
                wdwaittabbedindex.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("tabview"));
                objbase.WaitforPageload();

                QAReportsDriver.FindElement(By.Name("frametree1"));
                objbase.WaitForFrameload();
                wdwaittabbedindex.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("frametree1"));
                objbase.WaitForFrameload();


                IWebElement eleporfolio = QAReportsDriver.FindElement(By.LinkText(ConfigurationSettings.AppSettings["portfoliofund"]));
                QAReportexecutor.ExecuteScript("arguments[0].click();", eleporfolio);
               // objbase.WaitforPageload();
                QAReportsDriver.SwitchTo().DefaultContent();
                objbase.WaitforPageload();


                QAReportsDriver.FindElement(By.Name("tabview"));
                wdwaittabbedindex.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("tabview"));
                objbase.WaitforPageload();

                QAReportsDriver.FindElement(By.Name("frametree4"));
                wdwaittabbedindex.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("frametree4"));
                objbase.WaitforPageload();

                IWebElement treetable = QAReportsDriver.FindElement(By.Id("tree1table"));
                objbase.WaitforPageRefresh();
            
                IWebElement eleaccfeereport = treetable.FindElement(By.Id("i04"));
                eleaccfeereport.Click();
                objbase.WaitforAlert();

                try
                {
                    WebDriverWait wwait = new WebDriverWait(QAReportsDriver, TimeSpan.FromSeconds(30));
                    wwait.Until(ExpectedConditions.AlertIsPresent());
                    QAReportsDriver.SwitchTo().Alert().Accept();
                    objbase.WaitforPageRefresh();
                }
                catch (Exception EX)
                { }
                              
                QAReportsDriver.SwitchTo().Window(QAReportsDriver.WindowHandles.Last());
                objbase.WaitforPageRefresh();
                QAReportsDriver.Manage().Window.Maximize();
                objbase.WaitforPageRefresh();


                QAReportsDriver.FindElement(By.Name("frametree1"));
                objbase.WaitforPageload();
                wdwaittabbedindex.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt("frametree1"));
                objbase.WaitforPageload();


                IWebElement tbltreet = QAReportsDriver.FindElement(By.Id("tree1table"));
                IWebElement eleportfolioid = tbltreet.FindElement(By.Id("portfolioid"));
                QAReportsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                             
                //objbase.WaitforPageRefresh();

                SelectElement seleportfolioid = new SelectElement(eleportfolioid);
                seleportfolioid.SelectByValue(ConfigurationSettings.AppSettings["Portfolioid"]);
                objbase.WaitforReportPage();
                QAReportsDriver.Quit();
              
                    
                                                                            
            }
            catch(Exception exqareport)
            {
                Console.WriteLine("QA Report exception: " + exqareport.Message.ToString());
                QAReportsDriver.Quit();
            }

        

    
       
        }
    }
}
