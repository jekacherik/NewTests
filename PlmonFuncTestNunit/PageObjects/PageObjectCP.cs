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

        [FindsBy(How = How.CssSelector, Using = "#btnSave > div > span")]
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



        public void CheckLeftMenuDirectory(string hrefLink)
        {
            SwitchToCPMenu();
            int j = 0;
            for (int i = 0; i < LinksLeft.Count; i++)
            {
                if (LinksLeft[i].GetAttribute("href").Contains(hrefLink))
                {
                    j = i;
                    break;
                }
                else
                {
                    PropertiesCollection._reportingTasks.Log(Status.Info, "Something wrong...");
                }
                PropertiesCollection._reportingTasks.Log(Status.Info, LinksLeft[i].Text);
                PropertiesCollection._reportingTasks.Log(Status.Info, LinksLeft[i].GetAttribute("href"));
            }
            IJavaScriptExecutor executor = (IJavaScriptExecutor)PropertiesCollection.driver;
            string path1 = Path.GetDirectoryName(Assembly.GetCallingAssembly().CodeBase);
            string path2 = path1.Substring(0, path1.IndexOf("bin")) + ("Scripts\\cpClickPlus.js");
            string path = new Uri(path2).LocalPath;
            string jsString = File.ReadAllText(path);
            executor.ExecuteScript(jsString.Replace("@", j.ToString()));
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
