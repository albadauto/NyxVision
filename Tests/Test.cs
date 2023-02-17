using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyxVision.Tests
{
    public class Test : Begin
    {
        /**
         * Caso de teste para treino
         */
        [Test]
        public void TesteOne()
        {
            driver.FindElement(By.CssSelector(".btn-light > b:nth-child(2)")).Click();
            driver.FindElement(By.CssSelector("#fisic-people > form:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > input:nth-child(1)")).SendKeys("teste@teste.com");
            driver.FindElement(By.CssSelector("#fisic-people > form:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > input:nth-child(1)")).SendKeys("123");
            //Assert.That(driver.FindElement(By.CssSelector("#result-stats")).Text, Does.Contain("1.900.000"));
            driver.FindElement(By.CssSelector("button.btn-primary")).Click();
        }

        
    }
}
