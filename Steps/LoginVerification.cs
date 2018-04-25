using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CrossBrowserTests.Steps
{
    [Binding]
    public sealed class LoginVerification
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given(@"I go to the nopCommerce web page")]
        public void GivenIGoToTheNopCommerceWebPage()
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"I click on login page")]
        public void WhenIClickOnLoginPage()
        {
            ScenarioContext.Current.Pending();
        }



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
