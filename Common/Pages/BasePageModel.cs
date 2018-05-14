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
        private readonly By Email = By.Id("Email");
        private readonly By FirstName = By.Id("FirstName");
        private readonly By LastName = By.Id("LastName");
        private readonly By Phone = By.Id("Phone");
        private readonly By Username = By.Id("Username");
        private readonly By Password = By.Id("Password");
        private readonly By Yourrole = By.Id("Password");
        private readonly By Country = By.Id("Password");
        private readonly By RegisterButton = By.Id("ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm___CustomNav0_StepNextButton");
        private readonly By LoginButton = By.Id("ctl00_ctl00_cph1_cph1_ctrlCustomerLogin_LoginForm_LoginButton");



        public BasePageModel(RemoteWebDriver driver)
        {
            Driver = driver;
        }

        public void Gotohomepage()
        {
            var url = URLs.GoToUrl();
            Driver.Navigate().GoToUrl(url);
        }

    }
}