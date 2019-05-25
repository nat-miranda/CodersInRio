using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeTeste.pages
{
    public class NovoEstoquePage
    {
        IWebDriver driver;


        public NovoEstoquePage(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void Cadastra(string nome)
        {
            IWebElement campoDeTexto = driver.FindElement(By.Id("Nome"));
            IWebElement botaoCadastro = driver.FindElement(By.Id("buttoncreate"));

            campoDeTexto.SendKeys(nome);

            botaoCadastro.Click();

        }

        public bool ExisteMensagem()
        {
            IWebElement mensagem = driver.FindElement(By.Id("mensagemdesucesso"));
            bool achou = driver.PageSource.Contains("Estoque cadastrado com sucesso.");

            return achou;
        }

        public bool ValidarMensagemDeCaracteres()
        {
            IWebElement mensagemDeErro = driver.FindElement(By.Id("mensagemErro"));

            bool mensagemAparece = driver.PageSource.Contains("Por favor, informe no mínimo 3 caracteres.");

            return mensagemAparece;
  
        }
    }
}
