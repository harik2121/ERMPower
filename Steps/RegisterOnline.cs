using OpenQA.Selenium;
using TechTalk.SpecFlow;
using System;
using System.Configuration;
using System.Threading;
using NUnit.Framework;

namespace CrossBrowserTests.Steps
{

    [Binding]
    public class RegisterOnline : Hooks
    {

        [When(@"I click on register button")]
        public void WhenIClickOnRegisterButton()
        {
            ScenarioContext.Current.Pending();
        }

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
