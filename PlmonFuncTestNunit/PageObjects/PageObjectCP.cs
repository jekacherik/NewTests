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
using PlmonFuncTestNunit.TestsInputData.ControlPanel;

namespace PlmonFuncTestNunit.PageObjects
{
    public class PageObjectCP : PageBase
    {

        public PageObjectCP(PagesManager factory) : base(factory) { }
        public PageObjectCP(PagesManager factory, string windowHandle): base(factory, windowHandle){ }


        [FindsBy(How = How.CssSelector, Using = "#btnAdd > div > span")]
        public IWebElement AddRow { get; set; }

        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btnRemove > div > span")]
        public IWebElement btnRemove { get; set; }


        [FindsBy(How = How.Id, Using = "btnAddRow")]
        public IWebElement btnAddRow { get; set; }

        [FindsBy(How = How.Id, Using = "ddlRowsAmount")]
        public IWebElement ddlRowsAmount { get; set; }

        [FindsBy(How = How.Id, Using = "btnClosePopup")]
        public IWebElement btnClosePopup { get; set; }

        [FindsBy(How = How.Id, Using = "ControlPanelLeftNavigation_lblTitle")]
        public IWebElement titleOfPage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#LeftMenu_ControlLeftMenuYSTreeView1 > ul > li > div > a")]
        public IWebElement linkCPFolder { get; set; }



        [FindsBy(How = How.XPath, Using = "//*[@id='LeftMenu_ControlLeftMenuYSTreeView1']/ul/li/ul/li/ul/li[1]/div/a")]
        public IList<IWebElement> TheFirstItem { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span[class=rtPlus]")]
        public IList<IWebElement> CpArray { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LeftMenu_ControlLeftMenuYSTreeView1']/ul/li/ul/li/div/span[@class='rtMinus']")]
        public IWebElement Minus { get; set; }

        [FindsBy(How = How.Id, Using = "btnExcelExport")]
        public IWebElement DownLoadButton { get; set; }

                             /*-------------------------------------------------------------------------------------*/
        [FindsBy(How = How.XPath, Using = "//*[@id='LeftMenu_ControlLeftMenuYSTreeView1']/ul/li/ul/li[16]/div/span[2]")]
        public IWebElement CalendarArrow { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#LeftMenu_ControlLeftMenuYSTreeView1 > ul > li > ul > li:nth-child(8) > div > span.rtPlus")]
        public IWebElement GvtArrow { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LeftMenu_ControlLeftMenuYSTreeView1']/ul/li/ul/li[8]/ul/li[2]/div/a")]
        public IWebElement GenRepLogo { get; set; }

        [FindsBy(How = How.Id, Using = "btnAdd")]
        public IWebElement BtnAttachImg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LeftMenu_ControlLeftMenuYSTreeView1']/ul/li/ul/li[16]/ul/li[1]/div/a")]
        public IWebElement ActiveAcions { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='DataGrid1']/tbody/tr[51]/td[3]/table/tbody/tr/td/span/label")]
        public IWebElement ActActionsCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement BtnSaveAct { get; set; }

        [FindsBy(How = How.Id, Using = "imgBtnSearch")]
        public IWebElement BtnSearchACt { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ControlPanelLeftNavigation_ControlPanelLeftNav > ul > li.rtLI > div > a")]
        public IList<IWebElement> LinksLeft { get; set; }

        [FindsBy(How = How.Id, Using = "ControlPanelLeftNavigation_lblTitle")]
        public IWebElement spanCP { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li:nth-child(3)>ul>li>div>a")]
        public IList<IWebElement> CpMeasuremntsItems { get; set; }

        [FindsBy(How = How.Id, Using = "btnSort")]
        public IWebElement BtnSort { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'datagrid1_ctl')]")]
        public IList<IWebElement> SortTextBoxes { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btnEditSample >a")]
        public IWebElement EavEditorOpen { get; set; }

        public void SwitchToMain()
        {
            SwitchToFrameHelper.ToDefaultContext(driver);
            SwitchToFrameHelper.ToControlPanelDictionary(driver);
        }

        public void SwitchToCPMenu()
        {
            SwitchToFrameHelper.ToDefaultContext(driver);
            SwitchToFrameHelper.ToControlPanelMenu(driver);
        }



        public void AddRowCancel()
        {
            linkCPFolder.Click();
            //System.Threading.Thread.Sleep(3000);
            if(driver.IsElementExists(AddRow))
            {
                AddRow.Click();
                new WebDriverWait(driver, TimeSpan.FromSeconds(100)).Until(ExpectedConditions.ElementExists((By.Id("btnClosePopup"))));
                btnClosePopup.Click();
            }

        }


        public Dictionary<string, string> CpDirectoryHref = new Dictionary<string, string>
        {
            {"Workflows", "02c6e5c0-6e2a-e111-adfb-000c29572dc5"},
            {"Templates", "dfe5f47f-6f2a-e111-adfb-000c29572dc5"},
            {"Measurements", "61cd600c-6e2a-e111-adfb-000c29572dc5"},
            {"MatSubTypes", "35d22856-6f2a-e111-adfb-000c29572dc5"},
            {"MatValidTables", "6b215ae8-6f2a-e111-adfb-000c29572dc5"},
            {"ImgValidTables", "f39be66a-211d-e411-916d-000c296f1d62"},
            {"ColorValidTables", "dd04baed-241d-e411-916d-000c296f1d62"},
            {"GenValidTables", "f7b86858-3fc7-4e77-b08d-67f197f1e9a7"},
            {"Care", "aa595549-6f2a-e111-adfb-000c29572dc5"},
            {"BillOfLabor", "09773e42-5ab8-e011-9f63-544c92f24f0d"},
            {"LineListFolder", "9adee0a5-3617-41b2-b527-d476530aef34"},
            {"FlashCosting", "b899fa67-9356-e211-bbe2-005056c00008"},
            {"SourcingFolder", "a4483fe2-79c9-4276-bb93-52aa4d69cbdc"},
            {"PartnerFolder", "98a00aee-211d-e411-916d-000c296f1d62"},
            {"PlanningFolder", "01e27f69-07f1-46c1-852b-42dffae0b330"},
            {"Calendar", "ab01f70b-62a7-e211-a8cb-005056c00008"},
            {"TechPacks", "08a5b3fe-241d-e411-916d-000c296f1d62"},
            {"AIPlugin", "710dc630-c01d-4821-85cf-9da79dd5dba0"}
        };

        public void CheckLeftMenuDirectory(params string[] hrefLink)
        {
            SwitchToCPMenu();
            int j = 0;
            for (int i = 0; i < LinksLeft.Count; i++)
            {
                try
                {
                    if (LinksLeft[i].GetAttribute("href").Contains(CpDirectoryHref[hrefLink[0]]))
                    {
                        j = i;
                        PropertiesCollection._reportingTasks.Log(Status.Info, "User go to Folder " + LinksLeft[i].Text);
                        break;
                    }
                }
                catch (Exception)
                {
                    Assert.Fail("Could not click on CP Menu elemPlusNotFound");
                }
            }
            IJavaScriptExecutor executor = (IJavaScriptExecutor)PropertiesCollection.driver;
            string path1 = Path.GetDirectoryName(Assembly.GetCallingAssembly().CodeBase);
            string path2 = path1.Substring(0, path1.IndexOf("bin")) + ("Scripts\\cpClickPlus.js");
            string path = new Uri(path2).LocalPath;
            string jsString = File.ReadAllText(path);
            executor.ExecuteScript(jsString.Replace("@", j.ToString()));
            if (hrefLink.Length > 1)
            {
                try
                {
                    for (var x = 1; x < hrefLink.Length; x++)
                    {
                        var LinkFolder = driver.FindElement(By.CssSelector("[href *= '" + hrefLink[x] + "']"));
                        if (SeleniumGetMethod.IsElementExists(driver, LinkFolder))
                        {
                            LinkFolder.Click();
                            SeleniumGetMethod.WaitForPageLoad(PropertiesCollection.driver);
                        }
                    }
                }
                catch (Exception)
                {
                    Assert.Fail("Could not click on CP Menu elemNotFound");
                }
            }
        }


        public void CheckSorting()
        {
            CheckSortButton sortButton = new CheckSortButton();  
            CheckLeftMenuDirectory("Measurements","323","342","323","599");
            CheckLeftMenuDirectory("Measurements");
            CheckLeftMenuDirectory("Measurements");
            for (int i = 0; i < CpMeasuremntsItems.Count; i++)
            {
                CpMeasuremntsItems[i].Click();
                SeleniumGetMethod.WaitForPageLoad(driver);
                SwitchToMain();
                var deskCP = _pagesFactory.GetPage<MenuPageObject>();
                deskCP.LeftFrameExpander();
                sortButton.CheckSortingFunctionality(BtnSort, SortTextBoxes, btnSave);
                SwitchToCPMenu();
            }
        }


        public void OpenEavEditor()
        {
            OpenEavEntityEditor openEav = new OpenEavEntityEditor();
           // CheckLeftMenuDirectory("61cd600c-6e2a-e111-adfb-000c29572dc5");  // Measurements
            //CheckLeftMenuDirectory("35d22856-6f2a-e111-adfb-000c29572dc5");  // MatSubTypes
            for (int i = 0; i < CpMeasuremntsItems.Count; i++)
            {
                CpMeasuremntsItems[i].Click();
                SeleniumGetMethod.WaitForPageLoad(driver);
                SwitchToMain();
                            var deskCP = _pagesFactory.GetPage<MenuPageObject>();
                            deskCP.LeftFrameExpander();
                openEav.OpenEavEditor(EavEditorOpen);
                SwitchToCPMenu();
            }
        }


     
        public void CheckSearchMeasCp(InputDataCp dataInput)
        {
            //Open CP in menu
            CheckSearchForm check = new CheckSearchForm();
            string fields = "div.mdl-grid.mdl-components-index-text > div > div >input, div.mdl-grid.mdl-components-index-text > div > div >select, div.mdl-color--white.mdl-content-header-wrap.mdl-grid > div >select, div.section-body-wrapper.m-0.p-0 > div.mdl-grid.mdl-components-index-text input, div.section-body-wrapper.m-0.p-0 > div.mdl-grid.mdl-components-index-text input,select";
            check.CheckSearchFunctionality(fields, dataInput.TxtSearchName);
        }


        public string labelTitle()
        {
            var title ="";
            if (SeleniumGetMethod.IsElementExists(driver, titleOfPage))
            {
                title = titleOfPage.Text;
                
            }
            return title;
        }
         
    }
}
