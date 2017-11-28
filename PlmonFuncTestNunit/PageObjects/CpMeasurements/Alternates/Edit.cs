using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace PlmonFuncTestNunit.PageObjects.CpMeasurements.Alternates
{
    class Edit : PageBase
    {
        public Edit(PagesManager factory) : base(factory) { }
        public Edit(PagesManager factory, string windowHandle) : base(factory, windowHandle) { }

        [FindsBy(How = How.Id, Using = "txtAlternatesCode")]
        public IWebElement txtAlternatesCode { get; set; }

        [FindsBy(How = How.Id, Using = "txtAlternatesDesc")]
        public IWebElement txtAlternatesDesc { get; set; }

        [FindsBy(How = How.Id, Using = "linkBtnNavigateENV")]
        public IWebElement openEavEditor { get; set; }

        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.Id, Using = "btnClose")]
        public IWebElement btnClose { get; set; }

    }
}
