
namespace SecondTaskSeleniumTests.Pages.HomePag
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public partial class HomePage : BasePage
    {
        public IWebElement ResizableButton => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""sidebar""]/aside[1]/ul/li[3]/a")));
    }
}
