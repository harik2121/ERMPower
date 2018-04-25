using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using ERMPower.common.Infra;


namespace ERMPower.common.POM
{
    public class SignupPageModel : BasePageModel
    {
        private static string Country { get; set; }
        private static readonly By SignupButton = By.CssSelector("input.button.call-to-action-green");
        private static readonly By inputvalidationerror = By.ClassName("input-validation-error");
        private static readonly By SigninButton = By.XPath("(//button[@type='submit'])[4]");
        public SignupPageModel(RemoteWebDriver webDriver) : base(webDriver, Country) { }

        protected IWebElement FindElement(By by)
        {
            return new RetryFindElement(Driver, by)
                .WithRetry(7)
                .WithTimeout(1000)
                .Execute();
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
