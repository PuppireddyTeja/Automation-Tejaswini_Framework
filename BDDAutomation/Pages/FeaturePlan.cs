using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDAutomation.Pages
{
    class FeaturePlan : PageBase
    {
        private By referfriend = By.XPath("//span[text()='Refer a Friend']");
        private By changesource = By.XPath("//span[text()='Change source']");
        private By aplythrugh = By.XPath("(//input[@name='applyThrou'])[1]");
        private By carers = By.XPath("//button[@id='loadJobs']");
        private By loadurl = By.XPath("(//button[@class='btn btn-outline btn-info'])[1]");
        private By collectingresumes = By.XPath("(//input[@name='applyThrou'])[2]");
        private By email = By.XPath("//input[@id='emailId1']");

        public FeaturePlan(IWebDriver driver) : base(driver)
        {
        }
        public void clickonReferFriend()
        {
            JavaScriptClick(referfriend);
            Pause(3);
        }
        public void ClickOnChangeSourceFields()
        {
            JavaScriptClick(changesource);
            IWebElement ele = WaitForElementToBeClickeable(aplythrugh);
            JavaScriptClick(ele);
            Pause(2);
            JavaScriptClick(carers);
            Pause(10);
            JavaScriptClick(loadurl);
            Pause(2);
            
        }
        public void ClickOnChangeSourceFieldsAndSelectResumes()
        {
            JavaScriptClick(changesource);
            IWebElement ele = WaitForElementToBeClickeable(collectingresumes);
            JavaScriptClick(ele);
            Pause(2);
            WaitForElementToBeClickeable(email).SendKeys("tejaswini@jobiak.ai");
            Pause(2);
            JavaScriptClick(carers);
            Pause(10);
            JavaScriptClick(loadurl);
            Pause(2);

        }
        public void NavigateBackToOriginalPage()
        {
            driver.Navigate().Back();
            Pause(30);
        }
        public void AtsOptionContinuewithOriginalPage()
        {
            JavaScriptClick(changesource);
            IWebElement ele = WaitForElementToBeClickeable(aplythrugh);
            JavaScriptClick(ele);
            Pause(2);
        }
        public void AtsOptionCollectingResumes()
        {
            JavaScriptClick(changesource);
            IWebElement ele = WaitForElementToBeClickeable(collectingresumes);
            JavaScriptClick(ele);
            Pause(2);
            WaitForElementToBeClickeable(email).SendKeys("tejaswini@jobiak.ai");
            Pause(2);
        }



    }
}
