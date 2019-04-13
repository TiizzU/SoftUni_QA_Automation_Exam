namespace SecondTaskSeleniumTests
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Remote;
    using SecondTaskSeleniumTests.Pages.HomePag;
    using SecondTaskSeleniumTests.Pages.ResizablePage;
    using System;

    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver driver;
        protected HomePage homePage;
        protected ResizablePage resizablePage;

        [SetUp]
        public void Setup()
        {
            // Driver
            driver = GetChromeDriver();
            // Maximize The Window
            driver.Manage().Window.Maximize();

            // Home Page
            homePage = new HomePage(driver);

            // ResizablePage
            resizablePage = new ResizablePage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        private RemoteWebDriver GetChromeDriver()
        {
            var path = Environment.GetEnvironmentVariable("ChromeWebDriver", EnvironmentVariableTarget.Machine);
            var options = new ChromeOptions();
            options.AddArguments("--no-sandbox");

            if (!string.IsNullOrWhiteSpace(path))
            {
                return new ChromeDriver(path, options, TimeSpan.FromSeconds(30));
            }
            else
            {
                return new ChromeDriver(options);
            }
        }
    }
}