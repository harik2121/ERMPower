using TechTalk.SpecFlow;

namespace ERMPower.Steps
{
    [Binding]
    public sealed class LoginVerification
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        
       
        [Then(@"I provide user login details")]
        public void ThenIProvideUserLoginDetails()
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"Verify user login was sucessful")]
        public void ThenVerifyUserLoginWasSucessful()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
