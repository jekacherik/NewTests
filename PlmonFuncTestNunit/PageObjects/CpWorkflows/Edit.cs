using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;


namespace PlmonFuncTestNunit.PageObjects.CpWorkflows
{
    public class Edit : PageBase
    {
        public Edit(PagesManager factory) : base(factory) { }
        public Edit(PagesManager factory, string windowHandle) : base(factory, windowHandle) { }


        [FindsBy(How = How.Id, Using = "txtSampleWorkflowTempName")]
        public IWebElement txtSampleWorkflowTempName { get; set; }

        [FindsBy(How = How.Id, Using = "txtSampleWorkflowTempDesc")]
        public IWebElement txtSampleWorkflowTempDesc { get; set; }

        [FindsBy(How = How.Id, Using = "drlActive")]
        public IWebElement drlActive { get; set; }

        [FindsBy(How = How.Id, Using = "chbDefaultTemplate")]
        public IWebElement chbDefaultTemplate { get; set; }
        

        [FindsBy(How = How.Id, Using = "linkBtnNavigateENV")]
        public IWebElement openEavEditor { get; set; }

        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.Id, Using = "btnAdd")]
        public IWebElement btnAdd { get; set; }

        //2 saves button ?????
        //buttons for adding workflows in modal window
        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'rlbButtonIcon')]")]
        public IList<IWebElement> arrowButtons { get; set; }

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
