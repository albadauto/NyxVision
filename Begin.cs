using NyxVision.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NyxVision
{
    public class Begin
    {
        public IWebDriver driver;
        public bool driverQuit = false;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Settings.Settings.AVALIAAE_URI);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driverQuit = true;
        }

        [TearDown]
        public void TestEnd()
        {
            if(driverQuit) driver.Quit();
        }
    }
}