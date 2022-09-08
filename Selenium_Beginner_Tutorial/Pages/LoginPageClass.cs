using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Beginner_Tutorial.PAges
{
    public class LoginPageClass
    {
        public LoginPageClass(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }

        IWebElement userName => Driver.FindElement(By.Name("UserName"));
        IWebElement passWord=> Driver.FindElement(By.Name("Password"));
        IWebElement bttnLogin => Driver.FindElement(By.XPath("//input[@value='Log in']"));

        public void Login(string Username, string Password)
        {
            userName.SendKeys(Username);
            passWord.SendKeys(Password);
            bttnLogin.Submit();
        }
    }
}
