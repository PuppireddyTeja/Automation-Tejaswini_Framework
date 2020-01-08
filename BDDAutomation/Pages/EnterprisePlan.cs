using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDAutomation.Pages
{
    class EnterprisePlan : PageBase
    {
        private By customeronboarding = By.XPath("//span[text()='Customer Onboarding']");
        private By createaccount = By.XPath("//button[@onclick='createNewAccount()']");
        private By Email = By.XPath("//input[@name='email']");
        private By password = By.XPath("//input[@name='password']");
        private By fstname = By.XPath("//input[@name='firstName']");
        private By Lstname = By.XPath("//input[@name='lastName']");
        private By phneno = By.XPath("//input[@id='phoneNoId']");
        private By compnyname = By.XPath("//input[@id='inputCompanyName']");
        private By Website = By.XPath("//input[@id='siteId']");
        private By Address = By.XPath("//textarea[@id='inputAddress']");
        private By companylogo = By.XPath("//input[@id='customFile']");
        private By code = By.XPath("//input[@id='inputPostalCode']");
        private By aplybtn = By.XPath("//input[@id='inputApplyButtonName']");
        private By mthd1 = By.XPath("(//input[@class='domain-set-radio optionRadio'])[1]");
        private By mthd2 = By.XPath("(//input[@class='domain-set-radio optionRadio'])[2]");
        private By mthddomainurl = By.XPath("//input[@name='fileUploadUrl']");
        private By mthd3 = By.XPath("//input[@class='domain-set-radio']");
        private By save = By.XPath("//button[contains(text(),'Save')]");
        private By ats = By.XPath("//button[@value='ats']");
        private By Jobdiva = By.XPath("//a[@id='jobdiva-tab']");
        private By apikey = By.XPath("(//input[@id='credentialMapapiKey'])[2]");
        private By ctnue = By.XPath("(//button[text()='Continue'])[2]");
        private By carrers = By.Id("loadJobs");
        private By Loadurl = By.XPath("(//button[@class='btn btn-outline btn-info'])[1]");
        private const string method1 = "Method 1";
        private const string method2 = "Method 2";
        private const string method3 = "Method 3";

        private By changesource = By.XPath("//span[text()='Change source']");
        private By carers = By.XPath("//button[@id='loadJobs']");
        private By loadurl = By.XPath("(//button[@class='btn btn-outline btn-info'])[1]");


        public EnterprisePlan(IWebDriver driver) : base(driver)
        {

        }
        public void ClickOnCustomerOnboardingAndCreateAccount()
        {
            JavaScriptClick(customeronboarding);
            Pause(5);
            JavaScriptClick(createaccount);
            Pause(5);

        }
        public void FillOutEmail(string email)
        {
            IWebElement usernameW = this.WaitForElementToBeVisible(Email);
            usernameW.Click();
            ClearAndType(usernameW, email);
        }
        public void EnterAllBasicInformationFields()
        {
            //WaitForElementToBeClickeable(Email).SendKeys("rinki13@jobiak.ai");
            //Pause(2);
            WaitForElementToBeClickeable(password).SendKeys("z#0v8Uul");
            Pause(2);
            WaitForElementToBeClickeable(fstname).SendKeys("Tejaswini");
            Pause(2);
            WaitForElementToBeClickeable(Lstname).SendKeys("reddy");
            Pause(2);
            WaitForElementToBeClickeable(phneno).SendKeys("2345678921");
            Pause(2);
        }
        public void EnterCompanyInformartion()
        {
            WaitForElementToBeClickeable(compnyname).SendKeys("jobiak");
            Pause(2);

            WaitForElementToBeClickeable(Website).SendKeys("tephrainc.com");
            Pause(2);

            WaitForElementToBeClickeable(Address).SendKeys("H.NO 13");
            Pause(2);

            string filePath = @"C:\Users\User\Desktop\Senior Product Manager.pdf";
            driver.FindElement(companylogo).SendKeys(filePath);
            Pause(2);
            WaitForElementToBeClickeable(code).SendKeys("10234");
            Pause(2);
            WaitForElementToBeClickeable(aplybtn).SendKeys("Jobiak");
            Pause(2);


        }

        public void SaveJobBrandingDetailsBasedOnMethod(string methodName)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,400)");


            if (methodName.ToLower().Equals(method1.ToLower()))
            {
                JavaScriptClick(mthd1);
                Pause(2);
            }

            else if (methodName.ToLower().Equals(method2.ToLower()))
            {
                JavaScriptClick(mthd2);
                Pause(3);
                ClickElementAndSendkeys(mthddomainurl, "Jobiak");
                Pause(2);

            }
            else if (methodName.ToLower().Equals(method3.ToLower()))
            {

                JavaScriptClick(mthd3);
                Pause(3);


            }
        }

            //Click save
            public void clickOnSave()
            {
            JavaScriptScrollIntoView(save);
            JavaScriptClick(save);
                    Pause(3);
        }
        public void ClickOnATS()
        {
            JavaScriptClick(ats);
            Pause(4);
        }
        public void ClickOnJobDiva()
        {
            JavaScriptClick(Jobdiva);
            Pause(4);
        }
        public void EnterApiKey()
        {
            WaitForElementToBeClickeable(apikey).SendKeys("kpjdnw9gesvjl4dbzkydtnubq5uhyx051aropkhxe32zrgp706qprpbogq02j5lr");
            Pause(3);
        }
        public void ClickOncontinue()
        {
            JavaScriptClick(ctnue);
            Pause(4);
        }
        public void ClickOnChangeSourceFields()
        {
            JavaScriptClick(changesource);
            Pause(2);

        }
        public void ClickOnChangeSourceFieldsAndSelectOptionCarrer()
        {
            JavaScriptClick(changesource);
            Pause(2);
            JavaScriptClick(carers);
            Pause(10);
            JavaScriptClick(loadurl);
            Pause(2);
            
        }
       




    }

    }

