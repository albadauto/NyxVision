using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyxVision
{
    public class Test : Begin
    {
        private string[] result;
        [Test]
        public void TesteOne()
        {
            driver.FindElement(By.ClassName("gLFyf")).SendKeys("Teste");
            driver.FindElement(By.CssSelector("body > div.L3eUgb > div.o3j99.ikrT4e.om7nvf > form > div:nth-child(1) > div.A8SBwf > div.FPdoLc.lJ9FBc > center > input.gNO89b")).Click();
            Assert.That(driver.FindElement(By.CssSelector("#result-stats")).Text, Does.Contain("1.900.000"));
        }
    }
}
