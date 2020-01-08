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
    class SupportUserManagementSteps : StepBase
{
        private SupportUserManagement supportUserManagement = null;
        private Loginpage loginPage = null;

        public SupportUserManagementSteps() {

            supportUserManagement = new SupportUserManagement(driver);

        }
        
        [When(@"I click on supportUserManagementLink")]
        public void WhenclickonsupportUserManagementLink()
        {
            supportUserManagement.clickOnsupportUserManagementLink();
        }


        [When(@"User select Not Assigned From Assigned User DropDown To View All NotAssigned Jobs")]
        public void selectNotAssignedFromAssignedUserDropDownToViewNotAssignedJobs()
        {
            supportUserManagement.selectNotAssignedFromAssignedUserDropDownToViewAllNotAssignedJobs();
        }
        [Then(@"User pick Random Client Id From Available NotAssinged Jobs And Click on Edit")]
        public void ThenpickRandomClientIdNotAssingedJobsAndClickEdit() 
        {
            supportUserManagement.pickRandomClientIdFromAvailableNotAssingedJobsAndClickEdit();
        }
        [Then(@"User Select not Assigned from AssignUser Dropdown and click on save Button")]
       public void SelectAssignUserDropdownandclicksaveButton()
        {
            supportUserManagement.SelectAssignUserfromDropdownandclicksaveButton();
       }



}
}
