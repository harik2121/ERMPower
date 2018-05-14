using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using ERMPower.common.Infra;
using System.Threading;

namespace ERMPower.common.POM
{
    public class SignupPageModel : BasePageModel
    {
        private static readonly By RegisterButton = By.ClassName("ico-register");
       // private static readonly By inputvalidationerror = By.ClassName("input-validation-error");
        private static readonly By LoginButton = By.ClassName("ico-login");
        public SignupPageModel(RemoteWebDriver webDriver) : base(webDriver) { }

        public void FillWith(string email, string FirstName, string LastName, string Mobile, string Email, string Username, string Password, string ConfirmPassword, string Country, string Role)
        {
            FindElement(By.Id(FirstName)).SendKeys("Test");
            FindElement(By.Id(LastName)).SendKeys("User1");
            FindElement(By.Id(Email)).SendKeys(email);
            FindElement(By.Id(Username)).SendKeys("tester");
            FindElement(By.Id(Password)).SendKeys("p@ssWord");
            FindElement(By.Id(ConfirmPassword)).SendKeys("p@ssWord");
            FindElement(By.Id(Country)).SendKeys("Asutralia");
            FindElement(By.Id(Role)).SendKeys("Techinal/Developer");

        }



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
