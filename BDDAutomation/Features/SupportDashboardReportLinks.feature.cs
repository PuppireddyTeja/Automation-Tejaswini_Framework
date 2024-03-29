﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BDDAutomation.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SupportDashboardReportLinks")]
    [NUnit.Framework.CategoryAttribute("Smoke")]
    public partial class SupportDashboardReportLinksFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SupportDashboardReportLinks.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SupportDashboardReportLinks", null, ProgrammingLanguage.CSharp, new string[] {
                        "Smoke"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A)Verify Whether user clicks on Report Links and able to see Report")]
        [NUnit.Framework.CategoryAttribute("SupportDashboardReportLinks")]
        [NUnit.Framework.TestCaseAttribute("mohan@jobiak.ai", "mohan@123", "https://support.jobiak.ai/login", null)]
        public virtual void AVerifyWhetherUserClicksOnReportLinksAndAbleToSeeReport(string username, string password, string url, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SupportDashboardReportLinks"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A)Verify Whether user clicks on Report Links and able to see Report", null, @__tags);
#line 3
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
 testRunner.Given(string.Format("user navigates to {0} for support dashboard page", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.When(string.Format("I try to login with credentials {0} and {1}", username, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
 testRunner.When("user clicks on Customer Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.Then("user clicks on Company and Select Required Fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
 testRunner.When("user clicks on All Report Links", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.When("user clicks on View and Applies Links", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("B)Verify Whether user clicks on Access Permissions and able to Update")]
        [NUnit.Framework.TestCaseAttribute("mohan@jobiak.ai", "mohan@123", "https://support.jobiak.ai/login", null)]
        public virtual void BVerifyWhetherUserClicksOnAccessPermissionsAndAbleToUpdate(string username, string password, string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("B)Verify Whether user clicks on Access Permissions and able to Update", null, exampleTags);
#line 17
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 19
 testRunner.Given(string.Format("user navigates to {0} for support dashboard page", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
 testRunner.When(string.Format("I try to login with credentials {0} and {1}", username, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.When("user clicks on Access permissions and Enter All Fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("C)Verify Whether User able to edit and save in Access Users Page")]
        [NUnit.Framework.TestCaseAttribute("mohan@jobiak.ai", "mohan@123", "https://support.jobiak.ai/login", null)]
        public virtual void CVerifyWhetherUserAbleToEditAndSaveInAccessUsersPage(string username, string password, string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("C)Verify Whether User able to edit and save in Access Users Page", null, exampleTags);
#line 26
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 28
  testRunner.Given(string.Format("user navigates to {0} for support dashboard page", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
  testRunner.When(string.Format("I try to login with credentials {0} and {1}", username, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
  testRunner.When("user clicks on Edit in Given Access Users Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("D)Verify Whether user clicks on Job Queue Dashboard,Google PostedJobs Views and D" +
            "ashboard Stats")]
        [NUnit.Framework.TestCaseAttribute("mohan@jobiak.ai", "mohan@123", "https://support.jobiak.ai/login", null)]
        public virtual void DVerifyWhetherUserClicksOnJobQueueDashboardGooglePostedJobsViewsAndDashboardStats(string username, string password, string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("D)Verify Whether user clicks on Job Queue Dashboard,Google PostedJobs Views and D" +
                    "ashboard Stats", null, exampleTags);
#line 36
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 38
testRunner.Given(string.Format("user navigates to {0} for support dashboard page", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
 testRunner.When(string.Format("I try to login with credentials {0} and {1}", username, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.When("user clicks on Job Queue Dashboard,Google PostedJobs and Views", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("E)Verify Whether user clicks on Dashboard Stats")]
        [NUnit.Framework.TestCaseAttribute("mohan@jobiak.ai", "mohan@123", "https://support.jobiak.ai/login", null)]
        public virtual void EVerifyWhetherUserClicksOnDashboardStats(string username, string password, string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("E)Verify Whether user clicks on Dashboard Stats", null, exampleTags);
#line 46
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 48
testRunner.Given(string.Format("user navigates to {0} for support dashboard page", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
 testRunner.When(string.Format("I try to login with credentials {0} and {1}", username, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.When("user clicks on Dashboard Stats and ETL Management", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

