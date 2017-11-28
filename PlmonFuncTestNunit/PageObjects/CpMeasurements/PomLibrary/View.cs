using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace PlmonFuncTestNunit.PageObjects.CpMeasurements.PomLibrary
{
    public class View : PageBase
    {
        public View(PagesManager factory) : base(factory) { }
        public View(PagesManager factory, string windowHandle) : base(factory, windowHandle) { }


        [FindsBy(How = How.CssSelector, Using = "#DataGrid1 > tbody > tr.mdl-simple-datagrid-header > td > a")]
        public IList<IWebElement> gridHeaders { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#DataGrid1 > tbody > tr > td [id*=DataGrid1_ct][type=checkbox]")]
        public IList<IWebElement> allCheckboxes { get; set; }

        [FindsBy(How = How.CssSelector, Using = "*//span[@expander-id='searchDropdownExpander']")]
        public IWebElement searchExpander { get; set; }

        [FindsBy(How = How.Id, Using = "txtPOMCode")]
        public IWebElement txtPOMCode { get; set; }

        [FindsBy(How = How.Id, Using = "txtPOMDesc")]
        public IWebElement txtPOMDesc { get; set; }

        [FindsBy(How = How.Id, Using = "txtHow2MeasText")]
        public IWebElement txtHow2MeasText { get; set; }    

        [FindsBy(How = How.Id, Using = "btnSearch")]
        public IWebElement btnSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btnEditSample >a")]
        public IWebElement eavEditorOpenGrid { get; set; }

        [FindsBy(How = How.Id, Using = "linkBtnNavigateENV")]
        public IWebElement eavEditorOpenSearch { get; set; }

        [FindsBy(How = How.Id, Using = "btnNew")]
        public IWebElement btnNew { get; set; }

        [FindsBy(How = How.Id, Using = "btnCopy")]
        public IWebElement btnCopy { get; set; }

        [FindsBy(How = How.Id, Using = "btnPDFView")]
        public IWebElement btnPDFView { get; set; }

        [FindsBy(How = How.Id, Using = "menuExpanderHandle")]
        public IWebElement menuExpanderHandle { get; set; }

        [FindsBy(How = How.Id, Using = "btnDelete")]
        public IWebElement btnDelete { get; set; }


        //PagingData
        string recordsFound = "#RecordCount b";
        string dropdownSelectPerPage = "#ps";
        string goButton = "#RePage";
        string pagesaQua = "#lblPageCount";
        string nextPge = "#btnImgNext";
        string prevPage = "#btnImgPrevious";
        string lastPage = "#btnImgLast";
        string firstPage = "#btnImgFirst";
        /*string setGotoPage = "#ctrGrid_txtSkipToPg";
        string goToSkipPage = "#ctrGrid_btnImgSkipTo";*/
        string tableRecords = "#DataGrid1 > tbody > tr > td:nth-child(2) span";

    }
}
