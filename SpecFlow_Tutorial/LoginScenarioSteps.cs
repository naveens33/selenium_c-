using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlow_Tutorial
{
    [Binding]
    public class LoginScenarioSteps
    {
        [Given(@"Navigate to login page")]
        public void GivenNavigateToLoginPage()
        {
            
        }
        
        [When(@"enter credentials and click signin")]
        public void WhenEnterCredentialsAndClickSignin(Table table)
        {

            Credentials obj = new Credentials();
            Dictionary<string,string> cre=obj.getData(table);
            
                Console.WriteLine(cre["username"]+cre["password"]);
            
        }
        
        [Then(@"Verify usern logged in is unsuccessful")]
        public void ThenVerifyUsernLoggedInIsUnsuccessful()
        {
            
        }
    }
}
