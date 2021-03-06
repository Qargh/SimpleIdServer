// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.OpenID.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class UserInfoErrorsFeature : Xunit.IClassFixture<UserInfoErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "UserInfoErrors.feature"
#line hidden
        
        public UserInfoErrorsFeature(UserInfoErrorsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UserInfoErrors", "\tCheck the errors returned by the UserInfo endpoint", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when the token is missing")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when the token is missing")]
        public virtual void ErrorIsReturnedWhenTheTokenIsMissing()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when the token is missing", null, ((string[])(null)));
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table213 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
#line 5
 testRunner.When("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table213, "When ");
#line 8
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.Then("JSON \'error_description\'=\'missing token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when token is incorrect")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when token is incorrect")]
        public virtual void ErrorIsReturnedWhenTokenIsIncorrect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when token is incorrect", null, ((string[])(null)));
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table214 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table214.AddRow(new string[] {
                        "Authorization",
                        "Bearer tst tst"});
#line 14
 testRunner.When("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table214, "When ");
#line 18
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.Then("JSON \'error_description\'=\'missing token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when token is not well formatted")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when token is not well formatted")]
        public virtual void ErrorIsReturnedWhenTokenIsNotWellFormatted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when token is not well formatted", null, ((string[])(null)));
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table215 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table215.AddRow(new string[] {
                        "Authorization",
                        "Bearer tst"});
#line 24
 testRunner.When("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table215, "When ");
#line 28
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.Then("JSON \'error\'=\'invalid_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.Then("JSON \'error_description\'=\'bad token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when the user is unknown")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when the user is unknown")]
        public virtual void ErrorIsReturnedWhenTheUserIsUnknown()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when the user is unknown", null, ((string[])(null)));
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table216 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table216.AddRow(new string[] {
                        "redirect_uris",
                        "[https://web.com]"});
            table216.AddRow(new string[] {
                        "scope",
                        "email"});
#line 34
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table216, "When ");
#line 39
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table217 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Kid",
                        "AlgName"});
            table217.AddRow(new string[] {
                        "SIG",
                        "1",
                        "ES256"});
#line 42
 testRunner.And("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table217, "And ");
#line hidden
            TechTalk.SpecFlow.Table table218 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table218.AddRow(new string[] {
                        "sub",
                        "unknown"});
            table218.AddRow(new string[] {
                        "aud",
                        "aud"});
#line 46
 testRunner.And("use \'1\' JWK from \'jwks\' to build JWS and store into \'accesstoken\'", ((string)(null)), table218, "And ");
#line hidden
            TechTalk.SpecFlow.Table table219 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table219.AddRow(new string[] {
                        "Authorization",
                        "Bearer $accesstoken$"});
#line 51
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table219, "And ");
#line 55
 testRunner.Then("HTTP status code equals to \'401\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when there is not valid audience in the token")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when there is not valid audience in the token")]
        public virtual void ErrorIsReturnedWhenThereIsNotValidAudienceInTheToken()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when there is not valid audience in the token", null, ((string[])(null)));
#line 57
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table220 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table220.AddRow(new string[] {
                        "redirect_uris",
                        "[https://web.com]"});
            table220.AddRow(new string[] {
                        "scope",
                        "email"});
#line 58
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table220, "When ");
#line 63
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table221 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Kid",
                        "AlgName"});
            table221.AddRow(new string[] {
                        "SIG",
                        "1",
                        "ES256"});
#line 66
 testRunner.And("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table221, "And ");
#line hidden
            TechTalk.SpecFlow.Table table222 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table222.AddRow(new string[] {
                        "sub",
                        "administrator"});
            table222.AddRow(new string[] {
                        "aud",
                        "aud"});
#line 70
 testRunner.And("use \'1\' JWK from \'jwks\' to build JWS and store into \'accesstoken\'", ((string)(null)), table222, "And ");
#line hidden
            TechTalk.SpecFlow.Table table223 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table223.AddRow(new string[] {
                        "Authorization",
                        "Bearer $accesstoken$"});
#line 75
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table223, "And ");
#line 79
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
 testRunner.Then("JSON \'error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 83
 testRunner.Then("JSON \'error_description\'=\'invalid audiences\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when no consent has been accepted")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when no consent has been accepted")]
        public virtual void ErrorIsReturnedWhenNoConsentHasBeenAccepted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when no consent has been accepted", null, ((string[])(null)));
#line 85
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table224 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table224.AddRow(new string[] {
                        "redirect_uris",
                        "[https://web.com]"});
            table224.AddRow(new string[] {
                        "scope",
                        "email"});
#line 86
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table224, "When ");
#line 91
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table225 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Kid",
                        "AlgName"});
            table225.AddRow(new string[] {
                        "SIG",
                        "1",
                        "ES256"});
#line 94
 testRunner.And("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table225, "And ");
#line hidden
            TechTalk.SpecFlow.Table table226 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table226.AddRow(new string[] {
                        "sub",
                        "administrator"});
            table226.AddRow(new string[] {
                        "aud",
                        "$client_id$"});
            table226.AddRow(new string[] {
                        "scope",
                        "[openid,profile]"});
#line 98
 testRunner.And("use \'1\' JWK from \'jwks\' to build JWS and store into \'accesstoken\'", ((string)(null)), table226, "And ");
#line hidden
            TechTalk.SpecFlow.Table table227 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table227.AddRow(new string[] {
                        "Authorization",
                        "Bearer $accesstoken$"});
#line 104
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table227, "And ");
#line 108
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
 testRunner.Then("JSON \'error_description\'=\'no consent has been accepted\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                UserInfoErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UserInfoErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
