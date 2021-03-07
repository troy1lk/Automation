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
    public class PageLoad
    {
        public IWebDriver Driver;
        public PageLoad(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        IWebElement PL => Driver.FindElement(By.CssSelector("#navigation-tab-4 .MuiTab-wrapper"));

        public void Navigate() 
        {
            Driver.Navigate().GoToUrl("https://www.bmigroup.com/no/");
        }

        public void VerifyNavigate()
        {
            PL.Displayed.Should().BeTrue();
        }


    }
}
