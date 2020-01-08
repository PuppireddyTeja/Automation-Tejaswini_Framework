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
    [NUnit.Framework.DescriptionAttribute("Addcompany")]
    [NUnit.Framework.CategoryAttribute("Smoke")]
    public partial class AddcompanyFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Addcompany.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Addcompany", "Add and Edit company in Support Dashboard", ProgrammingLanguage.CSharp, new string[] {
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
        [NUnit.Framework.DescriptionAttribute("A)Verify whether the user is able to add the new company using \"add new company\" " +
            "option.")]
        [NUnit.Framework.CategoryAttribute("Addcompany")]
        [NUnit.Framework.TestCaseAttribute("mohan@jobiak.ai", "mohan@123", "https://support.jobiak.ai/login", null)]
        public virtual void AVerifyWhetherTheUserIsAbleToAddTheNewCompanyUsingAddNewCompanyOption_(string username, string password, string url, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Addcompany"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A)Verify whether the user is able to add the new company using \"add new company\" " +
                    "option.", "                 B)Verify whether the user is able to edit the company in compani" +
                    "es list.", @__tags);
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
           testRunner.Given(string.Format("user navigates to {0} for support dashboard page", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
     testRunner.When(string.Format("I try to login with credentials {0} and {1}", username, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
     testRunner.When("I click on JobApprovalpageLink", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
     testRunner.When("User clicks on Companies and Add new company", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
     testRunner.When("User click And selectEmployer From Dropdown and Enter Companyname", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
     testRunner.Then("User click on search Box And Edit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
