using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDAutomation.Pages
{
    class Carrers : PageBase
    {
        private By carrers = By.XPath("(//a[text()='Careers'])[1]");
        private By applynow1 = By.XPath("(//span[text()='Apply Now'])[1]");
        private By applynow2 = By.XPath("(//span[text()='Apply Now'])[2]");
        private By applynow3 = By.XPath("(//span[text()='Apply Now'])[3]");
        private By applynow3header = By.XPath("//h1[text()='Come, join the team!']");



     public Carrers(IWebDriver driver) : base(driver)
        {

        }
        public void ClickOnCarrers()
        {
            var ele1 = WaitForElementToBeClickeable(carrers, 7);
            MoveToElementAndClick(ele1);
        }
        public void ClickonApplyButton1()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,500)");

            var ele1 = WaitForElementToBeClickeable(applynow1, 6);
            MoveToElementAndClick(ele1);
            driver.Navigate().Back();
        }
        public void ClickonApplyButton2()
        {
            var ele1 = WaitForElementToBeClickeable(applynow2, 4);
            MoveToElementAndClick(ele1);
            driver.Navigate().Back();

        }
        public void ClickonApplyButton3()
        {
            var ele1 = WaitForElementToBeClickeable(applynow3, 4);
            MoveToElementAndClick(ele1);

            var ele2 = WaitForElementsToBeVisible(applynow3header, 3);

        }

    }
}
