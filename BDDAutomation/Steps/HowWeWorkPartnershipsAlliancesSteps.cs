using BDDAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDAutomation.Steps
{
    class HowWeWorkPartnershipsAlliancesSteps : StepBase
    {
        private HowWeWorkPartnershipsAlliances howWeWorkPartnershipsAlliances = null;
        public HowWeWorkPartnershipsAlliancesSteps()
        {
            howWeWorkPartnershipsAlliances = new HowWeWorkPartnershipsAlliances(driver);
        }

        [When(@"user clicks on How we Work")]
        public void WhenuserclicksonHowweWork()
        {
            howWeWorkPartnershipsAlliances.clickonHowweWork();
        }
        [When(@"user clicks on Contact Us Get Started Button in How we Work Link")]
        public void WhenclickOnHowweworkContactUsGetStarted()
        {
            howWeWorkPartnershipsAlliances.clickonHowweworkContactusGetStarted();
        }
        [When(@"user clicks on Partnerships")]
        public void WhenuserclicksonPartnerships()
        {
            howWeWorkPartnershipsAlliances.clickonPartnership();
        }
        [When(@"user clicks on Contact Us Get Started Button in Partnerships")]
        public void WhenuserclicksonContactUsGetStartedinPartnerships()
        {
            howWeWorkPartnershipsAlliances.clickonPartnershipContactusGetStarted();
        }
        [When(@"user clicks on Strategic Alliances")]
        public void WhenuserclicksonStrategicAlliances()
        {
            howWeWorkPartnershipsAlliances.ClickOnStartAllainces();
        }
        [When(@"user clicks Contact Us Get Started Button in StartAllainces")]
        public void WhenuserclicksContactUsGetStartedinStartAlliances()
        {
            howWeWorkPartnershipsAlliances.ClickOnStartAllaincesContactusGetStarted();
        }








    }
}
