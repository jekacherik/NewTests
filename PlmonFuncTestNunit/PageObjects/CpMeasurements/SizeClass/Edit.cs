using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;


namespace PlmonFuncTestNunit.PageObjects.CpMeasurements.SizeClass
{
    class Edit : PageBase
    {
        public Edit(PagesManager factory) : base(factory) { }
        public Edit(PagesManager factory, string windowHandle) : base(factory, windowHandle) { }

        [FindsBy(How = How.Id, Using = "txtCustomKey")]
        public IWebElement txtSizeClassCode { get; set; }

        [FindsBy(How = How.Id, Using = "txtCustom")]
        public IWebElement txtSizeClassName { get; set; }

        [FindsBy(How = How.Id, Using = "txtStyleCode")]
        public IWebElement txtStyleCode { get; set; }
        
        [FindsBy(How = How.Id, Using = "drlActive")]
        public IWebElement drlActive { get; set; }

        [FindsBy(How = How.Id, Using = "linkBtnNavigateENV")]
        public IWebElement openEavEditor { get; set; }

        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.Id, Using = "btnSaveNew")]
        public IWebElement btnSaveNew { get; set; }

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
