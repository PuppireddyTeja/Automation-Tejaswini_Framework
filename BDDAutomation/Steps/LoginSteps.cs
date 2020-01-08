using BDDAutomation.Pages;
using BDDAutomation.Test_Framework.Core;
using BDDAutomation.Steps;
using FluentAssertions;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using System;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace BDDAutomation.Steps.Login
{
    [Binding]
    public class LoginSteps:StepBase
    {
        private Loginpage loginPage = null;

        public LoginSteps() {
            loginPage = new Loginpage(driver);
        }

        [Given(@"I enter to Portal Login page")]
        public void GivenIEnterToPortalLoginPage()
        {
            try
            {

                //If user is not logged in, login page is loaded by default                               
                loginPage = new Loginpage(driver);
                loginPage.Reload();

            }

            catch (MissingElementException)
            {
                //if user is already logged in then homepage is loaded, so Logout and go to login page
                PageBase navigationBar = new PageBase(driver);
                loginPage = navigationBar.Logout();
                //dashboardPage = null;
            }


        }

        [When(@"I try to login with credentials (.*) and (.*)")]
        public void WhenITryToLoginWithCredentials(string username , string password)
        {
            loginPage.FillOutLoginForm(username, password);
            loginPage.ClickOnLoginButton();
        }
        [Given(@"I enter username")]
        public void GivenIEnterUsername()
        {
            loginPage.usernametext();
        }
        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
            loginPage.passwordtext();
        }
        [Given(@"I click on login button")]
        public void GivenIClickOnLoginButton()
        {
            loginPage.ClickOnLoginButton();
        }
        [Then(@"I click on Logout")]
        public void ThenIClickOnLogout()
        {
            Console.WriteLine("Logged in Sucess");
            loginPage.ClickOnLogOutButton();
        }

        [When(@"I click on All the pages are avaibale in the page")]
        public void WhenIClickOnAllThePagesAreAvaibaleInThePage()
        {
            loginPage.ClickOnAllPages();
        }
        [Then(@"user click on Logout")]
        public void ThenuserClickOnLogout()
        {
            Console.WriteLine("Logged in Sucess");
            loginPage.ClickOnLogOut();
        }
    }


}