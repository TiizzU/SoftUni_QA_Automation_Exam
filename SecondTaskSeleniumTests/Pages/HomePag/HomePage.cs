namespace SecondTaskSeleniumTests.Pages.HomePag
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        { }

        public string BaseUrl => "http://demoqa.com/";
    }
}
