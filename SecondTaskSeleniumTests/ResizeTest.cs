namespace SecondTaskSeleniumTests
{
    using NUnit.Framework;
    using OpenQA.Selenium.Interactions;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;

    [TestFixture]
    public class ResizeTest : BaseTest
    {
        [Test]
        public void ResizeBox()
        {
            driver.Navigate().GoToUrl(homePage.BaseUrl);
            homePage.ResizableButton.Click();


            Actions action = new Actions(driver);
            action.DragAndDropToOffset(resizablePage.ResizeArrow, 150, 150).Perform();


            //Element width.
            Assert.That(resizablePage.ResizeBoxEle.Size.Height == 283);
            //Element height.
            Assert.That(resizablePage.ResizeBoxEle.Size.Width == 283);
        }

    }
}
