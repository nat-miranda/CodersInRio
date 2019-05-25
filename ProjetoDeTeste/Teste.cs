using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjetoDeTeste.pages;

namespace ProjetoDeTeste
{
    [TestClass]
    public class Teste
    {
        private InicialPage page;
        private NovoEstoquePage estoque;

        public Teste()
        {
            IWebDriver driver = new ChromeDriver();
            page = new InicialPage(driver);
            estoque = new NovoEstoquePage(driver);
        }

        [TestMethod]
        public void ValidarMensagem()
        {
            page.AcessaPagina();
            page.Novo().Cadastra("Varejo");
            Thread.Sleep(2000);
            estoque.ExisteMensagem();
            Thread.Sleep(2000);


        }

        [TestMethod]
        public void ValidarMensagemDeCaractes()
        {
            page.AcessaPagina();
            page.Novo().Cadastra("l");
            Thread.Sleep(2000);
            estoque.ValidarMensagemDeCaracteres();
            Thread.Sleep(2000);

        }
    }
}
