using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using System.IO;
using System.Reflection;
using PlmonFuncTestNunit.Helpers;
using NUnit.Framework;
using NUnit.Framework.Internal;
using PlmonFuncTestNunit.PageObjects;
using PlmonFuncTestNunit.TestsInputData.ControlPanel;
using PlmonFuncTestNunit.TestsInputData.Style;

namespace PlmonFuncTestNunit.Helpers
{
    public class CheckSortButton
    {
        public void CheckSortingFunctionality(IWebElement btnSort, IList<IWebElement> sortTextBoxes, IWebElement btnSave)
        {
            if (SeleniumGetMethod.IsElementExists(PropertiesCollection.driver, btnSort))
            {
                btnSort.Click();
                PropertiesCollection.driver.SwitchTo().Window(PropertiesCollection.driver.WindowHandles.Last());
                SeleniumGetMethod.WaitForPageLoad(PropertiesCollection.driver);
                if (sortTextBoxes != null)
                {
                    int i = 0, j = 1;
                    for (; i < sortTextBoxes.Count; i++, j++)
                    {
                        sortTextBoxes[i].Clear();
                        sortTextBoxes[i].SendKeys(j.ToString());
                    }
                }
                btnSave.Click();
            }
            else
            {
                PropertiesCollection._reportingTasks.Log(Status.Info, "There is no SORT button in this directory..");
            }
            PropertiesCollection.driver.SwitchTo().Window(PropertiesCollection.driver.WindowHandles.Last());
        }

    }
}
