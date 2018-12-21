using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SeleniumTests
{
    [Binding]
    public class RegisterSteps
    {
        private IWebDriver driver;
        private IWebElement myField;
        public RegisterSteps()
        {
            driver = new ChromeDriver();
        }

        [Given(@"the user accesses the site")]
        public void GivenTheUserAccessesTheSite()
        {
            driver.Navigate().GoToUrl("http://thedemosite.co.uk/addauser.php");
        }
        
        [When(@"I insert the username (.*) and password (.*)")]
        public void WhenIInsertTheUsernameAndPassword(string p0, string p1)
        {
            myField = driver.FindElement(By.Name("username"));
            myField.SendKeys(p0);
            myField = driver.FindElement(By.Name("password"));
            myField.SendKeys(p1);
        }
        
        [When(@"I click on register button")]
        public void WhenIClickOnRegisterButton()
        {
            myField = driver.FindElement(By.Name("FormsButton2"));
            myField.Click();
        }

        [Then(@"my account must be created and username must be shown (.*) on the screen")]
        public void ThenMyAccountMustBeCreatedAndUsernameMustBeShownOnTheScreen(string p0)
        {           
            myField = driver.FindElement(By.XPath($"//blockquote/blockquote[2]/blockquote"));
            Assert.IsTrue(myField.Text.Contains(p0));
        }
    }
}
