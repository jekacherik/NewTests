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
    public class CpSizeRange : PropertiesCollection
    {
        public CpSizeRange(string browserName, string user) : base(browserName, user) { }

        public void OpenSizeRangeDirectory()
        {
            var pageMenuCp = _pages.GetPage<MenuPageObject>().SwitchToMenuCP();
            pageMenuCp.labelTitle();
            pageMenuCp.CheckLeftMenuDirectory("Measurements", "16");
            SeleniumGetMethod.WaitForPageLoad(driver);
            pageMenuCp.SwitchToMain();
        }


        public void SizeRangeCreate()
        {
            var cpSizeRangeView = _pages.GetPage<PageObjects.CpMeasurements.SizeRange.View>();
            cpSizeRangeView.btnNew.Click();
            var cpSizeRangeCreate = _pages.GetPage<PageObjects.CpMeasurements.SizeRange.Create>();
            cpSizeRangeCreate.btnClose.Click();
            cpSizeRangeCreate.btnNo.Click();
            cpSizeRangeCreate.btnClose.Click();
            cpSizeRangeCreate.btnYes.Click();
            cpSizeRangeView.btnNew.Click();
            //bool r = cpSizeRangeCreate.validator.Displayed;
            //Console.WriteLine(r);
            cpSizeRangeCreate.btnSave.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            System.Threading.Thread.Sleep(2000);
            //r = SeleniumGetMethod.IsElementExists(driver, cpSizeRangeCreate.validator);
            //Console.WriteLine(r);
            //cpSizeRangeView.btnNew.Click();
            cpSizeRangeCreate.txtSizeRangeCode.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            cpSizeRangeCreate.chbActive.Click();
            cpSizeRangeCreate.txtAllSizes[0].SendKeys("test");
            cpSizeRangeCreate.txtAllDescriptions[0].SendKeys("testDesc");
            cpSizeRangeCreate.txtAllRadioButtons[0].Click();
            cpSizeRangeCreate.btnSave.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            OpenEavEntityEditor openEav = new OpenEavEntityEditor();
            openEav.OpenEavEditor(cpSizeRangeCreate.openEavEditor);
            System.Threading.Thread.Sleep(2000);
            SwitchToFrameHelper.ToControlPanelDictionary(driver);
            cpSizeRangeCreate.btnClose.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
        }

        public void SizeRangeView()
        {
            var pageMainCp = _pages.GetPage<MenuPageObject>();
            pageMainCp.LeftFrameExpander();
            System.Threading.Thread.Sleep(1000);
                        //Check Search
            var cpSizeRangeView = _pages.GetPage<PageObjects.CpMeasurements.SizeRange.View>();
            cpSizeRangeView.btnSearch.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            cpSizeRangeView.txtSizeRangeCode.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            cpSizeRangeView.btnSearch.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
                        // Check EAV
            OpenEavEntityEditor openEav = new OpenEavEntityEditor();
            openEav.OpenEavEditor(cpSizeRangeView.eavEditorOpenSearch);
            System.Threading.Thread.Sleep(3000);
            SwitchToFrameHelper.ToControlPanelDictionary(driver);
                         // Grid Sort
            for (int i = 0; i < cpSizeRangeView.gridHeaders.Count; i++)
            {
                IWebElement header = cpSizeRangeView.gridHeaders[i];
                Actions action = new Actions(driver);
                action.MoveToElement(header).Click().Perform();
                SeleniumGetMethod.WaitForPageLoad(driver);
            }
                        // Check EAV
            openEav.OpenEavEditor(cpSizeRangeView.eavEditorOpenGrid);
            System.Threading.Thread.Sleep(2000);
                        // Check Paging
            SwitchToFrameHelper.ToControlPanelDictionary(driver);
            cpSizeRangeView.txtSizeRangeCode.Clear();
            cpSizeRangeView.btnSearch.Click();
            Paging paging = new Paging();
            paging.CheckPaging(cpSizeRangeView.SizeRangePaging);
            SeleniumGetMethod.WaitForPageLoad(driver);   
        }


        public void SizeRangeEdit()
        {
            var cpSizeRangeView = _pages.GetPage<PageObjects.CpMeasurements.SizeRange.View>();
            IList<IWebElement> theFirst = driver.FindElements(By.CssSelector(cpSizeRangeView.tableRecords));
            theFirst[0].Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            var cpSizeRangeEdit = _pages.GetPage<PageObjects.CpMeasurements.SizeRange.Edit>();
            cpSizeRangeEdit.btnClose.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            theFirst = driver.FindElements(By.CssSelector(cpSizeRangeView.tableRecords));
            theFirst[0].Click();
                    cpSizeRangeEdit.txtSizeRangeCode.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
                    System.Threading.Thread.Sleep(2000);
                    cpSizeRangeEdit.txtAllDescriptions[0].SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
                    cpSizeRangeEdit.txtAllSizes[0].SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            cpSizeRangeEdit.btnClose.Click();
            theFirst = driver.FindElements(By.CssSelector(cpSizeRangeView.tableRecords));
            theFirst[0].Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            cpSizeRangeEdit.chbActive.Click();
            cpSizeRangeEdit.txtSizeRangeCode.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            cpSizeRangeEdit.txtAllDescriptions[0].SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            cpSizeRangeEdit.txtAllSizes[0].SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            cpSizeRangeEdit.btnSave.Click();
            theFirst = driver.FindElements(By.CssSelector(cpSizeRangeView.tableRecords));
            theFirst[0].Click();
            cpSizeRangeEdit.btnSaveNew.Click();
            cpSizeRangeEdit.btnClose.Click();
            cpSizeRangeEdit.DeleteDialogNo.Click();
            cpSizeRangeEdit.btnClose.Click();
            cpSizeRangeEdit.DeleteDialogYes.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            theFirst = driver.FindElements(By.CssSelector(cpSizeRangeView.tableRecords));
            theFirst[0].Click();
            cpSizeRangeEdit.btnSaveNew.Click();
            cpSizeRangeEdit.btnSave.Click();
                    bool r = cpSizeRangeEdit.validator.Displayed;
                    Console.WriteLine(r);
            System.Threading.Thread.Sleep(2000);
            var cpSizeRangeCreate = _pages.GetPage<PageObjects.CpMeasurements.SizeRange.Create>();
            cpSizeRangeCreate.txtSizeRangeCode.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            cpSizeRangeCreate.txtAllDescriptions[0].SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            cpSizeRangeCreate.txtAllSizes[0].SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            cpSizeRangeCreate.txtAllRadioButtons[0].Click();
            cpSizeRangeCreate.btnSave.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            cpSizeRangeEdit.menuExpanderHandle.Click();
        }


        [Test]
        public void CheckSizeRange()
        {
            OpenSizeRangeDirectory();
            SizeRangeView();
            SizeRangeCreate();
            System.Threading.Thread.Sleep(7000);
            SizeRangeEdit();
        }
    }
}
