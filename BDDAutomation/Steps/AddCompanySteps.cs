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
    class AddCompanySteps : StepBase
    {
        private AddCompany addCompany = null;
        //private Loginpage loginPage = null;

        public AddCompanySteps()
        {
            addCompany = new AddCompany(driver);
            //loginPage = new Loginpage(driver);
            

        }
       /* [Given(@"I navigate to Support Dashboard Test Url Page")]
        public void GivenLoginToproductionDashboard()
        {
            try
            {
                //addCompany.Reload();

            }

            catch (MissingElementException)
            {
                //if user is already logged in then homepage is loaded, so Logout and go to login page
                PageBase navigationBar = new PageBase(driver);
                loginPage = navigationBar.Logout();
                //dashboardPage = null;
            }
        }*/
        /*[Given(@"I click on JobApprovalpageLink")]
        public void GivenclickonJobApprovalpageLink()
        {
            addCompany.clickOnJobApprovalPageLink();
        }*/
        [When(@"User clicks on Companies and Add new company")]
    public void UserclicksonCompaniesandAddnewcompany() 
        {
            addCompany.clickOnCompaniesAddnewCompanyLink();

    }
      [When(@"User click And selectEmployer From Dropdown and Enter Companyname")]
      public void UserclickAndselectEmployerFromDropdownCompanyname() 
        {
            addCompany.clickAndselectEmployerFromDropdown();
    }
      
     
        [Then(@"User click on search Box And Edit")]
        public void GivenclickonsearchBoxAndEdit()
        {
            addCompany.EnterAndEditCompany();
        }
        [Then(@"click on save")]
        public void ThenClickOnsave()
            {
            addCompany.ClickOnSave();
        } 










    }
}
