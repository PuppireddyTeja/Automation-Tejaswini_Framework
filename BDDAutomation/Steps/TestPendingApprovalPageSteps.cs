using System;
using BDDAutomation.Test_Framework.Core;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using BDDAutomation.Pages;

namespace BDDAutomation.Steps
{
    class TestPendingApprovalPageSteps : StepBase
    {
        private TestPendingApprovalPage testPendingApprovalPage = null;
        private AddnewJob addnewjob = null;
        private ProductTagging productTagging = null;

        public TestPendingApprovalPageSteps() {
            testPendingApprovalPage = new TestPendingApprovalPage(driver);
            addnewjob = new AddnewJob(driver);
            productTagging = new ProductTagging(driver);
        }
        [Given(@"user navigates to (.*) for support dashboard page")]
        public void GivenUserNavigatesSpecificURLForSuportDashboard(string url)
        {
            testPendingApprovalPage.NavigateToGivenURL(url);
        }




        /*
    [Given(@"Click on Signin Credentials")]
    public void GivenSiginCredentials()
    {
        testPendingApprovalPage.clickSignCredentials();
    }

    [When(@"I try to Sign with credentials (.*) and (.*)")]
    public void WhenITryToLoginWithCredentials(string username, string password)
    {
        testPendingApprovalPage.FillOutSignForm(username, password);
    }
    [Given(@"I enter Username")]
    public void GivenIenterUsername()
    {
        testPendingApprovalPage.Usernametext();
    }
    [Given(@"I enter Password")]
    public void GivenIEnterPassword()
    {
        testPendingApprovalPage.Passwordtext();
    }
    [Then(@"I click on Signin")]
    public void Givenclickonsignin()
    {
        testPendingApprovalPage.siginButton();
    }*/
        /*   [Given(@"I click on JobApprovalpageLink")]
           public void GivenclickonJobApprovalpageLink()
           {
             testPendingApprovalPage.clickOnJobApprovalPageLink();
           }*/

        [Then(@"User clicks on Load Pending Approval Jobs button from Jobs Approval page")]
         public void userClicksOnLoadPendingApprovalJobsButtonFromJobsApprovalPage()
        {
            testPendingApprovalPage.clickOnLoadpendingApprovaljobs();
        }
        [When(@"User performs Search in search box by giving Job Title")]
        public void userPerformsSearchInSearchBoxByGivingJobTitle()
        {
           testPendingApprovalPage.enterSearchOptionToSearch();
        }
        [Then(@"Search results should be as per searched input")]
        public void searchResultsShouldBeAsPerSearchedInput()
        {
            testPendingApprovalPage.validateSearchResultsAfterSearchingForOption("CEO");

        }
        [Then(@"Click on Reset editing Status")]
        public void ResetStatus()
        {
            testPendingApprovalPage.clickonResetoption();
            testPendingApprovalPage.Pause(3);
        }
        [When(@"User clicks on random edit icon for a job title")]
        public void userClicksOnRandomEditIconForAJobTitle()
        {
            testPendingApprovalPage.clickOnEditIconBasedOnRandomJobTitle();
        }
        [When(@"User performs Search in search box by giving a unique Job Title")]
        public void userPerformsSearchInSearchBoxByGivingAUniqueJobTitle()
        {
            testPendingApprovalPage.enterSearchOptionToSearch();
        }
        [When(@"User clicks on the unique search result job title edit icon")]
        public void userClicksOnTheUniqueSearchResultJobTitleEditIcon()
        {
            testPendingApprovalPage.clickOnEditIconBasedOnUniqueJobTitle("software engineer");
        }

        [Then(@"User Enter all the required details for Edit job posting")]
        public void userEnterAllTheRequiredDetailsForEditJobPosting()
        {
            //testPendingApprovalPage.Enterjobtitlecleansedtitle();
            addnewjob.EnterDirectValuesForEditAndApproveJob();
            testPendingApprovalPage.clickAndSelectRating("0.5");

            addnewjob.clickAndSelectOccupationCategoryFromDropdown();
            //addnewjob.clickAndSelectEmployerFromDropdown("Agency Oasis");
           // addnewjob.clickAndSelectEmployerTypeFromDropdown("FULL_TIME");
            /*addnewjob.clickAndEditSalaryInformation("USD",
                "Fixed",
                "HOUR",
                "15",
                "35");*/
        }
        [Then(@"User click on Optimize and close the Window")]
        public void ThenClickOptimize()
        {
            testPendingApprovalPage.clickonOptimize();

        }




    }
}
