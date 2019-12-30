using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace Hermes_Automation
{
    [TestClass]
    public class HermesBase
    {
        IWebDriver driver;
        //    IWebDriver driver = null;

        //  driver = null;

        public HermesBase()
        {
            // this.driver = driver;
        }

        [TestMethod]
        public IWebDriver Initializedriver()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.PageLoadStrategy = PageLoadStrategy.Eager;
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            options.IgnoreZoomLevel = true;


            InternetExplorerDriver driver = new InternetExplorerDriver(@"C:\Hermes\Hermes_Automation\packages\WebDriverIEDriver.2.45.0.0\Driver", options);
            return driver;
        }

        [TestMethod]
        public void WaitforPageload()
        {
            Thread.Sleep(20000);
        }

        [TestMethod]
        public void Waitforxpathelement()
        {
           Thread.Sleep(15000);
        }

        [TestMethod]
        public Func<IWebDriver, object> WaitUntilFrameLoadedAndSwitchToIt(By byToFindFrame)
        {
            return (driver) =>
           {
               try
               {
                   return driver.SwitchTo().Frame(driver.FindElement(byToFindFrame));
               }
               catch (Exception)
               {
                   return null;
               }

               return true;
           };
        }

        

        [TestMethod]
        public void WaitforAlert()
        {
            Thread.Sleep(10000);
        }

        [TestMethod]
        public void WaitForFrameload()
        {

            Thread.Sleep(30000);

        }

        [TestMethod]
        public void WaitforPageRefresh()
        {
            Thread.Sleep(20000);
        }


        [TestMethod]
        public void WaitforPortfolioload()
        {
            Thread.Sleep(11000);
        }

        [TestMethod]
        public void WaitforReportPage()
        {
            Thread.Sleep(20000);
        }

        [TestMethod]
        public bool validatelementexist(By by)
        {
            try
            {

                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }


}