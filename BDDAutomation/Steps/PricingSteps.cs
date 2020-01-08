using BDDAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDAutomation.Steps
{
    class PricingSteps : StepBase
    {
        private Pricing pricing = null;
        public PricingSteps()
        {
            pricing = new Pricing(driver);
        }
        [When(@"user clicks on Pricing")]
        public void WhenuserclicksonPricing()
        {
            pricing.clickonPricing();
        }
        [When(@"user clicks on Contact Us Get Started")]
        public void WhenuserclicksonContactUsGetStarted()
        {
            pricing.clickonContactUsGetStarted();
        }
        [Then(@"Navigate Back to Given Page")]
        public void ThenNavigateBacktoGivenPage()
        {
            pricing.NavigateBackToGivenPage();
        }
        [When(@"user selects and clicks on Small medium Business")]
        public void WhenuserSelectsAndclicksonSMBS()
        {
            pricing.ClickOnSMBPlan();

        }
        [When(@"User click on SMBS Basic plan")]
        public void WhenuserclickonBasicplan()
        {
            pricing.ClickOnBasicplan();
        }

        [When(@"User click on SMBS Pro plan")]
        public void WhenuserclickonProplan()
        {
            pricing.ClickOnProplan();
        }
        [When(@"User click on SMBS Feature plan")]
        public void WhenuserclickonFeatureplan()
        {
            pricing.ClickOnFeatureplan();
        }
        [When(@"User click on Partnerships")]
        public void WhenuserclickOnPartnerships()
        {
            pricing.ClickOnPartnerships();
        }
         [When(@"User click on Partnerships Link and click on contact us Get Started")]
        public void WhenuserclickOnPartnershipsAndclickContact()
        {
            pricing.ClickOnPartnershipsContactUsGetStarted();
        }
        [When(@"User click on About Link")]
        public void WhenuserclickOnAbout()
        {
            pricing.ClickOnAbout();
        }
        [When(@"User click on About Link and Start Posting")]
        public void WhenuserclickOnAboutAndStartPosting()
        {
            pricing.clickOnStartPosting();
        }


    }
}
