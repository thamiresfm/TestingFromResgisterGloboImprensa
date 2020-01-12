using System;
using System.Collections.Generic;
using System.Text;
using GloboImprensa.Hooks;
using OpenQA.Selenium;

namespace GloboImprensa.Page
{
    public class Register
    {
     
            private IWebDriver driver;
            private By ByFirstName;
            private By ByLastName;
            private By ByNickname;
            private By BySex;
            private By ByEmail;
            private By ByOffice;
            private By ByPublishingCompany;
            private By ByCarrier;
            private By ByCountry;
            private By ByState;
            private By ByCity;
            private By ByDDDTelephone;
            private By ByTelephone;
            private By ByDDDCellPhone;
            private By ByCellPhone;
            private By ByInstagram;
            private By ByTwitter;
            private By ByPassword;
            private By ByRepeatPassword;
            private By ByTerm;
            private By ByReceiveInformation;
            private By ByBtnSubmit;
            private _Wait _Wait;
            private _Screenshot _Screenshot;

        public Register(IWebDriver Driver)
        {
            driver = Driver;

            _Wait = new _Wait(driver);
            _Screenshot = new _Screenshot(driver);

            ByFirstName = By.Id("id_first_name") ;
            ByLastName = By.Id("id_last_name");
            ByNickname = By.Id("id_como_gostaria_de_ser_chamado");
            BySex = By.Id("id_sexo");
            ByEmail = By.Id("id_username");
            ByOffice = By.Id("id_cargo");
            ByPublishingCompany = By.Id("id_editoria");
            ByCarrier = By.Id("id_veiculo");
            ByCountry = By.Id("id_pais");
            ByState = By.Id("id_estado");
            ByCity = By.Id("id_cidade");
            ByDDDTelephone = By.Id("id_telefone_ddd");
            ByTelephone = By.Id("id_telefone_numero");
            ByDDDCellPhone = By.Id("id_celular_ddd");
            ByCellPhone = By.Id("id_celular_numero");
            ByTwitter = By.Id("id_twitter");
            ByInstagram = By.Id("id_instagram");
            ByPassword = By.Id("id_password1");
            ByRepeatPassword = By.Id("id_password2");
            ByTerm = By.Id("id_termos");
            ByReceiveInformation = By.Id("id_deseja_receber_releases");
            ByBtnSubmit = By.XPath("//button[text()='SOLICITAR CADASTRO']");
        }

        public void Visitar()
        {
            driver.Navigate().GoToUrl("https://imprensa.globo.com/cadastro/");
            _Screenshot.PrintScreenshot();
        }

        public void PreencherDados(
                                    string FirstName
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
           
            driver.FindElement(ByFirstName).SendKeys(FirstName);
            driver.FindElement(ByLastName).SendKeys(LastName);
            driver.FindElement(ByNickname).SendKeys(Nickname);
            driver.FindElement(BySex).SendKeys(Sex);
            driver.FindElement(ByEmail).SendKeys(Email);
            driver.FindElement(ByOffice).SendKeys(Office);
            driver.FindElement(ByPublishingCompany).SendKeys(PublishingCompany);
            driver.FindElement(ByCarrier).SendKeys(Carrier);
            driver.FindElement(ByCountry).SendKeys(Country);
            driver.FindElement(ByState).SendKeys(State);
            driver.FindElement(ByCity).SendKeys(City);
            driver.FindElement(ByDDDTelephone).SendKeys(DDDTelephone);
            driver.FindElement(ByTelephone).SendKeys(Telephone);
            driver.FindElement(ByDDDCellPhone).SendKeys(DDDCellPhone);
            driver.FindElement(ByCellPhone).SendKeys(CellPhone);
            driver.FindElement(ByInstagram).SendKeys(Instagram);
            driver.FindElement(ByTwitter).SendKeys(Twitter);
            driver.FindElement(ByPassword).SendKeys(Password);
            driver.FindElement(ByRepeatPassword).SendKeys(RepeatPassword);
            driver.FindElement(ByReceiveInformation).Click();
            driver.FindElement(ByTerm).Click();
            _Screenshot.PrintScreenshot();

        }

        public void Submit()
        {
            driver.FindElement(ByBtnSubmit).Click();
            _Screenshot.PrintScreenshot();
        }

        

    }
}
