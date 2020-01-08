using BDDAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDAutomation.Steps
{
    class EmployerSteps : StepBase
    {
        private Employer employer = null;
        public EmployerSteps()
        {
            employer = new Employer(driver);
            //loginPage = new Loginpage(driver);

        }
        [When(@"User clicks on Employer tab in Job approvals page")]
        public void userClicksOnEmployerTabInJobApprovalsPage()
        {
            employer.clickOnEmployersLink();
        }

        [Then(@"Employer Tab page elements should be displayed")]
        public void employerTabPageElementsShouldBeDisplayed()
        {
            employer.verifyEmployersTabIsOpened();
        }
        [When(@"User clicks on Employer record edit icon based on employer name")]
        public void userClicksOnEmployerRecordEditIconBasedOnEmployerName()
        {
            employer.clickOnEditIconBasedOnEmployeeName("11th Hour Staffing");
        }
        [Then(@"Employer details edit page should be opened")]
        public void employerDetailsEditPageShouldBeOpened()
        {
            employer.verifyEmployerDetailsAreDisplayedAfterEditClick();
        }
        [Then(@"User clicks on Rating count")]
        public void UserclicksonRatingcount()
        {
            employer.EnterRatingCount();
        }



        [Then(@"click on Save button inside Employer Details should save the form")]
        public void clickOnSaveButtonInsideEmployerDetailsShouldSaveTheForm()
        {
            employer.clickOnEmployersDetailsSaveButton();
        }
    }
    }
