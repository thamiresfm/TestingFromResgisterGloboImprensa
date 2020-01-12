using System;
using TechTalk.SpecFlow;
using Xunit;
using OpenQA.Selenium;
using GloboImprensa.Page;
using GloboImprensa.Browsers;



namespace GloboImprensa.Step
{
    [Binding]
    
    public class CadastraNoSiteGloboImprensaSteps
    {
        private IWebDriver driver;
        private Register login;

        public CadastraNoSiteGloboImprensaSteps()
        {

            driver = Browsers.Browsers.GetBrowsers(driver, "Chrome");
            login = new Register(driver);


        }
           
    



        [Given(@"que eu navegue para tela de cadastro")]
        public void DadoQueEuNavegueParaTelaDeCadastro()
        {
            login.Visitar();
        }

        [When(@"preencho  os campos de (.*), (.*), (.*), (.*), (.*), (.*) ,(.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) e (.*)")]
        public void QuandoPreenchoOsCamposDeE(string FirstName
                                              , string LastName
                                              , string Nickname
                                              , string Sex
                                              , string Email
                                              , string Office
                                              , string PublishingCompany
                                              , string Carrier
                                              , string Country
                                              , string State
                                              , string City
                                              , string DDDTelephone
                                              , string Telephone
                                              , string DDDCellPhone
                                              , string CellPhone
                                              , string Instagram
                                              , string Twitter
                                              , string Password
                                              , string RepeatPassword
            )
        {
            login.PreencherDados(
                                FirstName
                                , LastName
                                , Nickname
                                , Sex
                                , Email
                                , Office
                                , PublishingCompany
                                , Carrier
                                , Country
                                , State
                                , City
                                , DDDTelephone
                                , Telephone
                                , DDDTelephone
                                , CellPhone
                                , Instagram
                                , Twitter
                                , Password
                                , RepeatPassword




                );
        }
        
        [When(@"Clico em SOLICITAR CADASTRO")]
        public void QuandoClicoEmSOLICITARCADASTRO()
        {
            login.Submit();
         

        }
        
        [Then(@"aguarda a (.*)")]
        public void EntaoAguardaA(string Menssage)
        {

            Assert.Contains(Menssage, driver.PageSource);
            driver.Quit();

        }
    }
}
