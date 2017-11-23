using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace PlmonFuncTestNunit.PageObjects.CpMatSubTypes
{
    public class View : PageBase
    {
        public View(PagesManager factory) : base(factory) { }
        public View(PagesManager factory, string windowHandle): base(factory, windowHandle){ }


        [FindsBy(How = How.CssSelector, Using = "#DataGrid1 > tbody > tr.mdl-sortable-datagrid-header > td > a")]
        public IList <IWebElement> gridHeaders { get; set; }

        [FindsBy(How = How.CssSelector, Using = "*//span[@expander-id='searchDropdownExpander']")]
        public IWebElement searchExpander { get; set; }

        [FindsBy(How = How.Id, Using = "txtCustomKey")]
        public IWebElement txtCode { get; set; }

        [FindsBy(How = How.Id, Using = "txtCustom")]
        public IWebElement txtName { get; set; }

        [FindsBy(How = How.Id, Using = "drlActive")]
        public IWebElement drlActive { get; set; }

        [FindsBy(How = How.Id, Using = "imgBtnSearch")]
        public IWebElement btnSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btnEditSample >a")]
        public IWebElement eavEditorOpenGrid { get; set; }

        [FindsBy(How = How.Id, Using = "linkBtnNavigateENV")]
        public IWebElement eavEditorOpenSearch { get; set; }

        [FindsBy(How = How.Id, Using = "btnNew")]
        public IWebElement btnNew { get; set; }

        [FindsBy(How = How.Id, Using = "btnSort")]
        public IWebElement btnSort { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'datagrid1_ctl')]")]
        public IList<IWebElement> sortTextBoxes { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@id,'datagrid1_')]")]
        public IList<IWebElement> itemsToDrop { get; set; }

        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement btnSaveInSort { get; set; }

        [FindsBy(How = How.Id, Using = "btnClose")]
        public IWebElement btnCloseInSort { get; set; }

                    //PagingData
        string recordsFound = "#RecordCount b";
        string dropdownSelectPerPage = "#ps";
        string goButton = "#Button1";
        string pagesaQua = "#lblPageCount";
        string nextPge = "#btnImgNext";
        string prevPage = "#btnImgPrevious";
        string lastPage = "#btnImgLast";
        string firstPage = "#btnImgFirst";
        /*string setGotoPage = "#ctrGrid_txtSkipToPg";
        string goToSkipPage = "#ctrGrid_btnImgSkipTo";*/
        string tableRecords = "#DataGrid1 > tbody > tr[onclick]";

    }
}
