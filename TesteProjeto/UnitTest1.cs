using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TesteProjeto
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://localhost:51739/Estoque/Cadastro");

            IWebElement campo = driver.FindElement(By.Id("Nome"));
            IWebElement botao = driver.FindElement(By.Id("buttoncreate"));
            IWebElement mensagem = driver.FindElement(By.Id("mensagemdesucesso"));

            campo.SendKeys("Varejo");
            botao.Click();

            bool achou = driver.PageSource.Contains("Estoque cadastrado com sucesso.");

            Assert.IsTrue(achou);
        }

       
        
    }
}
