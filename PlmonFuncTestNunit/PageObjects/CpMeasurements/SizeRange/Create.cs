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

        [FindsBy(How = How.CssSelector, Using = "span.mdl-checkbox__ripple-container.mdl-js-ripple-effect.mdl-ripple--center")]
        public IWebElement chbActive { get; set; }

        [FindsBy(How = How.Id, Using = "linkBtnNavigateENV")]
        public IWebElement openEavEditor { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[id*=TextBox],[id*=box]")]
        public IList<IWebElement> txtAllSizes { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[id*=txtSizeDesc]")]
        public IList<IWebElement> txtAllDescriptions { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span.mdl-radio__ripple-container.mdl-js-ripple-effect.mdl-ripple--center")]
        public IList<IWebElement> txtAllRadioButtons { get; set; }
        
        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.Id, Using = "btnClose")]
        public IWebElement btnClose { get; set; }

                 // Modal
        [FindsBy(How = How.Id, Using = "btnYes")]
        public IWebElement btnYes { get; set; }

        [FindsBy(How = How.Id, Using = "btnNo")]
        public IWebElement btnNo { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#lblSampleRequired")]
        public IWebElement validator { get; set; }

    }
}
