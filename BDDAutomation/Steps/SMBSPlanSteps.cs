using BDDAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDAutomation.Steps
{
    class SMBSPlanSteps : StepBase
    {
        private SMBSPlan sMBSPlan = null;
        public SMBSPlanSteps()
        {
            sMBSPlan = new SMBSPlan(driver);
        }
        [When(@"user clicks on Who we work with")]
        public void whenuserclicksonWhoweworkwith()
        {
            sMBSPlan.ClickOnWhoWeWorkWith();
        }
        [When(@"user clicks on SMBS")]
        public void whenuserclicksonSMBS()
        {
            sMBSPlan.ClickOnSMBS();

        }
        [When(@"user clicks on Learn More Button")]
        public void WhenuserclicksonLearnMoreButton()
        {
            sMBSPlan.clickonLearnMoreButton();
        }
        [When(@"user clicks on Learn More Button where user dont have URL or PDF")]
        public void WhenuserclicksonLearnMoreButton1()
        {
            sMBSPlan.clickonLearnMoreButton1();
        }

        [When(@"user clicks on SMB Basicplan")]
        public void whenuserclicksonBasicplan()
        {
            sMBSPlan.clickonBasicPlan();
        }

        [When(@"user click on Basic TRY IT NOW")]
        public void whenuserclicksonBasicTryitNow()
        {
            sMBSPlan.ClickOnTryItNowForBasicPlan();
        }
       
        [When(@"user clicks on Basicplan and click on START POSTING")]
        public void whenuserclicksonBasicplanAndStartPostingJob()
        {
            sMBSPlan.ClickonStartPostingForBasicPlan();
        }
        [When(@"user selects and clicks on PRO plan")]
        public void whenuserclicksonproplan()
        {
            sMBSPlan.clickonProPlan();
        }
        [When(@"user selects PRO plan and click on TRY IT NOW")]
        public void whenuserclicksonproplanAndTryitNow()
        {
            sMBSPlan.ClickOnTryItNowForProPlan();
        }
        [When(@"user clicks on PRO plan and click on START POSTING")]
        public void whenuserclicksonProplan()
        {
            sMBSPlan.ClickonStartPostingForProPlan();
        }
        [When(@"user clicks on Feature plan")]
        public void whenuserClicksonFeatureplan()
        {
            sMBSPlan.clickonFeaturePlan();
        }
        [When(@"user Selects Feature plan and click on TRY IT NOW")]
        public void whenuserclicksonFeatureplanAndTryitNow()
        {
            sMBSPlan.ClickOnTryItNowForFeaturePlan();
        }
        [When(@"user clicks on Feature plan and click on START POSTING")]
        public void whenuserclicksonFeatureplan()
        {
            sMBSPlan.ClickonStartPostingFoFeaturePlan();
        }
        [When(@"user clicks on Close")]
        public void Whenclickonclose()
        {
            sMBSPlan.CloseDriver();
        }
        [When(@"Scroll Down to given Height for All plans")]
        public void WhenScrollDowntogivenHeightforGivenplans()
        {
            sMBSPlan.windowscroolsToGivenHeightParticularPlans();
        }



    }
}
