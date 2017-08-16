using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MobbySlotsTest
{
    class TopMenuNavBar
    {
        public static string BaseUrl = "https://mobbyslots.com";
        public const int TimeOut = 30;

        [Test]
        public void MenuLinks()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(BaseUrl + "/");
            driver.FindElement(By.CssSelector("img[alt=\"MobbySlots\"]")).Click();
            driver.FindElement(By.CssSelector("ul.menu-bar-games > li > a[title=\"All Games\"]")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Featured')])[2]")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Slots')])[2]")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Table')])[2]")).Click();
            driver.FindElement(By.CssSelector("li.highlight > a[title=\"Join Now\"]")).Click();
            driver.FindElement(By.CssSelector("a[title=\"Promotions\"]")).Click();
            driver.FindElement(By.CssSelector("a[title=\"Help\"]")).Click();

            driver.Close();
        }
    }
}
