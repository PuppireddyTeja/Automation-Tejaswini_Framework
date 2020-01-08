using System;
using OpenQA.Selenium;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;

namespace BDDAutomation.Pages
{
    class TestPendingApprovalPage : PageBase
    {
       
        private By loadpendingApprovalPage = By.XPath("//div[contains(text(),'Load Pending')]");
        private By resetEditStatusBtn = By.XPath("//div[contains(text(),'Reset Editing')]");
        private By searchjob = By.XPath("(//input[@aria-label='Search with in result below'])[1]");
        private By searchResultRows = By.XPath("(//div[@class='elevation-1 custom'])[1]//table//tbody/tr");
        private By tableGridJobTitleColumn = By.XPath("(//th[text()='Job Title'])[1]");
        private By JobDetailsHeading = By.XPath("//div[text()='Job Details']");
        static string reqJobTitle = "";
        private By jobtitle = By.XPath("(//input[@aria-label='Job Title'])[2]");
        private By Cleansedtitle = By.XPath("//input[@aria-label='Cleansed Job Title']");
        private By Rating = By.XPath("( //input[@aria-label='Rating'])[3]");
        private By optjob = By.XPath("//div[text()='Optimize Job']");
        private By submitjob = By.XPath("//div[text()='Submit Job Values']");
        private By modalwindowclose = By.XPath("(//i[text()='close'])[4]");



        public TestPendingApprovalPage(IWebDriver driver) : base(driver)
        {
           
        }
     
        public void clickOnLoadpendingApprovaljobs()
        {
            WaitForElementToBeClickeable(loadpendingApprovalPage).Click();

        }
        public void clickonResetoption()
        {
            JavaScriptClick(resetEditStatusBtn);
            
            Thread.Sleep(300);

        }
        public void enterSearchOptionToSearch()
        {
            WaitForElementToBeClickeable(searchjob).SendKeys(reqJobTitle);
        }
        public void validateSearchResultsAfterSearchingForOption(string givenInput)
        {
            IList<IWebElement> resultRows = GetWebElementListBy(searchResultRows);
            int totalSearchResultRows = resultRows.Count;
            Console.WriteLine("Total Rows:\t" + totalSearchResultRows);
            for (int i = 1; i <= totalSearchResultRows; i++)
            {
                var resultText = driver.FindElement(By.XPath("((//div[contains(@class,\"elevation-1 custom\")])[1]//table//tbody/tr)[" + i + "]/td[1]//span")).Text.ToLower();
                Console.WriteLine("Current Search result\t" + resultText);
                string searchedOpt = givenInput.ToLower();
                Assert.IsTrue(resultText.Contains(searchedOpt)
                        , "The Result Text\t" + resultText + " does not contain searched input\t" + searchedOpt);
            }
        }
        public void clickOnEditIconBasedOnRandomJobTitle()
        {


            Pause(30);

                WaitForElementToBeVisible(tableGridJobTitleColumn,30);
                int rowCount = driver.FindElements(searchResultRows).Count;
                int randomNum = new Random().Next(rowCount - 1) + 1;
                Console.WriteLine("Total Rwos :\t" + rowCount);
                reqJobTitle = driver.FindElement(By.XPath("((//div[@class=\"elevation-1 custom\"])[1]//table//tbody/tr)[" + randomNum + "]/td[1]//span")).Text;
                Console.WriteLine("Job Title is:\t" + reqJobTitle);
                string ReqEditButtonXpath = "//span[contains(text(),\"" + reqJobTitle + "\")]/ancestor::td//following-sibling::td/i";
                IWebElement reqWebEle = WaitForElementToBeVisible(ReqEditButtonXpath, 5);
                JavaScriptClick(reqWebEle);
                Thread.Sleep(300);
            WaitForElementToBeClickeable(JobDetailsHeading, 10);
                
            }
        public void clickOnEditIconBasedOnUniqueJobTitle(string jobTitle)
        {
            Thread.Sleep(3000);
            WaitForElementToBeVisible(tableGridJobTitleColumn, 10);
            string ReqEditButtonXpath = "//span[text()=\"" + jobTitle + "\"]/ancestor::td//following-sibling::td/i";
            Console.WriteLine("Job Title is:\t" + ReqEditButtonXpath);
            IWebElement reqWebEle = WaitForElementToBeVisible(ReqEditButtonXpath, 5);
            JavaScriptClick(reqWebEle);
        }
        public void Enterjobtitlecleansedtitle()
        {
            var el = WaitForElementToBeClickeable(jobtitle);
            el.Click();
            //string s = Keys.Backspace.ToString();
            //el.SendKeys(s + s + s + s + s + s + s);
            //el.SendKeys("software");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].value = '';", el);
            el.SendKeys("software");

            JavaScriptClear(Cleansedtitle);
            WaitForElementToBeClickeable(Cleansedtitle).SendKeys("Teacher");
        }
            public void clickAndSelectRating(string ratingcount)
            { 

            IWebElement ele = WaitForElementToBeVisible(Rating, 2);
            Thread.Sleep(300);
            JavaScriptClick(ele);
            Thread.Sleep(300);
            ele.SendKeys(ratingcount);
            Pause(2);
            string ReqEditButtonXpath = "//div[text()=\"" + ratingcount + "\"]";
            //string ReqEditButtonXpath = "(//div[contains(text(),\"" + empName + "\")])[3]";
            IWebElement reqWebEle = driver.FindElement(By.XPath(ReqEditButtonXpath));
            Thread.Sleep(300);
            JavaScriptClick(reqWebEle);
            Thread.Sleep(300);

           
        }
        public void clickonOptimize()
        {
            JavaScriptClick(optjob);
            Pause(10);

            JavaScriptClick(modalwindowclose);
            Pause(3);
        }

    }
}
