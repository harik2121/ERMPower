using TechTalk.SpecFlow;
using ERMPower.common.POM;
using ERMPower.common.Infra;
using OpenQA.Selenium.Remote;

namespace ERMPower.Steps

{
    [Binding]
    public class GenericFunctions
    {
        public RemoteWebDriver Driver { get; private set; }

        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        [Given(@"I go to the nopCommerce web page")]
        public void GivenIGoToTheNopCommerceWebPage()
        {
            new BasePageModel(Driver).Gotohomepage();
            Driver.Manage().Window.Maximize();
        }

        [When(@"I navigate to register page")]
        public void WhenINavigateToRegisterPage()
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"I navigate on login page")]
        public void WhenINavigateOnLoginPage()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
