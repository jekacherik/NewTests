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
    public class CpMeasTemplate: PropertiesCollection
    {
        public CpMeasTemplate(string browserName, string user) : base(browserName, user) { }

        public void OpenMeasTemplateDirectory()
        {
            var pageMenuCp = _pages.GetPage<MenuPageObject>().SwitchToMenuCP();
            pageMenuCp.labelTitle();
            pageMenuCp.CheckLeftMenuDirectory("Measurements", "345");
            SeleniumGetMethod.WaitForPageLoad(driver);
            pageMenuCp.SwitchToMain();
        }


        public void MeasTemplateCreate()
        {
            var cpMeasTemplateView = _pages.GetPage<PageObjects.CpMeasurements.MeasTemplates.View>();
            cpMeasTemplateView.btnNewPOM.Click();
            var cpMeasTemplateCreate = _pages.GetPage<PageObjects.CpMeasurements.MeasTemplates.Create>();
            cpMeasTemplateCreate.btnClose.Click();
            cpMeasTemplateCreate.btnNoModal.Click();
            cpMeasTemplateCreate.btnClose.Click();
            cpMeasTemplateCreate.btnYesModal.Click();
            cpMeasTemplateView.btnNewPOM.Click();
            cpMeasTemplateCreate.btnSave.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            System.Threading.Thread.Sleep(2000);
                    //Check EAV
            OpenEavEntityEditor openEav = new OpenEavEntityEditor();
            openEav.OpenEavEditor(cpMeasTemplateCreate.openEavEditor);
            System.Threading.Thread.Sleep(2000);
            SwitchToFrameHelper.ToControlPanelDictionary(driver);
                    //Create
            cpMeasTemplateCreate.txtPOMType.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            cpMeasTemplateCreate.txtPOMTypeDescription.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            SeleniumSetMethods.SelectDropDown(cpMeasTemplateCreate.drlClassRangeId, 1);
            cpMeasTemplateCreate.dclDivisionsIDs_ArrowToExpand.Click();
            System.Threading.Thread.Sleep(1000);
            IJavaScriptExecutor javaScript = (IJavaScriptExecutor)driver;
            javaScript.ExecuteScript(cpMeasTemplateCreate.AllDivisionsMultiDrops);
            cpMeasTemplateCreate.chbActive.Click();
                            //metric
                    cpMeasTemplateCreate.allGradingTypeRadios[0].Click();
                    cpMeasTemplateCreate.allGradesOfSampleRadios[0].Click();
                    cpMeasTemplateCreate.radiosMetricImperial[0].Click();
            cpMeasTemplateCreate.btnSave.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            cpMeasTemplateCreate.btnClose.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            cpMeasTemplateView.btnNewPOM.Click();
            cpMeasTemplateCreate.txtPOMType.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            cpMeasTemplateCreate.txtPOMTypeDescription.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            SeleniumSetMethods.SelectDropDown(cpMeasTemplateCreate.drlClassRangeId, 1);
            cpMeasTemplateCreate.dclDivisionsIDs_ArrowToExpand.Click();
            System.Threading.Thread.Sleep(1000);
            javaScript.ExecuteScript(cpMeasTemplateCreate.AllDivisionsMultiDrops);
            cpMeasTemplateCreate.chbActive.Click();
                        //imperial
                    cpMeasTemplateCreate.allGradingTypeRadios[1].Click();
                    cpMeasTemplateCreate.allGradesOfSampleRadios[1].Click();
                    cpMeasTemplateCreate.radiosMetricImperial[1].Click();
            cpMeasTemplateCreate.btnSave.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
        }

        public void MeasTemplateeView()
        {
            var pageMainCp = _pages.GetPage<MenuPageObject>();
            pageMainCp.LeftFrameExpander();
            System.Threading.Thread.Sleep(1000);
            var cpMeasTemplateView = _pages.GetPage<PageObjects.CpMeasurements.MeasTemplates.View>();
            cpMeasTemplateView.searchExpander.Click();
            System.Threading.Thread.Sleep(2000);
            cpMeasTemplateView.imgBtnSearch.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
                    //Check Search
            cpMeasTemplateView.searchExpander.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            cpMeasTemplateView.txtPOMType.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            cpMeasTemplateView.txtPOMTypeDescription.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
            SeleniumSetMethods.SelectDropDown(cpMeasTemplateView.drlDivisions, 1);
            SeleniumSetMethods.SelectDropDown(cpMeasTemplateView.drlActive, 1);
            cpMeasTemplateView.imgBtnSearch.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            cpMeasTemplateView.searchExpander.Click();
            SeleniumSetMethods.SelectDropDown(cpMeasTemplateView.drlActive, 2);
            cpMeasTemplateView.imgBtnSearch.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
                      //Check EAV  search
            cpMeasTemplateView.searchExpander.Click();
            OpenEavEntityEditor openEav = new OpenEavEntityEditor();
            openEav.OpenEavEditor(cpMeasTemplateView.eavEditorOpenSearch);
            System.Threading.Thread.Sleep(3000);
            SwitchToFrameHelper.ToControlPanelDictionary(driver);
                        // Grid Sort
            for (int i = 0; i < cpMeasTemplateView.gridHeaders.Count; i++)
            {
                IWebElement header = cpMeasTemplateView.gridHeaders[i];
                Actions action = new Actions(driver);
                action.MoveToElement(header).Click().Perform();
                SeleniumGetMethod.WaitForPageLoad(driver);
            }
                        // Check EAV
            openEav.OpenEavEditor(cpMeasTemplateView.eavEditorOpenGrid);
            System.Threading.Thread.Sleep(2000);
                            //Check Paging
            SwitchToFrameHelper.ToControlPanelDictionary(driver);
            cpMeasTemplateView.searchExpander.Click();
            System.Threading.Thread.Sleep(2000);
            cpMeasTemplateView.txtPOMType.Clear();
            cpMeasTemplateView.txtPOMTypeDescription.Clear();
            SeleniumSetMethods.SelectDropDown(cpMeasTemplateView.drlDivisions, 0);
            SeleniumSetMethods.SelectDropDown(cpMeasTemplateView.drlActive, 0);
            cpMeasTemplateView.imgBtnSearch.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            Paging paging = new Paging();
            paging.CheckPaging(cpMeasTemplateView.MeasTemplatesPaging);
            SeleniumGetMethod.WaitForPageLoad(driver);
        }


        public void MeasTemplateeEdit()
        {
            var cpMeasTemplateView = _pages.GetPage<PageObjects.CpMeasurements.MeasTemplates.View>();
            IList<IWebElement> theFirst = driver.FindElements(By.CssSelector(cpMeasTemplateView.tableRecords));
            theFirst[0].Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            var cpMeasTemplateEdit = _pages.GetPage<PageObjects.CpMeasurements.MeasTemplates.Edit>();
            cpMeasTemplateEdit.btnClose.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            theFirst = driver.FindElements(By.CssSelector(cpMeasTemplateView.tableRecords));
            theFirst[0].Click();
            cpMeasTemplateEdit.TemplatePropExpander.Click();
            cpMeasTemplateEdit.TemplatePropExpander.Click();
            System.Threading.Thread.Sleep(2000);
                    //link pop
            cpMeasTemplateEdit.btnLinkPom.Click();
                    //switch to POP UP
            SwitchToFrameHelper.GoToPopUpFrame("#RadWindowWrapper_modalPopup > div.rwContent.rwExternalContent > iframe");
            SeleniumGetMethod.WaitForPageLoad(driver);
            cpMeasTemplateEdit.btnClose.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            SwitchToFrameHelper.ToDefaultContext(driver);
            SwitchToFrameHelper.ToControlPanelDictionary(driver);
                    //pom critical
            cpMeasTemplateEdit.btnPomCritical.Click();
            SwitchToFrameHelper.GoToPopUpFrame("#RadWindowWrapper_modalPopup > div.rwContent.rwExternalContent > iframe");
            SeleniumGetMethod.WaitForPageLoad(driver);
            cpMeasTemplateEdit.btnClose.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            SwitchToFrameHelper.ToDefaultContext(driver);
            SwitchToFrameHelper.ToControlPanelDictionary(driver);
                //pom where used
            cpMeasTemplateEdit.btnWhereUsed.Click();
            SwitchToFrameHelper.GoToPopUpFrame("#RadWindowWrapper_modalPopup > div.rwContent.rwExternalContent > iframe");
            SeleniumGetMethod.WaitForPageLoad(driver);
            cpMeasTemplateEdit.btnClose.Click();
            SeleniumGetMethod.WaitForPageLoad(driver);
            SwitchToFrameHelper.ToDefaultContext(driver);
            SwitchToFrameHelper.ToControlPanelDictionary(driver);
                    //add size range
            cpMeasTemplateEdit.btnAddSizeRange.Click();
            SwitchToFrameHelper.GoToPopUpFrame("#RadWindowWrapper_modalPopup > div.rwContent.rwExternalContent > iframe");
            SeleniumGetMethod.WaitForPageLoad(driver);
            cpMeasTemplateEdit.cbSelectAllInSizeRange.Click();
            /*if (SeleniumGetMethod.IsElementExists(driver, cpMeasTemplateEdit.allDropDownsInModal[0]))
            {
                SeleniumSetMethods.SelectDropDown(cpMeasTemplateEdit.allDropDownsInModal[0], 0);
            }*/
            cpMeasTemplateEdit.btnAddModal.Click();
            System.Threading.Thread.Sleep(2000);
                 /*paging cpMeasTemplateEdit need set up*/
            SwitchToFrameHelper.ToDefaultContext(driver);
            SwitchToFrameHelper.ToControlPanelDictionary(driver);
            Paging paging = new Paging();
            paging.CheckPaging(cpMeasTemplateView.MeasTemplatesPaging);
                      //try check preview Page
            OpenPreview preview = new OpenPreview();
            preview.GeneratePreviewPage(cpMeasTemplateEdit.btnPDFView, cpMeasTemplateEdit.ddlLanguageInPreview, cpMeasTemplateEdit.allReportsInPreview);
            /* cpMeasTemplateEdit.txtSizeRangeCode.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
             System.Threading.Thread.Sleep(2000);
             cpMeasTemplateEdit.txtAllDescriptions[0].SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
             cpMeasTemplateEdit.txtAllSizes[0].SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
             cpMeasTemplateEdit.btnClose.Click();
             theFirst = driver.FindElements(By.CssSelector(cpMeasTemplateView.tableRecords));
             theFirst[0].Click();
             SeleniumGetMethod.WaitForPageLoad(driver);
             cpMeasTemplateEdit.chbActive.Click();
             cpMeasTemplateEdit.txtSizeRangeCode.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
             cpMeasTemplateEdit.txtAllDescriptions[0].SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
             cpMeasTemplateEdit.txtAllSizes[0].SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
             cpMeasTemplateEdit.btnSave.Click();
             theFirst = driver.FindElements(By.CssSelector(cpMeasTemplateView.tableRecords));
             theFirst[0].Click();
             cpMeasTemplateEdit.btnSaveNew.Click();
             cpMeasTemplateEdit.btnClose.Click();
             cpMeasTemplateEdit.DeleteDialogNo.Click();
             cpMeasTemplateEdit.btnClose.Click();
             cpMeasTemplateEdit.DeleteDialogYes.Click();
             SeleniumGetMethod.WaitForPageLoad(driver);
             theFirst = driver.FindElements(By.CssSelector(cpMeasTemplateView.tableRecords));
             theFirst[0].Click();
             cpMeasTemplateEdit.btnSaveNew.Click();
             cpMeasTemplateEdit.btnSave.Click();
             bool r = cpMeasTemplateEdit.validator.Displayed;
             Console.WriteLine(r);
             System.Threading.Thread.Sleep(2000);
             var cpMeasTemplateCreate = _pages.GetPage<PageObjects.CpMeasurements.SizeRange.Create>();
             cpMeasTemplateCreate.txtSizeRangeCode.SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
             cpMeasTemplateCreate.txtAllDescriptions[0].SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
             cpMeasTemplateCreate.txtAllSizes[0].SendKeys(Helpers.Randomizer.String(4, "qwertyuiop"));
             cpMeasTemplateCreate.txtAllRadioButtons[0].Click();
             cpMeasTemplateCreate.btnSave.Click();
             SeleniumGetMethod.WaitForPageLoad(driver);
             cpMeasTemplateEdit.menuExpanderHandle.Click();*/
        }


        [Test]
        public void CheckMeasTemplate()
        {
            OpenMeasTemplateDirectory();
            //MeasTemplateeView();
            //MeasTemplateCreate();
            MeasTemplateeEdit();
        }
    }
}
