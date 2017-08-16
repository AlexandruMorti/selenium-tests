using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class TopMenuLinks
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://mobbyslots.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheTopMenuLinksTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.CssSelector("img[alt=\"MobbySlots\"]")).Click();
            driver.FindElement(By.CssSelector("ul.menu-bar-games > li > a[title=\"All Games\"]")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Featured')])[2]")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Slots')])[2]")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Table')])[2]")).Click();
            driver.FindElement(By.CssSelector("li.highlight > a[title=\"Join Now\"]")).Click();
            driver.FindElement(By.CssSelector("a[title=\"Promotions\"]")).Click();
            driver.FindElement(By.CssSelector("a[title=\"Help\"]")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
