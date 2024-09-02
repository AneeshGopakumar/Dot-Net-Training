using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObjectModelDemo.Pages
{
    public class CartPage: BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
        }
        public IWebElement CheckoutButton => _driver.FindElement(By.Id("checkout"));

        public void Checkout()
        {
            CheckoutButton.Click();
        }
    }
}