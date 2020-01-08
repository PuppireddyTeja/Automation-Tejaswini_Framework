using BDDAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDAutomation.Steps
{
    class BasicPlanSiginSteps : StepBase
    {
        private BasicPlanSigin basicPlanSigin = null;
        private ProductTagging productTagging = null;
        private FeaturePlan featurePlan = null;
        private Proplan proplan = null;
        private FreePlan freePlan = null;
        // private Loginpage loginPage = null;

        public BasicPlanSiginSteps()
        {
            basicPlanSigin = new BasicPlanSigin(driver);
            productTagging = new ProductTagging(driver);
            featurePlan = new FeaturePlan(driver);
            proplan = new Proplan(driver);
            freePlan = new FreePlan(driver);
            //loginPage = new Loginpage(driver);
        }
        [When(@"user clicks on DAshboard Link")]
        public void WhenClicksOnDAshboardLink()
        {
            basicPlanSigin.clickOnDashboardAndFilter();
            basicPlanSigin.EnterAllJobDetails();
            basicPlanSigin.SelectDropDownsStatus();
            basicPlanSigin.SelectDatefromApplyfilters();

        }
        [When(@"user clicks on Add New Job and click on proceed")]
        public void WhenClicksOnProceed()
        {
            //basicPlanSigin.clickAddJob();
            basicPlanSigin.ClickonProceedButton();

        }
        [When(@"user clicks on Add New Job")]
        public void WhenClicksOnAddnewJob()
        {
            basicPlanSigin.clickAddJob();
            basicPlanSigin.ClickonProceedButton();

        }
        [When(@"user clicks on Settings and click on Account")]
        public void WhenClicksOnSettingsandclickonAccount()
        {
            basicPlanSigin.clickonSettings();
            basicPlanSigin.ClickEmployerDefaults();

        }
        [When(@"user clicks on Cancel Subscription")]
        public void WhenClicksOnCancelSubscription()
        {
            basicPlanSigin.clickonCancelSubscription();

        }

        [When(@"user clicks on Transactions")]
        public void WhenClicksOnTransactions()
        {
            basicPlanSigin.ClickonTransactions();
        }
        [When(@"user clicks on Alert")]
        public void WhenClicksOnAlert()
        {
            basicPlanSigin.ClickAlertMessage();
        }
        [When(@"user clicks on Settings for Free plan and update All details")]
        public void WhenClicksOnSettingsandupdate()
        {
            basicPlanSigin.clickOnsettingsFreeplan();
            basicPlanSigin.ClickEmployerDefaults();
        }
    }
}
