using TechTalk.SpecFlow;

namespace ERMPower.Steps
{
    [Binding]
    public sealed class VerifyAPIResults
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given(@"I communicate to public API url")]
        public void GivenICommunicateToPublicAPIUrl()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I have fetch API details")]
        public void WhenIHaveFetchAPIDetails()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I verify API returned values")]
        public void ThenIVerifyAPIReturnedValues()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
