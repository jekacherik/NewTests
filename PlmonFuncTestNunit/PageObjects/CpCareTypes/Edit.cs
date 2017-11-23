using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PlmonFuncTestNunit.PageObjects.CpCareTypes
{
    public class Edit : PageBase
    {
        public Edit(PagesManager factory) : base(factory) { }
        public Edit(PagesManager factory, string windowHandle) : base(factory, windowHandle) { }


        [FindsBy(How = How.Id, Using = "txtCustomKey")]
        public IWebElement txtItemId { get; set; }

        [FindsBy(How = How.Id, Using = "txtCustom")]
        public IWebElement txtItemName { get; set; }

        [FindsBy(How = How.Id, Using = "drlActive")]
        public IWebElement drlActive { get; set; }

        [FindsBy(How = How.Id, Using = "linkBtnNavigateENV")]
        public IWebElement openEavEditor { get; set; }

        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement btnSaveAndClose { get; set; }

        [FindsBy(How = How.Id, Using = "btnSaveNew")]
        public IWebElement btnSaveAndNew { get; set; }

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
