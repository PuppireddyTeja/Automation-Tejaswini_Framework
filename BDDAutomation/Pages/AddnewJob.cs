using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BDDAutomation.Pages
{
    class AddnewJob : PageBase
    {
        private By usernameInput = By.XPath("//input[@id='inputWorkEmail']");
        private By passwordInput = By.XPath("//input[@id='inputPassword']");
        private By sigin = By.XPath("//button[contains(text(),'Sign')]");
        private By Signcredentials = By.XPath("//a[text()='Sign In']");
        private By jobapprovalpage = By.XPath("//span[text()='Job Approval Page']");
        private By JobsAll = By.XPath("//a[text()='Jobs - All']");
        private By JobDetailsHeading = By.XPath("//div[text()='Job Details']");
        private By Addnewjob = By.XPath("//div[text()='Add New Job']");
        private By jobTitle = By.XPath("(//input[@aria-label='Job Title'])[2]");
        private By cleansedtitle = By.XPath("//input[@aria-label='Cleansed Job Title']");
        private By companyname=By.XPath("(//input[@aria-label='Company Name'])[2]");
        private By location = By.XPath("//input[@aria-label='Location']");
        private By postalcode = By.XPath("(//input[@aria-label='Postal Code'])[2]");
        private By Sameas = By.XPath("//input[@aria-label='Same as']");
        private By companylogo = By.XPath("(//input[@aria-label='Company Logo URL'])[2]");
        private By salaryestimate = By.XPath("//input[@aria-label='Salary Estimate']");
        private By saveJob = By.XPath("(//button[@type='button']//div[@class='v-btn__content' and contains(text(),'Save')])[4]");
        private By employerDropDown = By.XPath("(//input[@aria-label='Employer'])[2]/following-sibling::div//i[text()='arrow_drop_down']");
        private By employerInput = By.XPath("(//input[@aria-label='Employer'])[2]");
        private By employerTypeInput = By.XPath("(//input[@aria-label='Employment Type'])[2]/parent::div/following-sibling::div//i[text()='arrow_drop_down']");
        private By salaryInput = By.XPath("(//input[@aria-label='Salary'])[1]");
        private By salaryEditIcon = By.XPath("(//input[@aria-label='Salary'])[1]//following::div/i[text()='edit']");
        private By salaryCurrencyInput = By.XPath("//input[@aria-label='Currency *']");
        private By salaryToEnter = By.XPath("//input[@aria-label='Salary *']");
        private By minSalaryInput = By.XPath("//input[@aria-label='Minimum Salary *']");
        private By maxSalaryInput = By.XPath("//input[@aria-label='Maximum Salary *']");
        private By perSelection = By.XPath("//input[@aria-label='Per *']");
        private By salaryUpdateBtn = By.XPath("//div[@class='v-btn__content' and text()='Update']");
        private By salaryCloseBtn = By.XPath("(//div[@class='v-btn__content' and contains(text(),'Close')])[3]");
        private By occupationCat = By.XPath("//input[@aria-label='Occupational Category']/parent::div/following-sibling::div//i[text()='arrow_drop_down']");
        private By descriptionTextArea = By.XPath("//textarea[@aria-label='Description']");
        private By jobDetailsHeader = By.XPath("//div[text()='Job Details']");

        private By loadJobsBtn = By.XPath("//div[contains(text(),'Load Jobs')]");

        private By searchJobInsideLoadJobsPage = By.XPath("(//input[@aria-label = 'Search with in result below'])[2]");
        private By editjobdescription = By.XPath("//textarea[@aria-label='Description']");
        private By jobDescriptionHeader = By.XPath("//div[contains(@class,'headline') and text()='Job Description']");
        private By salaryEstimate = By.XPath("//input[@aria-label='Salary Estimate']");
        public AddnewJob(IWebDriver driver) : base(driver)
        {
            try
            {
               // this.WaitForBlockOverlayToDissapear();
                //this.WaitForElementToBeVisible(jobapprovalpage).Click();
            }
            catch (Exception)
            {
               // this.Reload();
                //this.WaitForBlockOverlayToDissapear();
                //this.WaitForElementToBeVisible(jobapprovalpage).Click();
            }
        }
        public void Usernametext()
        {
            Thread.Sleep(1000);
            WaitForElementToBeClickeable(usernameInput, 5).SendKeys("mohan@jobiak.ai");
        }
        public void Passwordtext()
        {
            Thread.Sleep(1000);
            WaitForElementToBeClickeable(passwordInput, 5).SendKeys("mohan@123");
        }
        public void siginButton()
        {
            WaitForElementToBeClickeable(sigin).Click();
        }
        public void clickSignCredentials()
        {
            WaitForElementToBeClickeable(Signcredentials).Click();
        }
        public void FillOutSignForm(string username, string password)
        {
            IWebElement usernameWE = this.WaitForElementToBeVisible(usernameInput);
            usernameWE.Click();
            ClearAndType(usernameWE, username);
            ClearAndType(WaitForElementToBeVisible(passwordInput), password);
        }
        public void clickOnJobApprovalPageLink()
        {
            WaitForElementToBeClickeable(jobapprovalpage).Click();
        }

        public void clickOnjobsall()
        {
            WaitForElementToBeClickeable(JobsAll).Click();
        }
        public void clickOnAddnewjob()
        {
            WaitForElementToBeClickeable(Addnewjob).Click();

        }


        public void ClickOnLoadJobs() {

            WaitForElementToBeClickeable(loadJobsBtn, 20);
            Thread.Sleep(3000);
            JavaScriptClick(loadJobsBtn);
            Thread.Sleep(1000);
        }

        public void enterSearchOptionToSearchInsideLoadJobsSearch(string reqJobTitle)
        {
            Thread.Sleep(2000);
            WaitForElementToBeClickeable(searchJobInsideLoadJobsPage,5).SendKeys(reqJobTitle);
        }

        public void EnterRequiredInputForSearch( string input)
        {
            WaitForElementToBeClickeable(companyname).SendKeys(input);
            Thread.Sleep(300);
        }
        public void EntercompanyDetails()
        {
                var ele=WaitForElementToBeClickeable(companyname);
            JavaScriptClick(ele);
                WaitForElementToBeClickeable(companyname).Clear();
                WaitForElementToBeClickeable(companyname).SendKeys("Wipro");

            WaitForElementToBeClickeable(location).Click();
            WaitForElementToBeClickeable(location).Clear();
                WaitForElementToBeClickeable(location).SendKeys("Hyderabad");

            WaitForElementToBeClickeable(jobTitle).Click();
                WaitForElementToBeClickeable(jobTitle).Clear();
                WaitForElementToBeClickeable(jobTitle).SendKeys("CEO");
            
        }
        public void ClickJobDescription()

        {
            IWebElement element = WaitForElementToBeClickeable(descriptionTextArea, 180);
            JavaScriptClick(element);

        }

        public void EnterRandomRequiredCharactersAsJobDescription()
        {
           
                string randString = GenerateRandomString(300);
                WaitForElementToBeClickeable(editjobdescription, 5).Click();
                MoveToViewElementandSAndkeys(editjobdescription, randString);
        
            //WaitForElementToBeClickeable(jobDescriptionHeader, 1).Click();
        }
        public void EnterDirectValuesForEditAndApproveJob()
        {
            WaitForElementToBeClickeable(cleansedtitle).Click();

            WaitForElementToBeClickeable(cleansedtitle).SendKeys("Teacher");


            JavaScriptClear(postalcode);
            WaitForElementToBeClickeable(postalcode).Click();
            WaitForElementToBeClickeable(postalcode).SendKeys("12345");
            Pause(2);
            JavaScriptClear(Sameas);
            WaitForElementToBeClickeable(Sameas).SendKeys("https//Infosys.com");
            
            Pause(2);
            JavaScriptClear(companylogo);
            WaitForElementToBeClickeable(companylogo).SendKeys("https://XpertTech.com");

            //WaitForElementToBeClickeable(salaryestimate).Clear();
            //WaitForElementToBeClickeable(salaryestimate).SendKeys("5$");
        }
           
        /*public void clickonsaveJobForNewJob()
        {
            Thread.Sleep(2000);
            JavaScriptClick(saveJob);
            Thread.Sleep(2000);
        }*/
        public void clickAndSelectEmployerFromDropdown(string empName)
        {
            
                IWebElement ele = WaitForElementToBeVisible(employerInput, 2);
            Thread.Sleep(300);
            JavaScriptClick(ele);
                Thread.Sleep(300);
                ele.SendKeys(empName);
                string ReqEditButtonXpath = "(//span[contains(text(),\"" + empName + "\")])";
                //string ReqEditButtonXpath = "(//div[contains(text(),\"" + empName + "\")])[3]";
                IWebElement reqWebEle = driver.FindElement(By.XPath(ReqEditButtonXpath));
            Thread.Sleep(300);
            JavaScriptClick(reqWebEle);
            Thread.Sleep(300);

        }
        public void clickAndSelectEmployerTypeFromDropdown(string empType)
        {
            
                WaitForElementToBeClickeable(employerTypeInput).Click();
                string reqXpath = "(//div[text()=\"" + empType + "\"])[2]/parent::div";
                IWebElement reqWebEle1 = driver.FindElement(By.XPath(reqXpath));
                reqWebEle1.Click();
            Thread.Sleep(300);

        }
        /*public void clickAndEditSalaryInformation(string currency, string salType, string per, string minSal, string maxSal)
        {
            try
            {
                JavaScriptClick(salaryEditIcon);
                string reqCurrXpath = "//div[@class=\"v-list__tile__title\" and text()=\"" + currency + "\"]";
                IWebElement reqcurrentEle = driver.FindElement(By.XPath(reqCurrXpath));
                JavaScriptClick(reqcurrentEle);
                Thread.Sleep(300);
                string reqSalTypeXpath = "";
                if (salType.Equals("Fixed"))
                {
                    reqSalTypeXpath = "//label[contains(text(),\"Fixed\")]";
                    IWebElement salxpath = driver.FindElement(By.XPath(reqSalTypeXpath));
                    JavaScriptClick(salxpath);
                    Thread.Sleep(300);
                    GetCurrentElement(salaryToEnter).Clear();
                    GetCurrentElement(salaryToEnter).SendKeys(maxSal);
                }
                IWebElement perEle = WaitForElementToBeClickeable(perSelection, 2);
                Thread.Sleep(300);
                JavaScriptClick(perEle);
                Thread.Sleep(300);
                string reqPerXpath = "//div[@class=\"v-list__tile__title\" and text()=\"" + per + "\"]";
                IWebElement perValEle = WaitForElementToBeClickeable(reqPerXpath, 2);
                Thread.Sleep(300);
                JavaScriptClick(perValEle);
                Thread.Sleep(300);
                IWebElement salaryUpDateEle = WaitForElementToBeClickeable(salaryUpdateBtn, 2);
                JavaScriptClick(salaryUpDateEle);
                Thread.Sleep(300);
            }
            catch (Exception e) {
                Debug.WriteLine(e.ToString());
            }

        }*/
        public void SalaryEstimate()
        {
            var ele = WaitForElementToBeClickeable(salaryEstimate);
            ele.Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].value = '';", ele);
            ele.SendKeys("5$");

        }
        public void clickAndSelectOccupationCategoryFromDropdown()
        {
            IWebElement ele = WaitForElementToBeClickeable(occupationCat, 10);
            JavaScriptClick(ele);
            Thread.Sleep(300);
            string reqXpath = "(//div[contains(@class,\"menuable__content__active\")]//div[@role=\"listitem\"]//div[@class=\"v-input--selection-controls__input\"]/input)[1]";
            IWebElement requxpath = driver.FindElement(By.XPath(reqXpath));
            JavaScriptClick(requxpath);
            Thread.Sleep(500);
            WaitForElementToBeClickeable(jobDetailsHeader).Click();
            //JavaScriptClick(jobDetailsHeader);
            Thread.Sleep(500);

        }


















    }
}
