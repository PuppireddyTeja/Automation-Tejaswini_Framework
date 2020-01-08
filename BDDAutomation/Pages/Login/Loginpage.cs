using OpenQA.Selenium;
using System.Threading;
using System;
using BDDAutomation.Pages;
using BDDAutomation.Test_Framework;
using BDDAutomation.Steps;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;
using System.Collections.Generic;

namespace BDDAutomation.Pages
{
    public class Loginpage : PageBase
    {
        //Page title
       //private static string pageTitle = "Login";

        //UI Elements locators
        private By usernameInput = By.XPath("//input[@id='inputWorkEmail']");
        private By passwordInput = By.XPath("//input[@id='inputPassword']");
        private By loginButton = By.XPath("//button[@class='btn btn-primary btn-block']");
        private By userDropdown = By.XPath("//div[@class='btn-group user-helper-dropdown']");
        private By logOutButton = By.XPath("//a[text()='Sign out']");
        private By inactiveLoginButton = By.XPath("//button[@id='btnLogin' and @disabled='']");
        private By customSearch = By.XPath("//a[contains(@href, '/customSearch')]");
        private By jobApprovalPage = By.XPath("//a[contains(@href, '/jobApprovalPage')]");
        private By menuIcon = By.XPath("//i[@class='icon hamburger hamburger-arrow-left']");
        private By getDashboardStats = By.XPath("//a[contains(@href, '/getDashboardStats')]");
        private By googlePostedJobs = By.XPath("//a[contains(@href, '/googlePostedJobs')]");
        private By assignEmployeePage = By.XPath("//a[contains(@href, '/assignEmployeePage')]");
        private By etlmanagement = By.XPath("//a[contains(@href, '/etl-management')]");
        private By customerOnboard = By.XPath("//a[contains(@href, '/customerOnboard')]");
        private By resetPassword = By.XPath("//a[contains(@href, '/resetPassword')]");
       
        public Loginpage(IWebDriver driver) : base(driver)
        {
            try
            {
                this.WaitForBlockOverlayToDissapear();
                this.WaitForElementToBeVisible(usernameInput).Click();
            }
            catch (Exception)
            {
                this.Reload();
                this.WaitForBlockOverlayToDissapear();
                this.WaitForElementToBeVisible(usernameInput).Click();
            }
        }

        protected void ScrollDownToAvoidStickyHeadersOnClick()
        {
            //Move by offset of the sticky headers height....
            IWebElement topBar = this.WaitForElementToBeVisible(By.Id("top-bar"));
            int Y = topBar.Size.Height;
            ScrollWindowBy(0, Y);
        }

        public string UsernameValue
        {
            get
            {
                return WaitForElementToBeVisible(usernameInput).Text;
            }
        }

        public string PasswordValue
        {
            get
            {
                return WaitForElementToBeVisible(passwordInput).Text;
            }
        }

        public Loginpage Login(string username , string password)
        {
            FillOutLoginForm(username, password);
            ClickOnLoginButton();
            return new Loginpage(driver);
        }


        public void FillOutLoginForm(string username , string password)
        {
            IWebElement usernameWE = this.WaitForElementToBeVisible(usernameInput);
            usernameWE.Click();
            ClearAndType(usernameWE, username);
            ClearAndType(WaitForElementToBeVisible(passwordInput), password);
        }
        public void ClickOnLoginButton()
        {
            WaitForElementToBeClickeable(loginButton).Click();
            Thread.Sleep(1000);
        }

        public void EnterUserName()
        {
            WaitForElementToBeClickeable(usernameInput).Click();
        }

        public void EnterPassword()
        {
            WaitForElementToBeClickeable(passwordInput).Click();
        }
        public void ClickOnLogOutButton()
        {
            Thread.Sleep(3000);
            WaitForElementToBeVisible(logOutButton).Click();
            //NavigateToGivenURL("https://app.jobiak.ai/login");
        }

        public void ClickOnAllPages()
        {
            Thread.Sleep(4000);
            var mycustomSearch = WaitForElementToBePresent(customSearch, 5);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", mycustomSearch);
            Thread.Sleep(2000);
            WaitForElementToBeClickeable(jobApprovalPage).Click();
            Thread.Sleep(6000);
            WaitForElementToBeClickeable(menuIcon).Click();
            Thread.Sleep(2000);
            WaitForElementToBeClickeable(getDashboardStats).Click();
            Thread.Sleep(2000);
            WaitForElementToBeClickeable(googlePostedJobs).Click();
            Thread.Sleep(2000);
            //WaitForElementToBeClickeable(assignEmployeePage).Click();
            //Thread.Sleep(3000);
            //WaitForElementToBeClickeable(etlmanagement).Click();
            //Thread.Sleep(2000);
            WaitForElementToBeClickeable(customerOnboard).Click();
            Thread.Sleep(2000);
            WaitForElementToBeClickeable(resetPassword).Click();
            Thread.Sleep(2000);
        }

        public void usernametext()
        {
            Thread.Sleep(1000);
            WaitForElementToBeClickeable(usernameInput, 5).SendKeys("mohan@jobiak.ai");
        }
        public void passwordtext()
        {
            Thread.Sleep(1000);
            WaitForElementToBeClickeable(passwordInput, 5).SendKeys("mohan@123");
        }
        public void ClickOnLogOut()
        {
            Thread.Sleep(3000);
            NavigateToGivenURL("https://app.jobiak.ai/login");
        }

    }


}


