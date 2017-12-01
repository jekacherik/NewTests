using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PlmonFuncTestNunit.Helpers;
using System.Collections.Generic;

namespace PlmonFuncTestNunit.PageObjects.CpMeasurements.SizeRange
{
    public class View : PageBase
    {
        public View(PagesManager factory) : base(factory) { }
        public View(PagesManager factory, string windowHandle) : base(factory, windowHandle) { }

        [FindsBy(How = How.CssSelector, Using = "#DataGrid1 > tbody > tr.mdl-simple-datagrid-header > td > a")]
        public IList<IWebElement> gridHeaders { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[expander-id=searchDropdownExpander]")]
        public IWebElement searchExpander { get; set; }

        [FindsBy(How = How.Id, Using = "txtSizeRangeCode")]
        public IWebElement txtSizeRangeCode { get; set; }

        [FindsBy(How = How.Id, Using = "btnSearch")]
        public IWebElement btnSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btnEditSample >a")]
        public IWebElement eavEditorOpenGrid { get; set; }

        [FindsBy(How = How.Id, Using = "linkBtnNavigateENV")]
        public IWebElement eavEditorOpenSearch { get; set; }

        [FindsBy(How = How.Id, Using = "btnNew")]
        public IWebElement btnNew { get; set; }

                    //PagingData
        public string recordsFound = "#RecordCount b";
        public string dropdownSelectPerPage = "#ps";
        public string goButton = "RePage";
        public string pagesaQua = "#lblPageCount";
        public string nextPge = "btnImgNext";
        public string prevPage = "btnImgPrevious";
        public string lastPage = "btnImgLast";
        public string firstPage = "btnImgFirst";
        /*public string setGotoPage = "#ctrGrid_txtSkipToPg";
        public string goToSkipPage = "#ctrGrid_btnImgSkipTo";*/
        public string tableRecords = "#DataGrid1 > tbody > tr[onclick]";


        public PagingData SizeRangePaging
        {
            get
            {
                PagingData parametes = new PagingData();
                parametes.recordsFound = recordsFound;
                parametes.dropdownSelectPerPage = dropdownSelectPerPage;
                parametes.goButton = goButton;
                parametes.pagesQua = pagesaQua;
                parametes.nextPage = nextPge;
                parametes.prevPage = prevPage;
                parametes.lastPage = lastPage;
                parametes.firstPage = firstPage;
                //parametes.setGotoPage = setGotoPage;
                //parametes.goToSkipPage = goToSkipPage;
                parametes.tableRecors = tableRecords;
                return parametes;
            }
        }
    }
}
