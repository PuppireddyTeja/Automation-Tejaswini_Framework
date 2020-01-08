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
    class ProductionTaggingSteps : StepBase
    {
        private ProductTagging productiontagging = null;
        private BasicPlanSigin basicPlanSigin = null;
        private FreePlan freePlan = null;
        private Proplan proplan = null;
        private StaffingAgencies staffingAgencies = null;

        public ProductionTaggingSteps() {
            productiontagging = new ProductTagging(driver);
            basicPlanSigin = new BasicPlanSigin(driver);
            freePlan = new FreePlan(driver);
            proplan = new Proplan(driver);
            staffingAgencies = new StaffingAgencies(driver);

        }

        [Given(@"I navigate to (.*) TRY IT NOW Tagging Page")]
        public void GivenIEntertoTRYITNOWTaggingPage(string url)
        {
           
                productiontagging.NavigateToGivenURL(url);
}
            

        [When(@"Click on Signin Credentials")]
        public void GivenSiginCredentials()
        {
            productiontagging.clickSignCredentials();
        }

        [When(@"I try to Sign with credentials (.*) and (.*)")]
        public void WhenITryToLoginWithCredentials(string username, string password)
        {
            productiontagging.FillOutSignForm(username, password);
        }
        [Given(@"I enter Username")]
        public void GivenIenterUsername()
        {
            productiontagging.Usernametext();
        }
        [Given(@"I enter Password")]
        public void GivenIEnterPassword()
        {
            productiontagging.Passwordtext();
        }
        [Then(@"I click on Signin")]
        public void Givenclickonsignin()
        {
            productiontagging.siginButton();
        }
        [Then(@"I try to Add job with single job Url and postjob")]
        public void ThenAddjobwithsinglejobUrlandPostjob()
        {
            productiontagging.clickAddJob();
            productiontagging.Entersinglejourl();
            productiontagging.clickPostJob();
        }
        [Given(@"I click on TRY IT NOW button")]
        public void GivenclickonTRYITNOWbutton()
        {
            productiontagging.ClickOnTryItNow();

        }
        [Given(@"Scroll down to Post Job Url")]
        public void GivenScrolldowntoPostJobUrl()
        {
            productiontagging.ScrollDown();
        }



        [Then(@"I enter Job Page URL")]
        public void ThenenterJobPageURL()
        {
            productiontagging.TextPostJobUrl();

        }
        [When(@"I click on Get Started")]
        public void WhenclickonGetStarted()

        {
            productiontagging.clickongetStarted();
        }

        [When(@"I click on Date Posted")]
        public void GivenclickonDatePosted()
        {
            productiontagging.EnterDateposted();
        }
        [When(@"I click on Custom Value")]
        public void WhenclickonCustomValue()
        {
            productiontagging.clickCustomValue();
        }
        [Then(@"I click on Dates")]
        public void WhenclickonDates()
        {
            productiontagging.ClickOnDatePostedText();
        }
        [When(@"I click on Save")]
        public void Whenclickonsave()
        {
            productiontagging.clickOnSave();
        }
        [When(@"I click on Valid Through based on Date Posted")]
        public void WhenClickOnValidThrough()
        {
            productiontagging.ClickOnValidThruDatePostedText();
            productiontagging.clickOnSave();

        }

        [Then(@"I Click on Preview Button")]
        public void ThenclickonPreview()
        {
            productiontagging.ClickonPreview();
        }
        [Then(@"I click on OptimiZe Button")]
        public void ThenclickonOptimiZeButton()
        {
            productiontagging.ClickOnOptimize();
        }
        [Then(@"I click on Edit Button")]
        public void ThenclickonEditButton()
        {
            productiontagging.clickonEdit();
        }
        [Given(@"Enter Signin Credentials and click on Publish")]
        public void GivenEnterSigninCredentialsclickonPublish()
        {
            productiontagging.EnterWorkMailId();
            productiontagging.EnterPassword();
            productiontagging.ClickOnCheckbox();
            //productiontagging.clickonCreateFreeAccountAndPublish();

        }
        [Then(@"Close and Quit Driver")]
        public void GivenCloseandQuitDriver()
        {
            productiontagging.Driverclose();
            productiontagging.Driverquit();
        }
        [Then(@"ScrollDown to Particular Element")]
        public void ThenScrollDowntoParticularElement()
        {
            productiontagging.DragAndDropToOffsetofElement();
        }
        [Then(@"switch to other window")]
        public void Thenswitchtootherwindow()
        {
            productiontagging.switchToChildWindow();
        }
        [When(@"I Click on job description and enter value")]
        public void WhenIClickOnJobDescriptionAndEnterValue()
        {
            productiontagging.ClickJobDescription();
            productiontagging.ClickOnClearButtonInsideJobDescription();
            productiontagging.EnterRandomRequiredCharactersAsJobDescription();
        }
        [Then (@"upload PDF")]
        public void ThenIClickOnpdf()
        {
            productiontagging.uploadPDF();
        }
        [Then(@"upload PDF By Plans")]
        public void ThenIClickOnpdfplans()
        {
            productiontagging.uploadPDFByPlans();

        }
        [Then(@"click on Salary")]
        public void ThenclickonEnterSalary()
        {
            productiontagging.EntersalaryCustom();
            productiontagging.clickAndEditsalaryInformation("USD",
                "Fixed",
                "HOUR",
                "15",
                "35");
        }
        [Then(@"click on company")]
        public void ThenclickonCompany()
        {
            productiontagging.clickoncompany();
        }
        [Then(@"click on company for the Given Job Url")]
        public void clickonCompanyForJoburl()
        {
            productiontagging.entercompanynameForGivenJobUrl();
        }

        [When(@"I Try to Signin with credentials (.*) and (.*)")]
        public void WhenITryToSiginWithCredentials(string username, string password)
        {
            productiontagging.FillOutSignInForm(username, password);
            productiontagging.siginButton();
        }
        [When(@"click on Location")]
        public void WhenclickonLocation()
        {
            productiontagging.clickonLocation();
        }
        [Then(@"click on company in Tagging Page")]
        public void ThenclickonCompanyForTagging()
        {
            productiontagging.clickoncompanyForTagging();
        }











    }
}
