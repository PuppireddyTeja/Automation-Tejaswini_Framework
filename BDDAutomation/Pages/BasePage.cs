using BDDAutomation.Test_Framework.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDAutomation.Pages
{

    public class PageBase : PageObject
    {     
        private By portalLogo = By.XPath("//a[@class='navbar-brand']");
        //Login button locator to check the login page is diplsayed or not
        private By loginButton = By.XPath("//button[contains(.,'Log in')]");
        //Block UI Overlay locator - wait please message and IU blocker
        protected By blockOverlays = By.CssSelector("div.blockUI.blockOverlay");
        protected int blockOverlayWaitTimeout = 65;
        protected int maxTimesOverlays = 30;


        public PageBase(IWebDriver driver) : base(driver)
        {
            try
            {
                //this.WaitForBlockOverlayToDissapear();
            }
            catch (Exception)
            {
                //Reload already checks for overlay to dissappear after refreshing the page
                //this.Reload();
            }
        }

        protected void WaitForBlockOverlayToDissapear()
        {
            //Message 'Please wait' is appearing multiple times, 
            //expecting it as many times as the max we could define per the current pages Ajax calls
            this.Pause(2);
            TestsLogger.Log("WaitForBlockOverlayToDissapear with locator " + blockOverlays + " for " + blockOverlayWaitTimeout + " secs (" + maxTimesOverlays + " times)");
            for (int i = 0; i < maxTimesOverlays; i++)
            {
                this.WaitForElementToDissapear(blockOverlays, blockOverlayWaitTimeout);

            }
        }

        public void ForceToLoadURL(string url)
        {
            TestsLogger.Log("Forcing URL load to " + url);
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            this.WaitForBlockOverlayToDissapear();
        }

        public new void Reload()
        {
            driver.Navigate().Refresh();
            //Thread.Sleep(5000);
            this.WaitForBlockOverlayToDissapear();
        }

        public bool IsLoginPageDisplayed()
        {
            try
            {
                this.WaitForElementsToBeVisible(loginButton);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public Loginpage Logout()
        {
            //this.SignOutFromPortal();
            driver.Manage().Cookies.DeleteAllCookies();            
            this.Pause(2);
            this.WaitForBlockOverlayToDissapear();
            return new Loginpage(driver);

        }

        private void GoToLoginPage()
        {
            this.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings.Get("PortalURL"));
        }

    }

}