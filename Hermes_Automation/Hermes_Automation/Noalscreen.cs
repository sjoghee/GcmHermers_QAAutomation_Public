using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;


using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.IE;


namespace Hermes_Automation
{
    [TestClass]
    public class Noalscreen
    {

        IWebDriver Noaldriver;
        HermesBase objbase = new HermesBase();

        [TestMethod]
        public void ValidateNoal_GrosvenorFund()
        {

            try
            {
                Noaldriver = objbase.Initializedriver();
                Noaldriver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                Noaldriver.Manage().Window.Maximize();
                objbase.WaitforPageload();

                IWebElement lnkmenuportfolio = Noaldriver.FindElement(By.Id("btnPortfolio"));
                IJavaScriptExecutor Noalexecutor = (IJavaScriptExecutor)Noaldriver;
                Noalexecutor.ExecuteScript("arguments[0].click();", lnkmenuportfolio);
                objbase.WaitforPageload();

                IWebElement lnknoalscreen = Noaldriver.FindElement(By.LinkText("NOAL Screen"));
                Noalexecutor.ExecuteScript("arguments[0].click();", lnknoalscreen);
                Noaldriver.SwitchTo().Window(Noaldriver.WindowHandles.Last());
                objbase.WaitforPageload();

                IWebElement eledivgrosvenorfund = Noaldriver.FindElement(By.XPath("//input[@value='Grosvenor Fund']"));
                objbase.WaitforPageload();
                Noalexecutor.ExecuteScript("arguments[0].click();", eledivgrosvenorfund);

                var overalllistoffunds = Noaldriver.FindElement(By.XPath("//div[@class='sg-list-items']"));
                IWebElement selectfund = overalllistoffunds.FindElement(By.XPath("//div[@class='itemHeadding matching-item']"));
                selectfund.Click();


                Noaldriver.SwitchTo().Window(Noaldriver.WindowHandles.Last());
                Assert.IsTrue(Noaldriver.PageSource.Contains("Net Other Assets and Liabilities"));
                Noaldriver.Quit();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Noal Screen exception: " + ex.Message.ToString());
            }

        }

        [TestMethod]
        public void Validate_Noal_PortfolioFund()
        {
            try
            {
                Noaldriver = objbase.Initializedriver();
                Noaldriver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                Noaldriver.Manage().Window.Maximize();
                objbase.WaitforPageload();

                IWebElement lnkmenuportfolio = Noaldriver.FindElement(By.Id("btnPortfolio"));
                IJavaScriptExecutor Noalexecutor = (IJavaScriptExecutor)Noaldriver;
                Noalexecutor.ExecuteScript("arguments[0].click();", lnkmenuportfolio);
                objbase.WaitforPageload();

                IWebElement lnknoalscreen = Noaldriver.FindElement(By.LinkText("NOAL Screen"));
                Noalexecutor.ExecuteScript("arguments[0].click();", lnknoalscreen);
                Noaldriver.SwitchTo().Window(Noaldriver.WindowHandles.Last());
                objbase.WaitforPageload();

                IWebElement eledivportfoliofund = Noaldriver.FindElement(By.XPath("//input[@value='Portfolio Fund']"));
                objbase.WaitforPageload();
                Noalexecutor.ExecuteScript("arguments[0].click();", eledivportfoliofund);
                objbase.WaitforPageload();
              

                var overalllistoffunds = Noaldriver.FindElement(By.XPath("//div[@class='dynamic-list-items']"));
                objbase.WaitforPageload();
                IWebElement selectportfoliofund = overalllistoffunds.FindElement(By.XPath("//div[@class='itemHeadding matching-item']"));
                Noalexecutor.ExecuteScript("arguments[0].click();", selectportfoliofund);

                //Noaldriver.SwitchTo().Window(


            }
            catch(Exception pfex)
            {
                Console.WriteLine("NOAL Portfolio Fund Exception: " + pfex.Message.ToString());
            }
           
        }

        [TestMethod]
        public void Validate_Noal_Associate()
        {
            try
            {
                Noaldriver = objbase.Initializedriver();
                Noaldriver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                Noaldriver.Manage().Window.Maximize();

                IWebElement lnkmenuportfolio = Noaldriver.FindElement(By.Id("btnPortfolio"));
                IJavaScriptExecutor Noalexecutor = (IJavaScriptExecutor)Noaldriver;
                Noalexecutor.ExecuteScript("arguments[0].click();", lnkmenuportfolio);
                objbase.WaitforPageload();

                IWebElement lnknoalscreen = Noaldriver.FindElement(By.LinkText("NOAL Screen"));
                Noalexecutor.ExecuteScript("arguments[0].click();", lnknoalscreen);
                Noaldriver.SwitchTo().Window(Noaldriver.WindowHandles.Last());
                objbase.WaitforPageload();

                IWebElement eledivassociatefund = Noaldriver.FindElement(By.XPath("//input[@value='Associate']"));
                objbase.WaitforPageload();
                Noalexecutor.ExecuteScript("arguments[0].click();", eledivassociatefund);
                objbase.WaitforPageload();

                               

            }
            catch (Exception pfex)
            {
                Console.WriteLine("NOAL Portfolio Fund Exception: " + pfex.Message.ToString());
            }

        }

        [TestMethod]
        public void Validate_Noal_AllocationDate()
        {
            try
            {
                Noaldriver = objbase.Initializedriver();
                Noaldriver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["QAT"]);
                Noaldriver.Manage().Window.Maximize();

                IWebElement lnkmenuportfolio = Noaldriver.FindElement(By.Id("btnPortfolio"));
                IJavaScriptExecutor Noalexecutor = (IJavaScriptExecutor)Noaldriver;
                Noalexecutor.ExecuteScript("arguments[0].click();", lnkmenuportfolio);
                objbase.WaitforPageload();

                IWebElement lnknoalscreen = Noaldriver.FindElement(By.LinkText("NOAL Screen"));
                Noalexecutor.ExecuteScript("arguments[0].click();", lnknoalscreen);
                Noaldriver.SwitchTo().Window(Noaldriver.WindowHandles.Last());
                objbase.Waitforxpathelement();

                IWebElement eledivallocationdate = Noaldriver.FindElement(By.XPath("//input[@value='Allocation Date']"));
                WebDriverWait waitallocationdateload = new WebDriverWait(Noaldriver, TimeSpan.FromSeconds(20));
                waitallocationdateload.Until(ExpectedConditions.ElementToBeClickable(eledivallocationdate));
                Noalexecutor.ExecuteScript("arguments[0].click();", eledivallocationdate);
                objbase.WaitforPageload();
                               
                var eledivclassyear = Noaldriver.FindElement(By.XPath("//div[@class='managerElement clickable selectableItem']"));
                objbase.WaitforPageload();
                var eldivclsmonth = eledivclassyear.FindElement(By.XPath("//div[@class='titleHeading filterable-date-displayDate']"));
                Noalexecutor.ExecuteScript("arguments[0].click();", eldivclsmonth);
                objbase.WaitforReportPage();

                IWebElement eleparentdivok= Noaldriver.FindElement(By.XPath("//div[@class='tab-container']"));
                objbase.WaitforPortfolioload();

                IWebElement childdivforok = Noaldriver.FindElement(By.XPath("//div[@class='tab-effectivedate']"));
                objbase.WaitforPortfolioload();

                IWebElement child1divforok = Noaldriver.FindElement(By.XPath("//div[@class='footer-filter']"));
                objbase.WaitforPageload();
                IWebElement elebtnok = child1divforok.FindElement(By.XPath("//input[@value='OK']"));
                Noalexecutor.ExecuteScript("arguments[0].click();", elebtnok);

                //elebtnok.Click();
              //Noalexecutor.ExecuteScript("arguments[0].click();", elebtnok);
                objbase.WaitforReportPage();



            }
            catch(Exception pfex)
            {
                Console.WriteLine("NOAL Portfolio Fund Exception: " + pfex.Message.ToString());
            }

        }

    }
}
