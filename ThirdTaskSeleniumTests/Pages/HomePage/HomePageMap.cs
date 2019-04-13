using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using ThirdTaskSeleniumTests.Page;

namespace ThirdTaskSeleniumTests.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public IWebElement AccordionButton => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""sidebar""]/aside[2]/ul/li[14]/a")));
    }
}
