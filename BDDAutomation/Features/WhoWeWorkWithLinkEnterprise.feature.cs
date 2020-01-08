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
    [NUnit.Framework.DescriptionAttribute("WhoWeWorkWithLink")]
    public partial class WhoWeWorkWithLinkFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "WhoWeWorkWithLinkEnterprise.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "WhoWeWorkWithLink", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("a)verify whether user clicks on \"who we work with\",Select Enterprise and click on" +
            " plan1")]
        [NUnit.Framework.CategoryAttribute("WhoWeWorkWithLink")]
        [NUnit.Framework.TestCaseAttribute("https://www.jobiak.ai", null)]
        public virtual void AVerifyWhetherUserClicksOnWhoWeWorkWithSelectEnterpriseAndClickOnPlan1(string url, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "WhoWeWorkWithLink"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("a)verify whether user clicks on \"who we work with\",Select Enterprise and click on" +
                    " plan1", null, @__tags);
#line 3
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
         testRunner.Given(string.Format("user navigates to {0} Jobiak URL site", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
   testRunner.When("user click on Enterprise Link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 6
   testRunner.Then("Scroll Down to Particular Height", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 7
         testRunner.When("user selects on Enterprise Plan 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
   testRunner.When("user click on contact us to get started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
   testRunner.Then("user Enter contact page Fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("b)verify whether user clicks on \"who we work with\",Select Enterprise and click on" +
            " plan2")]
        [NUnit.Framework.TestCaseAttribute("https://www.jobiak.ai", null)]
        public virtual void BVerifyWhetherUserClicksOnWhoWeWorkWithSelectEnterpriseAndClickOnPlan2(string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("b)verify whether user clicks on \"who we work with\",Select Enterprise and click on" +
                    " plan2", null, exampleTags);
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 15
         testRunner.Given(string.Format("user navigates to {0} Jobiak URL site", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
   testRunner.When("user click on Enterprise Link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
   testRunner.Then("Scroll Down to Particular Height", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
         testRunner.When("user selects  Enterprise and click Plan 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
   testRunner.When("user click on contact us to get started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
   testRunner.Then("user Enter contact page Fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("verify whether user clicks on \"who we work with\",Select Enterprise and click on p" +
            "lan3")]
        [NUnit.Framework.TestCaseAttribute("https://www.jobiak.ai", null)]
        public virtual void VerifyWhetherUserClicksOnWhoWeWorkWithSelectEnterpriseAndClickOnPlan3(string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("verify whether user clicks on \"who we work with\",Select Enterprise and click on p" +
                    "lan3", null, exampleTags);
#line 26
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 27
         testRunner.Given(string.Format("user navigates to {0} Jobiak URL site", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
   testRunner.When("user click on Enterprise Link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
   testRunner.Then("Scroll Down to Particular Height", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
         testRunner.When("user selects on Enterprise and click on plan 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
   testRunner.When("user click on contact us to get started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
   testRunner.Then("user Enter contact page Fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("verify whether user clicks on \"who we work with\",Select Enterprise and click on p" +
            "lan4")]
        [NUnit.Framework.TestCaseAttribute("https://www.jobiak.ai", null)]
        public virtual void VerifyWhetherUserClicksOnWhoWeWorkWithSelectEnterpriseAndClickOnPlan4(string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("verify whether user clicks on \"who we work with\",Select Enterprise and click on p" +
                    "lan4", null, exampleTags);
#line 37
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 38
         testRunner.Given(string.Format("user navigates to {0} Jobiak URL site", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
   testRunner.When("user click on Enterprise Link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
   testRunner.Then("Scroll Down to Particular Height", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
         testRunner.When("user selects and clicks on Enterprise Plan 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
   testRunner.When("user click on contact us to get started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
   testRunner.Then("user Enter contact page Fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("verify whether user clicks on \"who we work with\",Select Enterprise and click on p" +
            "lan5")]
        [NUnit.Framework.TestCaseAttribute("https://www.jobiak.ai", null)]
        public virtual void VerifyWhetherUserClicksOnWhoWeWorkWithSelectEnterpriseAndClickOnPlan5(string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("verify whether user clicks on \"who we work with\",Select Enterprise and click on p" +
                    "lan5", null, exampleTags);
#line 48
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 49
         testRunner.Given(string.Format("user navigates to {0} Jobiak URL site", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
   testRunner.When("user click on Enterprise Link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
   testRunner.Then("Scroll Down to Particular Height", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
         testRunner.When("user selects Enterprise Plan 5 and click on Contact US Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

