using TechTalk.SpecFlow;

namespace ERMPower.Steps

{
    [Binding]
    public sealed class GenericFunctions
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        [Given(@"I go to the nopCommerce web page")]
        public void GivenIGoToTheNopCommerceWebPage()
        {
            ScenarioContext.Current.Pending();
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
