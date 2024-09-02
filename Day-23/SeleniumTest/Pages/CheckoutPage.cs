using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObjectModelDemo.Pages
{
    public class CheckoutPage: BasePage
    {
        public CheckoutPage(IWebDriver driver) : base(driver)
        {
        }
        public IWebElement FNameField => _driver.FindElement(By.Id("first-name"));
        public IWebElement LNameField => _driver.FindElement(By.Id("last-name"));
        public IWebElement PostalCodeField => _driver.FindElement(By.Id("postal-code"));
        public IWebElement ContinueButton => _driver.FindElement(By.Id("continue"));
        public IWebElement FinishButton => _driver.FindElement(By.Id("finish"));
        public IWebElement CheckoutFinishSuccessField => _driver.FindElement(By.XPath("//div[@id=\"checkout_complete_container\"]//h2"));

        public void Checkout(string fName, string lName, string pCode)
        {
            FNameField.SendKeys(fName);
            LNameField.SendKeys(lName);
            PostalCodeField.SendKeys(pCode);
            ContinueButton.Click();
            FinishButton.Click();
        }
        
    }
}