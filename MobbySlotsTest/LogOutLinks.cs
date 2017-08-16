using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;

namespace MobbySlotsTest
{
    class LogOutLinks
    { //create new instance 
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// Logs the outpage links.
        /// </summary>
        [Test]
        public void LogOutpageLinks()
        {

            //Navigate to mobbyslots page
            driver.Navigate().GoToUrl("http:www.mobbyslots.com");
            Console.WriteLine("Navigate to www.mobbyslots.com - DONE");


            // Click logo
            driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[1]/form/div[1]/a/img")).Click();
            Console.WriteLine("Click on Logo - Done");

            //click banners
            driver.FindElement(By.XPath(".//*[@id='carousel-example-generic']/a[2]/span[1]")).Click();
            driver.FindElement(By.XPath(".//*[@id='carousel-example-generic']/a[2]/span[1]")).Click();
            driver.FindElement(By.XPath(".//*[@id='carousel-example-generic']/a[2]/span[1]")).Click();
            driver.FindElement(By.XPath(".//*[@id='carousel-example-generic']/a[2]/span[1]")).Click();
            driver.FindElement(By.XPath(".//*[@id='carousel-example-generic']/a[2]/span[1]")).Click();
            Console.WriteLine("Click on banner links - Done");

            //click on Join Now New Game Promotion
            driver.FindElement(By.XPath("html/body/div[3]/section/section[1]/p[3]/a")).Click();

            //go back to home page
            driver.Navigate().GoToUrl("http:www.mobbyslots.com");
            Console.WriteLine("Navigate to www.mobbyslots.com - DONE");

            //click on terms new game promotion
            driver.FindElement(By.XPath("html/body/div[3]/section/section[1]/p[4]/a")).Click();

            //Footer links

            //help&support
            driver.FindElement(By.XPath("html/body/div[3]/footer/section[2]/ul/li[1]/a")).Click();
            //driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/div[2]/p[4]/a")).Click();
            //driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/div[2]/p[5]/i/a")).Click();
            //driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/div[2]/p[6]/a")).Click();

            //privacy policy
            driver.FindElement(By.XPath("html/body/div[3]/footer/section[2]/ul/li[2]/a")).Click();

            //Terms and conditions
            driver.FindElement(By.XPath("html/body/div[3]/footer/section[2]/ul/li[3]/a")).Click();
            //driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/ol[1]/li[1]/a")).Click();

            //responsible gaming
            driver.FindElement(By.XPath("html/body/div[3]/footer/section[2]/ul/li[4]/a")).Click();
            //driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/ul[1]/li[5]/a")).Click();

            //FAQs
            driver.FindElement(By.XPath("html/body/div[3]/footer/section[2]/ul/li[5]/a")).Click();

            Console.WriteLine("General test on links - Done");

            //close browser
            driver.Close();
        }
    }
}
