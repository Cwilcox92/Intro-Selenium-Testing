using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Beginner_Tutorial.PAges
{
    public class HomePageClass
    {
        public HomePageClass(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver 
        { get; }

        public IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));

        IWebElement employeeDetails => Driver.FindElement(By.LinkText("Employee Details"));

        public void ClickLogin() => lnkLogin.Click();

        public bool DoesEmployeeDetailsExist() => employeeDetails.Displayed;
    }
}
