using TechTalk.SpecFlow;
using ERMPower.common.POM;

namespace ERMPower.Steps

{
    [Binding]
    public class GenericFunctions : CrossBrowserTests.Hooks

    {

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
            SignupPage.ClickOnRegisterpButton();
                
        }

        
        [When(@"I navigate on login page")]
        public void WhenINavigateOnLoginPage()
        {
            SignupPage.ClickOnLoginButton();
        }

    }
}
