using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BDDAutomation.Pages
{
    class AddCompany : PageBase
    {
        private By usernameInput = By.XPath("//input[@id='inputWorkEmail']");
        private By passwordInput = By.XPath("//input[@id='inputPassword']");
        private By sigin = By.XPath("//button[contains(text(),'Sign')]");
        private By Signcredentials = By.XPath("//a[text()='Sign In']");
        private By jobapprovalpage = By.XPath("//span[text()='Job Approval Page']");
        private By companies = By.XPath("//a[text()='Companies']");
        private By Addnewcompany = By.XPath("//div[text()='Add New Company']");
        private By employer = By.XPath("(//input[@aria-label='Employer'])[1]/following-sibling::div//i[text()='arrow_drop_down']");
        private By Addcompanyname=By.XPath("(//input[@aria-label='Company Name'])[1]");
        private By save = By.XPath("(//div[contains(text(),'Save')])[1]");
        private By searchbox = By.XPath("(//input[@aria-label='Search with in result below'])[4]");
        private By companynamecolumn = By.XPath("(//th[text()='Company Name'])[3]");
        private By rating = By.XPath("(//input[@aria-label='Rating Count'])[1]");

        public AddCompany(IWebDriver driver) : base(driver)
        {
            try
            {
                
               
            }
            catch (Exception)
            {
               
            }
        }
        public void Usernametext()
        {
            Thread.Sleep(1000);
            WaitForElementToBeClickeable(usernameInput, 5).SendKeys("mohan@jobiak.ai");
        }
        public void Passwordtext()
        {
            Thread.Sleep(1000);
            WaitForElementToBeClickeable(passwordInput, 5).SendKeys("mohan@123");
        }
        public void siginButton()
        {
            WaitForElementToBeClickeable(sigin).Click();
        }
        public void clickSignCredentials()
        {
            WaitForElementToBeClickeable(Signcredentials).Click();
        }
        public void FillOutSignForm(string username, string password)
        {
            IWebElement usernameWE = this.WaitForElementToBeVisible(usernameInput);
            usernameWE.Click();
            ClearAndType(usernameWE, username);
            ClearAndType(WaitForElementToBeVisible(passwordInput), password);
        }
        /*public void clickOnJobApprovalPageLink()
        {
            WaitForElementToBeClickeable(jobapprovalpage).Click();
        }*/
        public void clickOnCompaniesAddnewCompanyLink()
        {
            JavaScriptClick(companies);
            WaitForElementToBeClickeable(Addnewcompany).Click();
            Pause(2);
        }
        public void clickAndselectEmployerFromDropdown()

        {
            WaitForElementToBeClickeable(employer, 5);
            JavaScriptClick(employer);
            string ReqEditbuttonXpath = "(//div[@role='list'])[5]/div[@role='listitem'][20]";
            string reqText = WaitForElementToBeClickeable(ReqEditbuttonXpath, 2).Text;
            string reqXpath = "(//div[@role='list'])[5]//div[text()=\"" + reqText + "\"]/parent::div";

            IWebElement reqWebEle = driver.FindElement(By.XPath(reqXpath));
            JavaScriptScrollIntoView(reqWebEle);
            reqWebEle.Click();
        }
        public void EnterAndEditCompany()
        { 

            //JavaScriptClick(reqWebEle);
            string randString = GenerateRandomString(10);
            WaitForElementToBeClickeable(Addcompanyname).Click();
            MoveToViewElementandSAndkeys(Addcompanyname, randString);

            IWebElement ele = WaitForElementToBeClickeable(save);
            JavaScriptClick(ele);
            Pause(5);

            WaitForElementToBeClickeable(searchbox).Clear();
            JavaScriptClick(searchbox);
            WaitForElementToBeClickeable(searchbox).SendKeys(randString);
            Pause(2);
        
            string reqXpathForEditIcon = "//td[text()=\"" + randString + "\"]/following::td/i";
            IWebElement req = driver.FindElement(By.XPath(reqXpathForEditIcon));
            JavaScriptClick(req);

            var el = WaitForElementToBeClickeable(rating);
            JavaScriptClick(el);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].value = '';", el);
            el.SendKeys("3");
}
        public void ClickOnSave()
        {
            IWebElement ele = WaitForElementToBeClickeable(save);
            JavaScriptClick(ele);
            Pause(5);
        }
       





    }
    }
