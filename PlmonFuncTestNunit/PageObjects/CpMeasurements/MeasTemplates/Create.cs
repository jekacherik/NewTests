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

        [FindsBy(How = How.Id, Using = "txtHow2MeasText")]
        public IWebElement txtHow2MeasText { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#dclDivisionsIDs_DropDown > div input")]
        public IList<IWebElement> AllDivisionsMultiDrops { get; set; }

        [FindsBy(How = How.Id, Using = "drlClassRangeId")]
        public IWebElement drlClassRangeId { get; set; }

        [FindsBy(How = How.Id, Using = "chbActive")]
        public IWebElement chbActive { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".mdl-radio-button-group1 [id *= rb]")]
        public IList<IWebElement> allGradingTypeRadios { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".mdl-radio-button-group2 [id *= rb]")]
        public IList<IWebElement> allGradesOfSampleRadios { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".mdl-radio-button-group3 [id *= rb]")]
        public IList<IWebElement> radiosMetricImperial { get; set; }

        [FindsBy(How = How.Id, Using = "linkBtnNavigateENV")]
        public IWebElement openEavEditor { get; set; }

        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.Id, Using = "btnClose")]
        public IWebElement btnClose { get; set; }

    }
}
