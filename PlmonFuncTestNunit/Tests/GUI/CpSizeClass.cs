using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using PlmonFuncTestNunit.PageObjects;
using PlmonFuncTestNunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlmonFuncTestNunit.Helpers;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PlmonFuncTestNunit.TestsInputData;
using PlmonFuncTestNunit.Base_Classes;
using OpenQA.Selenium.Interactions;

namespace PlmonFuncTestNunit.Tests.GUI
{

    [TestFixture("Chrome", "IT")]
    public class CpSizeClass: PropertiesCollection
    {
        public CpSizeClass(string browserName, string user) : base(browserName, user) { }

        [Test, Category("Function test Open CP")]
        public void CheckSizeClass()
        {
            
            var deskCP = _pages.GetPage<MenuPageObject>().SwitchToMenuCP();
            deskCP.labelTitle();
            deskCP.CheckLeftMenuDirectory("Measurements", "323");
            SeleniumGetMethod.WaitForPageLoad(driver);
            deskCP.SwitchToMain();
            var desk = _pages.GetPage<MenuPageObject>();
            desk.LeftFrameExpander();
            System.Threading.Thread.Sleep(1000);
            var deskS = _pages.GetPage<PageObjects.CpMeasurements.SizeClass.View>();
            deskS.searchExpander.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            deskS.txtSizeClassCode.SendKeys("test");
            deskS.txtSizeClassName.SendKeys("test");
            SeleniumSetMethods.SelectDropDown(deskS.drlActive, 2);
            deskS.imgBtnSearch.Click();
                        SeleniumGetMethod.WaitForPageLoad(driver);
            deskS.searchExpander.Click();
            deskS.txtSizeClassCode.SendKeys("test");
            deskS.txtSizeClassName.SendKeys("test");
            SeleniumSetMethods.SelectDropDown(deskS.drlActive, 1);
            deskS.imgBtnSearch.Click();
                        SeleniumGetMethod.WaitForPageLoad(driver);
            deskS.searchExpander.Click();        
                    //grid sort
            for (int i = 0; i < deskS.gridHeaders.Count; i++)
            {
                IWebElement header =  deskS.gridHeaders[i];
                Actions action = new Actions(driver);
                action.MoveToElement(header).Click().Perform();
                SeleniumGetMethod.WaitForPageLoad(driver);
            }
                     //clear all fields
            deskS.searchExpander.Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(3000)).Until(ExpectedConditions.ElementIsVisible(By.Id(deskS.txtSizeClassCode.GetAttribute("Id"))));
            deskS.txtSizeClassCode.Clear();
            deskS.txtSizeClassName.Clear();
            SeleniumSetMethods.SelectDropDown(deskS.drlActive, 0);
            deskS.imgBtnSearch.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
                     //check paging
            Paging paging = new Paging();
            paging.CheckPaging(deskS.SizeClassPaging);
            SeleniumGetMethod.WaitForPageLoad(driver);
                        //check EAV
            OpenEavEntityEditor openEav = new OpenEavEntityEditor();
            openEav.OpenEavEditor(deskS.eavEditorOpenGrid);
                             //CHECK CREATION
            System.Threading.Thread.Sleep(3000);
            SwitchToFrameHelper.ToControlPanelDictionary(driver);
            deskS.btnNew.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            var deskN = _pages.GetPage<PageObjects.CpMeasurements.SizeClass.Create>();
            deskN.btnSave.Click();
            System.Threading.Thread.Sleep(3000);
                     //should be check for validators
           

        }

    }
}
