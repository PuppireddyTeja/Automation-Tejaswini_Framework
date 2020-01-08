using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using NUnit.Framework;
using System.Data;
using System.Data.SqlClient;
using OpenQA.Selenium.Interactions;
using System.Drawing;
using BDDAutomation.Test_Framework.Core;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace BDDAutomation.Steps
{
    [Binding]
    public class StepBase
    {
        //Setup common stuff
        private const string browserFireFox = "Firefox";
        private const string browserChrome = "Chrome";
        private const string browserIE = "IE";

        protected static IWebDriver driver;
        protected static Actions builder;

        //New changes to start and end close browser before and after a scenario
        private static string portalURL = "";
        private static  string browserName = "";
        private static string driverPath = "";
        private static int driverPort = 0;

        [BeforeFeature]
        public static void Setup()
        {
            //Load settings from config file
             portalURL = ConfigurationManager.AppSettings.Get("PortalURL");
             browserName = ConfigurationManager.AppSettings.Get("Browser");

            //set drivers path and start port from App.config
             driverPath = ConfigurationManager.AppSettings.Get("DriverPath");
             driverPort = Convert.ToInt32(ConfigurationManager.AppSettings.Get("DriverPort"));

            /*//Instantiate the WebDriver according to the browser on the App.config
            switch (browserName)
            {
                case browserFireFox:
                    driver = new FirefoxDriver();
                    break;

                case browserChrome:
                    ///////////// Here I open Chrome in Incognito Mode ////////////
                    var optionsChrome = new ChromeOptions();

                    //Removing incognito, it does not clear cache
                    //bad side-effectes: causes failure with Chrome 57 and avoids window resizing-> click errors.
                    //¡¡¡DO NOT ACTIVATE THIS AGAIN!!! optionsChrome.AddArgument("incognito");

                    //These could be useful for any extension errors that prevent browser from launching
                    //optionsChrome.AddArgument("--aggressive-cache-discard");
                    optionsChrome.AddArgument("--disable-infobars");
                    optionsChrome.AddArgument("--disable-extensions");
                    //For disabling popup blocking
                    optionsChrome.AddArgument("--disable-popup-blocking");
                    optionsChrome.AddArgument("--IGNORE");
                    driver = new ChromeDriver(optionsChrome);
                    //driver = new ChromeDriver();
                    break;

                case browserIE:
                    ////Ignore browser security warning
                    //var options = new InternetExplorerOptions();
                    //options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    //driver = new InternetExplorerDriver(options);
                    driver = GetNewInternetExplorerDriver(driverPath, driverPort);
                    break;

                default:
                    driver = new FirefoxDriver();
                    break;
            }

            //Configure driver basic settings

            driver.Manage().Cookies.DeleteAllCookies();
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(0));

            driver.Manage().Window.Maximize();
            //IMPORTANT: Keep this size to avoid CLICK issues
            //Size size = new Size(1920, 1080);
            // driver.Manage().Window.Size = size;

            //Navigate to the portal portalURL
            driver.Navigate().GoToUrl(portalURL);
            TestsLogger.Log("Running Tests on " + browserName + " for " + portalURL);*/
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            
            //Log test start to easily locate scenarios on the LOG
            TestsLogger.Log("[TEST START] " + ScenarioContext.Current.ScenarioInfo.Title);

            //Instantiate the WebDriver according to the browser on the App.config
            switch (browserName)
            {
                case browserFireFox:
                    driver = new FirefoxDriver();
                    break;

                case browserChrome:
                    ///////////// Here I open Chrome in Incognito Mode ////////////
                    var optionsChrome = new ChromeOptions();

                    //Removing incognito, it does not clear cache
                    //bad side-effectes: causes failure with Chrome 57 and avoids window resizing-> click errors.
                    //¡¡¡DO NOT ACTIVATE THIS AGAIN!!! optionsChrome.AddArgument("incognito");

                    //These could be useful for any extension errors that prevent browser from launching
                    //optionsChrome.AddArgument("--aggressive-cache-discard");
                    optionsChrome.AddArgument("--disable-infobars");
                    optionsChrome.AddArgument("--disable-extensions");
                    //For disabling popup blocking
                    optionsChrome.AddArgument("--disable-popup-blocking");
                    optionsChrome.AddArgument("--IGNORE");
                    driver = new ChromeDriver(optionsChrome);
                    //driver = new ChromeDriver();
                    break;

                case browserIE:
                    ////Ignore browser security warning
                    //var options = new InternetExplorerOptions();
                    //options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    //driver = new InternetExplorerDriver(options);
                    driver = GetNewInternetExplorerDriver(driverPath, driverPort);
                    break;

                default:
                    driver = new FirefoxDriver();
                    break;
            }

            //Configure driver basic settings

            driver.Manage().Cookies.DeleteAllCookies();
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(0));

            driver.Manage().Window.Maximize();
            //IMPORTANT: Keep this size to avoid CLICK issues
            //Size size = new Size(1920, 1080);
            // driver.Manage().Window.Size = size;

            //Navigate to the portal portalURL
            driver.Navigate().GoToUrl(portalURL);
            TestsLogger.Log("Running Tests on " + browserName + " for " + portalURL);
        }

        [StepArgumentTransformation]
        public static List<String> TransformToListOfString(string commaSeparatedList)
        {
            //Transform a string parameter received from Feature file 
            //that is a comma separated list into a List<string>
            return commaSeparatedList.Split(',').ToList();
        }

        //[AfterStep]
        //public static void CheckForExceptions()
        //{
        //    //Checks for exceptions and, if there are any, 
        //    //asserts a failure with the corresponding log and Stack Trace
        //    var exception = ScenarioContext.Current.TestError;
        //    if (exception is Exception)
        //    {
        //        TestsLogger.Log(exception.StackTrace);
        //        Assert.Fail(exception.Message);
        //        ((IDisposable)ScenarioContext.Current).Dispose();
        //    }
        //}


        [AfterScenario(Order = 20)]
        public static void LogoutAndClearScenarioContext()
        {
            TestsLogger.Log("Cleaning Scenario data... ");
            string curr = "";
            //First try catch To see if Alert is open for the first time
            try {
                //trying to get page source to display html code if any unhandled Alert is present
                curr = driver.PageSource;
            }
            catch (UnhandledAlertException e)
            {
                Console.WriteLine("Current line::\t" + curr);
                
                //2nd Try catch to check for alert opening second time
                try
                {
                    IAlert alert = driver.SwitchTo().Alert();
                    curr = driver.PageSource;
                    Console.WriteLine("Current line::\t" + curr);
                    alert.Accept();

                }
                catch (NoAlertPresentException noaleExe) {

                    driver.Navigate().Refresh();
                    driver.SwitchTo().Alert().Accept();
                    
                }
            
                TestsLogger.Log(e.StackTrace);
            }

            catch (WebDriverTimeoutException ) {
                TestsLogger.Log("failed to get Alert within timeframe");
                /*Alert did not appear, do nothing*/ }
                 
            driver.Manage().Cookies.DeleteAllCookies();
            //Closing and quit the broswer after end of each scenario instead of end of Feature
            driver.Close();
            driver.Quit();
            //Clear ScenarioContext data
            ScenarioContext.Current.Clear();
    }
        
    

        [AfterFeature]
        public static void Teardown()
        {
            
            TestsLogger.Log("Ending the run of a feature file... ");

          /*  driver.Close();
            //driver.Close();
            driver.Quit();
            //driver.Dispose();*/
        }

        private static IWebDriver GetNewChromeDriver(string driverPath, int driverPort)
        {
            //setup driver's folder and port
            var chromeDriverService = ChromeDriverService.CreateDefaultService(driverPath);
            chromeDriverService.Port = driverPort;

            TestsLogger.Debug("Attempting to start Chrome browser on port " + driverPort);
            return new ChromeDriver(chromeDriverService);
        }


        private static IWebDriver GetNewInternetExplorerDriver(string driverPath, int driverPort)
        {
            //setup driver's folder and port
            var IEDriverService = InternetExplorerDriverService.CreateDefaultService(driverPath);
            IEDriverService.Port = driverPort;

            //Ignore browser security warning
            var options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;

            //This property could be useful to fix scroll issues
            //?options.ElementScrollBehavior = 1;

            options.RequireWindowFocus = false;

            //ensure a clean session on browser startup and use private mode
            options.EnsureCleanSession = true;

            TestsLogger.Debug("Attempting to start IE browser on port " + (driverPort + 1));
            return new InternetExplorerDriver(IEDriverService, options);
        }

        [Given(@"I Press Tab Key")]
        [When(@"I Press Tab Key")]
        [Then(@"I Press Tab Key")]
        private void WhenIPressTabKey()
        {
            this.PressKeyOnActiveElement(Keys.Tab);

        }

        [Given(@"I Press Shift Tab Keys")]
        [When(@"I Press Shift Tab Keys")]
        [Then(@"I Press Shift Tab Keys")]
        private void WhenIPressShiftTabKeys()
        {
            this.PressKeyOnActiveElement(Keys.Shift + Keys.Tab);
        }

        [Given(@"I Press Space Bar")]
        [When(@"I Press Space Bar")]
        [Then(@"I Press Space Bar")]
        private void ThenIPressSpaceBar()
        {
            this.PressKeyOnActiveElement(Keys.Space);
        }

        private void PressKeyOnActiveElement(string keys)
        {
            IWebElement activeElem = driver.SwitchTo().ActiveElement();
            Actions builder = new Actions(driver);
            builder.MoveToElement(activeElem).SendKeys(keys).Build().Perform();
        }

        protected static void AddDataToScenarioContextOverridingExistentKey(string key, object value)
        {
            try
            {
                ScenarioContext.Current.Add(key, value);
            }
            catch (Exception)
            {
                ScenarioContext.Current.Remove(key);
                ScenarioContext.Current.Add(key, value);
            }
        }


    }
}