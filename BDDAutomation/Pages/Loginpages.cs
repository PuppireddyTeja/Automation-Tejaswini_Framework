using OpenQA.Selenium;
using System.Threading;
using System;
using BDDAutomation.Test_Framework.Core;
using BDDAutomation.Pages;

namespace BDDAutomation.Pages
{
    public class Loginpages : PageBase
    {
           //Page title
        private static string pageTitle = "Portal";

        //private By usernameInputs = By.XPath("//div[label[text()='USERNAME']]//input");

        public Loginpages(IWebDriver driver) : base(driver)
        {
        }
    }
}
