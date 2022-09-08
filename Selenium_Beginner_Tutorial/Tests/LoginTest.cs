using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_Beginner_Tutorial.PAges;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_Beginner_Tutorial.Tests
{
    class LoginTest
    {
        //Browser Driver
        IWebDriver webDriver = new ChromeDriver(@"C:\Users\carlt\Desktop\Selenium_Tutorial\Retry\chromedriver_win32");
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Execiutng SetUp");
            //Navigation to site
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Test]
        public void Login()
        {
            HomePageClass homePage = new HomePageClass(webDriver);
            homePage.ClickLogin();


            LoginPageClass loginPage = new LoginPageClass(webDriver);
            loginPage.Login("admin", "password");
            Assert.That(homePage.DoesEmployeeDetailsExist, Is.True);

        }
        [TearDown]
        public void TearDown() => webDriver.Quit();




    }
}
