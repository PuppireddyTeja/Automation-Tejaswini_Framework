using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BDDAutomation.Pages
{
    class SupportDashboardReportLinks : PageBase
    
    {
        private By Back = By.XPath("//i[@class='icon hamburger hamburger-arrow-left']");
        private By customsearch = By.XPath("//span[text()='Custom Search']");
        private By compnynme = By.XPath("//button[@title='Select Company Name']/span");
        private By companySearchInputBox = By.XPath("//div[@class='bs-searchbox']/input");
        private By jobstatus = By.XPath("//select[@id='status']");
        private By selecturl = By.XPath("//button[@title='Select an URL']");
        private By signupreport = By.XPath("//span[text()='Sign Up Report']");
        private By signupreprtHeadng = By.XPath("//h1[contains(text(),'Signup')]");
        private By prevwrept = By.XPath("//span[text()='Preview Report']");
        private By prevwreptheadng = By.XPath("//h1[contains(text(),'Preview')]");
        private By Triedurlrept = By.XPath("//span[text()='Tried Url Report']");
        private By Triedurlreptheadng = By.XPath("//h1[contains(text(),'Tried')]");
        private By viewAplies = By.XPath("//span[text()='Views & Applies']");
        private By apliesheadng = By.XPath("//h1[contains(text(),'views')]");
        //calendar
        private By BtnDateRange = By.XPath("//input[@name='daterange']");
        private By labelSelectDateRange = By.XPath("//label[text()='Select Date Range']");
        private By applyBtn = By.CssSelector("button.applyBtn");

        private By mastrviewaplies = By.XPath("//span[text()='Master Views & ' and text()=' Applies']");
        //Edit Xpath
        private By Editxpath = By.XPath("//span[text()='Edit XPath']");
        private By DomainName = By.XPath("//input[@id='domain']");
        private By Submit = By.XPath("//button[contains(text(),'Submit')]/i");
        //stripe user data
        private By StripeuserData = By.XPath("//span[text()='Stripe User Data']");
        private By Planname = By.XPath("//select[@id='planName']");
        private By planSubmit = By.XPath("//button[contains(text(),'Submit')]/i");
        //Add users
        private By addusrs = By.XPath("//span[text()='Add Users']");
        private By firstnme = By.Id("inputFirstName");
        private By lstname = By.Id("inputLastName");
        private By email = By.Id("inputWorkEmail");
        private By pswd = By.Id("inputPassword");
        private By supportuser = By.XPath("//select[@id='inputGroupSelect']");
        //Reset Password
        private By resetpswd = By.XPath("//span[text()='Reset Password']");
        private By username = By.Id("username");
        private By newpasswd = By.Id("password");
        private By ConfmPasswd = By.Id("confirmPassword");
        private By update = By.XPath("//button[contains(text(),'Update')]");
        //Upgrade User
        private By Upgradeuser = By.XPath("//span[text()='Upgrade User']");
        private By planname = By.XPath("//select[@id='planName']");
        private By userEmail = By.Id("userEmail");
        private By trialperid = By.Id("trialPeriod");
        private By NoOfJobs = By.Id("inputnoofJobs");
        private By amount = By.Id("inputamount");
        private By cupncode = By.XPath("//select[@id='cpncode']");
        private By JobsType = By.XPath("//select[@id='jobstype']");
        private By Aplymail = By.XPath("//select[@id='applyemail']");
        private By submtbutn = By.XPath("//button[@id='btnsubmitmyinfo']");
        //Access user
        private By accesuser = By.XPath("//span[text()='Access Users']");
        private By adduser = By.XPath("//div[text()='Add User']");
        private By textusrname = By.XPath("(//input[@type='text'])[1]");
        private By permisns = By.XPath("//input[@role='combobox']");
        private By accesclse = By.XPath("//i[text()='close']");
        private By save = By.XPath("//div[text()='Save']");
        //Access Edit
        private By edit = By.CssSelector("tbody tr:first-child td:nth-child(5)");
        private By Accesskey = By.XPath("//div[@class='v-btn__content' and text()='Generate Access Key']");
        //Jobqueuedashboard
        private By queuedashbd = By.XPath("//span[text()='Job Queue Dashboard']");
        private By employer = By.XPath("//input[@aria-label='Employer']");
        private By queuestatus = By.XPath("//input[@aria-label='Queue Status']/parent::div/following-sibling::div//i");
        private By calendar = By.CssSelector("div#reportrange i.material-icons");
        private By loadjobs = By.XPath("//button[@class='btn-primary v-btn theme--dark primary']");
        //google posted jobs
        private By goglepost = By.XPath("//span[text()='Google Posted Jobs']");
        //No of Views No of Applies
        private By views = By.XPath("//span[text()='No of Views']");
        private By viewsheader = By.XPath("//h1[contains(text(),'No of Views')]");
        private By nxtbutn = By.XPath("//a[text()='Next']");
        private By Applies = By.XPath("//span[text()='No of Applies']");
        private By AppliesHeader = By.XPath("//h1[contains(text(),'Applies')]");
        private By appnxtbutn = By.XPath("//a[text()='Next']");
        //DashboardStats
        private By Dashboardstats = By.XPath("//span[text()='DashboardStats']");
        private By Dashbordfilter = By.XPath("//div[@class='flex md12 row']//div/i[text()='filter_list']");
        private By Iframe = By.XPath("//iframe[@src='/dashboardFrame']");
        private By date = By.XPath("//input[@aria-label='Created Date From']");
        private By applyfilters = By.XPath("//div[contains(text(),'Apply Filters')]");
        private By loaddata = By.XPath("//div[contains(text(),'Load Data')]");

        //go to basic plan
        //ETL management
        private By etlmanagement = By.XPath("//span[text()='ETL Management']");
        private By stpupbutton = By.XPath("//a[text()=' Set Up ']");
        private By add = By.XPath("//i[@class='v-icon material-icons theme--dark' and text()='add']");
        private By etlemployr = By.XPath("(//input[@aria-label='Employer'])[2]");
        private By utc = By.XPath("//div[@class='v-select__selections']/input[@aria-label='Update Jobs Daily at (UTC)']");
        private By feedurl = By.XPath("//input[@placeholder='Enter XML Feed Url']");
        private By etlsave = By.XPath("//div[contains(text(),'Save')]");

        private By reports = By.XPath("//a[text()='Reports']");
        private By repfilter = By.XPath("//i[text()='filter_list']");
        private By repemp = By.XPath("(//input[@aria-label='Employer'])[1]");
        private By fromdte = By.XPath("//input[@aria-label='From Date']");
        private By todate = By.XPath("//input[@aria-label='To Date']");
        private By aplyfilters = By.XPath("//div[contains(text(),'Apply Filters')]");
        private By signout = By.XPath("//a[text()='Sign out']");
        public SupportDashboardReportLinks(IWebDriver driver) : base(driver)
        {

        }
        public void ClickonCustomSearchLink()
        {
            JavaScriptClick(customsearch);
            Pause(10);
    
        }

        public void ClickonCompanyAndSelectCompany(string compName)
        {
            
            IWebElement ele = WaitForElementToBePresent(compnynme, 2);
            Thread.Sleep(300);
            JavaScriptClick(ele);
            Thread.Sleep(300);

            // 
            var ele1 = WaitForElementToBePresent(companySearchInputBox, 5);
            ele1.SendKeys(compName);

            //By firstElement = By.CssSelector("div.dropdown-menu ul li:nth-child(2) a");
            //var ele2 = WaitForElementToBeClickeable(firstElement);
            //string text = ele1.Text;
            //Console.WriteLine("Current text: " + text);
            //JavaScriptClick(ele1);

            Pause(5);
            string Reqcmpnyname = "//li/a/span[text()='" + compName + "']";
            IWebElement reqEle = driver.FindElement(By.XPath(Reqcmpnyname));
            Pause(1);
            JavaScriptClick(reqEle);
            Thread.Sleep(300);

        }
        public void ClickonSelectJobStatusAndSelectURlFromDropDown()
        {
            SelectElementWithByAndText(jobstatus,"Active");
            Pause(2);

            IWebElement ele = WaitForElementToBeClickeable(selecturl, 10);
            JavaScriptClick(ele);
            Thread.Sleep(300);
            string reqXpath = "//ul[contains(@class,'multiselect-container')]/li//label[@class='checkbox']/input";
            IWebElement requxpath = driver.FindElement(By.XPath(reqXpath));
            JavaScriptClick(requxpath);
            Thread.Sleep(500);

        }
        public void ClickonReportLinks()
        {
            JavaScriptClick(signupreport);
            Pause(3);
            WaitForElementToBeClickeable(signupreprtHeadng, 1).Click();

            JavaScriptClick(prevwrept);
            Pause(3);

            WaitForElementToBeClickeable(prevwreptheadng, 1).Click();

            JavaScriptClick(Triedurlrept);
            Pause(3);

            WaitForElementToBeClickeable(Triedurlreptheadng, 1).Click();
}
        public void ClickOnviewAndAppliesLinks()
        {
            JavaScriptClick(viewAplies);
            Pause(5);
            WaitForElementToBeClickeable(apliesheadng, 1).Click();

            JavaScriptClick(mastrviewaplies);
            Pause(5);
        }
        public void ClickOnEditXpath()
        {
            JavaScriptClick(Editxpath);
            Pause(5);

            WaitForElementToBeClickeable(DomainName).SendKeys("Cengage");
            JavaScriptClick(Submit);
            Pause(3);
        }
        public void ClickOnStripeUSerData()
        {
            JavaScriptClick(StripeuserData);
            Pause(3);
            SelectElementWithByAndText(Planname,"Pro");
            Pause(2);
            JavaScriptClick(planSubmit);
            Pause(5);
        }
        public void ClickOnAddUser()
        {
            JavaScriptClick(addusrs);
            Pause(2);
            WaitForElementToBeClickeable(firstnme).SendKeys("Tejaswini");
            Pause(1);
            WaitForElementToBeClickeable(lstname).SendKeys("Reddy");
            Pause(1);
            WaitForElementToBeClickeable(email).SendKeys("tejaswini+137@jobiak.ai");
            Pause(1);
            WaitForElementToBeClickeable(pswd).SendKeys("Tejaswini@123");
            Pause(1);
            SelectElementWithByAndText(supportuser,"Job_Editor");
            Pause(2);


        }
        public void ClickOnResetPassword()
        {
            JavaScriptClick(resetpswd);
            Pause(2);
            WaitForElementToBeClickeable(username).SendKeys("tejaswini+137@jobiak.ai");
            Pause(1);
            WaitForElementToBeClickeable(newpasswd).SendKeys("Tejaswini@124");
            Pause(1);
            WaitForElementToBeClickeable(ConfmPasswd).SendKeys("Tejaswini@124");
            Pause(1);
            //JavaScriptClick(update);
            //Pause(2);
        }
        public void ClickOnUpgradeUser()
        {
            JavaScriptClick(Upgradeuser);
            Pause(3);
            SelectElementWithByAndText(planname, "Pro-plus");
            Pause(2);
            WaitForElementToBeClickeable(userEmail).SendKeys("tejaswini+138@jobiak.ai");
            Pause(1);
            WaitForElementToBeClickeable(trialperid).SendKeys("2");
            Pause(1);
            WaitForElementToBeClickeable(NoOfJobs).SendKeys("2");
            Pause(1);
            WaitForElementToBeClickeable(amount).SendKeys("2");
            Pause(1);
            SelectElementWithByAndText(cupncode,"JOBIAK20CNG");
            Pause(2);
            SelectElementWithByAndText(JobsType,"PDF");
            Pause(2);
            SelectElementWithByAndText(Aplymail,"Orginal_Page");
            Pause(2);
            //JavaScriptClick(submtbutn);
            //Pause(3);
        }
        public void ClickOnAccessUser()
        {
            JavaScriptClick(accesuser);
            Pause(3);
            JavaScriptClick(adduser);
            Pause(2);
            WaitForElementToBeClickeable(textusrname).SendKeys("tejaswini+138@jobiak.ai");
            Pause(1);
        }
        public void ClickOnAccessUserPermissions()
        {
            IWebElement ele = WaitForElementToBeClickeable(permisns, 10);
            JavaScriptClick(ele);
            Thread.Sleep(300);
             string access = "//div[@class='v-select-list v-card theme--light']//div[@role='listitem']//div[@class='v-input--selection-controls__input']/input";
             IWebElement user = driver.FindElement(By.XPath(access));
             JavaScriptClick(user);
              Thread.Sleep(500);

            JavaScriptClick(accesclse);
            Pause(2);
            //JavaScriptClick(save);

        }
        public void ClickOnQueueDashboard()
        {
            JavaScriptClick(queuedashbd);
            Pause(7);
        }
        public void ClickOnQueueDashboardEmployer(string employname)
        {
           
            IWebElement ele = WaitForElementToBePresent(employer, 2);
            Thread.Sleep(300);
            JavaScriptClick(ele);
            Thread.Sleep(300);
            ele.SendKeys(employname);
            Pause(5);
            string Reqemployname = "//span[text()=\"" + employname + "\"]";
            IWebElement reqEle = driver.FindElement(By.XPath(Reqemployname));
            Thread.Sleep(1000);
            JavaScriptClick(reqEle);
            Thread.Sleep(300);
        }
        public void clickonQueueStatus(string status)
        {
            IWebElement ele = WaitForElementToBePresent(queuestatus, 2);
            Thread.Sleep(300);
            JavaScriptClick(ele);
            Thread.Sleep(300);
            //ele.SendKeys(status);
            Pause(5);
            string Reqstatus = "//div[contains(@class,'title') and text()='"+status+"']";
            IWebElement reqEle = driver.FindElement(By.XPath(Reqstatus));
            Thread.Sleep(1000);
            JavaScriptClick(reqEle);
            Thread.Sleep(500);

        }
        public void clickoncalendar(string queuecalendar)
        {
            IWebElement ele = WaitForElementToBePresent(calendar, 2);
            Thread.Sleep(300);
            JavaScriptClick(ele);
            Thread.Sleep(300);
            
            Pause(5);
            string Reqcalendar = "//div[@class='ranges']//li[text()='"+ queuecalendar + "']";
            IWebElement reqEle = driver.FindElement(By.XPath(Reqcalendar));
            Thread.Sleep(1000);
            MoveToElementAndClick(reqEle);
            //JavaScriptClick(reqEle);
            Thread.Sleep(300);

        }
        public void ClickOnLoadJobs()
        {
            JavaScriptClick(loadjobs);
            Pause(7);

        }
        public void ClickonGooglepostedJobs()
        {
            JavaScriptClick(goglepost);
            Pause(2);
        }
        public void ClickOnNoOfViewsAndApplies()
        {
            JavaScriptClick(views);
            Pause(20);
            WaitForElementToBeClickeable(viewsheader, 1).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,600)");
            JavaScriptClick(nxtbutn);
            Pause(3);

            JavaScriptClick(Applies);
            Pause(20);
            WaitForElementToBeClickeable(AppliesHeader, 1).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,600)");
            JavaScriptClick(appnxtbutn);
            Pause(3);
        }
         public void ClickOnDashboardStats()
        {
            JavaScriptClick(Dashboardstats);
            Pause(10);
            IWebElement wEle = WaitForElementToBeVisible(Iframe, 30);
            driver.SwitchTo().Frame(wEle);
            var ele1 = WaitForElementToBeClickeable(Dashbordfilter);
            JavaScriptClick(ele1);
            Pause(20);
        }
        public void clickONApplyfilters()
        {
            var ele = WaitForElementToBeClickeable(applyfilters);
            JavaScriptClick(ele);
            Pause(2);
            var ele1 = WaitForElementToBeClickeable(loaddata);
            JavaScriptClick(ele1);
            Pause(2);
            driver.Navigate().Back();
        }
            public void ClickOnArrowLeft()
        {
            JavaScriptClick(Back);
            Pause(2);
        }
        public void ClickOnETLmanagement()
        {
            JavaScriptClick(etlmanagement);
            Pause(5);

            //JavaScriptClick(stpupbutton);
            JavaScriptClick(add);
            Pause(1);
        }
        public void ClickOnETLEmployer(string etlempname)
        {
             IWebElement ele = WaitForElementToBePresent(etlemployr, 2);
                Thread.Sleep(300);
                JavaScriptClick(ele);
                Thread.Sleep(300);
                ele.SendKeys(etlempname);
                Pause(5);
                string Reqempname = "//span[text()=\"" + etlempname + "\"]";
                IWebElement reqEle = driver.FindElement(By.XPath(Reqempname));
                Thread.Sleep(1000);
                JavaScriptClick(reqEle);
                Thread.Sleep(300);

            }
        public void clickonUTCAndEnterXMLUrl()
        {
            IWebElement ele = WaitForElementToBeClickeable(utc, 10);
            JavaScriptClick(ele);
            Thread.Sleep(300);
            string reqXpath = "//div[contains(@class,'menuable__content__active')]//div[@role='listitem']//div[@class='v-input--selection-controls__input']/input";
            IWebElement requxpath = driver.FindElement(By.XPath(reqXpath));
            JavaScriptClick(requxpath);
            Thread.Sleep(500);

            WaitForElementToBeClickeable(feedurl).SendKeys("https://www.eventbritecareers.com/sitemap.xml");
            Pause(2);
        }
        public void clickonReportsAndFilter()
        {
            JavaScriptClick(reports);
            Pause(2);
            JavaScriptClick(repfilter);
            Pause(2);


        }
        public void ClickOnReportsEmployer(string Repempname)
        {
            IWebElement ele = WaitForElementToBePresent(repemp, 2);
            Thread.Sleep(300);
            JavaScriptClick(ele);
            Thread.Sleep(300);
            //ele.SendKeys(Repempname);
            Pause(5);
            string Reqempname = "//div[contains(@class,'title') and text()='"+Repempname+"']";
            IWebElement reqEle = driver.FindElement(By.XPath(Reqempname));
            Thread.Sleep(1000);
            JavaScriptClick(reqEle);
            Thread.Sleep(300);

        }
        public void ClickAndselectDates()
        {
            WaitForElementToBeClickeable(fromdte).Click();
            string datepos = "(//div[@class='v-btn__content' and text()='1'])[2]";
            IWebElement datePosted = driver.FindElement(By.XPath(datepos));
            datePosted.Click();
            Pause(2);

            WaitForElementToBeClickeable(todate).Click();
            /*string reqValidDate = getDateAsStringToEnter("plus", 0);
            var currentby = By.XPath("(//tbody)[1]//tr/td[text()='" + reqValidDate + "' and @class='today day']");
            IWebElement dateValid = WaitForElementToBeClickeable(currentby);
            JavaScriptClick(dateValid);*/
            string Todate = "(//div[@class='v-btn__content' and text()='1'])[1]";
            IWebElement validdate = driver.FindElement(By.XPath(Todate));
            validdate.Click();
            Pause(2);

            var applyBtn = WaitForElementToBePresent(aplyfilters);
            JavaScriptClick(applyBtn);

            Pause(3);

            JavaScriptClick(signout);
            Pause(2);



        }

        private By GetRequiredDateByWithDateAsInput(string date)
        {

            return By.XPath("(//tbody)[1]//tr/td[text()='" + date + "']");
        }


        public void SelectDateRanges()
        {
            var dateRange = WaitForElementToBeClickeable(BtnDateRange);
            JavaScriptClick(dateRange);
            Pause(1);
            IWebElement LeftDate = WaitForElementToBeClickeable(GetRequiredLeftDateByWithDateAsInput("15"));
            MoveToElementAndClick(LeftDate);

            //JavaScriptClick(LeftDate);
            Pause(2);

            IWebElement RightDate = WaitForElementToBeClickeable(GetRequiredRightDateByWithDateAsInput("19"));
            MoveToElementAndClick(RightDate);
            //JavaScriptClick(RightDate);
            Pause(2);

            var applyBtnlEle = WaitForElementToBePresent(applyBtn);
            JavaScriptClick(applyBtnlEle);

            Pause(1);

        }

        private By GetRequiredLeftDateByWithDateAsInput(string date)
        {

            return By.XPath("//div[@class='drp-calendar left']//tr//td[text()='" + date + "']");
        }

        private By GetRequiredRightDateByWithDateAsInput(string date)
        {

            return By.XPath("//div[@class='drp-calendar right']//tr//td[text()='" + date + "']");
        }
       public void ClickOnEditAccessuserPageTable()
        {
            JavaScriptClick(accesuser);
            Pause(3);
            JavaScriptClick(edit);
            Pause(30);
            //JavaScriptClick(Accesskey);
            Pause(5);
            //JavaScriptClick(accesclse);
            Pause(2);

        }




    }
}
    