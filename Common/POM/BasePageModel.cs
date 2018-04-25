using System;
using ZingAcceptanceTest.Infrastructure;
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
        private static string OrderNo { get; set; }
        private readonly By Email = By.Id("Email");
        private readonly By ConfirmEmail = By.Id("CompareEmail");
        private readonly By FirstName = By.Id("FirstName");
        private readonly By LastName = By.Id("LastName");
        private readonly By Phone = By.Id("Phone");
        private readonly By AddressLine1 = By.Id("Line1");
        private readonly By AddressLine2 = By.Id("Line2");
        private readonly By State = By.Id("State");
        private readonly By suburb = By.Id("SuburbPostcodeState");
        private readonly By postcode = By.Id("Postcode");
        private readonly By NameonCard = By.Id("Name");
        private readonly By CardNumber = By.Id("CardNumber");
        private readonly By CardExpiryMonth = By.Id("ExpiryMonth");
        private readonly By CardExpiryYear = By.Id("ExpiryYear");
        private readonly By CCV = By.Id("VerificationCode");
        private readonly By Username = By.Id("Username");
        private readonly By Password = By.Id("Password");
        private readonly By voucherCode = By.Id("voucherCode");

        public BasePageModel(RemoteWebDriver driver, string country)
        {
            Driver = driver;
            Country = country;
        }

        public void AUGotohomepage()
        {
            var url = URLs.GoToUrlAU();
            Driver.Navigate().GoToUrl(url);
        }

       
         
        
    }
}