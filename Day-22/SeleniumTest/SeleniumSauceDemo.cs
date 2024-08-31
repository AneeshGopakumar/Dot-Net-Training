using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace SeleniumTest
{
    internal class SeleniumSauceDemo
    {
        static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
            IWebElement webElementUserName = driver.FindElement(By.Id("user-name"));
            webElementUserName.SendKeys("standard_user");
            IWebElement webElementPassword = driver.FindElement(By.Id("password"));
            webElementPassword.SendKeys("secret_sauce" + Keys.Enter);
            Thread.Sleep(2000);
            IWebElement webElementAddToCart = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            webElementAddToCart.Click();
            IWebElement webElementCart = driver.FindElement(By.XPath("//div[@id='shopping_cart_container']//a[@class='shopping_cart_link']"));
            webElementCart.Click();
            IWebElement webElementCheckOut = driver.FindElement(By.Id("checkout"));
            webElementCheckOut.Click();
            Thread.Sleep(2000);
            IWebElement webElementFName = driver.FindElement(By.Id("first-name"));
            webElementFName.SendKeys("FName");
            IWebElement webElementLName = driver.FindElement(By.Id("last-name"));
            webElementLName.SendKeys("LName");
            IWebElement webElementPostalCode = driver.FindElement(By.Id("postal-code"));
            webElementPostalCode.SendKeys("P1209");
            IWebElement webElementContinue = driver.FindElement(By.Id("continue"));
            webElementContinue.Click();
            Thread.Sleep(2000);
            IWebElement webElementFinish = driver.FindElement(By.Id("finish"));
            webElementFinish.Click();
            Thread.Sleep(2000);
            IWebElement webElementCompleteMsg = driver.FindElement(By.XPath("//div[@id=\"checkout_complete_container\"]//h2"));
            Console.WriteLine("===============================");
            Console.WriteLine(webElementCompleteMsg.Text);
            Console.WriteLine("===============================");
            //driver.Quit(); 
        }
    }
}
