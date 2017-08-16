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
    class LogInLinks
    {
        //create new instance 
        public static string BaseUrl = "https://mobbyslots.com";

        [Test]
        public void LogOUTLinksGeneral()
        {
            IWebDriver driver = new ChromeDriver();

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
        [Test]
        public void CreateLoginNewUser()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(BaseUrl);
            Console.WriteLine("Navigate to www.mobbyslots.com - DONE");

            //click join now
            driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[4]/ul[2]/li[1]/a")).Click();



            //Create new User   
            IWebElement username = driver.FindElement(By.XPath("//*[@title='Your username must be between 6 and 16 characters with no spaces or special characters.']"));
            username.SendKeys("MOB20170816");
            Console.WriteLine("Insert Username - DONE");

            //Create password
            IWebElement pswBox = driver.FindElement(By.XPath(".//*[@title='Your password needs to be between 6 and 16 characters long and for security it MUST contain at least 1 letter and 1 number.']"));
            pswBox.SendKeys("mob20170816");
            Console.WriteLine("Insert password - DONE");

            //confirm password
            IWebElement confPsw = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[1]/div[3]/input"));
            confPsw.SendKeys("mob20170816");

            //insert email address
            IWebElement email = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[2]/div[1]/input"));
            email.SendKeys("alexandrumorti+mob20170816@gmail.com");

            //insert mobile phone
            IWebElement phone = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[2]/div[2]/input"));
            phone.SendKeys("07829965485");


            //Hit Continue Button
            IWebElement continueBtn = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[3]/div/button"));
            continueBtn.Click();
            Console.WriteLine("Log In User - DONE");

            //driver.Quit();

        }

        [Test]
        public void ActivateAccount()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://mobbyslots.com/Account/Activate/MOB20170816");

            //ENTER VERIFICATION CODE

            //validation code first number
            IWebElement number1 = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[1]/div[1]/div/input[1]"));
            number1.SendKeys("1");

            //validation code second number
            IWebElement number2 = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[1]/div[1]/div/input[2]"));
            number2.SendKeys("4");

            //validation code third number
            IWebElement number3 = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[1]/div[1]/div/input[3]"));
            number3.SendKeys("5");

            //validation code fourth number
            IWebElement number4 = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[1]/div[1]/div/input[4]"));
            number4.SendKeys("1");


            //COMPLETE YOUR ACCOUNT

            //first name
            IWebElement firstName = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[2]/div[1]/input"));
            firstName.SendKeys("Alexandru");

            //last name
            IWebElement lastName = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[2]/div[2]/input"));
            lastName.SendKeys("Morti");


            //DATE OF BIRTH

            //day
            IWebElement day = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[3]/div/div/input[1]"));
            day.SendKeys("01");

            //month
            IWebElement month = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[3]/div/div/input[2]"));
            month.SendKeys("01");

            //year
            IWebElement year = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[3]/div/div/input[3]"));
            year.SendKeys("1999");

            //YOUR ADDRESS

            //postcode
            IWebElement manualInsertAddress = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[4]/div[2]/a"));
            manualInsertAddress.Click();

            //insert  house nr
            IWebElement houseNr = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[4]/div[3]/input"));
            houseNr.SendKeys("1 Eagle Flats");

            //insert Address 1
            IWebElement address1 = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[4]/div[4]/input"));
            address1.SendKeys("Queen's Road");

            //Address2

            //Town-City
            IWebElement townOrCity = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[4]/div[6]/input"));
            townOrCity.SendKeys("St Helier");

            //insert postcode
            IWebElement postcode = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[4]/div[7]/input"));
            postcode.SendKeys("JE2 3GR");

            //select country
            IWebElement coutry = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[4]/div[8]/select/option[2]"));
            coutry.Click();


            //activate account
            IWebElement activateAccount = driver.FindElement(By.XPath("html/body/div[3]/section/div[2]/form/div[5]/div[2]/button"));
            activateAccount.Click();

        }

        [Test]
        public void LogINLinksGeneral()
        {


            // LOG IN TEST USER
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(BaseUrl);
            Console.WriteLine("Navigate to www.mobbyslots.com - DONE");


            driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[1]/form/div[3]/a")).Click();

            IWebElement loginBox = driver.FindElement(By.Id("Username"));
            loginBox.SendKeys("MOB20170816");
            Console.WriteLine("Insert Username - DONE");

            IWebElement pwBox = driver.FindElement(By.Id("Password"));
            pwBox.SendKeys("mob20170816");
            Console.WriteLine("Insert password - DONE");

            IWebElement loginBtn = driver.FindElement(By.XPath("html/body/div[3]/header/nav/div[1]/form/div[2]/div/button"));
            loginBtn.Click();
            Console.WriteLine("Log In User - DONE");

            //CLICK LINKS 

            //top menu bar

            //all games
            //featured
            //slots
            //table
            //promotions
            //loyalty
            //competitions
            //more info competitions
            //vip members
            //my account
            //deposit funds
            //withdraw
            //loyalty
            //back to my account
            //activity
            //transactions
            //responsible gaming
            //betting limits
            //deposit limits select hourly value
            //deposit limits select daily value
            //deposit limits select weekly value
            //time alert
            //take a break - just visit
            //self-exclude - just visit
            //my details



            //banners

            //view your reward

            //new game promotion Play Now

            //new game promotion terms

            //featured games

            //latest competition more info

            //footer links


        }




    }
}
