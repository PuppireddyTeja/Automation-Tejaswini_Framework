using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BDDAutomation.Pages
{
    class SupportUserManagement : PageBase
    {
        private By Signcredentials = By.XPath("//a[text()='Sign In']");
        private By usernameInput = By.XPath("//input[@id='inputWorkEmail']");
        private By passwordInput = By.XPath("//input[@id='inputPassword']");
        private By sigin = By.XPath("//button[contains(text(),'Sign')]");
        private By supportdashboardlink = By.XPath("//span[text()='Support User Management']");
        private By Assigneduser = By.XPath("(//input[@aria-label='Assigned User'])[2]");
        private By editIconList = By.CssSelector("tbody tr td>i");
        private By notAssignedVal = By.XPath("(//div[text()='Not Assigned'])[1]");
        private By clientIdList = By.CssSelector("tbody tr td:nth-child(2)");
        private By availableUsersList = By.XPath("(//div[@role='list'])[1]//div[@class='v-list__tile__title']");
        private By AssignDropdown = By.XPath("(//label[text()='Assigned User'])[1]");
        private By Userdropdown = By.XPath("(//div[@role='listitem'])[1]");
        private By save = By.XPath("//div[contains(text(),'Save')]");

        public static string ClientID;

        public SupportUserManagement(IWebDriver driver) : base(driver)
        {
            try
            {
                this.WaitForBlockOverlayToDissapear();
                this.WaitForElementToBeVisible(supportdashboardlink).Click();
            }
            catch (Exception)
            {
                this.Reload();
                this.WaitForBlockOverlayToDissapear();
                this.WaitForElementToBeVisible(supportdashboardlink).Click();
            }
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
        public void clickOnsupportUserManagementLink()
        {
            IWebElement ele = WaitForElementToBeClickeable(supportdashboardlink);
            JavaScriptClick(ele);


        }
        public void selectNotAssignedFromAssignedUserDropDownToViewAllNotAssignedJobs()
        {
            IWebElement ele = WaitForElementToBeClickeable(Assigneduser);
            JavaScriptClick(ele);
            IWebElement ele1 = WaitForElementToBeClickeable(notAssignedVal);
            JavaScriptClick(ele1);
        }
        public void pickRandomClientIdFromAvailableNotAssingedJobsAndClickEdit()
        {
                
            IList<IWebElement> IdList = WaitForListOfElementsToBeVisible(clientIdList, 5);
            int totalCIds = IdList.Count;
            ClientID = IdList[new Random().Next(totalCIds)].Text.Trim();
            Console.WriteLine("Client ID is :\t" + ClientID);

            string reqEditIconXpath = "//td[text()=\"" + ClientID + "\"]/following-sibling::td/i";

            IWebElement reqWebEle = WaitForElementToBeVisible(reqEditIconXpath, 5);
            JavaScriptClick(reqWebEle);

        }
        public void SelectAssignUserfromDropdownandclicksaveButton()
        {
            IWebElement ele = null;

            ele = WaitForElementToBeClickeable(AssignDropdown);
            JavaScriptClick(ele);
            ele = WaitForElementToBeClickeable(Userdropdown);
            JavaScriptClick(ele);
            ele = WaitForElementToBeClickeable(save);
            JavaScriptClick(ele);
        }



    }
}
