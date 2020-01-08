using BDDAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDAutomation.Steps
{
    class CarrersSteps : StepBase
    {
        private Carrers carrers = null;


        public CarrersSteps()
        {
            carrers = new Carrers(driver);
        }

        [When(@"user clicks on Carrer Site Link")]
        public void WhenuserclicksonCarrerSite()
        {
            carrers.ClickOnCarrers();
        }
        [When(@"user clicks on Apply Now Button Links")]
        public void WhenuserclicksonApplyNowButtonLinks()
        {
            carrers.ClickonApplyButton1();
            carrers.ClickonApplyButton2();
            carrers.ClickonApplyButton3();
        }




    }
}
