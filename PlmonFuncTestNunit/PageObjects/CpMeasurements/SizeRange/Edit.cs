using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;


namespace PlmonFuncTestNunit.PageObjects.CpMeasurements.SizeRange
{
    class Edit : PageBase
    {
        public Edit(PagesManager factory) : base(factory) { }
        public Edit(PagesManager factory, string windowHandle) : base(factory, windowHandle) { }

        [FindsBy(How = How.Id, Using = "txtSizeRangeCode")]
        public IWebElement txtSizeRangeCode { get; set; }

        [FindsBy(How = How.Id, Using = "chbActive")]
        public IWebElement chbActive { get; set; }

        [FindsBy(How = How.Id, Using = "linkBtnNavigateENV")]
        public IWebElement openEavEditor { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#DataGrid1 > tbody > tr > td:nth-child(2) [id*=txtSize]")]
        public IList<IWebElement> txtAllSizes { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#DataGrid1 > tbody > tr > td:nth-child(3) [id*=txtSize]")]
        public IList<IWebElement> txtAllDescriptions { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#DataGrid1 > tbody > tr > td:nth-child(4) input[type=radio]")]
        public IList<IWebElement> txtAllRadioButtons { get; set; }


        [FindsBy(How = How.Id, Using = "menuExpanderHandle")]
        public IWebElement menuExpanderHandle { get; set; }

        [FindsBy(How = How.Id, Using = "btnAddInterSize")]
        public IWebElement btnAddInterSize { get; set; }
        
        [FindsBy(How = How.Id, Using = "btnDelete")]
        public IWebElement btnDelete { get; set; }

        [FindsBy(How = How.Id, Using = "btnNo")]
        public IWebElement DeleteDialogNo { get; set; }

        [FindsBy(How = How.Id, Using = "btnYes")]
        public IWebElement DeleteDialogYes { get; set; }

        [FindsBy(How = How.Id, Using = "btnClose")]
        public IWebElement btnClose { get; set; }


    }
}
