using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CrossBrowserTests.Steps
{
    [Binding]
    public sealed class UserRegistration
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Then(@"I provide user details in given fields")]
        public void ThenIProvideUserDetailsInGivenFields()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on register button")]
        public void WhenIClickOnRegisterButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Verify user registration was sucessful")]
        public void ThenVerifyUserRegistrationWasSucessful()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
