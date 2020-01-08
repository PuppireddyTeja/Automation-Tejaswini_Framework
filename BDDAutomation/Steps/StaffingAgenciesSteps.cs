using BDDAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDAutomation.Steps
{
    class StaffingAgenciesSteps : StepBase
    {
        private StaffingAgencies staffingAgencies = null;
        public StaffingAgenciesSteps()
        {
            staffingAgencies = new StaffingAgencies(driver);
        }
        [When(@"user clicks on StaffingAgencies")]
        public void whenuserclicksonStaffingAgencies()
        {
            staffingAgencies.clickonStaffingAgencies();
        }
        [When(@"user clicks on StaffingAgenciesContactUsGetStarted")]
        public void whenuserclicksonStaffingAgenciesContactUsGetStarted()
        {
            staffingAgencies.clickonStaffingAgenciesContactUsGetStarted();
        }
        [When(@"user clicks on PostJobUrl")]
        public void whenuserclicksonPostjobUrl()
        {
            staffingAgencies.clickonPostJobUrl();
        }
        [When(@"user clicks on Uploadpdf")]
        public void whenuserclicksonuploadpdf()
        {
            staffingAgencies.uploadPDF();
        }
        [When(@"user clicks on ATS contactusgetStarted Button")]
        public void WhenUserclicksonATScontactusgetStartedButton()
        {
            staffingAgencies.ATScontactusgetStarted();
        }
        [When(@"user clicks on contactusgetStarted Button to Register with Jobiak")]
        public void WhenclickoncontactusgetStarted()
        {
            staffingAgencies.LearningcontactusgetStarted();
        }

















    }
}
