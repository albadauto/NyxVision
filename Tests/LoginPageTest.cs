using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyxVision.Tests
{
    public class LoginPageTest : Begin
    {
        [Test]
        public void AuthenticateTest()
        {
            driver.FindElement(By.CssSelector(".btn-light")).Click();
            driver.FindElement(By.CssSelector("#fisic-people > form:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > input:nth-child(1)")).SendKeys("incoerente@incoerente");
            driver.FindElement(By.CssSelector("#fisic-people > form:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > input:nth-child(1)")).SendKeys("teste");
        }

        [Test]
        public void TextBoxTest()
        {
            int limit = 12;
            driver.FindElement(By.CssSelector(".btn-light")).Click();

            var box = driver.FindElement(By.CssSelector("#fisic-people > form:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > input:nth-child(1)"));
            box.SendKeys("a".PadRight(limit + 1, 'a')); //O Método padright adiciona um caractere no final da string até que ela seja atingida o limite
            Assert.AreEqual(limit, box.Text.Length);
        }
    }
}
