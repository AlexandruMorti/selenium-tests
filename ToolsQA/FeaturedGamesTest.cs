using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenQA.Selenium.Interactions;

namespace ToolsQA
{
    class FeaturedGamesTest
    {
        [Test]
        public static void FeaturedGames()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://mobbyslots.com");

            IWebElement image = driver.FindElement(By.XPath("//img[@src='https://cdn.mobbossgaming.com//Content/games/thumbnails/compact/art_of_the_heist_mob.png?v=20170317']"));
            IWebElement button = driver.FindElement(By.XPath("html/body/div[3]/section/section[2]/div/ul/li[1]/div/div/div/div/div/a[2]"));
            Hover(driver, image);
            HoverAndClick(driver, image, button);

        }

        public static void Hover(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public static void HoverAndClick(IWebDriver driver, IWebElement elementToHover, IWebElement elementToClick)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(elementToHover).Click(elementToClick).Build().Perform();
        }
    }
}
