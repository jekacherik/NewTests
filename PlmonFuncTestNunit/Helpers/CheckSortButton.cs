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
using OpenQA.Selenium.Interactions;

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
                    try
                    {
                        IList<IWebElement> itemsToDrop = PropertiesCollection.driver.FindElements(By.XPath("//div[contains(@id,'datagrid1_')]"));
                        if(itemsToDrop.Count > 1)
                        {
                            for(int x = 1; x < itemsToDrop.Count; x++ )
                            {
                                IWebElement drag = itemsToDrop[x-1];
                                IWebElement drop = itemsToDrop[x];
                                (new Actions(PropertiesCollection.driver)).ClickAndHold(drag).MoveToElement(drop).DragAndDrop(drag, drop).Perform();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        PropertiesCollection._reportingTasks.Log(Status.Info, "Can't test drag and drop");
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
