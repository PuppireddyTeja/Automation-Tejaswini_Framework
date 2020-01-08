using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BDDAutomation.Pages
{
    class MultipleJobUrl : PageBase
    {
        private By usernameInput = By.XPath("//input[@id='inputWorkEmail']");
        private By passwordInput = By.XPath("//input[@id='inputPassword']");
        //private By sigin = By.XPath("//button[contains(text(),'Sign')]");
        private By Signcredentials = By.XPath("//a[text()='Sign In']");
        private By addjob = By.XPath("//span[text()='Add Job']");
        private By multiplejob = By.XPath("//input[@id='careersiteurl']");
        private By postjobs = By.XPath("//button[text()='Post jobs']");
        //Add sigin credentials
        private By closepopup = By.XPath("//div[@id='modal-jobiak-guide']//div[@class='modal-content']//button[@class='close']/span");
        private By plusicons = By.XPath("//i[text()='+']");
        private By clickpreview = By.XPath("//button[contains(text(),'Preview')]");
        private By selectjobsheading = By.XPath("//h1[text()='Select jobs to post']");

        private By checkBox = By.XPath("//div[@class='checkbox-custom checkbox-success checkbox-unchecked']//input[@id='inputchecked0']/following-sibling::label");

        private By iFrameJobs = By.XPath("(//iframe)[1]");

        public MultipleJobUrl(IWebDriver driver) : base(driver)
        {
            try
            {
               // this.WaitForBlockOverlayToDissapear();
                //this.WaitForElementToBeVisible(jobapprovalpage).Click();
            }
            catch (Exception)
            {
                // this.Reload();
               // this.WaitForBlockOverlayToDissapear();
                //this.WaitForElementToBeVisible(jobapprovalpage).Click();
            }
        }
        
        public void clickonAddJob()
        {
            WaitForElementToBeClickeable(addjob).Click();
        }
        public void clickonmultipeAndpostjob()
        {
            IWebElement ele = WaitForElementToBeClickeable(multiplejob, 15);
            JavaScriptClick(ele);
            Thread.Sleep(300);
            ele.SendKeys("https://careers.ibm.com/ListJobs/All/?lang=en");

            WaitForElementToBeClickeable(postjobs).Click();
        }
        public void clickonPopup()
        {
            try
            {
                IWebElement popup = WaitForElementToBeClickeable(closepopup, 20);
                JavaScriptClick(popup);
                //Thread.Sleep(3000);
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }

      
public void selectplusicons()
        {
            IWebElement wEle = WaitForElementToBeVisible(iFrameJobs, 10);
            driver.SwitchTo().Frame(wEle);
            IList<IWebElement> icons = WaitForListOfElementsToBeVisible(plusicons, 10);
            int count = icons.Count;         
            for (int i = 0; i <3; i++) {
                Pause(1);
                JavaScriptScrollIntoView(icons[i]);
                Pause(1);
                JavaScriptClick(icons[i]);
                Pause(1);

            }
            
            Thread.Sleep(5000);

            driver.SwitchTo().DefaultContent();

        }
        public void clickonpreview()
        {
            IWebElement ex = WaitForElementToBeClickeable(clickpreview, 60);
            JavaScriptClick(ex);
            switchToChildWindow();
            
            IWebElement chck = WaitForElementToBeClickeable(checkBox, 10);
            JavaScriptClick(chck);

        }

        public void switchToChildWindow()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(2000);
            WaitForElementsToBePresent(selectjobsheading, 200);


        }


    }
}
