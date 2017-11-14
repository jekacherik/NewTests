﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using PlmonFuncTestNunit.Helpers;
using PlmonFuncTestNunit.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlmonFuncTestNunit
{
    public  class MenuPageObject : PageBase
    {

        public MenuPageObject(PagesManager factory) : base(factory) { }
        public MenuPageObject(PagesManager factory, string windowHandle) : base(factory, windowHandle) { }

        [FindsBy(How = How.XPath, Using = "//*[@id='LeftNavigation_GlobalListMenu']/ul/li[13]")]
        public IWebElement topMenuCP { get; set; }

        public PageObjectCP SwitchToMenuCP()
        {
            SeleniumGetMethod.WaitForPageLoad(driver);
            SwitchToFrameHelper.ToDefaultContext(driver);
            SwitchToFrameHelper.ToMainBody(driver);
            SwitchToFrameHelper.ToLeftMenu(driver);
            PopupWindowFinder wndFinder = new PopupWindowFinder(driver);
            string newWndHandle = wndFinder.Click(topMenuCP);
            return new PageObjectCP(_pagesFactory, newWndHandle);

        }
    }
}
