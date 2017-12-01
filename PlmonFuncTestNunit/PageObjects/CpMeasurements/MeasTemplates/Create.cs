using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace PlmonFuncTestNunit.PageObjects.CpMeasurements.MeasTemplates
{
    public class Create : PageBase
    {
        public Create(PagesManager factory) : base(factory) { }
        public Create(PagesManager factory, string windowHandle) : base(factory, windowHandle) { }

        [FindsBy(How = How.CssSelector, Using = "div.mdl-color--white.mdl-expand-header > div > div > span > i")]
        public IWebElement TemplatePropExpander { get; set; }

        [FindsBy(How = How.Id, Using = "txtPOMType")]
        public IWebElement txtPOMType { get; set; }

        [FindsBy(How = How.Id, Using = "txtPOMTypeDescription")]
        public IWebElement txtPOMTypeDescription { get; set; }

        [FindsBy(How = How.Id, Using = "dclDivisionsIDs_Arrow")]
        public IWebElement dclDivisionsIDs_ArrowToExpand { get; set; }
        
        [FindsBy(How = How.Id, Using = "txtHow2MeasText")]
        public IWebElement txtHow2MeasText { get; set; }

        /*[FindsBy(How = How.CssSelector, Using = "var el = document.querySelector('#checkbox_0');el.click();")]
        public IWebElement AllDivisionsMultiDrops { get; set; }*/
        public string AllDivisionsMultiDrops = "var el = document.querySelector('#checkbox_0');el.click();";

        [FindsBy(How = How.Id, Using = "drlClassRangeId")]
        public IWebElement drlClassRangeId { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.width-217.m-r-30.mdl-display-in-blk span.mdl-checkbox__ripple-container.mdl-js-ripple-effect.mdl-ripple--center")]
        public IWebElement chbActive { get; set; }

        [FindsBy(How = How.XPath, Using = "//*/div[1]/div[1]/div[6]/div[1]/div/span/label[1]")]
        public IList<IWebElement> allGradingTypeRadios { get; set; }

        [FindsBy(How = How.XPath, Using = "//*/div[1]/div[1]/div[6]/div[2]/div/span/label[1]")]
        public IList<IWebElement> allGradesOfSampleRadios { get; set; }

        [FindsBy(How = How.XPath, Using = "//*/div[1]/div[1]/div[6]/div[3]/div/span/label[1]")]
        public IList<IWebElement> radiosMetricImperial { get; set; }

        [FindsBy(How = How.Id, Using = "linkBtnNavigateENV")]
        public IWebElement openEavEditor { get; set; }

        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.Id, Using = "btnClose")]
        public IWebElement btnClose { get; set; }

        [FindsBy(How = How.Id, Using = "btnYes")]
        public IWebElement btnYesModal { get; set; }

        [FindsBy(How = How.Id, Using = "btnNo")]
        public IWebElement btnNoModal { get; set; }
        
        



    }
}
