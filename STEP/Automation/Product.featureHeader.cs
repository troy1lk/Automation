using System;
using TechTalk.SpecFlow;
using BMI.PAGE.Automation;
using BMI.BASE;
using OpenQA.Selenium;

namespace BMI.TEST.Automation
{
    [Binding]
    [Scope(Tag = "@product")]
    public class ProductfeatureHeader : Hooks
    {
        public IWebDriver driver;
        public Products browser;

        [Given(@"navigate to BMI")]
        public void GivenNavigateToBMI()
        {
            driver = Driver;
            browser = new Products(driver);
            browser.Navigate();
        }
        
        [When(@"I click on the product header")]
        public void WhenIClickOnTheProductHeader()
        {
            browser.ClickOnTheProduct();
        }
        
        [Then(@"I see the product header")]
        public void ThenISeeTheProductHeader()
        {
            browser.VerifyProcuctPage();
        }
    }
}
