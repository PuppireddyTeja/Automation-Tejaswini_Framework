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
    [NUnit.Framework.DescriptionAttribute("StaffingAgencies")]
    public partial class StaffingAgenciesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "StaffingAgencies.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "StaffingAgencies", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Verify user clicks on \"contact us to get started\" in \"Staffing Agencies\"")]
        [NUnit.Framework.CategoryAttribute("StaffingAgencies")]
        [NUnit.Framework.TestCaseAttribute("https://www.jobiak.ai", null)]
        public virtual void VerifyUserClicksOnContactUsToGetStartedInStaffingAgencies(string url, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "StaffingAgencies"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify user clicks on \"contact us to get started\" in \"Staffing Agencies\"", null, @__tags);
#line 3
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
          testRunner.Given(string.Format("user navigates to {0} Jobiak URL site", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
             testRunner.When("user clicks on StaffingAgencies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 6
    testRunner.When("user clicks on StaffingAgenciesContactUsGetStarted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify user clicks on \"Post Job URL\" or \"upload pdf\" in \"Staffing Agencies\"")]
        [NUnit.Framework.TestCaseAttribute("https://www.jobiak.ai", null)]
        public virtual void VerifyUserClicksOnPostJobURLOrUploadPdfInStaffingAgencies(string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify user clicks on \"Post Job URL\" or \"upload pdf\" in \"Staffing Agencies\"", null, exampleTags);
#line 12
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 13
          testRunner.Given(string.Format("user navigates to {0} Jobiak URL site", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
    testRunner.When("user clicks on StaffingAgencies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
             testRunner.When("user clicks on PostJobUrl", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
    testRunner.When("user clicks on Uploadpdf", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
    testRunner.When("I Click on job description and enter value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
             testRunner.When("I click on Date Posted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
          testRunner.When("I click on Save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
             testRunner.Then("click on company in Tagging Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
             testRunner.Then("click on Salary", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
          testRunner.Then("I Click on Preview Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
          testRunner.Then("I click on OptimiZe Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
             testRunner.Then("I Click on Preview Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
             testRunner.Then("I click on Edit Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
             testRunner.Then("I Click on Preview Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify user try through \"ATS\"  and click on \"contact us to get started\" in \"Staff" +
            "ing Agencies\"")]
        [NUnit.Framework.TestCaseAttribute("https://www.jobiak.ai", null)]
        public virtual void VerifyUserTryThroughATSAndClickOnContactUsToGetStartedInStaffingAgencies(string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify user try through \"ATS\"  and click on \"contact us to get started\" in \"Staff" +
                    "ing Agencies\"", null, exampleTags);
#line 32
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 33
          testRunner.Given(string.Format("user navigates to {0} Jobiak URL site", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
    testRunner.When("user clicks on StaffingAgencies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
             testRunner.When("user clicks on ATS contactusgetStarted Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify user Interested in learning more about Jobiak and click on \"contact us to " +
            "get started\" in \"Staffing Agencies\"")]
        [NUnit.Framework.TestCaseAttribute("https://www.jobiak.ai", null)]
        public virtual void VerifyUserInterestedInLearningMoreAboutJobiakAndClickOnContactUsToGetStartedInStaffingAgencies(string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify user Interested in learning more about Jobiak and click on \"contact us to " +
                    "get started\" in \"Staffing Agencies\"", null, exampleTags);
#line 41
    this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 42
          testRunner.Given(string.Format("user navigates to {0} Jobiak URL site", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
    testRunner.When("user clicks on StaffingAgencies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
             testRunner.When("user clicks on contactusgetStarted Button to Register with Jobiak", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

