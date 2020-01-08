using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BDDAutomation.Pages
{
    class ProductTagging : PageBase
    {

        //UI Elements locators

        private By Signcredentials = By.XPath("//a[text()='Sign In']");
        private By usernameInput = By.XPath("//input[@id='inputWorkEmail']");
        private By passwordInput = By.XPath("//input[@id='inputPassword']");
        private By sigin = By.XPath("//button[contains(text(),'Sign')]");
        private By addjob = By.XPath("//span[text()='Add Job']");
        private By singlejobUrl = By.XPath("//input[@id='joburl']");
        private By postjob = By.XPath("//button[text()='Post job']");
        private By tryitnow = By.XPath("//a[text()='Try It Now']");
        private By textjoburl = By.XPath("//input[@id='jobUrl']");
        private By getstarted = By.XPath("//form[@id='tryitform']/p/button[@id='submitJobUrl']");
        private By dateposted = By.XPath("//div[@class='left-nav-item']/span[text()='Date Posted']");
        private By customvalue = By.XPath("(//div[@class='flex prediction xs6'])[2]");
        private By datepostedtext = By.XPath("//input[@aria-label='Date Posted']");
        private By validthrough = By.XPath("//span[text()='Valid Through']");
        private By customvalid = By.XPath("(//div[@class='flex prediction xs6'])[2]");
        private By calendartext = By.XPath("//input[@aria-label='Valid Through']");
        private By clickonsave = By.XPath("//div[text()='Save']");
        private By preview = By.XPath("//div[text()='Preview & Post Job']");
        private By optimize = By.XPath("//div[text()='Optimize']");
        private By edit = By.XPath("//div[@class='v-btn__content' and text()='Edit']");
        private By workmailId = By.XPath("//input[@id='emailId']");
        private By workmailpassword = By.XPath("//input[@id='inputPassword']");
        private By checkbox = By.XPath("//input[@id='userApproval']");
        private By createaccount = By.XPath("//button[text()='Create Free Account and Publish ']");
        private By requiredLabelsHeader = By.XPath("//span[text()='Required Labels']");
        private By jobdescription = By.XPath("//span[text()='Job Description']");
        private By clear = By.XPath("//div[text()='Clear']");
        private By editjobdescription = By.XPath("//div[contains(@class,'ql-editor')]");
        private By jobDescriptionHeader = By.XPath("//div[contains(@class,'headline') and text()='Job Description']");
        private By pdf = By.XPath("//input[@type='radio' and @id='radiopdf']/parent::label");
        private By choosefile = By.XPath("//input[@id='customfile']");
        private By submit = By.XPath("//button[@id='btnSubmit']");
        private By popup = By.XPath("//div[@id='modal-jobiak-guide']//div[@class='modal-content']//button[@class='close']/span");
        private By uploadpdf = By.XPath("//span[text()='Upload Job PDF']");
        private By choosefile1 = By.XPath("(//input[@class='form-control form-control-lg'])[2]");
        private By Submit = By.XPath("//button[@id='btnSubmit']");
        private By salary = By.XPath("//span[text()='Salary']");
        private By customsalary = By.XPath("(//div[@class='flex prediction xs6'])[2]");
        private By salaryEditIcon = By.XPath("(//input[@aria-label='Salary'])[1]//following::div/i[text()='edit']");
        private By salaryToEnter = By.XPath("//input[@aria-label='Salary *']");
        private By perSelection = By.XPath("//input[@aria-label='Per *']");
        private By salaryUpdateBtn = By.XPath("//div[@class='v-btn__content' and text()='Update']");
        private By companyname = By.XPath("//span[text()='Company Name']");
        private By customcompanyForJob = By.XPath("(//div[@class='flex prediction xs6'])[6]");

        private By customcompany = By.XPath("(//div[@class='flex prediction xs6'])[2]");
        private By customcompanytext = By.XPath("//input[@aria-label='Company Name']");
        private By jobtitle = By.XPath("//span[text()='Job Title']");

        private By save = By.XPath("//div[text()='Save']");
        private By savesalary = By.XPath("//div[text()='Save']");

        private By customdateposted = By.XPath("(//div[@class='flex prediction xs6'])[4]");

        private By location = By.XPath("//span[text()='Location']");
        private By customloc = By.XPath("(//div[@class='flex prediction xs6'])[2]");
        private By locatintext = By.XPath("//input[@aria-label='Location']");
        //TickMarks

        private By companyNameTickMark = By.XPath("//div[contains(@class,'left-nav-item')]/span[text()='Company Name']/following-sibling::i[text()='check_circle']");
        private By jobTitleTickMark = By.XPath("//div[contains(@class,'left-nav-item')]/span[text()='Job Title']/following-sibling::i[text()='check_circle']");
        private By datepostedtickmark = By.XPath("//div[contains(@class,'left-nav-item')]/span[text()='Date Posted']/following-sibling::i[text()='check_circle']");
        private By locationtickmark = By.XPath("//div[contains(@class,'left-nav-item')]/span[text()='Location']/following-sibling::i[text()='check_circle']");

 // public static string productUrl = "https://www.jobiak.ai/try-it-now/";



        public ProductTagging(IWebDriver driver) : base(driver)
        {
            try
            {
                //this.WaitForBlockOverlayToDissapear();
                // this.WaitForElementToBeVisible(tryitnow).Click();
                //this.NavigateToGivenURL("https://www.jobiak.ai/try-it-now/");
            }
            catch (Exception)
            {
                // this.Reload();
                //this.WaitForBlockOverlayToDissapear();
                //this.WaitForElementToBeVisible(tryitnow).Click();
            }
        }

        /*public void NavigateToJobAikURL()
        {
            NavigateToGivenURL("https://www.jobiak.ai/try-it-now/");
        }*/
        public void clickSignCredentials()
        {
            IWebElement ele = WaitForElementToBeClickeable(Signcredentials);
            JavaScriptClick(ele);
            Pause(2);
        }
        public void FillOutSignForm(string username, string password)
        {
            IWebElement usernameWE = this.WaitForElementToBeVisible(usernameInput);
            usernameWE.Click();
            ClearAndType(usernameWE, username);
            ClearAndType(WaitForElementToBeVisible(passwordInput), password);
        }
        public void siginButton()
        {
            WaitForElementToBeClickeable(sigin).Click();
        }
        public void clickAddJob()
        {
            IWebElement ele = WaitForElementToBeClickeable(addjob);
            JavaScriptClick(ele);
        }
        public void Entersinglejourl()
        {
            Thread.Sleep(1500);
            WaitForElementToBeClickeable(singlejobUrl).SendKeys("https://www.hcltech.com/jobs/alameda-contractor-california-6");
        }
        public void clickPostJob()
        {
            var ele = WaitForElementToBeClickeable(postjob);
            JavaScriptClick(ele);
            Thread.Sleep(2500);

        }

        public void ClickOnTryItNow()
        {
            WaitForElementToBeClickeable(tryitnow).Click();
            Thread.Sleep(1000);
        }

        //Navigate to Tagging page
        public void TextPostJobUrl()
        {
            Thread.Sleep(1000);
            WaitForElementToBeClickeable(textjoburl, 5).SendKeys("https://www.hcltech.com/jobs/alameda-contractor-california-6");
        }
        public void clickongetStarted()
        {
            Thread.Sleep(1000);
            WaitForElementToBeClickeable(getstarted).Click();

        }
        public void ClickJobDescription()

        {
            switchToChildWindow();
            Thread.Sleep(400);
            IWebElement element = WaitForElementToBeClickeable(jobdescription, 200);
            JavaScriptClick(element);

        }

        public void uploadPDF()
        {
            Thread.Sleep(2000);
            IWebElement ele = driver.FindElement(pdf);


            JSMoveToViewElement(ele);

            Thread.Sleep(3000);
            JavaScriptClick(ele);
            Thread.Sleep(1000);
            string filePath = @"C:\Users\User\Desktop\Senior Product Manager.pdf";
            driver.FindElement(choosefile).SendKeys(filePath);
            Thread.Sleep(1500);
            IWebElement submitEle = driver.FindElement(submit);

            JavaScriptClick(submitEle);
            Thread.Sleep(2000);

        }
        public void ClickOnClearButtonInsideJobDescription()

        {
            IWebElement element = GetCurrentElement(clear);
            JSMoveToViewElement(element);
            JavaScriptClick(element);
        }



        public void EnterRandomRequiredCharactersAsJobDescription()
        {
            string randString = GenerateRandomString(300);
            MoveToViewElementandSAndkeys(editjobdescription, randString);
            WaitForElementToBeClickeable(jobDescriptionHeader, 1).Click();



        }
        


        public void switchToChildWindow()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(2000);
            WaitForElementsToBePresent(requiredLabelsHeader, 200);


        }
        public void switchToParentWindow()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Thread.Sleep(3000);



        }
        public void ClickDatePosted()
        {
            JavaScriptClick(dateposted);
            Thread.Sleep(1000);

        }
        public void clickCustomValue()
        {
            WaitForElementToBeClickeable(customvalue).Click();
            Thread.Sleep(1000);
        }
        public void ClickOnDatePostedText()
        {
            String currentDate = DateTime.Now.ToString("MM/dd/yyyy");

            JavaScriptClick(datepostedtext);
            MoveToViewElementandSAndkeys(datepostedtext, currentDate);
            //Pause(2);
            //JavaScriptClick(datepostedtext);
            Pause(3);

        }
        
        public void clickOnSave()
        {
            JavaScriptClick(save);
            Pause(3);

        }


        //Todo - modify below function for valid thru
        public void ClickOnValidThruDatePostedText()
        {
            JavaScriptClick(validthrough);
            Pause(5);
            JavaScriptClick(customvalid);
            Pause(5);
            String currentDate = DateTime
                .Now
                .AddDays(20)
                .ToString("MM/dd/yyyy");

            JavaScriptClick(calendartext);
            MoveToViewElementandSAndkeys(calendartext, currentDate);
            Pause(1);
            JavaScriptClick(calendartext);

        }

        public void ClickonPreview()

        {
            Pause(3);
            JavaScriptClick(preview);

        }
        public void ClickOnOptimize()
        {
            Pause(3);
            JavaScriptClick(optimize);
            Pause(5);
        }
        public void clickonEdit()
        {
            JavaScriptClick(edit);
            Pause(5);
        }
        public void EnterWorkMailId()
        {
            Thread.Sleep(1000);
            WaitForElementToBeClickeable(workmailId).SendKeys("tejaswini146@jobiak.ai");
        }
        public void EnterPassword()
        {
            WaitForElementToBeClickeable(workmailpassword).SendKeys("Tejuju@123");
        }
        public void ClickOnCheckbox()
        {
            WaitForElementToBeClickeable(checkbox).Click();
            Thread.Sleep(1000);
        }
        public void clickonCreateFreeAccountAndPublish()
        {
            WaitForElementToBeClickeable(createaccount).Click();
            Thread.Sleep(1000);
        }
        public void Usernametext()
        {
            Thread.Sleep(1000);
            WaitForElementToBeClickeable(usernameInput, 5).SendKeys("suresh.seela+15@jobiak.ai");
        }
        public void Passwordtext()
        {
            Thread.Sleep(1000);
            WaitForElementToBeClickeable(passwordInput, 5).SendKeys("suresh231");
        }
        public void DragAndDropToOffsetofElement()
        {

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,500)");

        }


        public void Driverquit()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }

        public void Driverclose()

        {
            if (driver != null)
            {
                driver.Close();
                switchToParentWindow();
                driver.Close();


            }
        }

        public void uploadPDFByPlans()
        {
            Thread.Sleep(2000);
            IWebElement ele1 = driver.FindElement(uploadpdf);


            JSMoveToViewElement(ele1);

            Thread.Sleep(3000);
            JavaScriptClick(ele1);
            Thread.Sleep(1000);
            string filePath = @"C:\Users\User\Desktop\Senior Product Manager.pdf";
            driver.FindElement(choosefile1).SendKeys(filePath);
            Thread.Sleep(1500);
            IWebElement SubmitEle = driver.FindElement(Submit);

            JavaScriptClick(SubmitEle);
            Thread.Sleep(2000);

        }
        public void EntersalaryCustom()
        {
            IWebElement sal = driver.FindElement(salary);
            MoveToElementAndClick(sal);
            JavaScriptClick(sal);
            IWebElement cus = driver.FindElement(customsalary);
            JavaScriptClick(cus);
            Thread.Sleep(1000);

        }
        public void clickAndEditsalaryInformation(string currency, string salType, string per, string minSal, string maxSal)
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
                IWebElement salsave = WaitForElementToBeClickeable(savesalary, 2);
                JavaScriptClick(salsave);
                Thread.Sleep(300);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }

        }
        public void clickoncompany()
        {

           JavaScriptClick(companyname);
            Pause(2);
            JavaScriptClick(customcompany);
            WaitForElementToBeClickeable(customcompanytext).SendKeys("Infosys");
            JavaScriptClick(save);

        }
        public void FillOutSignInForm(string username, string password)
        {
            IWebElement usernameWE = this.WaitForElementToBeVisible(usernameInput);
            usernameWE.Click();
            ClearAndType(usernameWE, username);
            ClearAndType(WaitForElementToBeVisible(passwordInput), password);
        }


        // 1) Req -> Tick mark

        public Boolean AreDetialsAlreadyEntered(By by)
        {
            try {

                IWebElement ele = driver.FindElement(by);
                //IWebElement ele = driver.FindElement(By.XPath(""));
                return true;
            
            }
            catch (NoSuchElementException e) {

                return false;
            }

        }


        //
        public void entercompanyname() {
            if (!AreDetialsAlreadyEntered(companyNameTickMark))
            {
                JavaScriptClick(companyname);
                Pause(2);
                JavaScriptClick(customcompany);
                Pause(2);
                WaitForElementToBeClickeable(customcompanytext).SendKeys("Infosys");
                JavaScriptClick(save);
            }

        }


        public void enterJobTitle()
        {
            if (!AreDetialsAlreadyEntered(jobTitleTickMark))
            {
                //Job title code details
            }

        }
        public void entercompanynameForGivenJobUrl()
        {
            if (!AreDetialsAlreadyEntered(companyNameTickMark))
            {
                JavaScriptClick(companyname);
                Pause(3);
                JavaScriptClick(customcompanyForJob);
                Pause(2);
                WaitForElementToBeClickeable(customcompanytext).SendKeys("Infosys");
            JavaScriptClick(save);
            }

        }
        public void EnterDateposted()
        {
            if (!AreDetialsAlreadyEntered(datepostedtickmark))
            {
                ClickDatePosted();
                clickCustomValue();
                ClickOnDatePostedText();

            }
        }
        public void clickonLocation()
        {
            if (!AreDetialsAlreadyEntered(locationtickmark))
            {
                JavaScriptClick(location);
                JavaScriptClick(customloc);
                WaitForElementToBeClickeable(locatintext).SendKeys("Hyderabad");
                JavaScriptClick(save);
            }
        }
        public void clickoncompanyForTagging()
        {
            if (!AreDetialsAlreadyEntered(companyNameTickMark))
            {
                JavaScriptClick(companyname);
                Pause(2);
                JavaScriptClick(customcompanyForJob);
                WaitForElementToBeClickeable(customcompanytext).SendKeys("Infosys");
                JavaScriptClick(save);

            }
        }


    }
}

