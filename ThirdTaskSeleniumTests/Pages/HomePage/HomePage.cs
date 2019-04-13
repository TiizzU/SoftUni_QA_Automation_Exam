namespace ThirdTaskSeleniumTests.Pages.HomePage
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ThirdTaskSeleniumTests.Page;

    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        { }

        public string BaseUrl => "http://demoqa.com/";
    }
}
