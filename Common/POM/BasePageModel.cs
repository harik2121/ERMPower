using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Threading;

namespace ERMPower.common.POM
{
    [Binding]
    public class BasePageModel
    {
        protected RemoteWebDriver Driver { get; set; }
        private string Country { get; set; }
        private readonly By Email = By.Id("Email");
        private readonly By FirstName = By.Id("FirstName");
        private readonly By LastName = By.Id("LastName");
        private readonly By Phone = By.Id("Phone");
        private readonly By Username = By.Id("Username");
        private readonly By Password = By.Id("Password");
        private readonly By Yourrole = By.Id("Password");


        public BasePageModel(RemoteWebDriver driver, string country)
        {
            Driver = driver;
            Country = country;
        }

        protected IWebElement FindElement(By by)
        {
            return new RetryFindElement(Driver, by)
                .WithRetry(7)
                .WithTimeout(1000)
                .Execute();
        }

    }
}