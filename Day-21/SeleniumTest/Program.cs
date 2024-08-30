using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://demoqa.com/text-box");
            //driver.Navigate().GoToUrl("https://www.google.com/");
            //driver.Manage().Window.Maximize();
            ////IWebElement webElementUserName = driver.FindElement(By.Id("userName"));
            ////webElementUserName.SendKeys("Aneesh Gopakumar");
            //IWebElement webElementSearchKey = driver.FindElement(By.Name("q"));
            //webElementSearchKey.SendKeys("Aneesh Gopakumar" + Keys.Tab);
            //Thread.Sleep(5000);
            //IWebElement webElementSearch = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]"));
            //webElementSearch.Click();

            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Maximize();
            IWebElement webElement = driver.FindElement(By.XPath("//font[@face='Georgia, Times New Roman, Times, serif']"));
            Console.WriteLine("IP: " + webElement.Text.Replace("Your IP is","").Replace("ecbiz312.inmotionhosting.com","").Trim());
            //driver.Quit(); 
        }
    }
}