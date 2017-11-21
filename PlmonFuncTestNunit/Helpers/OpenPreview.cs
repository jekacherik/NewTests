using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AventStack.ExtentReports;
using NUnit.Framework;

namespace PlmonFuncTestNunit.Helpers
{
    public class OpenPreview
    {
        public void GeneratePreviewPage(IWebElement prevButton, IWebElement langDropDown, IList<IWebElement> reportToGen)
        {
           
            if (SeleniumGetMethod.IsElementExists(PropertiesCollection.driver, prevButton))
            {
                prevButton.Click();
                PropertiesCollection.driver.SwitchTo().Window(PropertiesCollection.driver.WindowHandles.Last());
                SelectElement selectList = new SelectElement(langDropDown);
                IList<IWebElement> options = selectList.Options;
                if (options.Count != 0)
                {
                    SeleniumSetMethods.SelectDropDown(langDropDown, 1);
                    if (SeleniumGetMethod.IsElementExists(PropertiesCollection.driver, reportToGen[0]))
                    {
                        reportToGen[0].Click();
                        SeleniumGetMethod.WaitForPageLoad(PropertiesCollection.driver);
                                 //Make sure we go to PDF page
                        bool isPdf = SeleniumGetMethod.IsElementExists(PropertiesCollection.driver, PropertiesCollection.driver.FindElement(By.XPath("//embed[contains(@type,'pdf')]")));
                        Assert.IsTrue(isPdf, "this is not PDF page");
                    }
                    else
                    {
                        PropertiesCollection._reportingTasks.Log(Status.Info, "Can't click and generate report...");
                    }              
                }
                else
                {
                    PropertiesCollection._reportingTasks.Log(Status.Info, "LANGUAGE dropdown is empty....");
                }
                PropertiesCollection.driver.Close();
            }
            else
            {
                PropertiesCollection._reportingTasks.Log(Status.Info, "There is no PREVIEW button in this directory..");
            }
        }
        
    }
}
