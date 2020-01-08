using BDDAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDAutomation.Steps
{
    class JobiakMainLinksSteps : StepBase
    {
        private JobiakMainLinks jobiakMainLinks = null;
        // private Loginpage loginPage = null;
        private JobiakBottomLinks jobiakBottomLinks = null;
        private WhoWeWorkWithLinkEnterprise whoWeWorkWithLinkEnterprise = null;
        private HowWeWorkPartnershipsAlliances howWeWorkPartnershipsAlliances = null;
        private SMBSPlan sMBSPlan = null;


        public JobiakMainLinksSteps()
        {
            jobiakMainLinks = new JobiakMainLinks(driver);
            jobiakBottomLinks = new JobiakBottomLinks(driver);
            whoWeWorkWithLinkEnterprise = new WhoWeWorkWithLinkEnterprise(driver);
            howWeWorkPartnershipsAlliances = new HowWeWorkPartnershipsAlliances(driver);
            sMBSPlan = new SMBSPlan(driver);
            //loginPage = new Loginpage(driver);
}
        [Given(@"user navigates to (.*) Jobiak URL site")]
        public void UserNavigatesToJoiakURLSite(string url)
        {
            jobiakMainLinks.NavigateToGivenURL(url);
        }

        [When(@"user clicks on main Jobiak Links")]
        public void WhenClicksOnAllMainLinks()
        {
          jobiakMainLinks.clickonHowItWorks();
            jobiakMainLinks.clickonPricing();
            jobiakMainLinks.clickonAbout();
            jobiakMainLinks.clickonCarrers();
            jobiakMainLinks.clickonBlog();
            jobiakMainLinks.clickonSignin();
            jobiakMainLinks.clickonTryitnow();
        }
        [When(@"User Click and validate Navigation to Enterprise page")]
        public void UserClickAndValidateNavigationtoEnterprisepage()
        {
            jobiakMainLinks.clickonLinksInsideWhoWeWorkWith("Partnerships");
            jobiakMainLinks.clickonLinksInsideWhoWeWorkWith("Enterprises");
            jobiakMainLinks.ValidateNavigationToRequiredPageBasedOnLinkName("Enterprises");
            
        }


    }
}
