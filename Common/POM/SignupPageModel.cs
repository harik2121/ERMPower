using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System.Threading;

namespace ERMPower.common.POM
{
    public class SignupPageModel : BasePageModel
    {
        private static string Country { get; set; }
        private static readonly By SignupButton = By.CssSelector("input.button.call-to-action-green");
        private static readonly By inputvalidationerror = By.ClassName("input-validation-error");
        private static readonly By SigninButton = By.XPath("(//button[@type='submit'])[4]");
        public SignupPageModel(RemoteWebDriver webDriver) : base(webDriver, Country) { }

        public void FillWith(string email, string FirstName, string LastName, string Mobile, string Email, string ConfirmEmail, string Password, string ConfirmPassword)
        {
            FindElement(By.Id(FirstName)).SendKeys("Test");
            FindElement(By.Id(LastName)).SendKeys("User1");
            FindElement(By.Id(Mobile)).SendKeys(DataHelpers.RandomPhone);
            Thread.Sleep(1000);
            FindElement(By.Id(Email)).SendKeys(email);
            Thread.Sleep(1000);
            FindElement(By.Id(ConfirmEmail)).SendKeys(email);
            FindElement(By.Id(Password)).SendKeys("p@ssWord");
            FindElement(By.Id(ConfirmPassword)).SendKeys("p@ssWord");
        }

        
        public void ClickOnSignupButton()
        {   
                FindElement(SignupButton).Click();
        }

        public void ClickOnSigninButton()
        {
            FindElement(SigninButton).Click();
        }


                              
    }
}
