using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDAutomation.Pages
{
    class JobiakBottomLinks : PageBase
    {
        private By Free=By.XPath("//li[@id='menu-item-7329']/a[@href='https://www.jobiak.ai/try-it-now/']");
        private By About=By.XPath("(//a[@href='https://www.jobiak.ai/about/'])[3]");
        private By Blog=By.XPath("(//a[@href='https://www.jobiak.ai/blog/'])[3]");
        private By enterprise=By.XPath("(//a[@href='https://www.jobiak.ai/enterprise/'])[4]");
        private By smb=By.XPath("(//a[@href='https://www.jobiak.ai/smb/'])[3]");
        private By Howworks=By.XPath("(//a[@href='https://www.jobiak.ai/how-it-works/'])[3]");
        private By chkr=By.XPath("(//a[@href='https://www.jobiak.ai/google-job-check/'])");
        private By email = By.XPath("//input[@name='email']");
        private By postingurl = By.XPath("//input[@name='website']");
        private By submit = By.XPath("//button[text()='Submit']");

        private By contact=By.XPath("(//a[@href='https://www.jobiak.ai/contact-us/'])");
        private By price=By.XPath("(//a[@href='https://www.jobiak.ai/pricing/'])[1]");
        private By faq=By.XPath("//a[@href='https://www.jobiak.ai/faq/']");
        private By policy=By.XPath("(//a[@href='https://www.jobiak.ai/privacy-policy/'])");
        private By termsservice = By.XPath("(//a[@href='https://www.jobiak.ai/terms-of-service/'])");
        private By cookiepol=By.XPath("(//a[@href='https://www.jobiak.ai/cookie-policy/'])[1]");
        private By marketingTool = By.XPath("//a[@href='https://www.jobiak.ai/marketing-tool/']");
        private By marketingtoolheader = By.XPath("//h3[text()='Already using Google for jobs?']");

        public JobiakBottomLinks(IWebDriver driver) : base(driver)
        {

        }
        public void clickonBottomLinks()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,7000)");
            Pause(5);

            IWebElement ele = null;

            /*ele = WaitForElementToBeClickeable(Free);
           MoveToElementAndClick(ele);
           Pause(5);
           driver.Navigate().Back();
           Pause(10);
           ele = WaitForElementToBeClickeable(About);
           JavaScriptClick(ele);
           Pause(5);
           driver.Navigate().Back();
           Pause(10);
           ele = WaitForElementToBeClickeable(Blog);
           JavaScriptClick(ele);
           Pause(5);
           driver.Navigate().Back();
           Pause(10);
           ele = WaitForElementToBeClickeable(enterprise);
           JavaScriptScrollIntoView(ele);
           Pause(5);*/

           ele = WaitForElementToBeClickeable(smb);
           JavaScriptScrollIntoView(ele);
           Pause(7);
           

            ele = WaitForElementToBeClickeable(Howworks);
            JavaScriptClick(ele);
            Pause(5);
            driver.Navigate().Back();
            Pause(10);

            ele=WaitForElementToBeClickeable(contact);
            JavaScriptClick(ele);
            Pause(5);
            driver.Navigate().Back();
            Pause(6);

            ele=WaitForElementToBeClickeable(faq);
            MoveToElementAndClick(ele);
            JavaScriptClick(ele);
            Pause(5);
            driver.Navigate().Back();
            Pause(6);

            ele = WaitForElementToBeClickeable(policy);
            JavaScriptClick(ele);
            Pause(5);
            driver.Navigate().Back();
            Pause(10);


            ele = WaitForElementToBeClickeable(termsservice);
            JavaScriptClick(ele);
            Pause(5);
            driver.Navigate().Back();
            Pause(10);


            ele = WaitForElementToBeClickeable(cookiepol);
            JavaScriptClick(ele);
            Pause(5);
            driver.Navigate().Back();
            Pause(10);

            ele = WaitForElementToBeClickeable(chkr);
            JavaScriptClick(ele);
            Pause(5);
            WaitForElementToBeClickeable(email).SendKeys("tejaswini@jobiak.ai");
            Pause(2);
            WaitForElementToBeClickeable(postingurl).SendKeys("https://www.amazon.jobs/en-gb/jobs/999622/applied-scientist");
            Pause(2);

           ele =WaitForElementToBeClickeable(submit);
            JavaScriptClick(ele);
            Pause(6);
            driver.Navigate().Back();
            Pause(5);

            ele = WaitForElementToBeClickeable(marketingTool);
            JavaScriptClick(ele);
            Pause(5);
            driver.Navigate().Back();
            Pause(10);

        }



    }
}
