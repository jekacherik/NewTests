using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;


namespace PlmonFuncTestNunit.PageObjects.CpMeasurements.ClassRange
{
    public class View : PageBase
    {
        public View(PagesManager factory) : base(factory) { }
        public View(PagesManager factory, string windowHandle) : base(factory, windowHandle) { }

        [FindsBy(How = How.Id, Using = "ddlSizeClass")]
        public IWebElement ddlSizeClass { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[id*=lstSelect_i]")]
        public IList<IWebElement> allAvailableSizeRanges { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li[id *= lstSelected]")]
        public IList<IWebElement> allSelectedSizeRanges { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span[class*=rlbButtonIcon]")]
        public IList<IWebElement> allArrows { get; set; }
                
        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement btnNew { get; set; }

    }
}
