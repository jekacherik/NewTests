using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlmonFuncTestNunit.Helpers
{
    public class OpenEavEntityEditor
    {
        public void OpenEavEditor(IWebElement eavOpen)
        {
            if (SeleniumGetMethod.IsElementExists(PropertiesCollection.driver, eavOpen))
            {
                eavOpen.Click();
                PropertiesCollection.driver.SwitchTo().Window(PropertiesCollection.driver.WindowHandles.Last());
                SeleniumGetMethod.WaitForPageLoad(PropertiesCollection.driver);
                System.Threading.Thread.Sleep(3000);
                Assert.IsTrue(SeleniumGetMethod.IsElementExists(PropertiesCollection.driver, PropertiesCollection.driver.FindElement(By.XPath("//form[contains(@action,'EAV')]"))),"THIS IS NO EAV EDITOR PAGE");
                IWebElement btnClose = PropertiesCollection.driver.FindElement(By.Id("btnClose"));
                btnClose.Click(); 
            }
            else
            {
                PropertiesCollection._reportingTasks.Log(Status.Info, "There is no EAV EDITOR link in this directory..");
            }
            PropertiesCollection.driver.SwitchTo().Window(PropertiesCollection.driver.WindowHandles.Last());
            
        }
    }
}
