using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using Frogslayer.Repository;
using System.Diagnostics;

namespace Frogslayer.Utils
{
    // enum for browserType
    public enum BrowerType
    {
        Chrome,
        Firefox,
        IE
    }

    [TestFixture]
    public class Hooks : Base
    {
        // TODO: Create a data connector to parse a data source (csv, sql, txt, etc...)

        private string start_url = "http://paramount-demo.frogslayerdev.com/app/#!/login/";

        //browser
        private BrowerType _browserType;

        [OneTimeSetUp]
        public void InitializeTest()
        {
            // Get the value from NUnit - console--params 
            // e.g. nunit3-console.exe --params:Browser=Firefox \SeleniumNUnitParam.dll
            // If nothing specified, test will run in Chrome browser
            var browserType = TestContext.Parameters.Get("Browser", "Chrome");
            _browserType = (BrowerType)Enum.Parse(typeof(BrowerType), browserType); // parse enum
            ChooseDriverInstance(_browserType); // init webdriver
            repo = new Repo(webDriver); // init repo

    
            Console.WriteLine($"Navigating to {start_url}");
            webDriver.Navigate().GoToUrl(start_url);
            OpenAUT();
            // TODO: Assert page loaded


        }

        public void OpenAUT()
        {
            webDriver.Navigate().GoToUrl(start_url);
        }

        private void ChooseDriverInstance(BrowerType browserType)
        {
            // open browser
            switch (browserType)
            {
                case BrowerType.Chrome:
                    webDriver = new ChromeDriver();
                    break;
                case BrowerType.Firefox:
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
                    service.HideCommandPromptWindow = true;
                    service.SuppressInitialDiagnosticInformation = true;
                    webDriver = new FirefoxDriver(service);
                    break;
                case BrowerType.IE:
                    webDriver = new InternetExplorerDriver();
                    break;
                default:
                    webDriver = new ChromeDriver();
                    break;
            }

            OpenAUT();
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            // TODO: Logout if needed
            webDriver.Quit();
            webDriver.Dispose();
        }
    }
}
