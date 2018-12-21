using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

public class SeleniumTest
{
    [Test]
    public void TestBrowser()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://phptravels.com/demo/");

        IWebElement myField = driver.FindElement(By.Id("address"));
        myField.SendKeys("caio.work@gmail.com");

        driver = new FirefoxDriver();
        driver.Navigate().GoToUrl("https://phptravels.com/demo/");

        myField = driver.FindElement(By.Id("address"));
        myField.SendKeys("caio.work@gmail.com");
    }
}