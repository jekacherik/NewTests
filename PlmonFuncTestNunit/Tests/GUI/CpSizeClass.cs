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

        [Test]
        public void CheckSizeClass()
        {
            
            var pageMenuCp = _pages.GetPage<MenuPageObject>().SwitchToMenuCP();
            pageMenuCp.labelTitle();
            pageMenuCp.CheckLeftMenuDirectory("Measurements", "323");
            SeleniumGetMethod.WaitForPageLoad(driver);
            pageMenuCp.SwitchToMain();
            var pageMainCp = _pages.GetPage<MenuPageObject>();
            pageMainCp.LeftFrameExpander();
            System.Threading.Thread.Sleep(1000);
            var cpSiceClassView = _pages.GetPage<PageObjects.CpMeasurements.SizeClass.View>();
            cpSiceClassView.searchExpander.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            cpSiceClassView.txtSizeClassCode.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            cpSiceClassView.txtSizeClassName.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            SeleniumSetMethods.SelectDropDown(cpSiceClassView.drlActive, 2);
            cpSiceClassView.imgBtnSearch.Click();
            cpSiceClassView.searchExpander.Click();
            cpSiceClassView.txtSizeClassCode.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            cpSiceClassView.txtSizeClassName.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            SeleniumSetMethods.SelectDropDown(cpSiceClassView.drlActive, 1);
            cpSiceClassView.imgBtnSearch.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            cpSiceClassView.searchExpander.Click();        
                    //grid sort
            for (int i = 0; i < cpSiceClassView.gridHeaders.Count; i++)
            {
                IWebElement header =  cpSiceClassView.gridHeaders[i];
                Actions action = new Actions(driver);
                action.MoveToElement(header).Click().Perform();
                SeleniumGetMethod.WaitForPageLoad(driver);
            }
                     //clear all fields
            cpSiceClassView.searchExpander.Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(3000)).Until(ExpectedConditions.ElementIsVisible(By.Id(cpSiceClassView.txtSizeClassCode.GetAttribute("Id"))));
            cpSiceClassView.txtSizeClassCode.Clear();
            cpSiceClassView.txtSizeClassName.Clear();
            SeleniumSetMethods.SelectDropDown(cpSiceClassView.drlActive, 0);
            cpSiceClassView.imgBtnSearch.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
                     //check paging
            Paging paging = new Paging();
            paging.CheckPaging(cpSiceClassView.SizeClassPaging);
            SeleniumGetMethod.WaitForPageLoad(driver);
                        //check EAV
            OpenEavEntityEditor openEav = new OpenEavEntityEditor();
            openEav.OpenEavEditor(cpSiceClassView.eavEditorOpenGrid);
            /*--------------------------------------*///CHECK CREATION/*--------------------------------------------------------------*/
            System.Threading.Thread.Sleep(3000);
            SwitchToFrameHelper.ToControlPanelDictionary(driver);
            cpSiceClassView.btnNew.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            var cpSiceClassNew = _pages.GetPage<PageObjects.CpMeasurements.SizeClass.Create>();
            cpSiceClassNew.btnSave.Click();
                                                     openEav.OpenEavEditor(cpSiceClassNew.openEavEditor);
            System.Threading.Thread.Sleep(3000);
            SwitchToFrameHelper.ToControlPanelDictionary(driver);
            //Should be check for validators
                    bool r = SeleniumGetMethod.IsElementExists(driver, cpSiceClassNew.validator);
                    Console.WriteLine(r);
            cpSiceClassNew.txtSizeClassCode.SendKeys(Helpers.Randomizer.Number(100, 200).ToString());
            cpSiceClassNew.txtSizeClassName.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            SeleniumSetMethods.SelectDropDown(cpSiceClassNew.drlActive, 0);
            WindowsMessages mes = new WindowsMessages();
            cpSiceClassNew.btnSave.Click();
            mes.IsAlertPresent();
            System.Threading.Thread.Sleep(3000);
                    //another value in Active drl
            cpSiceClassView.btnNew.Click();    
            System.Threading.Thread.Sleep(5000);
            cpSiceClassNew.txtSizeClassCode.SendKeys(Helpers.Randomizer.Number(100, 200).ToString());
            cpSiceClassNew.txtSizeClassName.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            SeleniumSetMethods.SelectDropDown(cpSiceClassNew.drlActive, 1);
            cpSiceClassNew.btnSave.Click();
            mes.IsAlertPresent();
            /*--------------------------------------*///CHECK EDIT MODE/*------------------------------------------------------------------*/
            pageMenuCp.SwitchToCPMenu();
            pageMenuCp.CheckLeftMenuDirectory("Measurements");
            pageMenuCp.CheckLeftMenuDirectory("Measurements", "323");
            pageMenuCp.SwitchToMain();
            var row1 = driver.FindElements(By.CssSelector(cpSiceClassView.tableRecords));
            row1[0].Click();
            System.Threading.Thread.Sleep(3000);
            var cpSiceClassEdit = _pages.GetPage<PageObjects.CpMeasurements.SizeClass.Edit>();
            cpSiceClassEdit.btnClose.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            row1[0].Click();
            cpSiceClassEdit.txtSizeClassCode.Clear();
            cpSiceClassEdit.txtSizeClassCode.SendKeys(Helpers.Randomizer.Number(100, 200).ToString());
            cpSiceClassEdit.txtSizeClassName.Clear();
            cpSiceClassEdit.txtSizeClassName.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
        }

    }
}
