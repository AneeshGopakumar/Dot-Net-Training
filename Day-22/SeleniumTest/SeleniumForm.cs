using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace SeleniumForm
{
    internal class Program
    {
        static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms");
            //driver.Manage().Window.Maximize();
            //IWebElement webElementName1 = driver.FindElement(By.Id("et_pb_contact_name_0"));
            //webElementName1.SendKeys("Aneesh Gopakumar 1");
            //IWebElement webElementMsg1 = driver.FindElement(By.Id("et_pb_contact_message_0"));
            //webElementMsg1.SendKeys("Message 1");
            //IWebElement webElementSubmit1 = driver.FindElement(By.XPath("//div[@id='et_pb_contact_form_0']//button[@name='et_builder_submit_button']"));
            //webElementSubmit1.Click();


            //IWebElement webElementName2 = driver.FindElement(By.Id("et_pb_contact_name_1"));
            //webElementName2.SendKeys("Aneesh Gopakumar 2");            
            //IWebElement webElementMsg2 = driver.FindElement(By.Id("et_pb_contact_message_1"));
            //webElementMsg2.SendKeys("Message 2");
            //IWebElement webElementCaptcha = driver.FindElement(By.ClassName("et_pb_contact_captcha_question"));
            //string captchaResponse = (Convert.ToInt32(webElementCaptcha.Text.Replace("+","").Split(" ")[0].Trim()) +
            //            Convert.ToInt32(webElementCaptcha.Text.Replace("+", "").Split(" ")[2].Trim())).ToString();
            //Console.WriteLine(captchaResponse);
            //IWebElement webElementCaptchaResponse = driver.FindElement(By.Name("et_pb_contact_captcha_1"));
            //webElementCaptchaResponse.SendKeys(captchaResponse);
            //IWebElement webElementSubmit2 = driver.FindElement(By.XPath("//div[@id='et_pb_contact_form_1']//button[@name='et_builder_submit_button']"));
            //webElementSubmit2.Click();

            //dropdown selections
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            driver.Manage().Window.Maximize();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, 1000);"); // Scroll down by 1000 pixels

            // Optionally, you can wait to see the effect
            System.Threading.Thread.Sleep(2000);
            IWebElement webElementState = driver.FindElement(By.XPath("//div[@id='state']//div//div"));
            //webElementState.SendKeys("NCR");

            //System.Threading.Thread.Sleep(3000);
            //using JS
            //IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            //js1.ExecuteScript("arguments[0].innerText = 'ABC';", webElementState);

            //using Actions
            Actions actions = new Actions(driver);
            actions.MoveToElement(webElementState);
            actions.Click();
            actions.SendKeys("NCR").Perform();

            //driver.Quit(); 
        }
    }
}