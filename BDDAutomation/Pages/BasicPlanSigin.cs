
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BDDAutomation.Pages
{
    class BasicPlanSigin : PageBase
    {
        private By iFrameJobs = By.XPath("//iframe[@id='jobstatsframe']");

        private By dashboard = By.XPath("//span[text()='Dashboard']");
        private By filter = By.XPath("//div[@class='flex md12 row']//div/i[text()='filter_list']");
        private By jobcompany = By.XPath("//input[@aria-label='Job Company']");
        private By poststatus = By.XPath("//input[@aria-label='Posting Status']/parent::div/following-sibling::div[2]//i[text()='arrow_drop_down']");
        private By liststatus = By.XPath("//input[@aria-label='Listing Status']/parent::div/following-sibling::div[2]//i[text()='arrow_drop_down']");
        private By jobTitle = By.XPath("//input[@aria-label='Job Title']");
        private By joburl = By.XPath("//input[@aria-label='Job URL']");
        private By jobId = By.XPath("//input[@aria-label='Job ID']");
        private By date = By.XPath("//input[@aria-label='Created Date From']");
        private By applyfilters = By.XPath("//div[contains(text(),'Apply Filters')]");
        private By loaddata = By.XPath("//div[contains(text(),'Load Data')]");
        //click on Multiple job and Proceed
        private By multiplejob = By.XPath("//input[@id='careersiteurl']");
        private By proced = By.XPath("//button[text()='Proceed']");
        //click on settings
        private By setngs = By.XPath("//span[text()='Settings']");
        private By plandetails = By.XPath("//div[@id='exampleHeadingDefaultOne']/a");
        private By updatecard = By.XPath("//div[@id='exampleHeadingDefaultprofile']/a");
        private By passwd = By.XPath("//div[@id='exampleHeadingDefaultTwo']/a");
        private By employerdefaults = By.XPath("//div[@id='exampleHeadingDefaultThree']/a");
        private By empdomain = By.XPath("//input[@id='domainName']");
        private By empbut = By.XPath("(//button[text()='Update'])[3]");
        private By subscription = By.XPath("//div[@id='exampleHeadingDefaultSeven']/a");
        private By cancelsubscrptn = By.XPath("(//button[text()='Cancel'])[1]");
        //click on Transactions
        private By Trans = By.XPath("//span[text()='Transactions']");
        private By addjob = By.XPath("//span[text()='Add Job']");
        private By location = By.XPath("//input[@id='locationDefault']");

        //Filters
        private By filtersHeader = By.XPath("//span[text()='Filters']");



        public BasicPlanSigin(IWebDriver driver) : base(driver)
        {


        }
        public void clickOnDashboardAndFilter()
        {
            /*var ele = WaitForElementToBeClickeable(dashboard);
            JavaScriptClick(ele);
            Pause(5);*/
            IWebElement wEle = WaitForElementToBeVisible(iFrameJobs, 30);
            driver.SwitchTo().Frame(wEle);
            var ele1 = WaitForElementToBeClickeable(filter);
            JavaScriptClick(ele1);
            Pause(20);
        }
        public void EnterAllJobDetails()
        {
            WaitForElementToBeClickeable(jobcompany).SendKeys("Wipro");
            Pause(2);
            WaitForElementToBeClickeable(jobTitle).SendKeys("Software");
            Pause(2);
            WaitForElementToBeClickeable(jobId).SendKeys("I-2304");
            Pause(2);
            WaitForElementToBeClickeable(joburl).SendKeys("https://Wipro.com");
            Pause(2);
        }
        public void SelectDropDownsStatus()
        {
            IWebElement ele = WaitForElementToBeClickeable(poststatus, 10);
            JavaScriptClick(ele);
            Pause(3);
            string reqXpath = "//div[contains(@class,'menuable__content__active')]//div[@role='listitem']//div[@class='v-input--selection-controls__input']/input[1]";
            IWebElement requxpath = driver.FindElement(By.XPath(reqXpath));
            JavaScriptClick(requxpath);
            Pause(1);
            WaitForElementToBePresent(filtersHeader).Click();
            Pause(1);

            IWebElement ele1 = WaitForElementToBeClickeable(liststatus, 10);
            JavaScriptClick(ele1);
            Pause(2);
            string ReqXpath = "//div[contains(@class,'menuable__content__active')]//div[@role='listitem']//div[@class='v-input--selection-controls__input']/input[1]";
            IWebElement Requxpath = driver.FindElement(By.XPath(ReqXpath));
            JavaScriptClick(Requxpath);
            Pause(1);
            WaitForElementToBePresent(filtersHeader).Click();
            Pause(1);
        }
        public void SelectDatefromApplyfilters()
        {


            WaitForElementToBeClickeable(date).Click();
            //Give the date which is less than current date
            //var dateToEnter = getDateAsStringToEnter("minus", 1);
            //IWebElement dateValid = WaitForElementToBeClickeable(GetRequiredDateByWithDateAsInput(dateToEnter));
            //dateValid.Click();
            MoveToViewElementandSAndkeys(date, "2/12/2019");
            Pause(2);
            var ele = WaitForElementToBeClickeable(applyfilters);
            JavaScriptClick(ele);
            Pause(2);
            var ele1 = WaitForElementToBeClickeable(loaddata);
            JavaScriptClick(ele1);
            Pause(2);

        }
        public void ClickonProceedButton()
        {
            var pro = WaitForElementToBeClickeable(proced);
            JavaScriptClick(pro);
            Pause(10);
        }
        public void clickonSettings()
        {
            driver.SwitchTo().DefaultContent();
            var set = WaitForElementToBeClickeable(setngs);
            JavaScriptScrollIntoView(set);
            JavaScriptClick(set);
            Pause(2);
            var plan = WaitForElementToBeClickeable(plandetails);
            JavaScriptScrollIntoView(plan);
            JavaScriptClick(plan);
            Pause(2);
            var update = WaitForElementToBeClickeable(updatecard);
            JavaScriptScrollIntoView(update);
            JavaScriptClick(update);
            Pause(2);

             var pwd = WaitForElementToBeClickeable(passwd);
            JavaScriptScrollIntoView(pwd);
            JavaScriptClick(pwd);
            Pause(2);
           
        }
        public void ClickEmployerDefaults()
        {

            var Emp = WaitForElementToBeClickeable(employerdefaults);
            JavaScriptScrollIntoView(Emp);
            JavaScriptClick(Emp);
            Pause(2);

            var temp = WaitForElementToBeClickeable(empdomain);
            JavaScriptScrollIntoView(temp);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].value = '';", temp);
            ClickElementAndSendkeys(empdomain, "TestEmpDomain");
            Pause(2);
            var loc = WaitForElementToBeClickeable(location);
            JavaScriptScrollIntoView(loc);
            Pause(2);

            JavaScriptClear(location);
            ClickElementAndSendkeys(location, "Hyderabad");
            Pause(2);
            var upd = WaitForElementToBeClickeable(empbut);
            JavaScriptClick(upd);
            Pause(3);

        }
        public void clickonCancelSubscription()
        {
            var subsptn = WaitForElementToBeClickeable(subscription);
            JavaScriptScrollIntoView(subsptn);
            JavaScriptClick(subsptn);
            Pause(2);

        }
        public void ClickonTransactions()
        {
            var transctions = WaitForElementToBeClickeable(Trans);
            JavaScriptClick(transctions);
            Pause(5);
        }
        public void clickAddJob()
        {
            IWebElement ele = WaitForElementToBeClickeable(addjob);
            JavaScriptClick(ele);
        }
        private By GetRequiredDateByWithDateAsInput(string date)
        {

            return By.XPath("(//tbody)[2]//tr/td//div[text()='"+date+"']");

        }

        public void ClickAlertMessage()
        {
            /*IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();*/
            driver.Navigate().Back();
            string obj=driver.CurrentWindowHandle;

            Thread.Sleep(3000);
          
        }
        public void clickOnsettingsFreeplan()
        {
            driver.SwitchTo().DefaultContent();
            var set = WaitForElementToBeClickeable(setngs);
            JavaScriptScrollIntoView(set);
            JavaScriptClick(set);
            Pause(2);
            var plan = WaitForElementToBeClickeable(plandetails);
            JavaScriptScrollIntoView(plan);
            JavaScriptClick(plan);
            Pause(2);
          
            var pwd = WaitForElementToBeClickeable(passwd);
            JavaScriptScrollIntoView(pwd);
            JavaScriptClick(pwd);
            Pause(2);
            var pwd1 = WaitForElementToBeClickeable(passwd);
            JavaScriptScrollIntoView(pwd1);
            JavaScriptClick(pwd1);
            Pause(2);

        }




    }
}
