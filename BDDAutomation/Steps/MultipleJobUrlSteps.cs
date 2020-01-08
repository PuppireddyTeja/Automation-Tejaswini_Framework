using BDDAutomation.Pages;
using BDDAutomation.Test_Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDAutomation.Steps
{
    class MultipleJobUrlSteps : StepBase
    {
        private MultipleJobUrl multipleJobUrl = null;
        private Loginpage loginPage = null;
        private BasicPlanSigin basicPlanSigin = null;
        private Proplan proplan = null;
        private FeaturePlan featurePlan = null;
        private EnterprisePlan enterprisePlan = null;
        private FreePlan freePlan = null;

        public MultipleJobUrlSteps()
        {
             multipleJobUrl= new MultipleJobUrl(driver);
            // loginPage = new Loginpage(driver);
            basicPlanSigin = new BasicPlanSigin(driver);
            proplan = new Proplan(driver);
            featurePlan = new FeaturePlan(driver);
            enterprisePlan = new EnterprisePlan(driver);
            freePlan = new FreePlan(driver);

        }
        [Given(@"I navigate to Production Url page")]
        public void GivennavigatetoProductionUrl()
        {
            try
            {
                multipleJobUrl.NavigateToGivenURL("https://www.jobiak.ai/try-it-now/");

       }
            catch (MissingElementException)
            {
               
            }
        }
        [Then(@"I click on Addjob")]
        public void GivenclickonAddjob()
        {
            multipleJobUrl.clickonAddJob();
        }

        [Then(@"Enter multiple Job and click on Postjobs")]
        public void GivenEntermultipleJobandclickonPostjobs()
        {
            multipleJobUrl.clickonmultipeAndpostjob();
        }
        [Then(@"I click on popup")]
        public void Thenclickonpopup()
        {
            multipleJobUrl.clickonPopup();
        }

        [When(@"I click on +symbols")]
        public void WhenIclickonsymbols()
        {
            multipleJobUrl.selectplusicons();
        }
        [Then(@"I click on preview")]
        public void ThenIclickonpreview()
        {
            multipleJobUrl.clickonpreview();
        }



    }
}
