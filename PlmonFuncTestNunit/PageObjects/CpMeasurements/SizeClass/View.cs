using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PlmonFuncTestNunit.Helpers;
using System.Collections.Generic;

namespace PlmonFuncTestNunit.PageObjects.CpMeasurements.SizeClass
{
    public class View : PageBase
    {
        public View(PagesManager factory) : base(factory) { }
        public View(PagesManager factory, string windowHandle) : base(factory, windowHandle) { }


        [FindsBy(How = How.CssSelector, Using = "#DataGrid1 > tbody > tr.mdl-sortable-datagrid-header > td > a")]
        public IList<IWebElement> gridHeaders { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[expander-id=searchDropdownExpander]")]
        public IWebElement searchExpander { get; set; }

        [FindsBy(How = How.Id, Using = "txtCustomKey")]
        public IWebElement txtSizeClassCode { get; set; }

        [FindsBy(How = How.Id, Using = "txtCustom")]
        public IWebElement txtSizeClassName { get; set; }

        [FindsBy(How = How.Id, Using = "drlActive")]
        public IWebElement drlActive { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "#imgBtnSearch")]
        public IWebElement imgBtnSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btnEditSample >a")]
        public IWebElement eavEditorOpenGrid { get; set; }

        [FindsBy(How = How.Id, Using = "linkBtnNavigateENV")]
        public IWebElement eavEditorOpenSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btnNew>span")]
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
        public string recordsFound = "#RecordCount b";
        public string dropdownSelectPerPage = "#ps";
        public string goButton = "Button1";
        public string pagesaQua = "#lblPageCount";
        public string nextPge = "btnImgNext";
        public string prevPage = "btnImgPrevious";
        public string lastPage = "btnImgLast";
        public string firstPage = "btnImgFirst";
        /*public string setGotoPage = "#ctrGrid_txtSkipToPg";
        public string goToSkipPage = "#ctrGrid_btnImgSkipTo";*/
        public string tableRecords = "#DataGrid1 > tbody > tr[onclick]";


        public PagingData SizeClassPaging
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
