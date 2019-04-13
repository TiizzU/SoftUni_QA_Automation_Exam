using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace SecondTaskSeleniumTests.Pages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        public IWebElement ResizeArrow => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""resizable""]/div[3]")));

        public IWebElement ResizeBoxEle => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""resizable""]")));
    }
}
