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
    class LoginTest
    {
        public static string BaseUrl = "https://mobbyslots.com";
        public const int TimeOut = 30;

        [Test]
        public void Login()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(BaseUrl);
            Console.WriteLine("Navigate to www.mobbyslots.com - DONE");


            driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[1]/form/div[3]/a")).Click();

            IWebElement loginBox = driver.FindElement(By.Id("Username"));
            loginBox.SendKeys("warlockdead3");
            Console.WriteLine("Insert Username - DONE");

            IWebElement pwBox = driver.FindElement(By.Id("Password"));
            pwBox.SendKeys("warlockdead3");
            Console.WriteLine("Insert password - DONE");

            IWebElement loginBtn = driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[1]/form/div[2]/div/button"));
            loginBtn.Click();
            Console.WriteLine("Log In User - DONE");

            driver.Quit();

        }
    }
}
