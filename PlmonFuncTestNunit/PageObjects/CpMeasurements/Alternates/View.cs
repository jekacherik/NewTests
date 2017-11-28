using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace PlmonFuncTestNunit.PageObjects.CpMeasurements.Alternates
{
    public class View : PageBase
    {
        public View(PagesManager factory) : base(factory) { }
        public View(PagesManager factory, string windowHandle) : base(factory, windowHandle) { }

        [FindsBy(How = How.CssSelector, Using = "#DataGrid1 > tbody > tr> td:nth-child(1) input[type=checkbox]")]
        public IList<IWebElement> allCheckboxes { get; set; }

        [FindsBy(How = How.CssSelector, Using = "*//span[@expander-id='searchDropdownExpander']")]
        public IWebElement searchExpander { get; set; }

        [FindsBy(How = How.Id, Using = "txtAlternatesCode")]
        public IWebElement txtAlternatesCode { get; set; }

        [FindsBy(How = How.Id, Using = "txtAlternatesDesc")]
        public IWebElement txtAlternatesDesc { get; set; }

        [FindsBy(How = How.Id, Using = "imgBtnSearch")]
        public IWebElement imgBtnSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btnEditSample >a")]
        public IWebElement eavEditorOpenGrid { get; set; }

        [FindsBy(How = How.Id, Using = "linkBtnNavigateENV")]
        public IWebElement eavEditorOpenSearch { get; set; }

        [FindsBy(How = How.Id, Using = "btnNew")]
        public IWebElement btnNew { get; set; }

        [FindsBy(How = How.Id, Using = "btnDelete")]
        public IWebElement btnDelete { get; set; }
        

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
        string tableRecords = "#DataGrid1 > tbody > tr > td:nth-child(2) span";
    }
}
