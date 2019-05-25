using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeTeste.pages
{
    public class InicialPage
    {
        IWebDriver driver;

        public InicialPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public NovoEstoquePage Novo()
        {
            IWebElement link = driver.FindElement(By.Id("CadastrarEstoque"));

            link.Click();
            return new NovoEstoquePage(driver);
        }
        public void AcessaPagina()
        {
            driver.Navigate().GoToUrl("http://localhost:51739/Home/Index");
        }
    }
}
