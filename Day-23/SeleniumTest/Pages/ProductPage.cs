using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObjectModelDemo.Pages
{
    public class ProductPage: BasePage
    {
        public ProductPage(IWebDriver driver) : base(driver)
        {
        }
        public IWebElement AddToCartButton => _driver.FindElement(By.Id("add-to-cart"));
        public IWebElement OpenCartButton => _driver.FindElement(By.XPath("//div[@id='shopping_cart_container']//a[@class='shopping_cart_link']"));
        public void AddToCart()
        {
            AddToCartButton.Click();
        }
        public void OpenCart()
        {
            OpenCartButton.Click();
        }
    }
}