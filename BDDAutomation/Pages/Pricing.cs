using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDAutomation.Pages
{
    class Pricing : PageBase
    {
        private By pricing = By.XPath("(//a[text()='Pricing'])[1]");
        private By plan1 = By.XPath("//div[@id='price-item-1']");
        private By contactusstrtd = By.XPath("(//a[text()='Contact Us to Get Started'])[1]");
        private By smb = By.XPath("(//span[text()='Small-Medium Business'])[1]");
        private By basic = By.XPath("(//div[@id='price-item-1'])[2]");
        private By pro = By.XPath("(//div[@id='price-item-2'])[2]");
        private By feature = By.XPath("(//div[@id='price-item-3'])[2]");
        private By partnerships = By.XPath("(//span[text()='Partnerships'])[1]");
        private By prnershpscntctusgetstartd = By.XPath("(//a[text()='Contact Us to Get Started'])[2]");
        private By about = By.XPath("(//a[text()='About'])[1]");
        private By aboutstrtpstng = By.XPath("//a[contains(@class,'mk-button')]");

        public Pricing(IWebDriver driver) : base(driver)
        {

        }
        public void clickonPricing()
        {
            IWebElement eleE = WaitForElementToBeClickeable(pricing, 5);
            MoveToViewElement(eleE);
            JavaScriptClick(eleE);
            Pause(2);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,1700)");

        }
        public void clickonContactUsGetStarted()
        {
          ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,400)");

                var ele1 = WaitForElementToBeClickeable(contactusstrtd, 5);
                MoveToElementAndClick(ele1);
                //JavaScriptClick(ele1);

            }
        public void NavigateBackToGivenPage()
        {
            driver.Navigate().Back();
        }
        public void ClickOnSMBPlan()
        {
            var ele1 = WaitForElementToBeClickeable(smb, 5);
            MoveToElementAndClick(ele1);
            JavaScriptClick(ele1);
            Pause(2);
        }
        public void ClickOnBasicplan()
        {
            var ele1 = WaitForElementToBeClickeable(basic, 5);
            MoveToElementAndClick(ele1);
            JavaScriptClick(ele1);
            Pause(2);
        }
        public void ClickOnProplan()
        {
            var ele1 = WaitForElementToBeClickeable(pro, 5);
            MoveToElementAndClick(ele1);
            JavaScriptClick(ele1);
            Pause(2);
        }
        public void ClickOnFeatureplan()
        {
            var ele1 = WaitForElementToBeClickeable(feature, 5);
            MoveToElementAndClick(ele1);
            JavaScriptClick(ele1);
            Pause(2);
        }
        public void ClickOnPartnerships()
        {
            var ele1 = WaitForElementToBePresent(partnerships, 10);
            MoveToElementAndClick(ele1);
            JavaScriptClick(ele1);
        }
        public void ClickOnPartnershipsContactUsGetStarted()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,400)");

            var ele2 = WaitForElementToBePresent(prnershpscntctusgetstartd, 10);
            MoveToElementAndClick(ele2);
        }
        public void ClickOnAbout()
        {
            var ele1 = WaitForElementToBeClickeable(about, 7);
            MoveToElementAndClick(ele1);
        }
        public void clickOnStartPosting()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,800)");
            var ele1 = WaitForElementToBeClickeable(aboutstrtpstng, 10);
            MoveToElementAndClick(ele1);
        }


    }
    }

