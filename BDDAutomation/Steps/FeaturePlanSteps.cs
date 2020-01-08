using BDDAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDAutomation.Steps
{
    class FeaturePlanSteps : StepBase
    {
        private FeaturePlan featurePlan = null;
        private EnterprisePlan enterprisePlan = null;
        private BasicPlanSigin basicPlanSigin = null;
        private Proplan proplan = null;
        private FreePlan freePlan = null;


        public FeaturePlanSteps()
        {
            featurePlan = new FeaturePlan(driver);
            enterprisePlan = new EnterprisePlan(driver);
            basicPlanSigin = new BasicPlanSigin(driver);
            proplan = new Proplan(driver);
            freePlan = new FreePlan(driver);
        }
        [When(@"user clicks on Refer A Friend Link")]
        public void WhenClicksOnDAshboardLink()
        {
            featurePlan.clickonReferFriend();

        }
        [When(@"user clicks on Change Source Link and enter all field clicks")]
        public void WhenClicksOnChangeSourceLinkFields()
        {
            featurePlan.ClickOnChangeSourceFields();
            //featurePlan.NavigateBackToOriginalPage();
        }
        [When(@"user clicks on Change Source Link and Select collect Resume")]
        public void WhenClicksOnChangeSourceLinkFieldsAndSelectCollectResumes()
        {
            featurePlan.ClickOnChangeSourceFieldsAndSelectResumes();
        }
        [Then(@"User click on ATS and JobDiva by Continue with Original Page")]
        public void ThenUserclickonATSAndJobdiva()
        {
            featurePlan.AtsOptionContinuewithOriginalPage();
            enterprisePlan.ClickOnATS();
            enterprisePlan.ClickOnJobDiva();
        }
        [Then(@"User click on ATS and JobDiva by Collecting Resumes")]
        public void ThenUserclickonATSAndJobdivaByCollectingResumes()
        {
            featurePlan.AtsOptionCollectingResumes();
            enterprisePlan.ClickOnATS();
            enterprisePlan.ClickOnJobDiva();
        }


    }
}
