using System;
using TechTalk.SpecFlow;
using BMI.PAGE.Automation;
using BMI.BASE;
using OpenQA.Selenium;

namespace BMI.STEP.Automation
{
    [Binding]
    [Scope(Tag = "@pageload")]
    public class PageLoadSteps : Hooks
    {
        public IWebDriver driver;
        public PageLoad browser;

        [Given(@"I navigate to BMI")]
        public void GivenINavigateToBMI()
        {
            driver = Driver;
            browser = new PageLoad(driver);
            browser.Navigate();
        }
        
        [Then(@"I see the BMI page load sucessfully")]
        public void ThenISeeTheBMIPageLoadSucessfully()
        {
            browser.VerifyNavigate();
        }
    }
}
