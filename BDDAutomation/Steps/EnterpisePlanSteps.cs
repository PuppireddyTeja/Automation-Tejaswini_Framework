using BDDAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDAutomation.Steps
{
    class EnterpisePlanSteps : StepBase
    {
        private EnterprisePlan enterprisePlan = null;
        public EnterpisePlanSteps()
        {
            enterprisePlan = new EnterprisePlan(driver);
        }
        [When(@"User Click On CustomerOnboarding And CreateAccount")]
        public void WhenUserClickOnCustomerOnboardingAndCreateAccount()
        {
            enterprisePlan.ClickOnCustomerOnboardingAndCreateAccount();

        }
        [When(@"Signin with (.*) Email")]
        public void WhenSiginWithEmail(string email)
        {
            enterprisePlan.FillOutEmail(email);
        }
        [Then(@"User Enter All BasicInformation Fields")]
        public void ThenEnterAllBasicInformationFields()
        {
            enterprisePlan.EnterAllBasicInformationFields();

        }
        [Then(@"User Enter Company Informartion")]
        public void ThenEnterCompanyInformartion()
        {
            enterprisePlan.EnterCompanyInformartion();
        }
        [Then(@"Click on methods (.*) and save")]
        public void ThenClickonMethod(string methodName)
        {
            enterprisePlan.SaveJobBrandingDetailsBasedOnMethod(methodName);
            //enterprisePlan.clickOnSave();
        }
        [Then(@"User click on ATS and JobDiva")]
        public void ThenUserclickonATSAndJobdiva()
        {
            enterprisePlan.ClickOnChangeSourceFields();
            enterprisePlan.ClickOnATS();
            enterprisePlan.ClickOnJobDiva();

        }
        

        [Then(@"User enter API keys")]
        public void ThenUserenterAPIkeys()
        {
            enterprisePlan.EnterApiKey();

        }
        [Then(@"User click on continue")]
        public void ThenClickoncontinue()
        {
            enterprisePlan.ClickOncontinue();
        }
        [Then(@"User click on ChangeSource and select Carrer Job Url")]
        public void ThenClickOnCarrer()
        {
            enterprisePlan.ClickOnChangeSourceFieldsAndSelectOptionCarrer();
        }




    }
}
