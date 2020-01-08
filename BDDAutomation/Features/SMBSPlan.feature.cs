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
    [NUnit.Framework.DescriptionAttribute("SMBSPlan")]
    public partial class SMBSPlanFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SMBSPlan.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SMBSPlan", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("a)Verify whether user clicks \"Who We Work With\" and select \"SMBS\" and click on \"L" +
            "earn More\" button")]
        [NUnit.Framework.CategoryAttribute("SMBSPlan")]
        [NUnit.Framework.TestCaseAttribute("https://www.jobiak.ai", null)]
        public virtual void AVerifyWhetherUserClicksWhoWeWorkWithAndSelectSMBSAndClickOnLearnMoreButton(string url, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SMBSPlan"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("a)Verify whether user clicks \"Who We Work With\" and select \"SMBS\" and click on \"L" +
                    "earn More\" button", null, @__tags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
    testRunner.Given(string.Format("user navigates to {0} Jobiak URL site", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
          testRunner.When("user clicks on Who we work with", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
    testRunner.When("user clicks on SMBS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
    testRunner.When("user clicks on Learn More Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("b)Verify whether user select \"SMBS\" and click on \"Learn More\" button if User dont" +
            " have URL or PDF")]
        [NUnit.Framework.TestCaseAttribute("https://www.jobiak.ai", null)]
        public virtual void BVerifyWhetherUserSelectSMBSAndClickOnLearnMoreButtonIfUserDontHaveURLOrPDF(string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("b)Verify whether user select \"SMBS\" and click on \"Learn More\" button if User dont" +
                    " have URL or PDF", null, exampleTags);
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 15
      testRunner.Given(string.Format("user navigates to {0} Jobiak URL site", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
         testRunner.When("user clicks on Who we work with", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
   testRunner.When("user clicks on SMBS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
   testRunner.When("user clicks on Learn More Button where user dont have URL or PDF", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("c)Verify user clicks on \"Post Job URL\" or \"upload pdf\" in \"SMBS\"")]
        [NUnit.Framework.TestCaseAttribute("https://www.jobiak.ai", null)]
        public virtual void CVerifyUserClicksOnPostJobURLOrUploadPdfInSMBS(string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("c)Verify user clicks on \"Post Job URL\" or \"upload pdf\" in \"SMBS\"", null, exampleTags);
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 24
      testRunner.Given(string.Format("user navigates to {0} Jobiak URL site", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
      testRunner.When("user clicks on Who we work with", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
   testRunner.When("user clicks on SMBS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
         testRunner.When("user clicks on PostJobUrl", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
    testRunner.When("I Click on job description and enter value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
             testRunner.When("I click on Date Posted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
             testRunner.When("I click on Save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
    testRunner.Then("click on company for the Given Job Url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
          testRunner.When("click on Location", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
             testRunner.When("I click on Valid Through based on Date Posted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
          testRunner.Then("I Click on Preview Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
          testRunner.Then("I click on OptimiZe Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
             testRunner.Then("I Click on Preview Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
             testRunner.Then("I click on Edit Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
             testRunner.Then("I Click on Preview Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
           testRunner.When("user clicks on Close", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
           testRunner.When("user clicks on Uploadpdf", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
   testRunner.When("I Click on job description and enter value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
         testRunner.When("I click on Date Posted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
      testRunner.When("I click on Save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
   testRunner.Then("click on company", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
      testRunner.Then("click on Salary", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
      testRunner.Then("I Click on Preview Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
      testRunner.Then("I click on OptimiZe Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
         testRunner.Then("I Click on Preview Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
         testRunner.Then("I click on Edit Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 50
         testRunner.Then("I Click on Preview Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("d)verify user click on \"Basic plan\" in pricing then click on \"TRY IT NOW\"")]
        [NUnit.Framework.TestCaseAttribute("https://www.jobiak.ai", null)]
        public virtual void DVerifyUserClickOnBasicPlanInPricingThenClickOnTRYITNOW(string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("d)verify user click on \"Basic plan\" in pricing then click on \"TRY IT NOW\"", null, exampleTags);
#line 55
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 56
      testRunner.Given(string.Format("user navigates to {0} Jobiak URL site", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
         testRunner.When("user clicks on Who we work with", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
   testRunner.When("user clicks on SMBS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
   testRunner.When("Scroll Down to given Height for All plans", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
         testRunner.When("user clicks on SMB Basicplan", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
         testRunner.When("user click on Basic TRY IT NOW", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("e)verify user click on \"Basic plan\" in pricing then click on \"start Posting\"")]
        [NUnit.Framework.TestCaseAttribute("https://www.jobiak.ai", null)]
        public virtual void EVerifyUserClickOnBasicPlanInPricingThenClickOnStartPosting(string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("e)verify user click on \"Basic plan\" in pricing then click on \"start Posting\"", null, exampleTags);
#line 67
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 68
      testRunner.Given(string.Format("user navigates to {0} Jobiak URL site", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 69
         testRunner.When("user clicks on Who we work with", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
   testRunner.When("user clicks on SMBS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
   testRunner.When("Scroll Down to given Height for All plans", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
         testRunner.When("user clicks on SMB Basicplan", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
   testRunner.When("user clicks on Basicplan and click on START POSTING", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("f)verify user click on \"Pro plan\" in pricing then click on \"TRY IT NOW\"")]
        [NUnit.Framework.TestCaseAttribute("https://www.jobiak.ai", null)]
        public virtual void FVerifyUserClickOnProPlanInPricingThenClickOnTRYITNOW(string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("f)verify user click on \"Pro plan\" in pricing then click on \"TRY IT NOW\"", null, exampleTags);
#line 78
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 79
      testRunner.Given(string.Format("user navigates to {0} Jobiak URL site", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 80
         testRunner.When("user clicks on Who we work with", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
   testRunner.When("user clicks on SMBS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
   testRunner.When("Scroll Down to given Height for All plans", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
         testRunner.When("user selects and clicks on PRO plan", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
         testRunner.When("user selects PRO plan and click on TRY IT NOW", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("g)verify user click on \"Pro plan\" in pricing then click on \"start Posting\"")]
        [NUnit.Framework.TestCaseAttribute("https://www.jobiak.ai", null)]
        public virtual void GVerifyUserClickOnProPlanInPricingThenClickOnStartPosting(string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("g)verify user click on \"Pro plan\" in pricing then click on \"start Posting\"", null, exampleTags);
#line 91
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 92
      testRunner.Given(string.Format("user navigates to {0} Jobiak URL site", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 93
         testRunner.When("user clicks on Who we work with", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 94
   testRunner.When("user clicks on SMBS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
   testRunner.When("Scroll Down to given Height for All plans", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
         testRunner.When("user selects and clicks on PRO plan", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 97
         testRunner.When("user clicks on PRO plan and click on START POSTING", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("h)verify user click on \"Feature plan\" in pricing then click on \"TRY IT NOW\"")]
        [NUnit.Framework.TestCaseAttribute("https://www.jobiak.ai", null)]
        public virtual void HVerifyUserClickOnFeaturePlanInPricingThenClickOnTRYITNOW(string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("h)verify user click on \"Feature plan\" in pricing then click on \"TRY IT NOW\"", null, exampleTags);
#line 102
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 103
      testRunner.Given(string.Format("user navigates to {0} Jobiak URL site", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 104
         testRunner.When("user clicks on Who we work with", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
   testRunner.When("user clicks on SMBS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 106
   testRunner.When("Scroll Down to given Height for All plans", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
         testRunner.When("user clicks on Feature plan", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 108
   testRunner.When("user Selects Feature plan and click on TRY IT NOW", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("i)verify user click on \"Feature plan\" in pricing then click on \"start Posting\"")]
        [NUnit.Framework.TestCaseAttribute("https://www.jobiak.ai", null)]
        public virtual void IVerifyUserClickOnFeaturePlanInPricingThenClickOnStartPosting(string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("i)verify user click on \"Feature plan\" in pricing then click on \"start Posting\"", null, exampleTags);
#line 115
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 116
       testRunner.Given(string.Format("user navigates to {0} Jobiak URL site", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 117
         testRunner.When("user clicks on Who we work with", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 118
   testRunner.When("user clicks on SMBS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
   testRunner.When("Scroll Down to given Height for All plans", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
         testRunner.When("user clicks on Feature plan", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 121
         testRunner.When("user clicks on Feature plan and click on START POSTING", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

