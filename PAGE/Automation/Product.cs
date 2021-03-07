using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using FluentAssertions;


namespace BMI.PAGE.Automation
{
    public class Products
    {
        public IWebDriver Driver;
        public Products(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        IWebElement product => Driver.FindElement(By.CssSelector("#navigation-tab-0 .MuiSvgIcon-root"));
        IWebElement productVerify => Driver.FindElement(By.CssSelector("#navigation-tab-0"));
        public void Navigate()
        {
            Driver.Navigate().GoToUrl("https://www.bmigroup.com/no/");
        }

        public void ClickOnTheProduct() 
        {
            Task.Delay(3000);
            product.Click();
            Task.Delay(5000);

        }
        public void VerifyProcuctPage()
        {
            Task.Delay(5000);
            productVerify.Displayed.Should().BeTrue();
        }
    }
}
