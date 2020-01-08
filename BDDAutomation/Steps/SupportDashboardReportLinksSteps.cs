using BDDAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDAutomation.Steps
{
    class SupportDashboardReportLinksSteps : StepBase
    {
        private SupportDashboardReportLinks supportDashboardReportLinks = null;
        private BasicPlanSigin basicPlanSigin = null;
     public SupportDashboardReportLinksSteps()
    {
     supportDashboardReportLinks = new SupportDashboardReportLinks(driver);
            basicPlanSigin = new BasicPlanSigin(driver);
    }
    [When(@"user clicks on Customer Search")]
     public void WhenClickonCustomSearchLink()
    {
     supportDashboardReportLinks.ClickonCustomSearchLink();
    }

    [Then(@"user clicks on Company and Select Required Fields")]
    public void ThenClickonCompanyAndSelectRequiredFields()
    {
     supportDashboardReportLinks.ClickonCompanyAndSelectCompany("Amazon");

     supportDashboardReportLinks.ClickonSelectJobStatusAndSelectURlFromDropDown();
            supportDashboardReportLinks.SelectDateRanges();

        }
        [When(@"user clicks on All Report Links")]
    public void WhenClickonReportLinks()
    {
    supportDashboardReportLinks.ClickonReportLinks();
    }
    [When(@"user clicks on View and Applies Links")]
    public void WhenClickOnviewAndAppliesLinks()
    {
    supportDashboardReportLinks.ClickOnviewAndAppliesLinks();
    }

    [When(@"user clicks on Access permissions and Enter All Fields")]
    public void WhenuserclicksonAccesspermissionsandEnterAllFields()
    {
            supportDashboardReportLinks.ClickOnEditXpath();
            supportDashboardReportLinks.ClickOnStripeUSerData();
            supportDashboardReportLinks.ClickOnAddUser();
            supportDashboardReportLinks.ClickOnResetPassword();
            supportDashboardReportLinks.ClickOnUpgradeUser();
            supportDashboardReportLinks.ClickOnAccessUser();
            supportDashboardReportLinks.ClickOnAccessUserPermissions();
    }
    [When(@"user clicks on Edit in Given Access Users Page")]
    public void WhenuserclicksonEditinGivenAccessUsersPage()
        {
            supportDashboardReportLinks.ClickOnEditAccessuserPageTable();
        }


        [When(@"user clicks on Job Queue Dashboard,Google PostedJobs and Views")]
    public void WhenuserclicksonJobQueueDashboardGooglePostedJobsandViewsDashboardStats()
     {
            supportDashboardReportLinks.ClickOnQueueDashboard();
            supportDashboardReportLinks.ClickOnQueueDashboardEmployer("11th Hour Staffing");
            supportDashboardReportLinks.clickonQueueStatus("pending");
            supportDashboardReportLinks.clickoncalendar("Last 30 Days");
            supportDashboardReportLinks.ClickOnLoadJobs();
            supportDashboardReportLinks.ClickOnArrowLeft();
            supportDashboardReportLinks.ClickonGooglepostedJobs();
            supportDashboardReportLinks.ClickOnNoOfViewsAndApplies();
     }
    [When(@"user clicks on Dashboard Stats and ETL Management")]
    public void WhenuserclicksonDashboardStatsandETLManagement()
        {
            supportDashboardReportLinks.ClickOnDashboardStats();
            basicPlanSigin.EnterAllJobDetails();
            basicPlanSigin.SelectDropDownsStatus();
            supportDashboardReportLinks.clickONApplyfilters();
            supportDashboardReportLinks.ClickOnETLmanagement();
            supportDashboardReportLinks.ClickOnETLEmployer("180 Medical( Jobiak-3o3lC3FVl23o0MKv)");
            supportDashboardReportLinks.clickonUTCAndEnterXMLUrl();
            supportDashboardReportLinks.clickonReportsAndFilter();
            supportDashboardReportLinks.ClickOnReportsEmployer("180 Medical( Jobiak-WTTfOLFpM60p9mH5)");
            supportDashboardReportLinks.ClickAndselectDates();

        }









    }
}
