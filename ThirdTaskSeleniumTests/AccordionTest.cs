namespace ThirdTaskSeleniumTests
{
    using FluentAssertions;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Text;

    [TestFixture]
    public class AccordionTest : BaseTest
    {
        [Test]
        [TestCase("Section1")]
        [TestCase("Section2")]
        [TestCase("Section3")]
        [TestCase("Section4")]
        public void AccordionTestSection(string testCase)
        {
            driver.Navigate().GoToUrl(homePage.BaseUrl);

            homePage.AccordionButton.Click();

            switch (testCase)
            {
                case "Section1":
                    accordionPage.AccordionSection1Button.Click();
                    accordionPage.AccordionSection1Text.Should().Be("true");
                    accordionPage.AccordionSection2Text.Should().Be("false");
                    accordionPage.AccordionSection3Text.Should().Be("false");
                    accordionPage.AccordionSection4Text.Should().Be("false");
                    break;
                case "Section2":
                    accordionPage.AccordionSection2Button.Click();
                    accordionPage.AccordionSection2Text.Should().Be("true");
                    accordionPage.AccordionSection1Text.Should().Be("false");
                    accordionPage.AccordionSection3Text.Should().Be("false");
                    accordionPage.AccordionSection4Text.Should().Be("false");
                    break;
                case "Section3":
                    accordionPage.AccordionSection3Button.Click();
                    accordionPage.AccordionSection3Text.Should().Be("true");
                    accordionPage.AccordionSection1Text.Should().Be("false");
                    accordionPage.AccordionSection2Text.Should().Be("false");
                    accordionPage.AccordionSection4Text.Should().Be("false");
                    break;
                case "Section4":
                    accordionPage.AccordionSection4Button.Click();
                    accordionPage.AccordionSection4Text.Should().Be("true");
                    accordionPage.AccordionSection1Text.Should().Be("false");
                    accordionPage.AccordionSection2Text.Should().Be("false");
                    accordionPage.AccordionSection3Text.Should().Be("false");
                    break;
                default:
                    break;
            }
        }

    }
}
