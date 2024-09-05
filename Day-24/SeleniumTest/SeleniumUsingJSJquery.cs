using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace SeleniumSauceDemoUsingPageObjectModel
{
   internal class SeleniumUsingJSJquery
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //demoQA 
            //driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            //driver.Manage().Window.Maximize();
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("$('#firstName').val('Test first name');");
            

            //google.com
            //driver.Navigate().GoToUrl("https://google.com/");
            //driver.Manage().Window.Maximize();
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //wait.Until(d => d.FindElement(By.Name("q")));
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("var script = document.createElement('script');\r\nscript.src = 'https://code.jquery.com/jquery-3.6.0.min.js';\r\nscript.type = 'text/javascript';\r\ndocument.getElementsByTagName('head')[0].appendChild(script);");
            //Thread.Sleep(5000);
            //js.ExecuteScript("$('textarea[name=\"q\"]').val('Test Search');");
            //js.ExecuteScript("$('input[name=\"btnK\"]').click();");

            //amazon.com
            driver.Navigate().GoToUrl("https://www.amazon.com");
            driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.Id("twotabsearchtextbox")));

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            var script = "if(typeof jQuery == 'undefined'){ " +
                "var script=document.createElement('script');" +
                "script.src='https://code.jquery.com/jquery-3.7.1.min.js';" +
                "document.head.appendChild(script);}";
            js.ExecuteScript(script);
            Thread.Sleep(2000);
            js.ExecuteScript("$('#twotabsearchtextbox').val('laptop');");
            js.ExecuteScript("$(\"input.nav-input[type='submit']\").click();");
            wait.Until(d => d.FindElement(By.CssSelector("span.a-size-medium")));
            js.ExecuteScript(script);
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,500)");
            js.ExecuteScript("$(\"span.a-size-medium.a-color-base.a-text-normal\").first().click()");
            wait.Until(d => d.FindElement(By.Id("productTitle")));
            js.ExecuteScript(script);
            string productTitle = (string)js.ExecuteScript("return $('#productTitle').text().trim();");
            Console.WriteLine("==================================");
            Console.WriteLine("Product title: " + productTitle);
            Console.WriteLine("==================================");
            string firstReview = (string)js.ExecuteScript("return $('a[data-hook=\"review-title\"]').eq(0).text().trim();");
            Console.WriteLine("==================================");
            Console.WriteLine("First review: " + firstReview.Substring(firstReview.LastIndexOf("\n")).Trim());
            Console.WriteLine("==================================");
            //driver.Quit();
        }
    }
}