using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDAutomation.Pages
{
    class WhoWeWorkWithLinkEnterprise : PageBase
    {
        private By whoWeWorkWith = By.XPath("(//a[text()='Who We Work With'])[1]");
        private By enterprise = By.XPath("//ul[contains(@class,'sub-menu')]//a[text()='Enterprises']");
        private By plan1 = By.XPath("//div[@id='price-item-1']");
        private By plan2 = By.XPath("//div[@id='price-item-2']");
        private By plan3 = By.XPath("//div[@id='price-item-3']");
        private By plan4 = By.XPath("//div[@id='price-item-4']");
        private By plan5 = By.XPath("//div[@id='price-item-5']");
        private By plan5contactus = By.XPath("(//a[text()='Contact Us'])[1]");
        private By contactusgetstarted = By.XPath("(//a[contains(text(),'Contact Us to Get Started')])[2]");
        private By frstname = By.XPath("//input[@name='firstname']");
        private By lstname = By.XPath("//input[@name='lastname']");
        private By email = By.XPath("//input[@name='email']");
        private By company = By.XPath("//input[@name='company']");
        private By phne = By.XPath("(//input[@class='hs-input'])[1]");
        private By salecontacting = By.XPath("//select[@name='reason_for_contact']");
        private By jobmonth = By.XPath("//select[@name='open_jobs_per_month']");

        public WhoWeWorkWithLinkEnterprise(IWebDriver driver) : base(driver)
        {

        }
        public void clickonWhoWeWorkWithAndEnterprise()
        {
            IWebElement eleE = WaitForElementToBeClickeable(whoWeWorkWith, 5);
            MoveToViewElement(eleE);
            var ele = WaitForElementToBeClickeable(enterprise, 5);
            MoveToElementAndClick(ele);
        }
        public void Clickonplan1()
        {
            var ele = WaitForElementToBeClickeable(plan1, 5);
            MoveToElementAndClick(ele);
        }
        public void Clickonplan2()
        {
            var ele = WaitForElementToBeClickeable(plan2, 5);
            MoveToElementAndClick(ele);
        }
        public void Clickonplan3()
        {
            
            var ele = WaitForElementToBeClickeable(plan3, 5);
            MoveToElementAndClick(ele);
        }
        public void Clickonplan4()
        {
            
            var ele = WaitForElementToBeClickeable(plan4, 5);
            MoveToElementAndClick(ele);
        }
        public void Clickonplan5()
        {
           
            var ele = WaitForElementToBeClickeable(plan5, 5);
            MoveToElementAndClick(ele);
            var ele1 = WaitForElementToBeClickeable(plan5contactus, 10);
            MoveToElementAndClick(ele1);
            //JavaScriptClick(ele1);
        }
        public void ClickonContactusgetstarted()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,300)");

            var ele1 = WaitForElementToBeClickeable(contactusgetstarted, 5);
            MoveToElementAndClick(ele1);

        }
        public void EnterAllContactpageFields()
        {
            WaitForElementToBeClickeable(frstname).SendKeys("Tejaswini");
            Pause(2);
            WaitForElementToBeClickeable(lstname).SendKeys("Reddy");
            Pause(2);
            WaitForElementToBeClickeable(email).SendKeys("tejaswini.reddy13@gmail.com");
            Pause(2);
            WaitForElementToBeClickeable(company).SendKeys("Wipro");
            Pause(2);
            SelectElementWithByAndText(salecontacting, "Sales");
            Pause(2);
            SelectElementWithByAndText(jobmonth, "Below 99");
            Pause(2);
            }
        public void ScrollDownToParticularHeight()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,5500)");
            Pause(3);
        }



    }
}
