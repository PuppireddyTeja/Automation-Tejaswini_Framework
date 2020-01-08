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
    class AddnewJobSteps : StepBase
    {
        private AddnewJob addnewjob = null;
        private TestPendingApprovalPage testPendingApprovalPage = null;
       // private Loginpage loginPage = null;

        public AddnewJobSteps()
        {
            addnewjob = new AddnewJob(driver);
            testPendingApprovalPage = new TestPendingApprovalPage(driver);
            //loginPage = new Loginpage(driver);

        }
        [Given(@"I navigate to Support Dashboard production Url Page")]
        public void GivenLoginToSuportDashboard()
        {

            try
            {

                //addnewjob.Reload();
                //If user is not logged in, login page is loaded by default                               

                // TaggingProductionSteps
                //productiontagging.ForceToLoadURL(ProductTagging.productUrl);




            }
            catch (MissingElementException)
            {
                //if user is already logged in then homepage is loaded, so Logout and go to login page
               // PageBase navigationBar = new PageBase(driver);
                //loginPage = navigationBar.Logout();
                //dashboardPage = null;
            }
        }


        [When(@"I click on JobApprovalpageLink")]
        public void GivenclickonJobApprovalpageLink()
        {
            addnewjob.clickOnJobApprovalPageLink();
        }
        [When(@"User clicks on Jobs All in Job approvals page")]
        public void userClicksOnJobsAll()
        {
            addnewjob.clickOnjobsall();
        }
        [When(@"User clicks on Add new Job in Job approvals page")]
        public void userClicksOnAddnewJob()
        {
            addnewjob.clickOnAddnewjob();
        }


        [When(@"user clicks on Load Jobs button")]
        public void userClicksOnLoadJobsButtonInJobApprovalsPage()
        {
            addnewjob.ClickOnLoadJobs();
        }


        [When(@"User performs Search in search box by giving Job Title inside Load Jobs")]
        public void userPeformsSearchInSearchBoxByGivingJobTitleInsideLoadJobs()
        {
            addnewjob.enterSearchOptionToSearchInsideLoadJobsSearch("Ronan");
        }

        [When(@"User clicks on Search job here and enters job to search")]
        public void userClicksOnSearchJobHereAndEntersJobToSearch()
        {
            addnewjob.EnterRequiredInputForSearch("CEO");
        }

        [Then(@"User Enter all the required details for new job posting")]
        public void userEnterAllTheRequiredDetailsForNewJobPosting()
        {
            addnewjob.EntercompanyDetails();
            addnewjob.ClickJobDescription();
            addnewjob.EnterRandomRequiredCharactersAsJobDescription();
            addnewjob.EnterDirectValuesForEditAndApproveJob();
            addnewjob.clickAndSelectEmployerFromDropdown("Automation QA");
            addnewjob.clickAndSelectEmployerTypeFromDropdown("FULL_TIME");
            addnewjob.clickAndSelectOccupationCategoryFromDropdown();
            addnewjob.SalaryEstimate();
            testPendingApprovalPage.clickAndSelectRating("0.5");

     /*addnewjob.clickAndEditSalaryInformation("USD",
                "Fixed",
                "HOUR",
                "15",
                "35");*/
        }


        /*[Then(@"User clicks on Save and Approve job button for after editing job")]
        public void userClicksOnSaveAndApproveJobButtonForAfterEditingJob()
        {
            addnewjob.clickonsaveJobForNewJob();
        }*/


    }
}
