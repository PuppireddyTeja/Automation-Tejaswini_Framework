using BDDAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDAutomation.Steps
{
    class JobiakBottomLinksSteps : StepBase
    { 
    
        private JobiakBottomLinks jobiakBottomLinks = null;
        // private Loginpage loginPage = null;

        public JobiakBottomLinksSteps()
        {
            jobiakBottomLinks = new JobiakBottomLinks(driver);
            //loginPage = new Loginpage(driver);
        }
        [When(@"user clicks on Bottom Jobiak Links")]
        public void WhenClicksOnAllMainLinks()
        {
            jobiakBottomLinks.clickonBottomLinks();
        }


        }
}
