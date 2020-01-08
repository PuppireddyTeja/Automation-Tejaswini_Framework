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
    class Employer : PageBase
    {
        private By usernameInput = By.XPath("//input[@id='inputWorkEmail']");
        private By passwordInput = By.XPath("//input[@id='inputPassword']");
        private By sigin = By.XPath("//button[contains(text(),'Sign')]");
        private By Signcredentials = By.XPath("//a[text()='Sign In']");
        private By employer = By.XPath("//a[text()='Employers']");
        private By tableGridEmpNameColumn = By.XPath("(//th[text()='Employer Name'])[1]");
        private By employerDetailsHeading = By.XPath("//div[text()='Employer Details']");
        private By ratingcount = By.XPath("(//input[@aria-label='Rating Count'])[2]");
        private By saveBtn = By.XPath("(//div[contains(text(),'Save')])[2]");


        public Employer(IWebDriver driver) : base(driver)
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
        public void clickOnEmployersLink()
        {
            IWebElement Emp = WaitForElementToBeClickeable(employer, 10);
            JavaScriptClick(Emp);
            Thread.Sleep(500);
        }
        public void clickOnEditIconBasedOnEmployeeName(string empName)
        {
            string reqJobTitle = "";

            Thread.Sleep(3000);
            WaitForElementToBeClickeable(tableGridEmpNameColumn);
            string ReqEditButtonXpath = "//td[contains(text(),\"" + empName + "\")]//following-sibling::td/i";
            IWebElement reqWebEle = driver.FindElement(By.XPath(ReqEditButtonXpath));
            JavaScriptClick(reqWebEle);
            Thread.Sleep(500);
        }
        public Boolean verifyEmployersTabIsOpened()
        {
            Boolean isDisplayed = false;
            try {
                IWebElement ele = WaitForElementToBeClickeable(tableGridEmpNameColumn, 20);
                if (ele.Displayed)
                    isDisplayed = true;
            }
            catch (Exception e) {
                isDisplayed = false;

            }
            return isDisplayed;
        }
        public void verifyEmployerDetailsAreDisplayedAfterEditClick()
        {
            try
            {
                IWebElement ele = WaitForElementToBeClickeable(employerDetailsHeading);
                if (ele.Displayed)
                    Console.WriteLine("Employer Details edit page opened");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }
        public void EnterRatingCount()
        {
            //Thread.Sleep(2000);
            var el = WaitForElementToBeClickeable(ratingcount);
            el.Click();
            //el.Clear();
            //Actions act = new Actions(driver);
            //act.Click(el);
            //act.SendKeys
            //act.SendKeys("1").Build().Perform();
            //el.SendKeys("^a");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].value = '';", el);
            el.SendKeys("0.5");



        }
        public void clickOnEmployersDetailsSaveButton()
        {
            IWebElement ele2 = WaitForElementToBeClickeable(saveBtn);
            JavaScriptClick(ele2);
        }

















        }
    }
