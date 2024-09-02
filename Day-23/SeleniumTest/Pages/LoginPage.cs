using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObjectModelDemo.Pages
{
    public class LoginPage: BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement UsernameField => FindElement(By.Id("user-name"));
        private IWebElement PasswordField => FindElement(By.Id("password"));
        private IWebElement LoginButton => FindElement(By.Id("login-button"));

        public void Login(string userName, string password)
        {
            UsernameField.SendKeys(userName);
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }
    }
}