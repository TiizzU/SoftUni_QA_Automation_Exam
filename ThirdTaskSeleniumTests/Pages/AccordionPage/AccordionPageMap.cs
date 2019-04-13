using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using ThirdTaskSeleniumTests.Page;

namespace ThirdTaskSeleniumTests.Pages.AccordionPage
{
    public partial class AccordionPage : BasePage
    {
        public IWebElement AccordionSection1Button => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""ui-id-1""]")));
        public IWebElement AccordionSection2Button => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""ui-id-3""]")));
        public IWebElement AccordionSection3Button => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""ui-id-5""]")));
        public IWebElement AccordionSection4Button => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""ui-id-7""]")));
        
        public string AccordionSection1Text => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""ui-id-1""]")).GetAttribute("aria-expanded"));
        public string AccordionSection2Text => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""ui-id-3""]")).GetAttribute("aria-expanded"));
        public string AccordionSection3Text => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""ui-id-5""]")).GetAttribute("aria-expanded"));
        public string AccordionSection4Text => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id=""ui-id-7""]")).GetAttribute("aria-expanded"));

    }
}
