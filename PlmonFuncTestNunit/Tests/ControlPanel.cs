using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using PlmonFuncTestNunit.PageObjects;
using PlmonFuncTestNunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlmonFuncTestNunit.Helpers;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PlmonFuncTestNunit.Tests
{
    [TestFixture("Chrome", "ET")]

    //[Parallelizable]
    public class ControlPanel : PropertiesCollection
    {

        public ControlPanel(string browserName, string user) : base(browserName, user) { }

        //[Test, Category("Function tests Style")]
        ////[Ignore("Ignore a test")]
        //public void CheckScrollingInCalendars()
        //{
        //    var deskPage = _pages.GetPage<MenuPageObject>().SwitchToMenuCP();

        //    System.Threading.Thread.Sleep(10000);
        //    IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
        //    executor.ExecuteScript(Scripts.ScriptsJS.cparrowsCalendar);
        //    //need add href calendar 
        //    deskPage.CheckLeftMenuDirectory("Control_PanelType.aspx?CPTID=ab01f70b-62a7-e211-a8cb-005056c00008");
        //    System.Threading.Thread.Sleep(7000);

        //    Scrolling.ScrollToBottom("#overflow-view");
        //    System.Threading.Thread.Sleep(3000);

        //    Scrolling.ScrollToTop("div#overflow-view");
        //    System.Threading.Thread.Sleep(3000);


        //    Scrolling.ScrollToBottom("#overflow-view");
        //    System.Threading.Thread.Sleep(3000);
        //    Scrolling.ScrollToElement("#DataGrid1 > tbody > tr.TableHeader > td:nth-child(1) > a");
        //    System.Threading.Thread.Sleep(3000);
        //}



        [Test, Category("Function test Open CP")]
        public void CheckOpenCP()
        {
            //Open CP in menu
            var deskCP = _pages.GetPage<MenuPageObject>().SwitchToMenuCP();
            deskCP.labelTitle();

            deskCP.CheckLeftMenuDirectory("61cd600c-6e2a-e111-adfb-000c29572dc5");

        }


        public static IEnumerable<TestCaseData> StyleData
        {

            get
            {
                string pathGl = Path.GetDirectoryName(System.Reflection.Assembly.GetCallingAssembly().CodeBase);
                string path = pathGl.Substring(0, pathGl.IndexOf("bin")) + ("TestsInputData\\TestData.xlsx");
                string projectPth = new Uri(path).LocalPath;

                List<TestCaseData> testCaseDataList = new ExelUnit().ReadExcelData(projectPth, "Login");
                if (testCaseDataList != null)
                    foreach (TestCaseData testCaseData in testCaseDataList)
                        yield return testCaseData;
            }
        }

    }



}
