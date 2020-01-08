using BDDAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDAutomation.Steps
{
    class TaggingNewJobSteps : StepBase
    {
        private TaggingNewJob taggingNewJob = null;
        private FreePlan freeplan = null;



        public TaggingNewJobSteps()
        {
            taggingNewJob = new TaggingNewJob(driver);
            freeplan = new FreePlan(driver);
            //loginPage = new Loginpage(driver);
        }
        [When(@"user clicks on Create job")]
        public void whenuserclicksonCreatejob()
        {
            taggingNewJob.clickonCreatejob();
        }
        [When(@"user Enter All the Job details")]
        public void WhenuserenterjobDetails()
        {
            taggingNewJob.EnterAllFieldJobDetails();
        }
        [Then(@"user clicks on previewbutton")]
        public void ThenuserclicksonpreviewButton()
        {
            taggingNewJob.clickonPreviewButton();
        }






    }
}
