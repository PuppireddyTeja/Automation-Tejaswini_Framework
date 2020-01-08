using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDAutomation.Pages
{
    class SMBSPlan : PageBase
    {
        private By whoWeWorkWith = By.XPath("(//a[text()='Who We Work With'])[1]");
        private By smallMedBusiness = By.XPath("(//ul[contains(@class,'sub-menu')]//a[text()='SMBs'])[1]");
        private By learnmrebtn=By.XPath("(//a[contains(@class,'mk-button')])[1]");
        private By technolgyheader = By.XPath("//h1[text()='Our Technology']");
        private By learnmorebutn1 = By.XPath("(//a[contains(@class,'mk-button')])[3]");
        private By basic = By.XPath("//div[@id='price-item-1']");
        private By pro = By.XPath("//div[@id='price-item-2']");
        private By featre = By.XPath("//div[@id='price-item-3']");
        private By tryitnwbasic = By.XPath("(//a[text()='Try It Now'])[1]");
        private By tryitnwpro = By.XPath("(//a[text()='Try It Now'])[2]");
        private By tryitnwfeatre = By.XPath("(//a[text()='Try It Now'])[3]");
        private By strtpstngBasicplan = By.XPath("(//a[text()='Start Posting'])[1]");
        private By strtpstngproplan = By.XPath("(//a[text()='Start Posting'])[2]");
        private By strtpstngfeatureplan = By.XPath("(//a[text()='Start Posting'])[3]");




        public SMBSPlan(IWebDriver driver) : base(driver)
        {
        }
        public void ClickOnWhoWeWorkWith()
        {
            IWebElement eleE = WaitForElementToBeClickeable(whoWeWorkWith, 5);
            MoveToViewElement(eleE);
        }
        public void ClickOnSMBS()
        {
            IWebElement eleE = WaitForElementToBeClickeable(smallMedBusiness, 7);
            MoveToViewElement(eleE);
            JavaScriptClick(eleE);
        }
        public void clickonLearnMoreButton()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,700)");

            IWebElement eleE = WaitForElementToBeClickeable(learnmrebtn, 5);
            MoveToViewElement(eleE);
            JavaScriptClick(eleE);
             WaitForElementToBeVisible(technolgyheader, 5);
           
        }
        public void clickonLearnMoreButton1()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,1500)");
            IWebElement eleE = WaitForElementToBeClickeable(learnmorebutn1, 5);
            MoveToViewElement(eleE);
            JavaScriptClick(eleE);

        }
        public void clickonBasicPlan()
        {

            IWebElement eleE = WaitForElementToBeClickeable(basic, 5);
            MoveToViewElement(eleE);
            JavaScriptClick(eleE);
        }
        public void clickonProPlan()
        {

            //IWebElement eleE = WaitForElementToBeClickeable(pro, 5);
            //MoveToViewElement(eleE);
            //JavaScriptClick(eleE);

        }
        public void clickonFeaturePlan()
        {
            IWebElement eleE = WaitForElementToBeClickeable(featre, 5);
            MoveToViewElement(eleE);
            JavaScriptClick(eleE);

        }

        public void ClickOnTryItNowForBasicPlan()
        {

            IWebElement ele1 = WaitForElementToBeClickeable(tryitnwbasic, 5);
            MoveToViewElement(ele1);
            JavaScriptClick(ele1);
        }
        public void ClickOnTryItNowForProPlan()
        {

            IWebElement ele1 = WaitForElementToBeClickeable(tryitnwpro, 5);
            MoveToViewElement(ele1);
            JavaScriptClick(ele1);
        }
        public void ClickOnTryItNowForFeaturePlan()
        {

            IWebElement ele1 = WaitForElementToBeClickeable(tryitnwfeatre, 5);
            MoveToViewElement(ele1);
            JavaScriptClick(ele1);
        }
        public void ClickonStartPostingForBasicPlan()
        {
            IWebElement ele1 = WaitForElementToBeClickeable(strtpstngBasicplan, 5);
            MoveToViewElement(ele1);
            JavaScriptClick(ele1);

        }
        public void ClickonStartPostingForProPlan()
        {
            IWebElement ele1 = WaitForElementToBeClickeable(strtpstngproplan, 5);
            MoveToViewElement(ele1);
            JavaScriptClick(ele1);

        }
        public void ClickonStartPostingFoFeaturePlan()
        {
            IWebElement ele1 = WaitForElementToBeClickeable(strtpstngfeatureplan, 5);
            MoveToViewElement(ele1);
            JavaScriptClick(ele1);

        }
        public void CloseDriver()
        {
            driver.Close();
        }
        public void windowscroolsToGivenHeightParticularPlans()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,3200)");

        }









    }
}
