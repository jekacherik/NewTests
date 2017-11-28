using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace PlmonFuncTestNunit.PageObjects.CpGVT.IntroSeasonYear
{
    class Edit : PageBase
    {
        public Edit(PagesManager factory) : base(factory) { }
        public Edit(PagesManager factory, string windowHandle) : base(factory, windowHandle) { }


        [FindsBy(How = How.Id, Using = "txtCustomKey")]
        public IWebElement txtSeasonYearCode { get; set; }

        [FindsBy(How = How.Id, Using = "txtSeasonOrder")]
        public IWebElement txtSeasonOrder { get; set; }

        [FindsBy(How = How.Id, Using = "chbCurrentSeason")]
        public IWebElement chbCurrentSeason { get; set; }
        
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

        [FindsBy(How = How.Id, Using = "btnClose")]
        public IWebElement btnClose { get; set; }

    }
}
