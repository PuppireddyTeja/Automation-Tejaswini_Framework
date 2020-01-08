using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BDDAutomation.Pages
{
    class StaffingAgencies : PageBase
    {
        private By whoWeWorkWith = By.XPath("(//a[text()='Who We Work With'])[1]");
        private By staffAgency = By.XPath("(//ul[contains(@class,'sub-menu')]//a[text()='Staffing Agencies'])[1]");
        private By stafctctusstrtd = By.XPath("(//a[contains(@class,'mk-button')])[1]");
        private By pstjoburl = By.XPath("(//a[contains(@class,'mk-button')])[2]");
        private By contnue = By.XPath("//div[text()='Continue']");
        private By jobpageurl = By.XPath("//input[@aria-label='Please Provide Job Page URL']");
        private By choosefile = By.XPath("//input[@id='customfile']");
        private By submit = By.XPath("//button[@id='btnSubmit']");
        private By Atscntctusstrtd = By.XPath("(//a[contains(@class,'mk-button')])[3]");
        private By Learningmore = By.XPath("(//a[contains(@class,'mk-button')])[4]");

     public StaffingAgencies(IWebDriver driver) : base(driver)
     {
        }
        public void switchToChildWindow()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(2000);

        }
        public void switchToParentWindow()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Thread.Sleep(3000);
        }

            public void clickonStaffingAgencies()
        {
            IWebElement eleE = WaitForElementToBeClickeable(whoWeWorkWith, 5);
            MoveToViewElement(eleE);
            var ele = WaitForElementToBeClickeable(staffAgency, 5);
            MoveToElementAndClick(ele);
        }
        public void clickonStaffingAgenciesContactUsGetStarted()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,700)");
            Pause(5);
            var ele1 = WaitForElementToBeClickeable(stafctctusstrtd, 5);
            MoveToElementAndClick(ele1);
            driver.Navigate().Back();
        }
        public void clickonPostJobUrl()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,1000)");
            var ele1 = WaitForElementToBeClickeable(pstjoburl, 5);
            MoveToElementAndClick(ele1);
            Pause(7);

            switchToChildWindow();
            WaitForElementToBeClickeable(jobpageurl, 5).SendKeys("https://www.hcltech.com/jobs/alameda-contractor-california-6");
            Thread.Sleep(1000);
            JavaScriptClick(contnue);
            Pause(30);
           

        }
        public void uploadPDF()
        {
            switchToParentWindow();

            string filePath = @"C:\Users\User\Desktop\Senior Product Manager.pdf";
            driver.FindElement(choosefile).SendKeys(filePath);
            Thread.Sleep(1500);
            IWebElement submitEle = driver.FindElement(submit);

            JavaScriptClick(submitEle);
            Thread.Sleep(2000);
        }
        public void ATScontactusgetStarted()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,1600)");

            var ele1 = WaitForElementToBeClickeable(Atscntctusstrtd, 5);
            MoveToElementAndClick(ele1);
        }
        public void LearningcontactusgetStarted()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,2500)");

            var ele1 = WaitForElementToBeClickeable(Learningmore, 5);
            MoveToElementAndClick(ele1);
        }










        }
}
