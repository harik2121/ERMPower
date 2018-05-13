using System;
using System.Linq;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using ERMPower.common.POM;
using ERMPower.common.Infra;

namespace CrossBrowserTests.Steps
{
    [Binding]
    public class BaseStepDefinitions
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        private SignupPageModel _signupPage;
        protected static RemoteWebDriver Driver { get; set; }

        protected SignupPageModel SignupPage
        {
            get
            {
                _signupPage = _signupPage ?? new SignupPageModel(Driver);
                return _signupPage;
            }
        }
        protected string BaseUrl
        {
            get
            {
                return string.Join("//", Driver.Url.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Take(2));
            }
        }

        protected IWebElement FindElement(By by)
        {
            return new RetryFindElement(Driver, by)
                .WithRetry(7)
                .WithTimeout(1500)
                .Execute();
        }

        protected bool ClickElement(IWebElement webElement)
        {
            return new RetryClickElement(webElement)
                .WithRetry(7)
                .WithTimeout(1500)
                .Execute();
        }

        protected IWebElement FindElementSafe(By by)
        {
            try
            {
                return FindElement(by);
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        protected bool IsElementPresent(By by)
        {
            try
            {
                FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        protected void NavigateTo(string url)
        {
            try
            {
                Driver.Navigate().GoToUrl(url);
            }
            catch (NoSuchElementException)
            {

            }
        }
    }
}
