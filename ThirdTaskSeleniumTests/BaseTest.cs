namespace ThirdTaskSeleniumTests
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Remote;
    using System;
    using ThirdTaskSeleniumTests.Pages.AccordionPage;
    using ThirdTaskSeleniumTests.Pages.HomePage;

    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver driver;
        protected HomePage homePage;
        protected AccordionPage accordionPage;

        [SetUp]
        public void Setup()
        {
            // Driver
            driver = GetChromeDriver();

            // Maximize The Window
            driver.Manage().Window.Maximize();

            // Home Page
            homePage = new HomePage(driver);

            // Accordion Page
            accordionPage = new AccordionPage(driver);
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