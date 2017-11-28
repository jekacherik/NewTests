using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace PlmonFuncTestNunit.PageObjects.CpMeasurements.InternationalSize
{
    class Edit : PageBase
    {
        public Edit(PagesManager factory) : base(factory) { }
        public Edit(PagesManager factory, string windowHandle) : base(factory, windowHandle) { }

        [FindsBy(How = How.Id, Using = "txtCustomKey")]
        public IWebElement txtSizeNameCode { get; set; }

        [FindsBy(How = How.Id, Using = "txtCustom")]
        public IWebElement txtSizeName { get; set; }

        [FindsBy(How = How.Id, Using = "drlActive")]
        public IWebElement drlActive { get; set; }

        [FindsBy(How = How.Id, Using = "linkBtnNavigateENV")]
        public IWebElement openEavEditor { get; set; }

        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement btnSaveAndClose { get; set; }

        [FindsBy(How = How.Id, Using = "btnSaveNew")]
        public IWebElement btnSaveNew { get; set; }

        [FindsBy(How = How.Id, Using = "btnDelete")]
        public IWebElement btnDelete { get; set; }

        [FindsBy(How = How.Id, Using = "btnYes")]
        public IWebElement btnYesModal { get; set; }

        [FindsBy(How = How.Id, Using = "btnNo")]
        public IWebElement btnNoModal { get; set; }
        
        [FindsBy(How = How.Id, Using = "btnClose")]
        public IWebElement btnClose { get; set; }

    }
}
