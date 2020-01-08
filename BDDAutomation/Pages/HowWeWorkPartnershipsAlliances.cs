using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDAutomation.Pages
{
    class HowWeWorkPartnershipsAlliances : PageBase
    {
        private By howwework = By.XPath("(//a[text()='How We Work'])[1]");
        private By whoWeWorkWith = By.XPath("(//a[text()='Who We Work With'])[1]");
        private By hwctctusstrted = By.XPath("//a[text()='Contact Us to Get Started']");
        private By partnerships = By.XPath("(//ul[contains(@class,'sub-menu')]//a[text()='Partnerships'])[1]");
        private By pctctusstrted1 = By.XPath("(//a[text()='Contact Us to Get Started'])[1]");
        private By pctctusstrted2 = By.XPath("(//a[text()='Contact Us to Get Started'])[2]");
        private By stratAlliances = By.XPath("//ul[contains(@class,'sub-menu')]//a[text()='Strategic Alliances']");
        private By Allctctusstrted = By.XPath("//a[contains(@class,'mk-button')]");

        public HowWeWorkPartnershipsAlliances(IWebDriver driver) : base(driver)
        {
        }
        public void clickonHowweWork()
        {
            var work = WaitForElementToBeClickeable(howwework);
            JavaScriptClick(work);
            Pause(5);
        }
        public void clickonHowweworkContactusGetStarted()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,11000)");
            Pause(5);
            var ele1 = WaitForElementToBeClickeable(hwctctusstrted, 5);
            MoveToElementAndClick(ele1);
        }
        public void clickonPartnership()
        {
            IWebElement eleE = WaitForElementToBeClickeable(whoWeWorkWith, 5);
            MoveToViewElement(eleE);
            var ele = WaitForElementToBeClickeable(partnerships, 5);
            MoveToElementAndClick(ele);
        }
        public void clickonPartnershipContactusGetStarted()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,1000)");
            Pause(5);
            var ele1 = WaitForElementToBeClickeable(pctctusstrted1, 5);
            MoveToElementAndClick(ele1);
            driver.Navigate().Back();

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,5500)");
            Pause(5);
            var ele2 = WaitForElementToBeClickeable(pctctusstrted2, 5);
            MoveToElementAndClick(ele2);
        }
        public void ClickOnStartAllainces()
        {
            IWebElement eleE = WaitForElementToBeClickeable(whoWeWorkWith, 5);
            MoveToViewElement(eleE);
            var ele = WaitForElementToBeClickeable(stratAlliances, 5);

            MoveToElementAndClick(ele);

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,5500)");
            Pause(5);
        }
        public void ClickOnStartAllaincesContactusGetStarted()
        {
            var ele1 = WaitForElementToBeClickeable(Allctctusstrted, 5);
            MoveToElementAndClick(ele1);

        }
    }
}
