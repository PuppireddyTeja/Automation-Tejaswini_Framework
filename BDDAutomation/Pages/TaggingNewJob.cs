using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BDDAutomation.Pages
{
    class TaggingNewJob : PageBase
    {
        private By createjob = By.XPath("//a[text()='Create New Job']");
        private By compny = By.XPath("//input[@id='company']");
        private By jobtitle = By.XPath("//input[@id='title']");
        private By location = By.XPath("//input[@id='location']");
        private By employmenttype = By.XPath("//select[@id='inputGroupSelect01']");
        private By description = By.XPath("//div[@class='ql-editor ql-blank']");
        private By jobid = By.XPath("//input[@id='clientJobId']");
        private By salry = By.XPath("//input[@id='salary']");
        private By salunit = By.XPath("//select[@id='salunit']");
        private By salcurrency = By.XPath("//select[@id='salcurrency']");
        private By salsingle = By.XPath("//input[@id='singlesal']");
        private By entersalary = By.XPath("//input[@id='salary-enter-input-single']");
        private By buttonenter = By.XPath("//button[@id='salary-enter']");
        private By dateposted = By.XPath("//input[@id='datePosted']");
        private By validthrough = By.XPath("//input[@id='validThrough']");
        private By prevw = By.XPath("//button[@id='preview']");
        private By JobHeader = By.XPath("//h1[text()='Enter the Job Details']");
        public TaggingNewJob(IWebDriver driver) : base(driver)
        {

        }
        public void clickonCreatejob()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,500)");

            IWebElement element = WaitForElementToBeClickeable(createjob, 180);
            JavaScriptClick(element);
        }
        public void EnterAllFieldJobDetails()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Pause(2);
            WaitForElementsToBePresent(JobHeader, 200);
            //Enter job Details

            ClickElementAndSendkeys(compny, "Tcs");
            Pause(2);

            ClickElementAndSendkeys(jobtitle, "Marketing Manager");
            Pause(2);

            var ele = WaitForElementToBeClickeable(location);
            ele.Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].value = '';", ele);
            ele.SendKeys("Hyderabad");
            Pause(2);

            SelectElementWithByAndText(employmenttype, "PART_TIME");
            Pause(2);

            //Description
            string randString = GenerateRandomString(250);

            MoveToViewElementandSAndkeys(description, randString);

            ClickElementAndSendkeys(jobid, "I-303092");
            Pause(2);

            //Entering salary Details
            JavaScriptClick(salry);
            Pause(2);
            SelectElementWithByAndText(salunit, "DAY");
            Pause(2);
            SelectElementWithByAndText(salcurrency, "USD");
            Pause(2);

            JavaScriptClick(salsingle);
            Pause(2);
            ClickElementAndSendkeys(entersalary, "175");

            Pause(2);
            //click on Button Enter

            JavaScriptClick(buttonenter);
            //click on Dateposted
            //JavaScriptClick(dateposted);
            Pause(2);

            DateTime today = DateTime.Now;
            DateTime validThru = today.AddDays(21);
            String currentDate = today.ToString("MM/dd/yyyy");
            String validThruDate = validThru.ToString("MM/dd/yyyy");
            //WaitForElementToBeClickeable(dateposted).Click();
            /*IWebElement datePosted = WaitForElementToBeClickeable(GetRequiredDateByWithDateAsInput("15"));
            datePosted.Click();*/
            MoveToViewElementandSAndkeys(dateposted, currentDate);
            WaitForElementToBeClickeable(dateposted).SendKeys(Keys.Tab);
            Pause(2);
            MoveToViewElementandSAndkeys(validthrough, validThruDate);
            WaitForElementToBeClickeable(validthrough).SendKeys(Keys.Tab);
            Pause(2);
            
            


            /*WaitForElementToBeClickeable(validthrough).Click();
            string reqValidDate = getDateAsStringToEnter("plus", 0);
            var currentby = By.XPath("(//tbody)[1]//tr/td[text()='"+ reqValidDate + "' and @class='today day']");
            IWebElement dateValid = WaitForElementToBeClickeable(currentby);
            JavaScriptClick(dateValid);*//*

            MoveToViewElementandSAndkeys(validthrough, "16/12/2019");
            JavaScriptClick(validthrough);*/
            

        }
        public void clickonPreviewButton()
        {
            Thread.Sleep(5000);
            JavaScriptClick(prevw);
            Pause(10);
            /*driver.Navigate().Back();
            string pagesource = this.driver.PageSource;*/


        }

        private By GetRequiredDateByWithDateAsInput(string date)
        {

            return By.XPath("(//tbody)[1]//tr/td[text()='" + date + "']");
        }



    }

}
