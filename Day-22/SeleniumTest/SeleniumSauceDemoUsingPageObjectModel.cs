using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace SeleniumSauceDemoUsingPageObjectModel
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }
        public IWebElement UsernameField => _driver.FindElement(By.Id("user-name"));
        public IWebElement PasswordField => _driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => _driver.FindElement(By.Id("login-button"));

        public void Login(string userName, string password)
        {
            UsernameField.SendKeys(userName);
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }
    }

    public class ProductPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }
        public IWebElement AddToCartButton;
        public IWebElement OpenCartButton => _driver.FindElement(By.XPath("//div[@id='shopping_cart_container']//a[@class='shopping_cart_link']"));

        public void AddToCart(string productId)
        {
            AddToCartButton = _driver.FindElement(By.Id(productId));
            AddToCartButton.Click();
        }
        public void OpenCart()
        {
            OpenCartButton.Click();
        }
    }

    public class CartPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        public CartPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }
        public IWebElement CheckoutButton => _driver.FindElement(By.Id("checkout"));

        public void Checkout()
        {
            CheckoutButton.Click();
        }
    }

    public class CheckoutPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        public CheckoutPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }
        public IWebElement FNameField => _driver.FindElement(By.Id("first-name"));
        public IWebElement LNameField => _driver.FindElement(By.Id("last-name"));
        public IWebElement PostalCodeField => _driver.FindElement(By.Id("postal-code"));
        public IWebElement ContinueButton => _driver.FindElement(By.Id("continue"));
        public IWebElement FinishButton => _driver.FindElement(By.Id("finish"));
        public IWebElement CheckoutFinishSuccessField => _driver.FindElement(By.XPath("//div[@id=\"checkout_complete_container\"]//h2"));

        public void ContinueCheckout(string fName, string lName, string pCode)
        {
            FNameField.SendKeys(fName);
            LNameField.SendKeys(lName);
            PostalCodeField.SendKeys(pCode);
            ContinueButton.Click();
        }
        public void FinishCheckout()
        {
            FinishButton.Click();
        }
    }

    internal class SeleniumSauceDemoUsingPageObjectModel
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("standard_user", "secret_sauce");
            ProductPage productPage = new ProductPage(driver);
            productPage.AddToCart("add-to-cart-sauce-labs-backpack");
            productPage.OpenCart();
            CartPage cartPage = new CartPage(driver);
            cartPage.Checkout();
            CheckoutPage checkoutPage = new CheckoutPage(driver);
            checkoutPage.ContinueCheckout("FName","Lname","P1209");
            checkoutPage.FinishCheckout();
            Console.WriteLine("===============================");
            Console.WriteLine(checkoutPage.CheckoutFinishSuccessField.Text);
            Console.WriteLine("===============================");
            //driver.Quit(); 
        }
    }
}