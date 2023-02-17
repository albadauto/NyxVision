using NyxVision.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NyxVision
{
    public class Begin
    {
        public IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Settings.Settings.AVALIAAE_URI);
            driver.Manage().Window.Maximize();
        }

  
    }
}