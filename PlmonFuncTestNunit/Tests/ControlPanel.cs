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
using PlmonFuncTestNunit.TestsInputData;
using PlmonFuncTestNunit.Base_Classes;
using PlmonFuncTestNunit.TestsInputData.ControlPanel;

namespace PlmonFuncTestNunit.Tests
{
    [TestFixture("Chrome", "IT")]

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

        [Test, Category("Function test Open CP")]
        [TestCaseSource(typeof(TestDataSourceCp), nameof(TestDataSourceCp.GetInputDataForTest))]
        public void CheckSearchInCp(InputDataCp dataInput)
        {
            if (!string.IsNullOrEmpty(dataInput.ReadingDataError)) Assert.Fail(dataInput.ReadingDataError);
            if (!string.IsNullOrEmpty(dataInput.IgnoreReason)) Assert.Ignore(dataInput.IgnoreReason);

            var deskCP = _pages.GetPage<MenuPageObject>().SwitchToMenuCP();
            deskCP.labelTitle();
            deskCP.CheckLeftMenuDirectory("61cd600c-6e2a-e111-adfb-000c29572dc5");  // Measurements
            for (int i = 0; i < deskCP.CpMeasuremntsItems.Count; i++)
            {
                deskCP.CpMeasuremntsItems[i].Click();
                SeleniumGetMethod.WaitForPageLoad(driver);
                deskCP.SwitchToMain();
                deskCP.CheckSearchMeasCp(dataInput);
                deskCP.SwitchToCPMenu();
            }
        }

        [Test, Category("Function test Open CP")]
        public void CheckSortInCp()
        {
            var deskCP = _pages.GetPage<MenuPageObject>().SwitchToMenuCP();
            deskCP.labelTitle();
            deskCP.CheckLeftMenuDirectory("61cd600c-6e2a-e111-adfb-000c29572dc5");  // Measurements
            //deskCP.CheckLeftMenuDirectory("35d22856-6f2a-e111-adfb-000c29572dc5");  // MatSubTypes
            for (int i = 0; i < deskCP.CpMeasuremntsItems.Count; i++)
            {
                deskCP.CpMeasuremntsItems[i].Click();
                SeleniumGetMethod.WaitForPageLoad(driver);
                deskCP.SwitchToMain();
                deskCP.CheckSorting();
                deskCP.SwitchToCPMenu();
            }
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
        public class TestDataSourceCp
        {
            private static string XmlFileName { get; set; }
            static TestDataSourceCp()
            {
                var testsConfig = TestsConfiguration.Instance;

                string pathGl = Path.GetDirectoryName(System.Reflection.Assembly.GetCallingAssembly().CodeBase);
                string path = pathGl.Substring(0, pathGl.IndexOf("bin")) + ("TestsInputData\\XMLData\\TestsCasesDataCp.xml");
                string projectPth = new Uri(path).LocalPath;

                XmlFileName = projectPth;
                _getInputDataForTest = TestCasesDataLoader.Load<InputDataCp>(XmlFileName, nameof(ControlPanel.CheckSearchInCp));

            }
            private static Func<IEnumerable<TestCaseData>> _getInputDataForTest;
            public static IEnumerable<TestCaseData> GetInputDataForTest() => _getInputDataForTest();
        }


}
