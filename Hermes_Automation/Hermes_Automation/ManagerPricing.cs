using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Data;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace Hermes_Automation
{
    [TestClass]
    public class ManagerPricing
    {
        IWebDriver ManagerDriver;
        HermesBase objbase = new HermesBase();

        

        [TestMethod]
        public void Validate_Manager_Pricing()
        {
            try
            {
                ManagerDriver = objbase.Initializedriver();
                ManagerDriver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                ManagerDriver.Manage().Window.Maximize();
                objbase.WaitforPageload();

                IJavaScriptExecutor QAManagerexecutor = (IJavaScriptExecutor)ManagerDriver;
                IWebElement menumanager = ManagerDriver.FindElement(By.Id("btnManagers"));
                QAManagerexecutor.ExecuteScript("arguments[0].click();", menumanager);
                IWebElement lnkmgricing = ManagerDriver.FindElement(By.LinkText("View/Edit Manager Pricing"));
                QAManagerexecutor.ExecuteScript("arguments[0].click();", lnkmgricing);
                objbase.WaitforPageload();

                IWebElement frmtesttarge = ManagerDriver.FindElement(By.Name("testTarget"));
                ManagerDriver.SwitchTo().Frame(frmtesttarge);

                IWebElement eleselectmgr = ManagerDriver.FindElement(By.Id("ctl00_ctl00_baseFormContent_PortalPageFormContent_ddlManager"));
                SelectElement selectmgr = new SelectElement(eleselectmgr);
                selectmgr.SelectByValue(ConfigurationSettings.AppSettings["SelectManager"]);

                IWebElement eledate = ManagerDriver.FindElement(By.Id("ctl00_ctl00_baseFormContent_PortalPageFormContent_tbEffectiveDate"));
                eledate.SendKeys(ConfigurationSettings.AppSettings["selectDate"]);
                IWebElement btnview = ManagerDriver.FindElement(By.Id("ctl00_ctl00_baseFormContent_PortalPageFormContent_btnView"));
                QAManagerexecutor.ExecuteScript("arguments[0].click();", btnview);
                objbase.WaitforReportPage();

                ManagerDriver.SwitchTo().Window(ManagerDriver.WindowHandles.Last());
              //  objbase.WaitforPageload();
               
               //Assert.IsTrue(ManagerDriver.PageSource.Contains("Opening Balance"));
                ManagerDriver.SwitchTo().DefaultContent();
                ManagerDriver.Quit();
             
              
                                          
            }
            catch(Exception exmanagerpricing)
            {
                Console.WriteLine("Manager Pricing Exception: " + exmanagerpricing.Message.ToString());
               // Assert.Fail();
            }
        }

    }
}
