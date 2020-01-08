using BDDAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDAutomation.Steps
{
    class WhoWeWorkWithLinkStepsEnterprise : StepBase
    {
        private WhoWeWorkWithLinkEnterprise whoWeWorkWithLinkEnterprise = null;
        public WhoWeWorkWithLinkStepsEnterprise()
        {
            whoWeWorkWithLinkEnterprise = new WhoWeWorkWithLinkEnterprise(driver);
        }
        [When(@"user click on Enterprise Link")]
        public void WhenUserClickEnterpriseLink()
        {
            whoWeWorkWithLinkEnterprise.clickonWhoWeWorkWithAndEnterprise();
        }

        [When(@"user selects on Enterprise Plan 1")]
        public void WhenUserClickPlan1()
        {
            whoWeWorkWithLinkEnterprise.Clickonplan1();
        }
        [When(@"user click on contact us to get started")]
        public void WhenUserClickContactUsGetStarted()
        {
            whoWeWorkWithLinkEnterprise.ClickonContactusgetstarted();
        }
        [Then(@"user Enter contact page Fields")]
        public void ThenUserEnterAllFields()
        {
            whoWeWorkWithLinkEnterprise.EnterAllContactpageFields();

        }
        [When(@"user selects  Enterprise and click Plan 2")]
        public void WhenUserClickPlan2()
        {
            whoWeWorkWithLinkEnterprise.Clickonplan2();
        }
        [When(@"user selects on Enterprise and click on plan 3")]
        public void WhenUserClickPlan3()
        {
            whoWeWorkWithLinkEnterprise.Clickonplan3();
        }
        [When(@"user selects and clicks on Enterprise Plan 4")]
        public void WhenUserClickPlan4()
        {
            whoWeWorkWithLinkEnterprise.Clickonplan4();
        }
        [When(@"user selects Enterprise Plan 5 and click on Contact US Button")]
        public void WhenUserClickPlan5()
        {
            whoWeWorkWithLinkEnterprise.Clickonplan5();
        }
        [Then(@"Scroll Down to Particular Height")]
        public void ThenScrollDowntoParticularHeight()
        {
            whoWeWorkWithLinkEnterprise.ScrollDownToParticularHeight();
        }










    }
}
