using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
namespace PlmonFuncTestNunit.PageObjects.CpMeasurements.PomLibrary
{
    class Edit : PageBase
    {
        public Edit(PagesManager factory) : base(factory) { }
        public Edit(PagesManager factory, string windowHandle) : base(factory, windowHandle) { }

        [FindsBy(How = How.Id, Using = "txtPOMCode")]
        public IWebElement txtPOMCode { get; set; }

        [FindsBy(How = How.Id, Using = "txtPOMDesc")]
        public IWebElement txtPOMDesc { get; set; }

        [FindsBy(How = How.Id, Using = "txtHow2MeasText")]
        public IWebElement txtHow2MeasText { get; set; }

        [FindsBy(How = How.Id, Using = "txtSort")]
        public IWebElement txtSort { get; set; }

        [FindsBy(How = How.CssSelector, Using = "textarea[id *= eavA],input[id *= eavA]")]
        public IList<IWebElement> allEavTextBoxes { get; set; }

        [FindsBy(How = How.Id, Using = "btnAdd")]
        public IWebElement btnSelectImage { get; set; }

        [FindsBy(How = How.Id, Using = "imgFeature")]
        public IWebElement imgFeature { get; set; }

        [FindsBy(How = How.Id, Using = "linkBtnNavigateENV")]
        public IWebElement openEavEditor { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#lstSelect > div.rlbGroup > ul li")]
        public IList<IWebElement> allAvailabelAlternates { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#lstSelected > div > ul li[class=rlbItem]")]
        public IList<IWebElement> allSelectedAlternates { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[class*=rlbButtonIcon]")]
        public IList<IWebElement> allArrows { get; set; }

        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.Id, Using = "btnClose")]
        public IWebElement btnClose { get; set; }

    }
}
