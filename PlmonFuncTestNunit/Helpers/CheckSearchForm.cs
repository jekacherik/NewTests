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
    public class CheckSearchForm
    {

        public void CheckSearchFunctionality(string fieldsFinder, string data)
        {
            IList<IWebElement> fields = PropertiesCollection.driver.FindElements(By.CssSelector(fieldsFinder));
            int last = fields.Count - 1;
            try
            {
                IWebElement searchExpander = PropertiesCollection.driver.FindElement(By.CssSelector("span[expander-id=searchDropdownExpander]"));
                if (fields[last].Displayed == false && searchExpander != null)
                {
                    searchExpander.Click();
                }
            }
            catch (Exception)
            {
                new Exception("No search expander");
            }
            for (int x = 0; x < fields.Count; x++)
            {
                fields = PropertiesCollection.driver.FindElements(By.CssSelector(fieldsFinder));
                var id = fields[x].GetAttribute("id");
                if (id.Contains("txt"))
                {
                    fields[x].SendKeys(data);
                }
                if (id.Contains("drl") || id.Contains("ddl"))
                {
                    SelectElement selectList = new SelectElement(fields[x]);
                    IList<IWebElement> options = selectList.Options;
                    if (options.Count != 0)
                    {
                        SeleniumSetMethods.SelectDropDown(fields[x], 1);
                        SeleniumGetMethod.WaitForPageLoad(PropertiesCollection.driver);
                    }
                }
            }
            try
            {
                var search = PropertiesCollection.driver.FindElement(By.XPath("//input[@id='imgBtnSearch']|//a[@id='imgBtnSearch']|//a[@id='btnSearch']"));
                search.Click();
                SeleniumGetMethod.WaitForPageLoad(PropertiesCollection.driver);
            }
            catch (Exception)
            {
                new Exception("No search button");
            }
        }
    }
}
