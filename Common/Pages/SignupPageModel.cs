using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using ERMPower.common.Infra;


namespace ERMPower.common.POM
{
    public class SignupPageModel : BasePageModel
    {
        private static readonly By RegisterButton = By.ClassName("ico-register");
       // private static readonly By inputvalidationerror = By.ClassName("input-validation-error");
        private static readonly By LoginButton = By.ClassName("ico-login");
        public SignupPageModel(RemoteWebDriver webDriver) : base(webDriver) { }

        protected IWebElement FindElement(By by)
        {
            return new RetryFindElement(Driver, by)
                .WithRetry(7)
                .WithTimeout(1000)
                .Execute();
        }


        public void ClickOnRegisterpButton()
        {   
             FindElement(RegisterButton).Click();
        }

        public void ClickOnLoginButton()
        {
            FindElement(LoginButton).Click();
        }


                              
    }
}
