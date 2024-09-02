using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObjectModelDemo.Pages
{
    public class HomePage: BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        //private IReadOnlyCollection<IWebElement> ProductList => FindElements(By.ClassName("inventory_list"));
        private IReadOnlyCollection<IWebElement> ProductList => FindElements(By.CssSelector(".inventory_item"));

        public void OpenProduct(string productName)
        {
            int counter = 0;
            foreach (IWebElement product in ProductList)
            {
                counter++;
                if (product.Text.Contains(productName))
                {
                    FindElement(By.XPath("(//div[@class='inventory_item']//div[@class='inventory_item_img']//a)[" + counter.ToString() + "]")).Click();
                    break;
                }
            }
        }
    }
}