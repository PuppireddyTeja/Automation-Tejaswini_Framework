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
    class JobiakMainLinks : PageBase
    {
        private By howitworks = By.XPath("(//a[text()='How We Work'])[1]");
        private By whoWeWorkWith = By.XPath("//a[text()='Who We Work With']");
        private By howwrkwith = By.XPath("(//a[@href='#'])[1]");
        private By enterprise = By.XPath("//ul[contains(@class,'sub-menu')]//a[text()='Enterprises']");
        private By partnerships = By.XPath("//ul[contains(@class,'sub-menu')]//a[text()='Partnerships']");
        private By staffAgency = By.XPath("(//ul[contains(@class,'sub-menu')]//a[text()='Staffing Agencies'])[1]");
        private By smallMedBusiness = By.XPath("(//ul[contains(@class,'sub-menu')]//a[text()='SMBs'])[1]");
        private By stratAlliances = By.XPath("//ul[contains(@class,'sub-menu')]//a[text()='Strategic Alliances']");
        private By pricing = By.XPath("(//a[text()='Pricing'])[1]");
        private By about = By.XPath("(//a[text()='About'])[1]");
        private By carrers = By.XPath("(//a[text()='Careers'])[1]");
        private By blog = By.XPath("(//a[text()='Blog'])[1]");
        private By signin = By.XPath("(//a[text()='Sign In'])[1]");
        private By tryitnow = By.XPath("(//a[text()='Try It Now'])[1]");
        private By EnterpirseHeader = By.XPath("//h1[text()='Enterprise']");
        private By partnershipsHeader = By.XPath("//h1[text()='Partnerships']");
        private By staffAgencyHeader = By.XPath("//h1[text()='Staffing Recruitment Solutions']");
        private By smallMedBussinessHeader = By.XPath("//h1[text()='Small to Medium Business']");
        private By alliancesheader = By.XPath("//h1[text()='Alliances']");



        private const string EnterpriseLink = "Enterprises";
        private const string PartnershipsLink = "Partnerships";
        private const string StaffAgencyLink = "Staffing Agencies";
        private const string SmallMedBusinessLink = "SMBS";
        private const string StratAlliancesLink = "Strategic Alliances";
        public JobiakMainLinks(IWebDriver driver) : base(driver)
        {
           
        }
        public void clickonHowItWorks()
        {
            var work = WaitForElementToBeClickeable(howitworks);
            JavaScriptClick(work);
            Pause(5);
        }


        public void clickonLinksInsideWhoWeWorkWith(string ReqLinkName)

        {
            IWebElement eleE = WaitForElementToBeClickeable(whoWeWorkWith,5);
            MoveToViewElement(eleE);

            var local = ReqLinkName.ToLower();
            if (local.Equals(EnterpriseLink.ToLower()))
            {
                var ele = WaitForElementToBeClickeable(enterprise, 5);

                MoveToElementAndClick(ele);
            }
            else if (local.Equals(PartnershipsLink.ToLower())) {
                var ele = WaitForElementToBeClickeable(partnerships, 5);

                MoveToElementAndClick(ele);
            }
            else if (local.Equals(StaffAgencyLink.ToLower()))
            {
                var ele = WaitForElementToBeClickeable(staffAgency, 5);

                MoveToElementAndClick(ele);
            }
            else if (local.Equals(SmallMedBusinessLink.ToLower()))
            {
                var ele = WaitForElementToBeClickeable(smallMedBusiness, 5);

                MoveToElementAndClick(ele);
            }
            else if (local.Equals(StratAlliancesLink.ToLower()))
            {
                var ele = WaitForElementToBeClickeable(stratAlliances, 5);

                MoveToElementAndClick(ele);
            }

            
        }

        public void ValidateNavigationToRequiredPageBasedOnLinkName(string ReqLinkName)

        {
            
            var local = ReqLinkName.ToLower();
            if (local.Equals(EnterpriseLink.ToLower()))
            {
                var ele = WaitForElementToBeVisible(EnterpirseHeader, 5);
                Debug.Assert(ele.Displayed);

                
           }
            else if (local.Equals(PartnershipsLink.ToLower()))
            {
                var ele = WaitForElementToBeClickeable(partnershipsHeader, 5);

                MoveToElementAndClick(ele);
            }
            else if (local.Equals(StaffAgencyLink.ToLower()))
            {
                var ele = WaitForElementToBeClickeable(staffAgencyHeader, 5);

                MoveToElementAndClick(ele);
            }
            else if (local.Equals(SmallMedBusinessLink.ToLower()))
            {
                var ele = WaitForElementToBeClickeable(smallMedBussinessHeader, 5);

                MoveToElementAndClick(ele);
            }
            else if (local.Equals(StratAlliancesLink.ToLower()))
            {
                var ele = WaitForElementToBeClickeable(alliancesheader, 5);

                MoveToElementAndClick(ele);
            }


        }

        public void clickonPricing()
        {
            var Pricing = WaitForElementToBeClickeable(pricing);
            JavaScriptClick(Pricing);
            Pause(5);
        }
        public void clickonAbout()
        {
            var About = WaitForElementToBeClickeable(about);
            JavaScriptClick(About);
            Pause(5);
        }
        public void clickonCarrers()
        {
            var car = WaitForElementToBeClickeable(carrers);
            JavaScriptClick(car);
            Pause(5);
        }
        public void clickonBlog()
        {
            var Blog = WaitForElementToBeClickeable(blog);
            JavaScriptClick(Blog);
            Pause(5);
        }
        public void clickonSignin()
        {
            var sig = WaitForElementToBeClickeable(signin);
            JavaScriptClick(sig);
            Pause(10);
            driver.Navigate().Back();
            Pause(10);
        }
        public void clickonTryitnow()
        {
            var cli= WaitForElementToBeClickeable(tryitnow);
            JavaScriptClick(cli);
            Pause(10);
        }
        public void clickOnWhoWeWorkWith()
        {

            IWebElement ele = WaitForElementToBeVisible(howwrkwith, 2);
            Thread.Sleep(300);
            JavaScriptClick(ele);
            Thread.Sleep(300);
            //string ReqEditButtonXpath = "(//a[text(),\"" + categoriesName + "\"])[1]";

            IWebElement enterprse = WaitForElementToBeClickeable(enterprise, 6);
            Thread.Sleep(300);
            JavaScriptClick(enterprse);
            Thread.Sleep(300);

        }







    }
}
