using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;


namespace PlmonFuncTestNunit.PageObjects.CpMeasurements.SizeRange
{
    public class Create : PageBase
    {
        public Create(PagesManager factory) : base(factory) { }
        public Create(PagesManager factory, string windowHandle) : base(factory, windowHandle) { }

        [FindsBy(How = How.Id, Using = "txtSizeRangeCode")]
        public IWebElement txtSizeRangeCode { get; set; }

        [FindsBy(How = How.Id, Using = "chbActive")]
        public IWebElement chbActive { get; set; }

        [FindsBy(How = How.Id, Using = "linkBtnNavigateENV")]
        public IWebElement openEavEditor { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[id*=TextBox],[id*=box]")]
        public IList<IWebElement> txtAllSizes { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[id*=txtSizeDesc]")]
        public IList<IWebElement> txtAllDescriptions { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[id*=RadioButton],[id*=Radiobutton]")]
        public IList<IWebElement> txtAllRadioButtons { get; set; }
        
        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.Id, Using = "btnClose")]
        public IWebElement btnClose { get; set; }
    }
}
