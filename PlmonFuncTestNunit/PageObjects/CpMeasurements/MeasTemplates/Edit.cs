using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace PlmonFuncTestNunit.PageObjects.CpMeasurements.MeasTemplates
{
    class Edit : PageBase
    {
        public Edit(PagesManager factory) : base(factory) { }
        public Edit(PagesManager factory, string windowHandle) : base(factory, windowHandle) { }


        [FindsBy(How = How.CssSelector, Using = "div.mdl-color--white.mdl-expand-header > div > div > span > i")]
        public IWebElement TemplatePropExpander { get; set; }

        [FindsBy(How = How.Id, Using = "txtPOMType")]
        public IWebElement txtPOMType { get; set; }

        [FindsBy(How = How.Id, Using = "txtPOMTypeDescription")]
        public IWebElement txtPOMTypeDescription { get; set; }

        [FindsBy(How = How.Id, Using = "txtHow2MeasText")]
        public IWebElement txtHow2MeasText { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#dclDivisionsIDs_DropDown > div input")]
        public IList<IWebElement> AllDivisionsMultiDrops { get; set; }

        [FindsBy(How = How.Id, Using = "drlClassRangeId")]
        public IWebElement drlClassRangeId { get; set; }

        [FindsBy(How = How.Id, Using = "chbActive")]
        public IWebElement chbActive { get; set; }

        [FindsBy(How = How.Id, Using = "btnAddSizeRange")]
        public IWebElement btnAddSizeRange { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#DataGrid1 > tbody > tr > td > label input[type=checkbox]")]
        public IList<IWebElement> allCheckBoxesInModal { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#DataGrid1 > tbody > tr > td select")]
        public IList<IWebElement> allDropDownsInModal { get; set; }

        [FindsBy(How = How.Id, Using = "btnAdd")]
        public IWebElement btnAddModal { get; set; }

        [FindsBy(How = How.Id, Using = "btnClose")]
        public IWebElement btnCloseModal { get; set; }

        [FindsBy(How = How.Id, Using = "btnPDFView")]
        public IWebElement btnPDFView { get; set; }

        [FindsBy(How = How.Id, Using = "ddlLanguage")]
        public IWebElement ddlLanguageInPreview { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#DataGrid1 > tbody > tr > td a")]
        public IList<IWebElement> allReportsInPreview { get; set; }



        [FindsBy(How = How.Id, Using = "menuExpanderHandle")]
        public IWebElement menuExpanderHandle { get; set; }

        [FindsBy(How = How.Id, Using = "btnCopy")]
        public IWebElement btnCopy { get; set; }


        [FindsBy(How = How.CssSelector, Using = "[expander-id=viewTypeDropdownExpander]")]
        public IWebElement viewEngExpander { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#tb_pos a")]
        public IList<IWebElement> allSizes { get; set; }

        [FindsBy(How = How.Id, Using = "imgBtnAdd")]
        public IWebElement imgBtnAdd { get; set; }

        [FindsBy(How = How.Id, Using = "btnPomLibrary")]
        public IWebElement btnPomLibrary { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[expander-id=searchDropdownExpander]")]
        public IWebElement modalSearchExpander { get; set; }

        [FindsBy(How = How.Id, Using = "txtPOMCode")]
        public IWebElement modalTxtPOMCode { get; set; }

        [FindsBy(How = How.Id, Using = "txtPOMDesc")]
        public IWebElement modalTxtPOMDesc { get; set; }

        [FindsBy(How = How.Id, Using = "txtAlternatesCode")]
        public IWebElement modalTxtAlternatesCode { get; set; }

        [FindsBy(How = How.Id, Using = "imgBtnSearch")]
        public IWebElement imgBtnSearchModal { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#DataGrid1 > tbody > tr > td:nth-child(1) > label > span input")]
        public IList<IWebElement> allCheckBoxesModal2 { get; set; }

        //PagingData in MODAL WINDOW
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
        string tableRecords = "#DataGrid1 > tbody > tr > td:nth-child(1) > label > span input:not([id*='SelectAll'])";

        [FindsBy(How = How.CssSelector, Using = "[class*=modalwindow] #btnSave")]
        public IWebElement btnSaveInModal { get; set; }

        //[FindsBy(How = How.CssSelector, Using = "[class*=modalwindow] #btnClose")]
        [FindsBy(How = How.CssSelector, Using = "div.mdl-layout__container > div > header > div > span.mdl-toolbar-button:nth-child(odd)")]
        public IWebElement btnCloseInModal { get; set; }

        [FindsBy(How = How.Id, Using = "btnPOMDelete")]
        public IWebElement btnPOMDelete { get; set; }

        [FindsBy(How = How.Id, Using = "cbDeleteAll")]
        public IWebElement cbDeleteAll { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[type=checkbox][id*=chkDelete]")]
        public IList<IWebElement> allCheckboxesModal { get; set; }

        [FindsBy(How = How.CssSelector, Using = "tr.mdl-simple-datagrid-header label > span.mdl-checkbox__ripple-container.mdl-js-ripple-effect.mdl-ripple--center")]
        public IWebElement cbSelectAllInSizeRange { get; set; }


        [FindsBy(How = How.Id, Using = "btnDelete")]
        public IWebElement btnDeleteModal { get; set; }

        [FindsBy(How = How.Id, Using = "btnNo")]
        public IWebElement DeleteDialogNo { get; set; }

        [FindsBy(How = How.Id, Using = "btnYes")]
        public IWebElement DeleteDialogYes { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".mdl-radio-button-group1 [id *= rb]")]
        public IList<IWebElement> allGradingTypeRadios { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".mdl-radio-button-group2 [id *= rb]")]
        public IList<IWebElement> allGradesOfSampleRadios { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".mdl-radio-button-group3 [id *= rb]")]
        public IList<IWebElement> radiosMetricImperial { get; set; }

        [FindsBy(How = How.Id, Using = "linkBtnNavigateENV")]
        public IWebElement openEavEditor { get; set; }

        [FindsBy(How = How.Id, Using = "btnPOMLinked")]
        public IWebElement btnLinkPom { get; set; }

        [FindsBy(How = How.Id, Using = "btnPomCritical")]
        public IWebElement btnPomCritical { get; set; }

        [FindsBy(How = How.Id, Using = "btnWhereUsed")]
        public IWebElement btnWhereUsed { get; set; }


        /* -----------------------------------MEASUREMENT TEMPLATE WHERE USED PAGE--------------------------*/

       [FindsBy(How = How.CssSelector, Using = "#form-search input,#form-search select")]
       public IList<IWebElement> allSearchFieldsWhereUsed { get; set; }

       [FindsBy(How = How.CssSelector, Using = "[action*=Style_List_WhereUse] [expander-id=searchDropdownExpander]")]
       public IWebElement btnSearchExpanderInWhereUsed { get; set; }

       [FindsBy(How = How.CssSelector, Using = "[action*=Style_List_WhereUse] [expander-id=viewTypeDropdownExpander]")]
       public IWebElement btnViewTypeDropdownExpanderInWhereUsed { get; set; }

       [FindsBy(How = How.CssSelector, Using = "[action*=Style_List_WhereUse] #tb_pos a>span")]
       public IList<IWebElement> allSelectViewItemsWhereUsed { get; set; }


       [FindsBy(How = How.CssSelector, Using = "[action*=Style_List_WhereUse] #imgBtnSearch")]
       public IWebElement btnSearchInWhereUsed { get; set; }

       [FindsBy(How = How.CssSelector, Using = "[action*=Style_List_WhereUse] #linkBtnNavigateENV")]
       public IWebElement btnEavInWhereUsed { get; set; }

       [FindsBy(How = How.CssSelector, Using = "#ctrGrid_RadGridStyles_ctl00 > thead > tr > th > a")]
       public IList<IWebElement> allGridHeadersInWhereUsed { get; set; }

       [FindsBy(How = How.Id, Using = "mdlThumbViewImg")]
       public IWebElement showHideThumbnail { get; set; }

                //Paging where used
       string recordsFoundWhereUsed = "#ctrGrid_RecordCount strong";
       string dropdownSelectPerPageWhereUsed = "#ctrGrid_ps";
       string goButtonWhereUsed = "#ctrGrid_btnGo";
       string pagesaQuaWhereUsed = "#ctrGrid_lblPageCount";
       string nextPgeWhereUsed = "#ctrGrid_btnImgNext";
       string prevPageWhereUsed = "#ctrGrid_btnImgPrevious";
       string lastPageWhereUsed = "#ctrGrid_btnImgLast";
       string firstPageWhereUsed = "#ctrGrid_btnImgFirst";
       string setGotoPageWhereUsed = "#ctrGrid_txtSkipToPg";
       string goToSkipPageWhereUsed = "#ctrGrid_btnImgSkipTo";
       string tableRecordsWhereUsed = "#ctrGrid_RadGridStyles_ctl00 > tbody > tr";

       [FindsBy(How = How.CssSelector, Using = "[action*=Style_List_WhereUse] #btnClose")]
       public IWebElement btnCloseInWhereUsed { get; set; }

       /* ---------------------------------------------------------------------------------------------------*/

        [FindsBy(How = How.Id, Using = "editableGridMenuExpanderHandle")]
        public IWebElement editableGridMenuExpanderHandle { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li #btnPOMUnLink")]
        public IWebElement btnBreakLinkPom { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li #btnSampleSize")]
        public IWebElement btnChangeSampleSize { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SizeDataGrid > tbody > tr > td:nth-child(2) input")]
        public IList<IWebElement> allRadiosSampleChange { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li #btnCopyGrading")]
        public IWebElement btnCopyGradingValues { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li #btnPOMSort")]
        public IWebElement btnPOMSortFromExpander { get; set; }

        [FindsBy(How = How.Id, Using = "btn_selectimage")]
        public IWebElement btn_selectImage { get; set; }

        [FindsBy(How = How.Id, Using = "btn_remove")]
        public IWebElement btn_removeImage { get; set; }

        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.Id, Using = "btnClose")]
        public IWebElement btnClose { get; set; }
    }
}
